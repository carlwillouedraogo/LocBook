
namespace projetLocBook
{
    partial class FrmLivre
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
            this.lblNomLivre = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblBibliotheque = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDisponibilite = new System.Windows.Forms.Label();
            this.mnsLivre = new System.Windows.Forms.MenuStrip();
            this.tsmiPageAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPanier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjoutPanier = new System.Windows.Forms.Button();
            this.btnEmprunter = new System.Windows.Forms.Button();
            this.btnReserver = new System.Windows.Forms.Button();
            this.mnsLivre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomLivre
            // 
            this.lblNomLivre.AutoSize = true;
            this.lblNomLivre.Location = new System.Drawing.Point(43, 70);
            this.lblNomLivre.Name = "lblNomLivre";
            this.lblNomLivre.Size = new System.Drawing.Size(72, 17);
            this.lblNomLivre.TabIndex = 2;
            this.lblNomLivre.Text = "Nom Livre";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(43, 126);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(50, 17);
            this.lblAuteur.TabIndex = 3;
            this.lblAuteur.Text = "Auteur";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(43, 182);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 17);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // lblBibliotheque
            // 
            this.lblBibliotheque.AutoSize = true;
            this.lblBibliotheque.Location = new System.Drawing.Point(43, 238);
            this.lblBibliotheque.Name = "lblBibliotheque";
            this.lblBibliotheque.Size = new System.Drawing.Size(119, 17);
            this.lblBibliotheque.TabIndex = 5;
            this.lblBibliotheque.Text = "Nom Bibliothèque";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(46, 294);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(31, 17);
            this.lblPrix.TabIndex = 6;
            this.lblPrix.Text = "Prix";
            // 
            // lblDisponibilite
            // 
            this.lblDisponibilite.AutoSize = true;
            this.lblDisponibilite.Location = new System.Drawing.Point(46, 350);
            this.lblDisponibilite.Name = "lblDisponibilite";
            this.lblDisponibilite.Size = new System.Drawing.Size(84, 17);
            this.lblDisponibilite.TabIndex = 7;
            this.lblDisponibilite.Text = "Disponibilité";
            // 
            // mnsLivre
            // 
            this.mnsLivre.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsLivre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPageAccueil,
            this.tsmiProfil,
            this.tsmiPanier,
            this.tsmiDeconnexion});
            this.mnsLivre.Location = new System.Drawing.Point(0, 0);
            this.mnsLivre.Name = "mnsLivre";
            this.mnsLivre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnsLivre.Size = new System.Drawing.Size(464, 28);
            this.mnsLivre.TabIndex = 0;
            this.mnsLivre.Text = "mnsLivre";
            // 
            // tsmiPageAccueil
            // 
            this.tsmiPageAccueil.Name = "tsmiPageAccueil";
            this.tsmiPageAccueil.Size = new System.Drawing.Size(105, 24);
            this.tsmiPageAccueil.Text = "&Page accueil";
            this.tsmiPageAccueil.Click += new System.EventHandler(this.tsmiPageAccueil_Click);
            // 
            // tsmiProfil
            // 
            this.tsmiProfil.Name = "tsmiProfil";
            this.tsmiProfil.Size = new System.Drawing.Size(58, 24);
            this.tsmiProfil.Text = "Pr&ofil";
            this.tsmiProfil.Click += new System.EventHandler(this.tsmiProfil_Click);
            // 
            // tsmiPanier
            // 
            this.tsmiPanier.Name = "tsmiPanier";
            this.tsmiPanier.Size = new System.Drawing.Size(63, 24);
            this.tsmiPanier.Text = "P&anier";
            this.tsmiPanier.Click += new System.EventHandler(this.tsmiPanier_Click);
            // 
            // tsmiDeconnexion
            // 
            this.tsmiDeconnexion.Name = "tsmiDeconnexion";
            this.tsmiDeconnexion.Size = new System.Drawing.Size(110, 24);
            this.tsmiDeconnexion.Text = "&Déconnexion";
            this.tsmiDeconnexion.Click += new System.EventHandler(this.tsmiDeconnexion_Click);
            // 
            // btnAjoutPanier
            // 
            this.btnAjoutPanier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAjoutPanier.Location = new System.Drawing.Point(260, 233);
            this.btnAjoutPanier.Name = "btnAjoutPanier";
            this.btnAjoutPanier.Size = new System.Drawing.Size(136, 28);
            this.btnAjoutPanier.TabIndex = 8;
            this.btnAjoutPanier.Text = "Ajouter au Panier";
            this.btnAjoutPanier.UseVisualStyleBackColor = true;
            this.btnAjoutPanier.Click += new System.EventHandler(this.btnAjoutPanier_Click);
            // 
            // btnEmprunter
            // 
            this.btnEmprunter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEmprunter.Location = new System.Drawing.Point(260, 288);
            this.btnEmprunter.Name = "btnEmprunter";
            this.btnEmprunter.Size = new System.Drawing.Size(109, 28);
            this.btnEmprunter.TabIndex = 9;
            this.btnEmprunter.Text = "Emprunter";
            this.btnEmprunter.UseVisualStyleBackColor = true;
            // 
            // btnReserver
            // 
            this.btnReserver.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReserver.Location = new System.Drawing.Point(260, 343);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(109, 28);
            this.btnReserver.TabIndex = 10;
            this.btnReserver.Text = "Réserver";
            this.btnReserver.UseVisualStyleBackColor = true;
            // 
            // FrmLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 440);
            this.Controls.Add(this.btnReserver);
            this.Controls.Add(this.btnEmprunter);
            this.Controls.Add(this.btnAjoutPanier);
            this.Controls.Add(this.lblDisponibilite);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblBibliotheque);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblNomLivre);
            this.Controls.Add(this.mnsLivre);
            this.MainMenuStrip = this.mnsLivre;
            this.MaximumSize = new System.Drawing.Size(927, 497);
            this.MinimumSize = new System.Drawing.Size(482, 487);
            this.Name = "FrmLivre";
            this.Text = "Livre";
            this.Load += new System.EventHandler(this.FrmLivre_Load);
            this.mnsLivre.ResumeLayout(false);
            this.mnsLivre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomLivre;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblBibliotheque;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblDisponibilite;
        private System.Windows.Forms.MenuStrip mnsLivre;
        private System.Windows.Forms.ToolStripMenuItem tsmiPageAccueil;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiPanier;
        private System.Windows.Forms.Button btnAjoutPanier;
        private System.Windows.Forms.Button btnEmprunter;
        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeconnexion;
    }
}