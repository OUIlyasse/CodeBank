namespace CodeBank.Sub
{
    partial class frmNew
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNew));
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTitre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtRepeat = new DevExpress.XtraEditors.TextEdit();
            this.txtDescrip = new DevExpress.XtraEditors.MemoEdit();
            this.txtObserv = new DevExpress.XtraEditors.MemoEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCode = new DevExpress.XtraEditors.SimpleButton();
            this.txtURL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ckbShow = new DevExpress.XtraEditors.CheckEdit();
            this.vpValidate = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObserv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbShow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(167, 195);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(343, 28);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.EditValueChanged += new System.EventHandler(this.txtPassword_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Titre";
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(167, 12);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Properties.Appearance.Options.UseFont = true;
            this.txtTitre.Size = new System.Drawing.Size(343, 28);
            this.txtTitre.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Ce champ est vide";
            this.vpValidate.SetValidationRule(this.txtTitre, conditionValidationRule1);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Description";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 158);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(123, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Nom d\'utilisateur";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 199);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 21);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Mot de passe";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(21, 290);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(87, 21);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Observation";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(21, 240);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 21);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Répéter";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(167, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Size = new System.Drawing.Size(343, 28);
            this.txtUsername.TabIndex = 3;
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(167, 236);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeat.Properties.Appearance.Options.UseFont = true;
            this.txtRepeat.Properties.UseSystemPasswordChar = true;
            this.txtRepeat.Size = new System.Drawing.Size(343, 28);
            this.txtRepeat.TabIndex = 6;
            compareAgainstControlValidationRule1.CaseSensitive = true;
            compareAgainstControlValidationRule1.Control = this.txtPassword;
            compareAgainstControlValidationRule1.ErrorText = "This value is not valid";
            this.vpValidate.SetValidationRule(this.txtRepeat, compareAgainstControlValidationRule1);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(167, 53);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrip.Properties.Appearance.Options.UseFont = true;
            this.txtDescrip.Size = new System.Drawing.Size(343, 47);
            this.txtDescrip.TabIndex = 1;
            // 
            // txtObserv
            // 
            this.txtObserv.Location = new System.Drawing.Point(167, 277);
            this.txtObserv.Name = "txtObserv";
            this.txtObserv.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObserv.Properties.Appearance.Options.UseFont = true;
            this.txtObserv.Size = new System.Drawing.Size(343, 47);
            this.txtObserv.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdd.Location = new System.Drawing.Point(167, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 50);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUpdate.Location = new System.Drawing.Point(358, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 50);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCode
            // 
            this.btnCode.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCode.Appearance.Options.UseFont = true;
            this.btnCode.AutoSize = true;
            this.btnCode.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCode.ImageOptions.Image")));
            this.btnCode.Location = new System.Drawing.Point(520, 190);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(40, 38);
            this.btnCode.TabIndex = 5;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(167, 113);
            this.txtURL.Name = "txtURL";
            this.txtURL.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Properties.Appearance.Options.UseFont = true;
            this.txtURL.Size = new System.Drawing.Size(343, 28);
            this.txtURL.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(21, 117);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 21);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "URL";
            // 
            // ckbShow
            // 
            this.ckbShow.Location = new System.Drawing.Point(520, 238);
            this.ckbShow.Name = "ckbShow";
            this.ckbShow.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShow.Properties.Appearance.Options.UseFont = true;
            this.ckbShow.Properties.Caption = "Afficher";
            this.ckbShow.Size = new System.Drawing.Size(90, 25);
            this.ckbShow.TabIndex = 20;
            this.ckbShow.CheckedChanged += new System.EventHandler(this.ckbShow_CheckedChanged);
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 432);
            this.Controls.Add(this.ckbShow);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtObserv);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObserv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbShow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTitre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtRepeat;
        private DevExpress.XtraEditors.MemoEdit txtDescrip;
        private DevExpress.XtraEditors.MemoEdit txtObserv;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnCode;
        private DevExpress.XtraEditors.TextEdit txtURL;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit ckbShow;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidate;
    }
}