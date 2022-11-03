using CodeBank.DB;
using CodeBank.Main;
using CodeGenerateur.Main;
using System;
using System.Windows.Forms;
using Tools;

namespace CodeBank.Sub
{
    public partial class frmNew : Form
    {
        #region Variables

        private CodeBankEntities db = new CodeBankEntities();
        private frmMain form;
        private frmListCode frm;
        private int id;

        #endregion Variables

        #region Codes

        public void verifyButton()
        {
            if (Text == "Nouveau Code")
            {
                newRecord();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
            }
        }

        public void newRecord()
        {
            txtTitre.Text = string.Empty;
            txtDescrip.Text = string.Empty;
            txtURL.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtRepeat.Text = string.Empty;
            txtObserv.Text = string.Empty;
            txtTitre.Focus();
        }

        public void getData()
        {
            frm.gcCodes.DataSource = db.Select_Entry();
        }

        #endregion Codes

        public frmNew(frmMain f, frmListCode ff)
        {
            InitializeComponent();
            form = f;
            frm = ff;
        }

        public frmNew(frmMain f, frmListCode ff, int code, string entr_Titre, string entr_Description, string entr_Username, string entr_Password, string entr_Site, string entr_Observation)
        {
            InitializeComponent();
            form = f;
            frm = ff;
            id = code;
            txtTitre.Text = entr_Titre;
            txtDescrip.Text = entr_Description;
            txtUsername.Text = entr_Username;
            txtPassword.Text = entr_Password;
            txtRepeat.Text = entr_Password;
            txtURL.Text = entr_Site;
            txtObserv.Text = entr_Observation;
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
                txtRepeat.Enabled = false;
                txtRepeat.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.Properties.UseSystemPasswordChar = true;
                txtRepeat.Enabled = true;
                txtRepeat.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            frmMainCG frm = new frmMainCG();
            iTools.OpenForm(frm);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (vpValidate.Validate())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Insert_Entry(txtTitre.Text, txtDescrip.Text, txtUsername.Text, txtPassword.Text, txtURL.Text, txtObserv.Text, DateTime.Now);
                        db.SaveChanges();
                        transaction.Commit();
                        form.txtStatus.Caption = "Votre code a bien ajouté";
                        newRecord();
                        getData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        form.txtStatus.Caption = ex.Message;
                    }
                }
            }
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
            {
                txtRepeat.Text = txtPassword.Text;
            }
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            verifyButton();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (vpValidate.Validate())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Update_Entry(id, txtTitre.Text, txtDescrip.Text, txtUsername.Text, txtPassword.Text, txtURL.Text, txtObserv.Text);
                        db.SaveChanges();
                        transaction.Commit();
                        form.txtStatus.Caption = "Votre code a bien modifié";
                        newRecord();
                        getData();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        form.txtStatus.Caption = ex.Message;
                    }
                }
            }
        }
    }
}