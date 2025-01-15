using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace bruteForce_AliMert
{
    public partial class Form1 : Form
    {
        private bool isMusicPlaying = false; // M�zi�in �al�p �almad���n� takip etmek i�in bir bayrak
        private SoundPlayer soundPlayer; // Ses �alar nesnesi

        public Form1()
        {
            InitializeComponent();
            soundPlayer = new SoundPlayer("back.wav"); // back.wav dosyas�n� y�kleyin

            // Uyar� mesaj�n� g�ster
            var result = MessageBox.Show("Bu tamamen bir siber g�venlik arac�d�r. Test ama�l� yap�lm��t�r. Herhangi bir illegal i�lem yaparsan�z sorumluluk size aittir. Uygulamay� kullanmay� kabul ediyor musunuz?", "Uyar�", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                Environment.Exit(0); // Kullan�c� hay�r dediyse uygulamadan ��k
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (isMusicPlaying)
            {
                // M�zi�i durdur
                soundPlayer.Stop();

                // Resmi de�i�tir
                pictureBox2.Image = Image.FromFile("stop.png"); // stop.png yerine kapal� durumu g�steren resim dosyas�n� ekleyin

                // Bayra�� g�ncelle
                isMusicPlaying = false;
            }
            else
            {
                // M�zi�i ba�lat
                soundPlayer.PlayLooping();

                // Resmi de�i�tir
                pictureBox2.Image = Image.FromFile("play.png"); // play.png yerine a��k durumu g�steren resim dosyas�n� ekleyin

                // Bayra�� g�ncelle
                isMusicPlaying = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Yeni bir Form2 �rne�i olu�tur.
            Form2 form2 = new Form2();

            // Form2'yi g�ster.
            form2.Show();

            // Mevcut formu gizlemek isterseniz (iste�e ba�l�):
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form4'� olu�tur ve g�ster
            Form4 form4 = new Form4();
            form4.Show();

            // Mevcut formu gizle
            this.Hide();
        }
    }
}
