
namespace projetLocBook
{
    partial class frmParametre
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
            this.lblParametre = new System.Windows.Forms.Label();
            this.lblChangerMail = new System.Windows.Forms.Label();
            this.lblChangerAdresse = new System.Windows.Forms.Label();
            this.lblNouveauPasse = new System.Windows.Forms.Label();
            this.txtChangerMail = new System.Windows.Forms.TextBox();
            this.txtChangerAdresse = new System.Windows.Forms.TextBox();
            this.txtNouveauMotPasse = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.mnsParametre = new System.Windows.Forms.MenuStrip();
            this.tsmiPageAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHistorique = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeconnextion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParametre
            // 
            this.lblParametre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblParametre.AutoSize = true;
            this.lblParametre.Location = new System.Drawing.Point(395, 50);
            this.lblParametre.Name = "lblParametre";
            this.lblParametre.Size = new System.Drawing.Size(93, 17);
            this.lblParametre.TabIndex = 1;
            this.lblParametre.Text = "Modifier profil";
            // 
            // lblChangerMail
            // 
            this.lblChangerMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChangerMail.AutoSize = true;
            this.lblChangerMail.Location = new System.Drawing.Point(111, 108);
            this.lblChangerMail.Name = "lblChangerMail";
            this.lblChangerMail.Size = new System.Drawing.Size(99, 17);
            this.lblChangerMail.TabIndex = 2;
            this.lblChangerMail.Text = "Changer email";
            // 
            // lblChangerAdresse
            // 
            this.lblChangerAdresse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChangerAdresse.AutoSize = true;
            this.lblChangerAdresse.Location = new System.Drawing.Point(111, 174);
            this.lblChangerAdresse.Name = "lblChangerAdresse";
            this.lblChangerAdresse.Size = new System.Drawing.Size(117, 17);
            this.lblChangerAdresse.TabIndex = 4;
            this.lblChangerAdresse.Text = "Changer adresse";
            // 
            // lblNouveauPasse
            // 
            this.lblNouveauPasse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNouveauPasse.AutoSize = true;
            this.lblNouveauPasse.Location = new System.Drawing.Point(111, 254);
            this.lblNouveauPasse.Name = "lblNouveauPasse";
            this.lblNouveauPasse.Size = new System.Drawing.Size(154, 17);
            this.lblNouveauPasse.TabIndex = 8;
            this.lblNouveauPasse.Text = "Nouveau mot de passe";
            // 
            // txtChangerMail
            // 
            this.txtChangerMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChangerMail.Location = new System.Drawing.Point(323, 108);
            this.txtChangerMail.Name = "txtChangerMail";
            this.txtChangerMail.Size = new System.Drawing.Size(461, 22);
            this.txtChangerMail.TabIndex = 3;
            this.txtChangerMail.TextChanged += new System.EventHandler(this.txtChangerMail_TextChanged);
            // 
            // txtChangerAdresse
            // 
            this.txtChangerAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChangerAdresse.Location = new System.Drawing.Point(323, 174);
            this.txtChangerAdresse.Name = "txtChangerAdresse";
            this.txtChangerAdresse.Size = new System.Drawing.Size(461, 22);
            this.txtChangerAdresse.TabIndex = 5;
            // 
            // txtNouveauMotPasse
            // 
            this.txtNouveauMotPasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNouveauMotPasse.Location = new System.Drawing.Point(323, 254);
            this.txtNouveauMotPasse.Name = "txtNouveauMotPasse";
            this.txtNouveauMotPasse.Size = new System.Drawing.Size(461, 22);
            this.txtNouveauMotPasse.TabIndex = 9;
            this.txtNouveauMotPasse.UseSystemPasswordChar = true;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmer.Location = new System.Drawing.Point(335, 319);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(84, 29);
            this.btnConfirmer.TabIndex = 10;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(540, 319);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(84, 29);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // mnsParametre
            // 
            this.mnsParametre.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsParametre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPageAccueil,
            this.tsmiHistorique,
            this.tsmiProfil,
            this.tsmiDeconnextion});
            this.mnsParametre.Location = new System.Drawing.Point(0, 0);
            this.mnsParametre.Name = "mnsParametre";
            this.mnsParametre.Size = new System.Drawing.Size(916, 28);
            this.mnsParametre.TabIndex = 0;
            this.mnsParametre.Text = "menuStrip1";
            // 
            // tsmiPageAccueil
            // 
            this.tsmiPageAccueil.Name = "tsmiPageAccueil";
            this.tsmiPageAccueil.ShortcutKeyDisplayString = "Ctrl + A";
            this.tsmiPageAccueil.Size = new System.Drawing.Size(107, 24);
            this.tsmiPageAccueil.Text = "&Page Accueil";
            this.tsmiPageAccueil.Click += new System.EventHandler(this.tsmiPageAccueil_Click);
            // 
            // tsmiHistorique
            // 
            this.tsmiHistorique.Name = "tsmiHistorique";
            this.tsmiHistorique.Size = new System.Drawing.Size(92, 24);
            this.tsmiHistorique.Text = "&Historique";
            this.tsmiHistorique.Click += new System.EventHandler(this.tsmiHistorique_Click);
            // 
            // tsmiProfil
            // 
            this.tsmiProfil.Name = "tsmiProfil";
            this.tsmiProfil.Size = new System.Drawing.Size(58, 24);
            this.tsmiProfil.Text = "Pr&ofil";
            this.tsmiProfil.Click += new System.EventHandler(this.tsmiProfil_Click);
            // 
            // tsmiDeconnextion
            // 
            this.tsmiDeconnextion.Name = "tsmiDeconnextion";
            this.tsmiDeconnextion.Size = new System.Drawing.Size(110, 24);
            this.tsmiDeconnextion.Text = "&Deconnexion";
            this.tsmiDeconnextion.Click += new System.EventHandler(this.tsmiDeconnextion_Click);
            // 
            // frmParametre
            // 
            this.AcceptButton = this.btnConfirmer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(916, 442);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtNouveauMotPasse);
            this.Controls.Add(this.txtChangerAdresse);
            this.Controls.Add(this.txtChangerMail);
            this.Controls.Add(this.lblNouveauPasse);
            this.Controls.Add(this.lblChangerAdresse);
            this.Controls.Add(this.lblChangerMail);
            this.Controls.Add(this.lblParametre);
            this.Controls.Add(this.mnsParametre);
            this.MainMenuStrip = this.mnsParametre;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(994, 538);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(919, 489);
            this.Name = "frmParametre";
            this.Text = "Parametre";
            this.Load += new System.EventHandler(this.frmParametre_Load);
            this.mnsParametre.ResumeLayout(false);
            this.mnsParametre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParametre;
        private System.Windows.Forms.Label lblChangerMail;
        private System.Windows.Forms.Label lblChangerAdresse;
        private System.Windows.Forms.Label lblNouveauPasse;
        private System.Windows.Forms.TextBox txtChangerMail;
        private System.Windows.Forms.TextBox txtChangerAdresse;
        private System.Windows.Forms.TextBox txtNouveauMotPasse;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.MenuStrip mnsParametre;
        private System.Windows.Forms.ToolStripMenuItem tsmiPageAccueil;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistorique;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeconnextion;
    }
}