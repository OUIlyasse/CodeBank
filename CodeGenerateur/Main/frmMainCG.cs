using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenerateur.Main
{
    public partial class frmMainCG : Form
    {
        #region Variable

        private const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        private const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string NUMBERIC = "1234567890";
        private const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-|";

        #endregion Variable

        #region Codes

        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            System.Random _random = new Random();
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (mumberic)
                charSet += NUMBERIC;
            if (specialCharacter)
                charSet += SPECIAL_CHARACTER;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }

        #endregion Codes

        public frmMainCG()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                txtPass.Text = PasswordGenerator(chkLowerCase.Checked, chkUpperCase.Checked, chkNumeric.Checked, chkSpecical.Checked, int.Parse(numLongueur.Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, txtPass.Text);
        }
    }
}