using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Tools
{
    public class iTools
    {
        private static RSACryptoServiceProvider csp = new RSACryptoServiceProvider(512);
        private static RSAParameters pubKey = csp.ExportParameters(false);
        private static RSAParameters privKey = csp.ExportParameters(true);

        public static void OpenForm(Form frm)
        {
            frm.ShowDialog();
        }

        public static string Encrypt(string text)
        {
            RSACryptoServiceProvider rcp = new RSACryptoServiceProvider();
            rcp.ImportParameters(pubKey);
            byte[] output = Encoding.Unicode.GetBytes(text);
            byte[] txtEncrypt = rcp.Encrypt(output, false);
            return Convert.ToBase64String(txtEncrypt);
        }

        public static string Decrypte(string text)
        {
            RSACryptoServiceProvider rcp = new RSACryptoServiceProvider();
            rcp.ImportParameters(privKey);
            byte[] output = Convert.FromBase64String(text);
            byte[] txtDecrypt = rcp.Decrypt(output, false);
            return Encoding.Unicode.GetString(txtDecrypt);
        }
    }
}