using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBank.Sub;
using CodeGenerateur.Main;
using Tools;

namespace CodeBank.Main
{
    public partial class frmMain : Form
    {
        #region Var

        private frmListCode f;

        #endregion Var

        #region Codes

        public void Open()
        {
            f = new frmListCode(this);
            f.MdiParent = this;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        #endregion Codes

        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(frmListCode flc)
        {
            InitializeComponent();
            f = flc;
        }

        private void btnCodeGenerateur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMainCG frm = new frmMainCG();
            iTools.OpenForm(frm);
        }

        private void frmMaim_Load(object sender, EventArgs e)
        {
            Open();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNew frm = new frmNew(this, f);
            iTools.OpenForm(frm);
        }
    }
}