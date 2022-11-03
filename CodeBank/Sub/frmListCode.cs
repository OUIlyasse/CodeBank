using CodeBank.DB;
using CodeBank.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace CodeBank.Sub
{
    public partial class frmListCode : Form
    {
        #region Variables

        private CodeBankEntities db = new CodeBankEntities();

        private frmMain f;
        public int code;

        #endregion Variables

        #region Codes

        public void getData()
        {
            gcCodes.DataSource = db.Select_Entry();
        }

        public void DeleteData()
        {
            DialogResult re = MessageBox.Show("Voulez-vous supprimer cette pièce", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        string code = gvCodes.GetFocusedRowCellValue("entr_Code").ToString();
                        db.Delete_Entry(int.Parse(code));
                        db.SaveChanges();
                        transaction.Commit();
                        f.txtStatus.Caption = "Votre code a bien supprimé";
                        getData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        f.txtStatus.Caption = ex.Message;
                    }
                }
            }
        }

        #endregion Codes

        public frmListCode(frmMain fm)
        {
            InitializeComponent();
            f = fm;
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmNew frm = new frmNew(f, this);
            frm.Text = "Nouveau Code";
            iTools.OpenForm(frm);
        }

        private void frmListCode_Activated(object sender, EventArgs e)
        {
            getData();
        }

        private void gvCodes_DoubleClick(object sender, EventArgs e)
        {
            if (gvCodes.RowCount > 0)
            {
                try
                {
                    var row = gvCodes.FocusedRowHandle;
                    int id = int.Parse(gvCodes.GetRowCellValue(row, "entr_Code").ToString());
                    Entry c = db.Select_Entry_By_Code(id).FirstOrDefault();
                    frmNew frm = new frmNew(f, this, c.entr_Code, c.entr_Titre, c.entr_Description, c.entr_Username, c.entr_Password, c.entr_Site, c.entr_Observation);
                    frm.Text = "Modifer Code";
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    f.txtStatus.Caption = ex.Message;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

            txtPass.UseSystemPasswordChar = false;
        }
    }
}