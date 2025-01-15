using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace bruteForce_AliMert
{
    public partial class Form1 : Form
    {
        private bool isMusicPlaying = false; // Müziðin çalýp çalmadýðýný takip etmek için bir bayrak
        private SoundPlayer soundPlayer; // Ses çalar nesnesi

        public Form1()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("back.wav"); // back.wav dosyasýný yükleyin

            // Uyarý mesajýný göster
            var result = MessageBox.Show("Bu tamamen bir siber güvenlik aracýdýr. Test amaçlý yapýlmýþtýr. Herhangi bir illegal iþlem yaparsanýz sorumluluk size aittir. Uygulamayý kullanmayý kabul ediyor musunuz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                Environment.Exit(0); // Kullanýcý hayýr dediyse uygulamadan çýk
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isMusicPlaying)
            {
                // Müziði durdur
                soundPlayer.Stop();

                // Resmi deðiþtir
                pictureBox2.Image = Image.FromFile("stop.png"); // stop.png yerine kapalý durumu gösteren resim dosyasýný ekleyin

                // Bayraðý güncelle
                isMusicPlaying = false;
            }
            else
            {
                // Müziði baþlat
                soundPlayer.PlayLooping();

                // Resmi deðiþtir
                pictureBox2.Image = Image.FromFile("play.png"); // play.png yerine açýk durumu gösteren resim dosyasýný ekleyin

                // Bayraðý güncelle
                isMusicPlaying = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Yeni bir Form2 örneði oluþtur.
            Form2 form2 = new Form2();

            // Form2'yi göster.
            form2.Show();

            // Mevcut formu gizlemek isterseniz (isteðe baðlý):
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form4'ü oluþtur ve göster
            Form4 form4 = new Form4();
            form4.Show();

            // Mevcut formu gizle
            this.Hide();
        }
    }
}
