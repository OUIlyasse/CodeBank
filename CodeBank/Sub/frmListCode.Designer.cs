namespace CodeBank.Sub
{
    partial class frmListCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gcCodes = new DevExpress.XtraGrid.GridControl();
            this.menu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.gvCodes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTitre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcUsername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPass = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcURL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLink = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gcObservation = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcCodes)).BeginInit();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLink)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCodes
            // 
            this.gcCodes.ContextMenuStrip = this.menu1;
            this.gcCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCodes.Location = new System.Drawing.Point(0, 0);
            this.gcCodes.MainView = this.gvCodes;
            this.gcCodes.Name = "gcCodes";
            this.gcCodes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPass,
            this.txtLink});
            this.gcCodes.Size = new System.Drawing.Size(877, 464);
            this.gcCodes.TabIndex = 0;
            this.gcCodes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCodes});
            // 
            // menu1
            // 
            this.menu1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNouveau,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnShowPassword});
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(233, 88);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(232, 26);
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 26);
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Enabled = false;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(232, 26);
            this.btnShowPassword.Text = "Afficher Mot de passe";
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // gvCodes
            // 
            this.gvCodes.Appearance.GroupRow.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCodes.Appearance.GroupRow.Options.UseFont = true;
            this.gvCodes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCodes.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCodes.Appearance.Row.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCodes.Appearance.Row.Options.UseFont = true;
            this.gvCodes.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCodes.Appearance.SelectedRow.Options.UseFont = true;
            this.gvCodes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCode,
            this.gcTitre,
            this.gcDescription,
            this.gcUsername,
            this.gcPassword,
            this.gcURL,
            this.gcObservation});
            this.gvCodes.GridControl = this.gcCodes;
            this.gvCodes.Name = "gvCodes";
            this.gvCodes.OptionsBehavior.Editable = false;
            this.gvCodes.OptionsBehavior.ReadOnly = true;
            this.gvCodes.OptionsFind.AlwaysVisible = true;
            this.gvCodes.OptionsView.ShowAutoFilterRow = true;
            this.gvCodes.OptionsView.ShowGroupPanel = false;
            this.gvCodes.DoubleClick += new System.EventHandler(this.gvCodes_DoubleClick);
            // 
            // gcCode
            // 
            this.gcCode.Caption = "Code";
            this.gcCode.FieldName = "entr_Code";
            this.gcCode.Name = "gcCode";
            // 
            // gcTitre
            // 
            this.gcTitre.Caption = "Titre";
            this.gcTitre.FieldName = "entr_Titre";
            this.gcTitre.Name = "gcTitre";
            this.gcTitre.Visible = true;
            this.gcTitre.VisibleIndex = 0;
            // 
            // gcDescription
            // 
            this.gcDescription.Caption = "Description";
            this.gcDescription.FieldName = "entr_Description";
            this.gcDescription.Name = "gcDescription";
            this.gcDescription.Visible = true;
            this.gcDescription.VisibleIndex = 1;
            // 
            // gcUsername
            // 
            this.gcUsername.Caption = "Nom d\'utilisateur";
            this.gcUsername.FieldName = "entr_Username";
            this.gcUsername.Name = "gcUsername";
            this.gcUsername.Visible = true;
            this.gcUsername.VisibleIndex = 2;
            // 
            // gcPassword
            // 
            this.gcPassword.Caption = "Mot de passe";
            this.gcPassword.ColumnEdit = this.txtPass;
            this.gcPassword.FieldName = "entr_Password";
            this.gcPassword.Name = "gcPassword";
            this.gcPassword.Visible = true;
            this.gcPassword.VisibleIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.AutoHeight = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // gcURL
            // 
            this.gcURL.Caption = "URL";
            this.gcURL.ColumnEdit = this.txtLink;
            this.gcURL.FieldName = "entr_Site";
            this.gcURL.Name = "gcURL";
            this.gcURL.Visible = true;
            this.gcURL.VisibleIndex = 4;
            // 
            // txtLink
            // 
            this.txtLink.AutoHeight = false;
            this.txtLink.Name = "txtLink";
            // 
            // gcObservation
            // 
            this.gcObservation.Caption = "Observation";
            this.gcObservation.FieldName = "entr_Observation";
            this.gcObservation.Name = "gcObservation";
            this.gcObservation.Visible = true;
            this.gcObservation.VisibleIndex = 5;
            // 
            // frmListCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 464);
            this.Controls.Add(this.gcCodes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Codes";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.frmListCode_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gcCodes)).EndInit();
            this.menu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gvCodes;
        private DevExpress.XtraGrid.Columns.GridColumn gcTitre;
        private DevExpress.XtraGrid.Columns.GridColumn gcDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gcUsername;
        private DevExpress.XtraGrid.Columns.GridColumn gcPassword;
        private DevExpress.XtraGrid.Columns.GridColumn gcURL;
        private DevExpress.XtraGrid.Columns.GridColumn gcObservation;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPass;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit txtLink;
        private System.Windows.Forms.ContextMenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem btnNouveau;
        private DevExpress.XtraGrid.Columns.GridColumn gcCode;
        public DevExpress.XtraGrid.GridControl gcCodes;
        private System.Windows.Forms.ToolStripMenuItem btnShowPassword;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}