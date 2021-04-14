using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrzToolHelper;
using GrzToolHelper.BurnIgnorance.PGPEncryption;

namespace PGPEncryptDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerateKey_Click(object sender, EventArgs e)
        {
            //string signature = txtSignKey.Text;
            //txtPrivateKey.Text = PGPKEYS.PGPKeyrings.PrivateKey(signature);
            //txtPublicKey.Text = PGPKEYS.PGPKeyrings.PublicKey(signature);

            GrzToolHelper.BinocullarPath.Binocullar f = new GrzToolHelper.BinocullarPath.Binocullar();
            txtChiperText.Text = f.RootProjectDirectory;

            GrzToolHelper.GNUPG.PGCrypto a = new GrzToolHelper.GNUPG.PGCrypto();
            GrzToolHelper.Cepuk.Reader reader = new GrzToolHelper.Cepuk.Reader();

            // txtPrivateKey.Text =  a.EncryptGnuPG(txtInputFile.Text,txtInputPGP.Text,"Anjari");

            //Sample one
            //string pri = "";
            //string pub = "";
            //a.PGPGenerateKey(1024, txtSignKey.Text, txtPassword.Text, out pri, out pub);

            //txtPrivateKey.Text = pri;
            //txtPublicKey.Text = pub;


            //Sample two


            string pri = @"D:\Camp Latihan Pemrograman\C#\Tempat sampah\keyPrivate.txt";
            string pub = @"D:\Camp Latihan Pemrograman\C#\Tempat sampah\keyPublic.txt";
            string passPhrase = "password";
            string pathOutput = @"D:\Camp Latihan Pemrograman\C#\Tempat sampah\MyTest.txt";

            string path1 = @"D:\Camp Latihan Pemrograman\C#\Tempat sampah\unEncryptedFile.txt";
            FileInfo fi = new FileInfo(path1);


           

            //GetFile();

            string path = @"D:\Camp Latihan Pemrograman\C#\Tempat sampah\MyTest.txt";

            // Delete the file if it exists.
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            PgpEncryptionKeys objPgpEncryptionKeys;
            PgpEncrypt objPgpEncrypt;
            //Create the file.
            using (FileStream fs = fi.Create())
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
                fs.Flush();
                fs.Close();
                FileStream str = new FileStream(pathOutput, FileMode.Create);
                objPgpEncryptionKeys = new PgpEncryptionKeys(pub, pri, passPhrase);
                objPgpEncrypt = new PgpEncrypt(objPgpEncryptionKeys);
                objPgpEncrypt.EncryptAndSign(str, fi);

                str.Flush();
                str.Close();
                
            }


            txtPrivateKey.Text = reader.readAllText(pri);
            txtPublicKey.Text = reader.readAllText(pub);
            txtChiperText.Text = reader.readAllText(pathOutput);
        }

        private void BtnInputFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var filename = openFileDialog1.FileName;

            txtInputFile.Text = filename;
        }

        private void BtnPGPFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            var filename = openFileDialog2.FileName;

            txtInputPGP.Text = filename + ".pgp";
        }
    }
}
