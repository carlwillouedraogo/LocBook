
namespace projetLocBook
{
    partial class frmHistorique
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
            this.mnsMenuHistorique = new System.Windows.Forms.MenuStrip();
            this.tsmiProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPageAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPanier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiParametre = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvHistorique = new System.Windows.Forms.DataGridView();
            this.lblHistorique = new System.Windows.Forms.Label();
            this.colNomLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrixLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHistoriqueAchat = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnEmprunt = new System.Windows.Forms.Button();
            this.mnsMenuHistorique.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorique)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMenuHistorique
            // 
            this.mnsMenuHistorique.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenuHistorique.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProfil,
            this.tsmiPageAccueil,
            this.tsmiPanier,
            this.tsmiDeconnexion,
            this.tsmiParametre});
            this.mnsMenuHistorique.Location = new System.Drawing.Point(0, 0);
            this.mnsMenuHistorique.Name = "mnsMenuHistorique";
            this.mnsMenuHistorique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnsMenuHistorique.Size = new System.Drawing.Size(868, 28);
            this.mnsMenuHistorique.TabIndex = 0;
            this.mnsMenuHistorique.Text = "menuStrip1";
            // 
            // tsmiProfil
            // 
            this.tsmiProfil.Name = "tsmiProfil";
            this.tsmiProfil.ShortcutKeyDisplayString = "alt + 1";
            this.tsmiProfil.Size = new System.Drawing.Size(58, 24);
            this.tsmiProfil.Text = "&Profil";
            this.tsmiProfil.Click += new System.EventHandler(this.tsmiProfil_Click);
            // 
            // tsmiPageAccueil
            // 
            this.tsmiPageAccueil.Name = "tsmiPageAccueil";
            this.tsmiPageAccueil.Size = new System.Drawing.Size(119, 24);
            this.tsmiPageAccueil.Text = "Pa&ge D\'accueil";
            this.tsmiPageAccueil.Click += new System.EventHandler(this.tsmiPageAccueil_Click);
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
            this.tsmiDeconnexion.Text = "&Deconnexion";
            this.tsmiDeconnexion.Click += new System.EventHandler(this.tsmiDeconnexion_Click);
            // 
            // tsmiParametre
            // 
            this.tsmiParametre.Name = "tsmiParametre";
            this.tsmiParametre.Size = new System.Drawing.Size(90, 24);
            this.tsmiParametre.Text = "Pa&ramètre";
            this.tsmiParametre.Click += new System.EventHandler(this.tsmiParametre_Click);
            // 
            // dgvHistorique
            // 
            this.dgvHistorique.AllowUserToAddRows = false;
            this.dgvHistorique.AllowUserToDeleteRows = false;
            this.dgvHistorique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorique.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomLivre,
            this.colPrixLivre});
            this.dgvHistorique.Location = new System.Drawing.Point(28, 100);
            this.dgvHistorique.Name = "dgvHistorique";
            this.dgvHistorique.ReadOnly = true;
            this.dgvHistorique.RowHeadersWidth = 51;
            this.dgvHistorique.RowTemplate.Height = 24;
            this.dgvHistorique.Size = new System.Drawing.Size(737, 282);
            this.dgvHistorique.TabIndex = 5;
            // 
            // lblHistorique
            // 
            this.lblHistorique.AutoSize = true;
            this.lblHistorique.Location = new System.Drawing.Point(64, 68);
            this.lblHistorique.Name = "lblHistorique";
            this.lblHistorique.Size = new System.Drawing.Size(72, 17);
            this.lblHistorique.TabIndex = 2;
            this.lblHistorique.Text = "Historique";
            this.lblHistorique.Click += new System.EventHandler(this.label1_Click);
            // 
            // colNomLivre
            // 
            this.colNomLivre.HeaderText = "Nom du livre";
            this.colNomLivre.MinimumWidth = 6;
            this.colNomLivre.Name = "colNomLivre";
            this.colNomLivre.ReadOnly = true;
            // 
            // colPrixLivre
            // 
            this.colPrixLivre.HeaderText = "Prix du livre";
            this.colPrixLivre.MinimumWidth = 6;
            this.colPrixLivre.Name = "colPrixLivre";
            this.colPrixLivre.ReadOnly = true;
            // 
            // btnHistoriqueAchat
            // 
            this.btnHistoriqueAchat.Location = new System.Drawing.Point(67, 406);
            this.btnHistoriqueAchat.Name = "btnHistoriqueAchat";
            this.btnHistoriqueAchat.Size = new System.Drawing.Size(144, 32);
            this.btnHistoriqueAchat.TabIndex = 6;
            this.btnHistoriqueAchat.Text = "Historique Achat";
            this.btnHistoriqueAchat.UseVisualStyleBackColor = true;
            this.btnHistoriqueAchat.Click += new System.EventHandler(this.btnHistoriqueAchat_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(302, 406);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(167, 32);
            this.btnReservation.TabIndex = 7;
            this.btnReservation.Text = "Historique Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnEmprunt
            // 
            this.btnEmprunt.Location = new System.Drawing.Point(568, 406);
            this.btnEmprunt.Name = "btnEmprunt";
            this.btnEmprunt.Size = new System.Drawing.Size(144, 32);
            this.btnEmprunt.TabIndex = 8;
            this.btnEmprunt.Text = "Historique Emprunt";
            this.btnEmprunt.UseVisualStyleBackColor = true;
            this.btnEmprunt.Click += new System.EventHandler(this.btnEmprunt_Click);
            // 
            // frmHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.btnEmprunt);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnHistoriqueAchat);
            this.Controls.Add(this.lblHistorique);
            this.Controls.Add(this.dgvHistorique);
            this.Controls.Add(this.mnsMenuHistorique);
            this.MainMenuStrip = this.mnsMenuHistorique;
            this.MinimumSize = new System.Drawing.Size(886, 497);
            this.Name = "frmHistorique";
            this.Text = "Historique";
            this.Load += new System.EventHandler(this.frmHistorique_Load);
            this.mnsMenuHistorique.ResumeLayout(false);
            this.mnsMenuHistorique.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnsMenuHistorique;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiPageAccueil;
        private System.Windows.Forms.ToolStripMenuItem tsmiPanier;
        private System.Windows.Forms.DataGridView dgvHistorique;
        private System.Windows.Forms.Label lblHistorique;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeconnexion;
        private System.Windows.Forms.ToolStripMenuItem tsmiParametre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrixLivre;
        private System.Windows.Forms.Button btnHistoriqueAchat;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnEmprunt;
    }
}