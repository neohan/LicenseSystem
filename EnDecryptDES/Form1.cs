using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace EnDecryptDES
{
    public partial class FormEnDecryptDES : Form
    {
        private static byte[] Keys = { 0xA5, 0x95, 0x6E, 0x44, 0x80, 0xCB, 0x8F, 0x77 };
        private static string AddKey = "kmSsNzfhdCNRYi02kJjJ8bMiDNvTznaxy3yHXGMNLhyyMr4ntKEX1AwWFUZN7rq6rlTtnauIo4Swc9mSW4z9TFmiUHi8PS78n/IKAn3H6cGBJ2PG9lrLW/xy55beJKSMIAa1fq1WVkk=";
        public FormEnDecryptDES()
        {
            InitializeComponent();
        }

        private void FormEnDecryptDES_Load(object sender, EventArgs e)
        {

        }

        private static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                if (encryptKey.Length < 8)
                {
                    encryptKey += AddKey;
                }

                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));

                byte[] rgbIV = Keys;

                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);

                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();

                MemoryStream mStream = new MemoryStream();

                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);

                cStream.Write(inputByteArray, 0, inputByteArray.Length);

                cStream.FlushFinalBlock();

                return Convert.ToBase64String(mStream.ToArray());

            }
            catch
            {
                return encryptString;
            }
        }


        private static string DecryptDES(string decryptString, string decryptKey)
        {

            try
            {
                if (decryptKey.Length < 8)
                {
                    decryptKey += AddKey;
                }
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));

                byte[] rgbIV = Keys;

                byte[] inputByteArray = Convert.FromBase64String(decryptString);

                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();

                MemoryStream mStream = new MemoryStream();

                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);

                cStream.Write(inputByteArray, 0, inputByteArray.Length);

                cStream.FlushFinalBlock();

                return Encoding.UTF8.GetString(mStream.ToArray());

            }
            catch
            {
                return decryptString;
            }
        }


        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            textBoxEncryptedString.Text = labelEncryptedString.Text = EncryptDES(textBoxOriginalString.Text, "35405717");
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            labelDecryptedString.Text = DecryptDES(textBoxOriginalString.Text, "35405717");
        }
    }
}
