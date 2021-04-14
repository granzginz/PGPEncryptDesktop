namespace PGPEncryptDesktop
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInputPGP = new System.Windows.Forms.TextBox();
            this.btnPGPFile = new System.Windows.Forms.Button();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPlainTextInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChiperText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlainTextOutput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSignKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Enabled = false;
            this.txtInputFile.Location = new System.Drawing.Point(128, 34);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(482, 22);
            this.txtInputFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input File";
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(643, 33);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(121, 23);
            this.btnInputFile.TabIndex = 2;
            this.btnInputFile.Text = "Choose File";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.BtnInputFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "PGP File";
            // 
            // txtInputPGP
            // 
            this.txtInputPGP.Enabled = false;
            this.txtInputPGP.Location = new System.Drawing.Point(128, 78);
            this.txtInputPGP.Name = "txtInputPGP";
            this.txtInputPGP.Size = new System.Drawing.Size(482, 22);
            this.txtInputPGP.TabIndex = 4;
            // 
            // btnPGPFile
            // 
            this.btnPGPFile.Location = new System.Drawing.Point(643, 78);
            this.btnPGPFile.Name = "btnPGPFile";
            this.btnPGPFile.Size = new System.Drawing.Size(121, 23);
            this.btnPGPFile.TabIndex = 5;
            this.btnPGPFile.Text = "Choose File";
            this.btnPGPFile.UseVisualStyleBackColor = true;
            this.btnPGPFile.Click += new System.EventHandler(this.BtnPGPFile_Click);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(94, 307);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(415, 429);
            this.txtPrivateKey.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Private Key";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(632, 308);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(448, 428);
            this.txtPublicKey.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Public Key";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(96, 802);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(984, 81);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // txtPlainTextInput
            // 
            this.txtPlainTextInput.Location = new System.Drawing.Point(1216, 267);
            this.txtPlainTextInput.Multiline = true;
            this.txtPlainTextInput.Name = "txtPlainTextInput";
            this.txtPlainTextInput.Size = new System.Drawing.Size(696, 113);
            this.txtPlainTextInput.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1213, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Plain Text Input";
            // 
            // txtChiperText
            // 
            this.txtChiperText.Location = new System.Drawing.Point(1216, 618);
            this.txtChiperText.Multiline = true;
            this.txtChiperText.Name = "txtChiperText";
            this.txtChiperText.Size = new System.Drawing.Size(696, 118);
            this.txtChiperText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1214, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Chiper Text";
            // 
            // txtPlainTextOutput
            // 
            this.txtPlainTextOutput.Location = new System.Drawing.Point(1216, 429);
            this.txtPlainTextOutput.Multiline = true;
            this.txtPlainTextOutput.Name = "txtPlainTextOutput";
            this.txtPlainTextOutput.Size = new System.Drawing.Size(696, 98);
            this.txtPlainTextOutput.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1213, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Plain Text Output";
            // 
            // txtSignKey
            // 
            this.txtSignKey.Location = new System.Drawing.Point(94, 166);
            this.txtSignKey.Name = "txtSignKey";
            this.txtSignKey.Size = new System.Drawing.Size(305, 22);
            this.txtSignKey.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sign";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(476, 165);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateKey.TabIndex = 19;
            this.btnGenerateKey.Text = "Generate Key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.BtnGenerateKey_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(305, 22);
            this.txtPassword.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSignKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPlainTextOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtChiperText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlainTextInput);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.btnPGPFile);
            this.Controls.Add(this.txtInputPGP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputFile);
            this.Name = "Form1";
            this.Text = "FilePGP Encryption";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInputPGP;
        private System.Windows.Forms.Button btnPGPFile;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtPlainTextInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChiperText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlainTextOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSignKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
    }
}

