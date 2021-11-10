using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EncryptionDecryption
{
    public partial class Form1 : Form
    {
        public AesCryptoServiceProvider aesCryptoService;
        public Form1()
        {
            InitializeComponent();

            aesCryptoService = new AesCryptoServiceProvider();
            aesCryptoService.BlockSize = 128;
            aesCryptoService.KeySize = 256;

            //aesCryptoService.IV = Encoding.UTF8.GetBytes("amsZlfovb2M35vgh");
            //aesCryptoService.Key = Encoding.UTF8.GetBytes("nbmsjhcxdaq10f5s");

            //Rastgele Key ve Vector oluşturuyor.
            aesCryptoService.GenerateKey();
            aesCryptoService.GenerateIV();
            aesCryptoService.Mode = CipherMode.CBC;
            aesCryptoService.Padding = PaddingMode.PKCS7;
        }

        public string Encryption(string text)
        {
            ICryptoTransform encryptor = aesCryptoService.CreateEncryptor();
            byte[] encrypted_bytes = encryptor.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(text), 0, text.Length);
            string encryptedData = Convert.ToBase64String(encrypted_bytes);
            return encryptedData;
        }

        public string Decryption(string text)
        {
            ICryptoTransform decryptor = aesCryptoService.CreateDecryptor();
            byte[] enc_bytes = Convert.FromBase64String(text);
            byte[] decrypted_bytes = decryptor.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);
            string decryptedData = ASCIIEncoding.ASCII.GetString(decrypted_bytes);
            return decryptedData;
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            richEncryption.Text = Encryption(txtData.Text);
        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {
            txtDecryption.Text = Decryption(richEncryption.Text);
        }
    }
}
