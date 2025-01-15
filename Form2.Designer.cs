namespace bruteForce_AliMert
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            numMinLength = new NumericUpDown();
            chkLetters = new CheckBox();
            chkNumbers = new CheckBox();
            chkSpecialChars = new CheckBox();
            btnBrowse = new Button();
            btnGenerate = new Button();
            txtOutputPath = new RichTextBox();
            numMaxLength = new NumericUpDown();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            howToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            howToolStripMenuItem1 = new ToolStripMenuItem();
            contextMenuStrip4 = new ContextMenuStrip(components);
            dsddasdasdToolStripMenuItem = new ToolStripMenuItem();
            asdasdasdToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            adsadToolStripMenuItem = new ToolStripMenuItem();
            minLengthToolStripMenuItem = new ToolStripMenuItem();
            maxLengthToolStripMenuItem = new ToolStripMenuItem();
            lettersToolStripMenuItem = new ToolStripMenuItem();
            numbersToolStripMenuItem = new ToolStripMenuItem();
            specialCharsToolStripMenuItem = new ToolStripMenuItem();
            filePathToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            homePageButtonToolStripMenuItem = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numMinLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            contextMenuStrip4.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // numMinLength
            // 
            numMinLength.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            numMinLength.Location = new Point(47, 261);
            numMinLength.Margin = new Padding(5);
            numMinLength.Name = "numMinLength";
            numMinLength.Size = new Size(136, 71);
            numMinLength.TabIndex = 0;
            // 
            // chkLetters
            // 
            chkLetters.AutoSize = true;
            chkLetters.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            chkLetters.ForeColor = Color.White;
            chkLetters.Location = new Point(47, 400);
            chkLetters.Margin = new Padding(5);
            chkLetters.Name = "chkLetters";
            chkLetters.Size = new Size(166, 37);
            chkLetters.TabIndex = 1;
            chkLetters.Text = "Letters";
            chkLetters.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            chkNumbers.ForeColor = Color.White;
            chkNumbers.Location = new Point(47, 448);
            chkNumbers.Margin = new Padding(5);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(166, 37);
            chkNumbers.TabIndex = 2;
            chkNumbers.Text = "Numbers";
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // chkSpecialChars
            // 
            chkSpecialChars.AutoSize = true;
            chkSpecialChars.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            chkSpecialChars.ForeColor = Color.White;
            chkSpecialChars.Location = new Point(47, 496);
            chkSpecialChars.Margin = new Padding(5);
            chkSpecialChars.Name = "chkSpecialChars";
            chkSpecialChars.Size = new Size(268, 37);
            chkSpecialChars.TabIndex = 3;
            chkSpecialChars.Text = "Special Chars";
            chkSpecialChars.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Red;
            btnBrowse.Font = new Font("Chiller", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(367, 563);
            btnBrowse.Margin = new Padding(5);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(288, 134);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Select File";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Lime;
            btnGenerate.Font = new Font("Chiller", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Location = new Point(47, 563);
            btnGenerate.Margin = new Padding(5);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(283, 130);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Create";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtOutputPath
            // 
            txtOutputPath.Location = new Point(760, 261);
            txtOutputPath.Margin = new Padding(5);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(547, 63);
            txtOutputPath.TabIndex = 6;
            txtOutputPath.Text = "";
            // 
            // numMaxLength
            // 
            numMaxLength.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            numMaxLength.Location = new Point(314, 261);
            numMaxLength.Margin = new Padding(5);
            numMaxLength.Name = "numMaxLength";
            numMaxLength.Size = new Size(136, 71);
            numMaxLength.TabIndex = 7;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(47, 723);
            progressBar.Margin = new Padding(5);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(608, 46);
            progressBar.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(47, 789);
            lblStatus.Margin = new Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(202, 33);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Not started";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(760, 400);
            richTextBox1.Margin = new Padding(5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(547, 418);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 224);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 33);
            label1.TabIndex = 11;
            label1.Text = "min Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(314, 224);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(185, 33);
            label2.TabIndex = 12;
            label2.Text = "max Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(760, 224);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(168, 33);
            label3.TabIndex = 13;
            label3.Text = "File path";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(760, 350);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(168, 33);
            label4.TabIndex = 14;
            label4.Text = "Creations";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Chiller", 55.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(20, 50);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(539, 171);
            label5.TabIndex = 15;
            label5.Text = "PassGenTR";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.crow_bird_logo_vector;
            pictureBox1.Location = new Point(1142, 53);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Chiller", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(804, 93);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(357, 111);
            label6.TabIndex = 17;
            label6.Text = "CROWatch";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.circle;
            pictureBox2.Location = new Point(627, 72);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(562, 174);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(222, 27);
            label7.TabIndex = 19;
            label7.Text = "HomePage Button";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { howToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(137, 42);
            // 
            // howToolStripMenuItem
            // 
            howToolStripMenuItem.Name = "howToolStripMenuItem";
            howToolStripMenuItem.Size = new Size(136, 38);
            howToolStripMenuItem.Text = "How";
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { howToolStripMenuItem1 });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(137, 42);
            // 
            // howToolStripMenuItem1
            // 
            howToolStripMenuItem1.Name = "howToolStripMenuItem1";
            howToolStripMenuItem1.Size = new Size(136, 38);
            howToolStripMenuItem1.Text = "How";
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.ImageScalingSize = new Size(20, 20);
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { dsddasdasdToolStripMenuItem, asdasdasdToolStripMenuItem });
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(213, 80);
            // 
            // dsddasdasdToolStripMenuItem
            // 
            dsddasdasdToolStripMenuItem.Name = "dsddasdasdToolStripMenuItem";
            dsddasdasdToolStripMenuItem.Size = new Size(212, 38);
            dsddasdasdToolStripMenuItem.Text = "dsddasdasd";
            // 
            // asdasdasdToolStripMenuItem
            // 
            asdasdasdToolStripMenuItem.Name = "asdasdasdToolStripMenuItem";
            asdasdasdToolStripMenuItem.Size = new Size(212, 38);
            asdasdasdToolStripMenuItem.Text = "asdasdasd";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Red;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, adsadToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1386, 37);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.BackColor = Color.White;
            openFileToolStripMenuItem.Font = new Font("Courier New", 9F, FontStyle.Italic);
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(158, 31);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // adsadToolStripMenuItem
            // 
            adsadToolStripMenuItem.BackColor = Color.Lime;
            adsadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { minLengthToolStripMenuItem, maxLengthToolStripMenuItem, lettersToolStripMenuItem, numbersToolStripMenuItem, specialCharsToolStripMenuItem, filePathToolStripMenuItem, createToolStripMenuItem, homePageButtonToolStripMenuItem });
            adsadToolStripMenuItem.Font = new Font("Courier New", 9F, FontStyle.Italic);
            adsadToolStripMenuItem.Name = "adsadToolStripMenuItem";
            adsadToolStripMenuItem.Size = new Size(172, 31);
            adsadToolStripMenuItem.Text = "How to use";
            // 
            // minLengthToolStripMenuItem
            // 
            minLengthToolStripMenuItem.Image = Properties.Resources.crow_bird_logo_vector;
            minLengthToolStripMenuItem.Name = "minLengthToolStripMenuItem";
            minLengthToolStripMenuItem.Size = new Size(353, 44);
            minLengthToolStripMenuItem.Text = "Min Length";
            minLengthToolStripMenuItem.Click += minLengthToolStripMenuItem_Click;
            // 
            // maxLengthToolStripMenuItem
            // 
            maxLengthToolStripMenuItem.Image = Properties.Resources.crow_bird_logo_vector;
            maxLengthToolStripMenuItem.Name = "maxLengthToolStripMenuItem";
            maxLengthToolStripMenuItem.Size = new Size(353, 44);
            maxLengthToolStripMenuItem.Text = "Max Length";
            maxLengthToolStripMenuItem.Click += maxLengthToolStripMenuItem_Click;
            // 
            // lettersToolStripMenuItem
            // 
            lettersToolStripMenuItem.Image = Properties.Resources.crow_bird_logo_vector;
            lettersToolStripMenuItem.Name = "lettersToolStripMenuItem";
            lettersToolStripMenuItem.Size = new Size(353, 44);
            lettersToolStripMenuItem.Text = "Letters";
            lettersToolStripMenuItem.Click += lettersToolStripMenuItem_Click;
            // 
            // numbersToolStripMenuItem
            // 
            numbersToolStripMenuItem.Image = Properties.Resources.crow_bird_logo_vector;
            numbersToolStripMenuItem.Name = "numbersToolStripMenuItem";
            numbersToolStripMenuItem.Size = new Size(353, 44);
            numbersToolStripMenuItem.Text = "Numbers";
            numbersToolStripMenuItem.Click += numbersToolStripMenuItem_Click;
            // 
            // specialCharsToolStripMenuItem
            // 
            specialCharsToolStripMenuItem.Image = Properties.Resources.crow_bird_logo_vector;
            specialCharsToolStripMenuItem.Name = "specialCharsToolStripMenuItem";
            specialCharsToolStripMenuItem.Size = new Size(353, 44);
            specialCharsToolStripMenuItem.Text = "Special Chars";
            specialCharsToolStripMenuItem.Click += specialCharsToolStripMenuItem_Click;
            // 
            // filePathToolStripMenuItem
            // 
            filePathToolStripMenuItem.Image = Properties.Resources.crow_bird_logo_vector;
            filePathToolStripMenuItem.Name = "filePathToolStripMenuItem";
            filePathToolStripMenuItem.Size = new Size(353, 44);
            filePathToolStripMenuItem.Text = "File Path";
            filePathToolStripMenuItem.Click += filePathToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Image = Properties.Resources.crow_bird_logo_vector;
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(353, 44);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // homePageButtonToolStripMenuItem
            // 
            homePageButtonToolStripMenuItem.Image = Properties.Resources.crow_bird_logo_vector;
            homePageButtonToolStripMenuItem.Name = "homePageButtonToolStripMenuItem";
            homePageButtonToolStripMenuItem.Size = new Size(353, 44);
            homePageButtonToolStripMenuItem.Text = "HomePage Button";
            homePageButtonToolStripMenuItem.Click += homePageButtonToolStripMenuItem_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ay_yildiz_39028;
            pictureBox3.Location = new Point(472, 272);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(280, 261);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1386, 880);
            Controls.Add(pictureBox3);
            Controls.Add(menuStrip1);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Controls.Add(numMaxLength);
            Controls.Add(txtOutputPath);
            Controls.Add(btnGenerate);
            Controls.Add(btnBrowse);
            Controls.Add(chkSpecialChars);
            Controls.Add(chkNumbers);
            Controls.Add(chkLetters);
            Controls.Add(numMinLength);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CROWatch | PassGenTR";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numMinLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            contextMenuStrip4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMinLength;
        private CheckBox chkLetters;
        private CheckBox chkNumbers;
        private CheckBox chkSpecialChars;
        private Button btnBrowse;
        private Button btnGenerate;
        private RichTextBox txtOutputPath;
        private NumericUpDown numMaxLength;
        private ProgressBar progressBar;
        private Label lblStatus;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem howToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem howToolStripMenuItem1;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem dsddasdasdToolStripMenuItem;
        private ToolStripMenuItem asdasdasdToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adsadToolStripMenuItem;
        private ToolStripMenuItem minLengthToolStripMenuItem;
        private ToolStripMenuItem maxLengthToolStripMenuItem;
        private ToolStripMenuItem lettersToolStripMenuItem;
        private ToolStripMenuItem numbersToolStripMenuItem;
        private ToolStripMenuItem specialCharsToolStripMenuItem;
        private ToolStripMenuItem filePathToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem homePageButtonToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private PictureBox pictureBox3;
    }
}