using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using steganography;
using System.Windows.Forms;

namespace SiguriSteganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMP3button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            String filename;
            dialog.Filter = "MP3 Audio (.mp3)|*.mp3";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (txtFile.Enabled != true && txtPlainText.Enabled != true)
                {
                    comboBox.Enabled = true;
                }
                filename = dialog.FileName;
                txtFileName.Text = filename;
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String zgjedhja = comboBox.SelectedIndex.ToString();
            if (zgjedhja == "0")
            {
                txtFile.Enabled = true;
                btnTxtFile.Enabled = true;
                comboBox.Enabled = false;
            }
            else if(zgjedhja == "1")
            {
               
                txtPlainText.Enabled = true;
                comboBox.Enabled = false;
            }
        }

        private void btnTxtFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            String filename;
            dialog.Filter = "Txt File (.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
                txtFile.Text = filename;
            }
        }

      

       

        private void btnEncode_Click(object sender, EventArgs e)
        {

            
                if (!File.Exists(txtFileName.Text) && comboBox.SelectedIndex == 1)
                {
                    MessageBox.Show("Fajli MP3 eshte invalid");
                    txtFileName.Text = "";
                    txtFileName.Focus();
                }

                else if ((!File.Exists(txtFileName.Text) || !File.Exists(txtFile.Text)) && comboBox.SelectedIndex == 0)
                {

                    if (!File.Exists(txtFileName.Text) && File.Exists(txtFile.Text))
                    {
                        MessageBox.Show("Fajli MP3 eshte invalid");
                        txtFileName.Text = "";
                        txtFileName.Focus();

                    }

                    else if (!File.Exists(txtFile.Text) && File.Exists(txtFileName.Text))
                    {
                        MessageBox.Show("Fajli TXT eshte invalid");
                        txtFile.Text = "";
                        txtFile.Focus();
                    }

                    else if (!File.Exists(txtFile.Text) && !File.Exists(txtFileName.Text))
                    {
                        MessageBox.Show("Fajlet jane invalide");
                        txtFile.Text = "";
                        txtFileName.Text = "";
                        txtFileName.Focus();
                    }
                }
            

                else
                {
                    MP3 mp3 = new MP3(txtFileName.Text);
                    String pathFile = txtFile.Text;
                    int zgjedhja = comboBox.SelectedIndex;
                    String path = "";
                    if (zgjedhja == 0)
                    {
                        FileStream txtfile = new FileStream(pathFile, FileMode.Open, FileAccess.Read);
                        byte[] b = new byte[1024];
                        int bytetelexuar = txtfile.Read(b, 0, b.Length);
                        path = Encoding.ASCII.GetString(b, 0, bytetelexuar);
                    
                    }
                    else if(zgjedhja==1)
                    {
                        path = txtPlainText.Text;
                    }
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "MP3 Audio (.mp3)|*.mp3";
                    String filename;
                    steganography.Message msg = new steganography.Message(path);
                     mp3.stega(msg, 8);
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        mp3.toMP3(dialog.FileName);
                    }
                }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            String filename;
            dialog.Filter = "MP3 Audio (.mp3)|*.mp3";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
                txtFileNameDec.Text = filename;

            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtFileNameDec.Text))
            {
                MessageBox.Show("Fajli nuk eshte valid");
                txtFileNameDec.Text = "";
                btnExtract.Enabled = false;
                btnResetDec.Enabled = false;
            }
            else
            {
                MP3 mp3 = new MP3(txtFileNameDec.Text);
                String filePath;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Text FileName (.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                    StreamWriter msg = new StreamWriter(filePath);
                    string strMsg = mp3.decoder(8);
                    msg.Write(strMsg);
                    txtExtractedText.Text = mp3.decoder(8);
                    msg.Flush();
                }
            }
        }
      

       

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            if(txtFileName.Text!="" && txtFile.Text != "")
            {
                btnEncode.Enabled = true;
            }
            else if(txtFileName.Text != "" && txtPlainText.Text != "")
            {
                btnEncode.Enabled = true;
            }
            else
            {
                btnEncode.Enabled = false;
            }

            if (txtFileName.Text != "" || txtPlainText.Text != "" || txtFile.Text !="" || comboBox.SelectedIndex != -1)
            {
                btnReset.Enabled = true;
            }
            else
            {
                btnReset.Enabled = false;
            }
        }



        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            if (txtFileName.Text != "" && txtFile.Text != "")
            {
                btnEncode.Enabled = true;
            }
            else
            {
                btnEncode.Enabled = false;
            }

            if (txtFileName.Text != "" || txtPlainText.Text != "" || txtFile.Text != "" || comboBox.SelectedIndex != -1)
            {
                btnReset.Enabled = true;
            }
            else
            {
                btnReset.Enabled = false;
            }
        }


        private void txtPlainText_TextChanged(object sender, EventArgs e)
        {
            if (txtFileName.Text != "" && txtPlainText.Text != "")
            {
                btnEncode.Enabled = true;
            }
            else
            {
                btnEncode.Enabled = false;
            }

            if (txtFileName.Text != "" || txtPlainText.Text != "" || txtFile.Text != "" || comboBox.SelectedIndex != -1)
            {
                btnReset.Enabled = true;
            }
            else
            {
                btnReset.Enabled = false;
            }
        }

      

        private void txtFileNameDec_TextChanged(object sender, EventArgs e)
        {
            if (txtFileNameDec.Text != "")
            {
                btnExtract.Enabled = true;
                btnResetDec.Enabled = true;
            }
            else
            {
                btnExtract.Enabled = false;
                btnResetDec.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFileName.Text = "";
            txtPlainText.Text = "";
            txtFile.Text = "";
            txtPlainText.Enabled = false;
            txtFile.Enabled = false;
            comboBox.SelectedIndex = -1;
            comboBox.Enabled = false;
            btnTxtFile.Enabled = false;
            btnReset.Enabled = false;
            btnEncode.Enabled = false;
        }


        private void btnResetDec_Click(object sender, EventArgs e)
        {
            txtFileNameDec.Text = "";
            txtExtractedText.Text = "";
            btnExtract.Enabled = false;
            btnResetDec.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtExtractedText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
