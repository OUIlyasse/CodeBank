namespace CodeGenerateur.Main
{
    partial class frmMainCG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCG));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkLowerCase = new DevExpress.XtraEditors.CheckEdit();
            this.chkUpperCase = new DevExpress.XtraEditors.CheckEdit();
            this.chkNumeric = new DevExpress.XtraEditors.CheckEdit();
            this.chkSpecical = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.numLongueur = new System.Windows.Forms.NumericUpDown();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkLowerCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUpperCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNumeric.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSpecical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.chkSpecical);
            this.groupControl1.Controls.Add(this.chkNumeric);
            this.groupControl1.Controls.Add(this.chkUpperCase);
            this.groupControl1.Controls.Add(this.chkLowerCase);
            this.groupControl1.Location = new System.Drawing.Point(12, 223);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(458, 154);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Jeu de caractères";
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.EditValue = true;
            this.chkLowerCase.Location = new System.Drawing.Point(17, 55);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLowerCase.Properties.Appearance.Options.UseFont = true;
            this.chkLowerCase.Properties.Caption = "Minuscules (a-z)";
            this.chkLowerCase.Size = new System.Drawing.Size(187, 25);
            this.chkLowerCase.TabIndex = 0;
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.EditValue = true;
            this.chkUpperCase.Location = new System.Drawing.Point(17, 100);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpperCase.Properties.Appearance.Options.UseFont = true;
            this.chkUpperCase.Properties.Caption = "Majuscule (A-Z)";
            this.chkUpperCase.Size = new System.Drawing.Size(187, 25);
            this.chkUpperCase.TabIndex = 1;
            // 
            // chkNumeric
            // 
            this.chkNumeric.EditValue = true;
            this.chkNumeric.Location = new System.Drawing.Point(239, 55);
            this.chkNumeric.Name = "chkNumeric";
            this.chkNumeric.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumeric.Properties.Appearance.Options.UseFont = true;
            this.chkNumeric.Properties.Caption = "Chiffres (0-9)";
            this.chkNumeric.Size = new System.Drawing.Size(187, 25);
            this.chkNumeric.TabIndex = 2;
            // 
            // chkSpecical
            // 
            this.chkSpecical.EditValue = true;
            this.chkSpecical.Location = new System.Drawing.Point(239, 100);
            this.chkSpecical.Name = "chkSpecical";
            this.chkSpecical.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpecical.Properties.Appearance.Options.UseFont = true;
            this.chkSpecical.Properties.Caption = "Symboles ASCII (@#&$)";
            this.chkSpecical.Size = new System.Drawing.Size(187, 25);
            this.chkSpecical.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 416);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(187, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Longueur du mot de passe";
            // 
            // numLongueur
            // 
            this.numLongueur.Location = new System.Drawing.Point(239, 412);
            this.numLongueur.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numLongueur.Name = "numLongueur";
            this.numLongueur.Size = new System.Drawing.Size(76, 28);
            this.numLongueur.TabIndex = 2;
            this.numLongueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLongueur.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txtPass);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(458, 92);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Généré le mot de passe";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(17, 46);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Size = new System.Drawing.Size(409, 28);
            this.txtPass.TabIndex = 0;
            this.txtPass.DoubleClick += new System.EventHandler(this.txtPass_DoubleClick);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Appearance.Options.UseFont = true;
            this.btnGenerate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.ImageOptions.Image = global::CodeGenerateur.Properties.Resources.icons8_Password_Key_32px;
            this.btnGenerate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGenerate.Location = new System.Drawing.Point(89, 142);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(308, 50);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Générer";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmMainCG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 468);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.numLongueur);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainCG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generateur";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkLowerCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUpperCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNumeric.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSpecical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkLowerCase;
        private DevExpress.XtraEditors.CheckEdit chkSpecical;
        private DevExpress.XtraEditors.CheckEdit chkNumeric;
        private DevExpress.XtraEditors.CheckEdit chkUpperCase;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.NumericUpDown numLongueur;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
    }
}