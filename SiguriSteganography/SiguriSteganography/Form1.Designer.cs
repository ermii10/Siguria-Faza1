namespace SiguriSteganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnTxtFile = new System.Windows.Forms.Button();
            this.btnMP3button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnResetDec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnMP3dec = new System.Windows.Forms.Button();
            this.txtExtractedText = new System.Windows.Forms.TextBox();
            this.txtFileNameDec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtPlainText);
            this.tabPage1.Controls.Add(this.txtFile);
            this.tabPage1.Controls.Add(this.txtFileName);
            this.tabPage1.Controls.Add(this.btnTxtFile);
            this.tabPage1.Controls.Add(this.btnMP3button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encode";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(321, 423);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Plain text to enkrypt";
            // 
            // btnEncode
            // 
            this.btnEncode.Enabled = false;
            this.btnEncode.Location = new System.Drawing.Point(402, 423);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 11;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enkryption type";
            // 
            // comboBox
            // 
            this.comboBox.Enabled = false;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Enkrypt by text file",
            "Enkrypt by plain text"});
            this.comboBox.Location = new System.Drawing.Point(22, 89);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(208, 21);
            this.comboBox.TabIndex = 9;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MP3 file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TXT file";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Enabled = false;
            this.txtPlainText.Location = new System.Drawing.Point(23, 204);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(454, 207);
            this.txtPlainText.TabIndex = 6;
            this.txtPlainText.TextChanged += new System.EventHandler(this.txtPlainText_TextChanged);
            // 
            // txtFile
            // 
            this.txtFile.Enabled = false;
            this.txtFile.Location = new System.Drawing.Point(22, 145);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(346, 20);
            this.txtFile.TabIndex = 5;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(22, 29);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(346, 20);
            this.txtFileName.TabIndex = 4;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // btnTxtFile
            // 
            this.btnTxtFile.Enabled = false;
            this.btnTxtFile.Location = new System.Drawing.Point(401, 145);
            this.btnTxtFile.Name = "btnTxtFile";
            this.btnTxtFile.Size = new System.Drawing.Size(75, 23);
            this.btnTxtFile.TabIndex = 3;
            this.btnTxtFile.Text = "TXT";
            this.btnTxtFile.UseVisualStyleBackColor = true;
            this.btnTxtFile.Click += new System.EventHandler(this.btnTxtFile_Click);
            // 
            // btnMP3button
            // 
            this.btnMP3button.Location = new System.Drawing.Point(402, 29);
            this.btnMP3button.Name = "btnMP3button";
            this.btnMP3button.Size = new System.Drawing.Size(75, 23);
            this.btnMP3button.TabIndex = 2;
            this.btnMP3button.Text = "MP3";
            this.btnMP3button.UseVisualStyleBackColor = true;
            this.btnMP3button.Click += new System.EventHandler(this.btnMP3button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnResetDec);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btnExtract);
            this.tabPage2.Controls.Add(this.btnMP3dec);
            this.tabPage2.Controls.Add(this.txtExtractedText);
            this.tabPage2.Controls.Add(this.txtFileNameDec);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnResetDec
            // 
            this.btnResetDec.Enabled = false;
            this.btnResetDec.Location = new System.Drawing.Point(321, 423);
            this.btnResetDec.Name = "btnResetDec";
            this.btnResetDec.Size = new System.Drawing.Size(75, 23);
            this.btnResetDec.TabIndex = 6;
            this.btnResetDec.Text = "Reset";
            this.btnResetDec.UseVisualStyleBackColor = true;
            this.btnResetDec.Click += new System.EventHandler(this.btnResetDec_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Extracted text";
            // 
            // btnExtract
            // 
            this.btnExtract.Enabled = false;
            this.btnExtract.Location = new System.Drawing.Point(402, 423);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 4;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnMP3dec
            // 
            this.btnMP3dec.Location = new System.Drawing.Point(402, 29);
            this.btnMP3dec.Name = "btnMP3dec";
            this.btnMP3dec.Size = new System.Drawing.Size(75, 23);
            this.btnMP3dec.TabIndex = 3;
            this.btnMP3dec.Text = "MP3";
            this.btnMP3dec.UseVisualStyleBackColor = true;
            this.btnMP3dec.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtExtractedText
            // 
            this.txtExtractedText.Location = new System.Drawing.Point(22, 138);
            this.txtExtractedText.Multiline = true;
            this.txtExtractedText.Name = "txtExtractedText";
            this.txtExtractedText.ReadOnly = true;
            this.txtExtractedText.Size = new System.Drawing.Size(455, 272);
            this.txtExtractedText.TabIndex = 2;
            this.txtExtractedText.TextChanged += new System.EventHandler(this.txtExtractedText_TextChanged);
            // 
            // txtFileNameDec
            // 
            this.txtFileNameDec.Location = new System.Drawing.Point(22, 29);
            this.txtFileNameDec.Name = "txtFileNameDec";
            this.txtFileNameDec.Size = new System.Drawing.Size(346, 20);
            this.txtFileNameDec.TabIndex = 1;
            this.txtFileNameDec.TextChanged += new System.EventHandler(this.txtFileNameDec_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "MP3 file";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 480);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIEK-Steganography";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnTxtFile;
        private System.Windows.Forms.Button btnMP3button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnMP3dec;
        private System.Windows.Forms.TextBox txtExtractedText;
        private System.Windows.Forms.TextBox txtFileNameDec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnResetDec;
    }
}

