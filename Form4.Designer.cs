namespace bruteForce_AliMert
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            txtPayload = new TextBox();
            richTextBoxResults = new RichTextBox();
            txtEmailFilePath = new TextBox();
            txtPasswordFilePath = new TextBox();
            btnSelectEmailFile = new Button();
            btnSelectPasswordFile = new Button();
            btnStart = new Button();
            btnCancel = new Button();
            lblStatus = new Label();
            txtSiteLink = new TextBox();
            txtErrorMessage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtPayload
            // 
            txtPayload.Location = new Point(20, 158);
            txtPayload.Margin = new Padding(3, 2, 3, 2);
            txtPayload.Multiline = true;
            txtPayload.Name = "txtPayload";
            txtPayload.Size = new Size(196, 28);
            txtPayload.TabIndex = 0;
            // 
            // richTextBoxResults
            // 
            richTextBoxResults.Location = new Point(20, 258);
            richTextBoxResults.Margin = new Padding(3, 2, 3, 2);
            richTextBoxResults.Name = "richTextBoxResults";
            richTextBoxResults.Size = new Size(659, 158);
            richTextBoxResults.TabIndex = 1;
            richTextBoxResults.Text = "";
            // 
            // txtEmailFilePath
            // 
            txtEmailFilePath.Location = new Point(476, 147);
            txtEmailFilePath.Margin = new Padding(3, 2, 3, 2);
            txtEmailFilePath.Name = "txtEmailFilePath";
            txtEmailFilePath.Size = new Size(175, 23);
            txtEmailFilePath.TabIndex = 2;
            // 
            // txtPasswordFilePath
            // 
            txtPasswordFilePath.Location = new Point(476, 200);
            txtPasswordFilePath.Margin = new Padding(3, 2, 3, 2);
            txtPasswordFilePath.Name = "txtPasswordFilePath";
            txtPasswordFilePath.Size = new Size(174, 23);
            txtPasswordFilePath.TabIndex = 3;
            // 
            // btnSelectEmailFile
            // 
            btnSelectEmailFile.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            btnSelectEmailFile.Location = new Point(476, 120);
            btnSelectEmailFile.Margin = new Padding(3, 2, 3, 2);
            btnSelectEmailFile.Name = "btnSelectEmailFile";
            btnSelectEmailFile.Size = new Size(173, 22);
            btnSelectEmailFile.TabIndex = 4;
            btnSelectEmailFile.Text = "username select";
            btnSelectEmailFile.UseVisualStyleBackColor = true;
            btnSelectEmailFile.Click += btnSelectEmailFile_Click;
            // 
            // btnSelectPasswordFile
            // 
            btnSelectPasswordFile.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            btnSelectPasswordFile.Location = new Point(476, 173);
            btnSelectPasswordFile.Margin = new Padding(3, 2, 3, 2);
            btnSelectPasswordFile.Name = "btnSelectPasswordFile";
            btnSelectPasswordFile.Size = new Size(173, 22);
            btnSelectPasswordFile.TabIndex = 5;
            btnSelectPasswordFile.Text = "pass select";
            btnSelectPasswordFile.UseVisualStyleBackColor = true;
            btnSelectPasswordFile.Click += btnSelectPasswordFile_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Lime;
            btnStart.Font = new Font("Chiller", 18F, FontStyle.Bold);
            btnStart.Location = new Point(254, 136);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(190, 36);
            btnStart.TabIndex = 6;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Chiller", 18F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(254, 178);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(190, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(476, 233);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 18);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "label1";
            // 
            // txtSiteLink
            // 
            txtSiteLink.Location = new Point(20, 112);
            txtSiteLink.Margin = new Padding(3, 2, 3, 2);
            txtSiteLink.Name = "txtSiteLink";
            txtSiteLink.Size = new Size(196, 23);
            txtSiteLink.TabIndex = 9;
            // 
            // txtErrorMessage
            // 
            txtErrorMessage.Location = new Point(20, 210);
            txtErrorMessage.Margin = new Padding(3, 2, 3, 2);
            txtErrorMessage.Name = "txtErrorMessage";
            txtErrorMessage.Size = new Size(196, 23);
            txtErrorMessage.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 91);
            label1.Name = "label1";
            label1.Size = new Size(89, 18);
            label1.TabIndex = 11;
            label1.Text = "Site Link";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 136);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 12;
            label2.Text = "Payload";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.8F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 189);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 13;
            label3.Text = "error message";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(291, 97);
            label7.Name = "label7";
            label7.Size = new Size(112, 16);
            label7.TabIndex = 21;
            label7.Text = "HomePage Button";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.circle;
            pictureBox2.Location = new Point(326, 49);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Chiller", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(460, 49);
            label5.Name = "label5";
            label5.Size = new Size(219, 74);
            label5.TabIndex = 22;
            label5.Text = "BrutForza";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Chiller", 55.8000031F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(8, 11);
            label4.Name = "label4";
            label4.Size = new Size(272, 86);
            label4.TabIndex = 23;
            label4.Text = "PassGenTR";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ay_yildiz_39028;
            pictureBox3.Location = new Point(366, -24);
            pictureBox3.Margin = new Padding(2, 1, 2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(151, 122);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.White;
            btnHelp.Font = new Font("Chiller", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHelp.ForeColor = Color.Black;
            btnHelp.Location = new Point(269, 221);
            btnHelp.Margin = new Padding(3, 2, 3, 2);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(160, 27);
            btnHelp.TabIndex = 25;
            btnHelp.Text = "Nasıl Kullanılır?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(694, 435);
            Controls.Add(btnHelp);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtErrorMessage);
            Controls.Add(txtSiteLink);
            Controls.Add(lblStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnStart);
            Controls.Add(btnSelectPasswordFile);
            Controls.Add(btnSelectEmailFile);
            Controls.Add(txtPasswordFilePath);
            Controls.Add(txtEmailFilePath);
            Controls.Add(richTextBoxResults);
            Controls.Add(txtPayload);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CROWatch | BruteForza";
            FormClosing += Form4_FormClosing;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPayload;
        private RichTextBox richTextBoxResults;
        private TextBox txtEmailFilePath;
        private TextBox txtPasswordFilePath;
        private Button btnSelectEmailFile;
        private Button btnSelectPasswordFile;
        private Button btnStart;
        private Button btnCancel;
        private Label lblStatus;
        private TextBox txtSiteLink;
        private TextBox txtErrorMessage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label7;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox3;
        private Button btnHelp;
    }
}