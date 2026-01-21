
namespace projetLocBook
{
    partial class FrmProfil
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.mnsProfil = new System.Windows.Forms.MenuStrip();
            this.tsmiPageAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPanier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHistorique = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParamètre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(46, 57);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(46, 105);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(46, 153);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 17);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(46, 201);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblAdresse
            // 
            this.lblAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(46, 249);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(60, 17);
            this.lblAdresse.TabIndex = 6;
            this.lblAdresse.Text = "Adresse";
            // 
            // mnsProfil
            // 
            this.mnsProfil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsProfil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPageAccueil,
            this.tsmiPanier,
            this.tsmiHistorique,
            this.tsmiDeconnexion,
            this.tsmiParamètre});
            this.mnsProfil.Location = new System.Drawing.Point(0, 0);
            this.mnsProfil.Name = "mnsProfil";
            this.mnsProfil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnsProfil.Size = new System.Drawing.Size(663, 30);
            this.mnsProfil.TabIndex = 0;
            this.mnsProfil.Text = "menuStrip1";
            this.mnsProfil.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsMenu_ItemClicked);
            // 
            // tsmiPageAccueil
            // 
            this.tsmiPageAccueil.Name = "tsmiPageAccueil";
            this.tsmiPageAccueil.Size = new System.Drawing.Size(117, 26);
            this.tsmiPageAccueil.Text = "&Page d\'accueil";
            this.tsmiPageAccueil.Click += new System.EventHandler(this.tsmiPageAccueil_Click);
            // 
            // tsmiPanier
            // 
            this.tsmiPanier.Name = "tsmiPanier";
            this.tsmiPanier.Size = new System.Drawing.Size(63, 26);
            this.tsmiPanier.Text = "P&anier";
            this.tsmiPanier.Click += new System.EventHandler(this.tsmiPanier_Click);
            // 
            // tsmiHistorique
            // 
            this.tsmiHistorique.Name = "tsmiHistorique";
            this.tsmiHistorique.Size = new System.Drawing.Size(92, 26);
            this.tsmiHistorique.Text = "&Historique";
            this.tsmiHistorique.Click += new System.EventHandler(this.tsmiHistorique_Click);
            // 
            // tsmiDeconnexion
            // 
            this.tsmiDeconnexion.Name = "tsmiDeconnexion";
            this.tsmiDeconnexion.Size = new System.Drawing.Size(110, 26);
            this.tsmiDeconnexion.Text = "&Déconnexion";
            this.tsmiDeconnexion.Click += new System.EventHandler(this.tsmiDeconnexion_Click);
            // 
            // tsmiParamètre
            // 
            this.tsmiParamètre.Name = "tsmiParamètre";
            this.tsmiParamètre.Size = new System.Drawing.Size(90, 26);
            this.tsmiParamètre.Text = "Pa&ramètre";
            this.tsmiParamètre.Click += new System.EventHandler(this.tsmiParamètre_Click);
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 388);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.mnsProfil);
            this.MainMenuStrip = this.mnsProfil;
            this.MaximumSize = new System.Drawing.Size(970, 464);
            this.MinimumSize = new System.Drawing.Size(681, 435);
            this.Name = "FrmProfil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.FrmProfil_Load);
            this.mnsProfil.ResumeLayout(false);
            this.mnsProfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.MenuStrip mnsProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiPageAccueil;
        private System.Windows.Forms.ToolStripMenuItem tsmiPanier;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistorique;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeconnexion;
        private System.Windows.Forms.ToolStripMenuItem tsmiParamètre;
    }
}