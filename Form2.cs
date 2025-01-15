using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bruteForce_AliMert
{
    public partial class Form2 : Form
    {
        private CancellationTokenSource _cancellationTokenSource;

        public Form2()
        {
            InitializeComponent();
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            int minLength = (int)numMinLength.Value;
            int maxLength = (int)numMaxLength.Value;
            string charset = GetSelectedCharset();
            string outputPath = txtOutputPath.Text;

            if (string.IsNullOrWhiteSpace(outputPath))
            {
                MessageBox.Show("Please select an output file.");
                return;
            }

            btnGenerate.Enabled = false;
            lblStatus.Text = "Generating passwords...";
            progressBar.Minimum = 0;
            progressBar.Maximum = maxLength - minLength + 1;
            progressBar.Value = 0;

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                await Task.Run(() => GeneratePasswordsParallel(minLength, maxLength, charset, outputPath, token), token);
                lblStatus.Text = "Passwords generated successfully!";
            }
            catch (OperationCanceledException)
            {
                lblStatus.Text = "Operation was canceled by the user.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGenerate.Enabled = true;
                _cancellationTokenSource = null;
            }
        }

        private string GetSelectedCharset()
        {
            StringBuilder charset = new StringBuilder();
            if (chkLetters.Checked) charset.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
            if (chkNumbers.Checked) charset.Append("0123456789");
            if (chkSpecialChars.Checked) charset.Append("!@#$%^&*()-_=+[]{}|;:'\",.<>?/");

            return charset.ToString();
        }

        private void GeneratePasswordsParallel(int minLength, int maxLength, string charset, string outputPath, CancellationToken token)
        {
            var buffer = new ConcurrentBag<string>();
            int bufferLimit = 100000; // Büyük tampon boyutu
            object fileLock = new object(); // Paralel yazma için kilit

            Parallel.For(minLength, maxLength + 1, (length, state) =>
            {
                if (token.IsCancellationRequested)
                {
                    state.Stop(); // Paralel işlem iptal ediliyor
                    return;
                }

                // Döngü ile kombinasyon üret
                char[] combination = new char[length];
                GenerateCombinations(charset, length, combination, 0, buffer, bufferLimit, outputPath, token, fileLock);
            });

            // Tampondaki son verileri diske yaz
            if (buffer.Count > 0)
            {
                lock (fileLock)
                {
                    File.AppendAllLines(outputPath, buffer);
                }
            }
        }

        private void GenerateCombinations(string charset, int length, char[] combination, int position, ConcurrentBag<string> buffer, int bufferLimit, string outputPath, CancellationToken token, object fileLock)
        {
            if (position == length)
            {
                string password = new string(combination);
                buffer.Add(password);

                // Şifreleri ekranda göstermek için toplu güncelleme
                UpdateRichTextBox(password);

                if (buffer.Count >= bufferLimit)
                {
                    lock (fileLock)
                    {
                        File.AppendAllLines(outputPath, buffer);
                        buffer.Clear();
                    }
                }

                return;
            }

            foreach (char c in charset)
            {
                if (token.IsCancellationRequested)
                    return;

                combination[position] = c;
                GenerateCombinations(charset, length, combination, position + 1, buffer, bufferLimit, outputPath, token, fileLock);
            }
        }

        private void UpdateRichTextBox(string text)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        if (!richTextBox1.IsDisposed)
                        {
                            richTextBox1.AppendText(text + Environment.NewLine);

                            // Scroll işlemini en son satıra getir
                            richTextBox1.SelectionStart = richTextBox1.Text.Length;
                            richTextBox1.ScrollToCaret();
                        }
                    }));
                }
                catch (ObjectDisposedException)
                {
                    // Form veya kontrol kapatılmışsa işlem yapma
                }
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputPath.Text = saveFileDialog.FileName;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Mevcut formu sadece gizler
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_cancellationTokenSource != null)
            {
                _cancellationTokenSource.Cancel();
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;
            }
            base.OnFormClosing(e);
        }
        private void ShowExplanation(string menuItem)
        {
            string message = "";

            switch (menuItem)
            {
                case "minLength":
                    message = "The 'Min Length' field allows you to set the shortest possible password length.\n" +
                              "Enter a value to define the minimum number of characters in the generated passwords.\n" +
                              "Example: If you enter '6,' all generated passwords will be at least 6 characters long.";
                    break;

                case "maxLength":
                    message = "The 'Max Length' field allows you to set the longest possible password length.\n" +
                              "Enter a value to define the maximum number of characters in the generated passwords.\n" +
                              "Example: If you enter '12,' all generated passwords will be no longer than 12 characters.";
                    break;

                case "letters":
                    message = "The 'Letters' option lets you include uppercase and lowercase letters (A-Z, a-z) in your passwords.\n" +
                              "Check this option if you want to use letters in the generated passwords.\n" +
                              "Example: 'abcXYZ' will be possible combinations if this option is checked.";
                    break;

                case "numbers":
                    message = "The 'Numbers' option lets you include digits (0-9) in your passwords.\n" +
                              "Check this option if you want to use numbers in the generated passwords.\n" +
                              "Example: '123456' will be possible combinations if this option is checked.";
                    break;

                case "specialChars":
                    message = "The 'Special Chars' option lets you include special characters (!, @, #, $, etc.) in your passwords.\n" +
                              "Check this option if you want to use symbols in the generated passwords.\n" +
                              "Example: '!@#$%' will be possible combinations if this option is checked.";
                    break;

                case "filePath":
                    message = "The 'File Path' field lets you specify where the generated passwords will be saved.\n" +
                              "Click the 'Select File' button to choose or create a text file to save the results.\n" +
                              "Ensure the path is valid and accessible.";
                    break;

                case "create":
                    message = "The 'Create' button starts the password generation process based on your selected options.\n" +
                              "Generated passwords will appear in the 'Creations' box and be saved to the selected file.\n" +
                              "Ensure you have set the options (length, charset) and the file path before clicking this button.";
                    break;

                case "homePageButton":
                    message = "The 'Home Page Button' takes you back to the application's main page.\n" +
                              "Ensure that the current process (e.g., password generation) is stopped before navigating away.";
                    break;

                default:
                    message = "This menu item is not recognized.";
                    break;
            }

            MessageBox.Show(message, "Explanation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void minLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplanation("minLength");
        }

        private void maxLengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplanation("maxLength");
        }

        private void lettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplanation("letters");
        }

        private void numbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplanation("numbers");
        }

        private void specialCharsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplanation("specialChars");
        }

        private void filePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplanation("filePath");
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplanation("create");
        }

        private void homePageButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowExplanation("homePageButton");
        }

        private async void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    openFileDialog.Title = "Select a File to Open";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        // Dosya okuma işlemini asenkron olarak gerçekleştir
                        await LoadFileWithBufferAsync(filePath);

                        MessageBox.Show("File loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadFileWithBufferAsync(string filePath)
        {
            // Büyük dosyaları tampon ile asenkron olarak okuyup RichTextBox'a ekler
            const int bufferSize = 100; // Bir seferde işlenecek satır sayısı
            var buffer = new StringBuilder(); // Tampon için StringBuilder kullanılır

            using (StreamReader reader = new StreamReader(filePath))
            {
                richTextBox1.Clear(); // Mevcut içeriği temizle
                string line;
                int lineCount = 0;

                while ((line = await reader.ReadLineAsync()) != null)
                {
                    buffer.AppendLine(line);
                    lineCount++;

                    if (lineCount >= bufferSize)
                    {
                        // Tampondaki veriyi RichTextBox'a ekle
                        AppendToRichTextBox(buffer.ToString());
                        buffer.Clear(); // Tamponu temizle
                        lineCount = 0;

                        // UI'nin yanıt verebilmesi için küçük bir bekleme
                        await Task.Delay(1);
                    }
                }

                // Kalan satırları ekle
                if (buffer.Length > 0)
                {
                    AppendToRichTextBox(buffer.ToString());
                }
            }
        }

        private void AppendToRichTextBox(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    richTextBox1.AppendText(text);
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.ScrollToCaret();
                }));
            }
            else
            {
                richTextBox1.AppendText(text);
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Uygulamadan tamamen çık.
        }
    }
}
