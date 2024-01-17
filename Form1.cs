using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qr_generater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
            string ImageFileName = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ImageFileName = open.FileName;
                GeneratedBarcode Qrcode = QRCodeWriter.CreateQrCodeWithLogo(textBox1.Text, ImageFileName, 500);
                string folderPath = "C:\\Users\\Abbas J\\Desktop";
                FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
                if (directchoosedlg.ShowDialog() == DialogResult.OK)
                {
                    folderPath = directchoosedlg.SelectedPath;
                }

                Qrcode.SaveAsPng(folderPath + "//QR-Image.png");
            }
            else
            {
                GeneratedBarcode Qrcode = QRCodeWriter.CreateQrCode(textBox1.Text);
                string folderPath = "C:\\Users\\Abbas J\\Desktop";
                FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
                if (directchoosedlg.ShowDialog() == DialogResult.OK)
                {
                    folderPath = directchoosedlg.SelectedPath;
                }

                Qrcode.SaveAsPng(folderPath + "//QR-Image.png");
            }
        }
    }
}