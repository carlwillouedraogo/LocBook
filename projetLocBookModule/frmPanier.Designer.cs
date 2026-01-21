
namespace projetLocBook
{
    partial class frmPanier
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
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPageAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.lblListe = new System.Windows.Forms.Label();
            this.dgvPanier = new System.Windows.Forms.DataGridView();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnAchat = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnEmprunt = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.colNomLivre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProfil,
            this.tsmiPageAccueil,
            this.tsmiDeconnexion});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnsMenu.Size = new System.Drawing.Size(800, 28);
            this.mnsMenu.TabIndex = 0;
            // 
            // tsmiProfil
            // 
            this.tsmiProfil.Name = "tsmiProfil";
            this.tsmiProfil.Size = new System.Drawing.Size(58, 24);
            this.tsmiProfil.Text = "Pr&ofil";
            this.tsmiProfil.Click += new System.EventHandler(this.tsmiProfil_Click);
            // 
            // tsmiPageAccueil
            // 
            this.tsmiPageAccueil.Name = "tsmiPageAccueil";
            this.tsmiPageAccueil.Size = new System.Drawing.Size(119, 24);
            this.tsmiPageAccueil.Text = "&Page d\'Accueil";
            this.tsmiPageAccueil.Click += new System.EventHandler(this.tsmiPageAccueil_Click);
            // 
            // tsmiDeconnexion
            // 
            this.tsmiDeconnexion.Name = "tsmiDeconnexion";
            this.tsmiDeconnexion.Size = new System.Drawing.Size(110, 24);
            this.tsmiDeconnexion.Text = "&Deconnexion";
            this.tsmiDeconnexion.Click += new System.EventHandler(this.tsmiDeconnexion_Click);
            // 
            // lblListe
            // 
            this.lblListe.AutoSize = true;
            this.lblListe.Location = new System.Drawing.Point(30, 72);
            this.lblListe.Name = "lblListe";
            this.lblListe.Size = new System.Drawing.Size(75, 17);
            this.lblListe.TabIndex = 2;
            this.lblListe.Text = "Liste livres";
            // 
            // dgvPanier
            // 
            this.dgvPanier.AllowUserToAddRows = false;
            this.dgvPanier.AllowUserToDeleteRows = false;
            this.dgvPanier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPanier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomLivre,
            this.colPrix,
            this.colAuteur});
            this.dgvPanier.Location = new System.Drawing.Point(33, 127);
            this.dgvPanier.Name = "dgvPanier";
            this.dgvPanier.ReadOnly = true;
            this.dgvPanier.RowHeadersWidth = 51;
            this.dgvPanier.RowTemplate.Height = 24;
            this.dgvPanier.Size = new System.Drawing.Size(726, 198);
            this.dgvPanier.TabIndex = 4;
            this.dgvPanier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPanier_CellContentClick);
            // 
            // btnVider
            // 
            this.btnVider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVider.Location = new System.Drawing.Point(624, 72);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(135, 29);
            this.btnVider.TabIndex = 3;
            this.btnVider.Text = "Vider panier";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnAchat
            // 
            this.btnAchat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAchat.Location = new System.Drawing.Point(33, 349);
            this.btnAchat.Name = "btnAchat";
            this.btnAchat.Size = new System.Drawing.Size(135, 29);
            this.btnAchat.TabIndex = 5;
            this.btnAchat.Text = "Valider Achat";
            this.btnAchat.UseVisualStyleBackColor = true;
            this.btnAchat.Click += new System.EventHandler(this.btnAchat_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReservation.Location = new System.Drawing.Point(312, 349);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(144, 29);
            this.btnReservation.TabIndex = 6;
            this.btnReservation.Text = "Valider Réservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnEmprunt
            // 
            this.btnEmprunt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmprunt.Location = new System.Drawing.Point(591, 349);
            this.btnEmprunt.Name = "btnEmprunt";
            this.btnEmprunt.Size = new System.Drawing.Size(135, 29);
            this.btnEmprunt.TabIndex = 7;
            this.btnEmprunt.Text = "Valider Emprunt";
            this.btnEmprunt.UseVisualStyleBackColor = true;
            this.btnEmprunt.Click += new System.EventHandler(this.btnEmprunt_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(33, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 37);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // colNomLivre
            // 
            this.colNomLivre.HeaderText = "Nom du livre";
            this.colNomLivre.MinimumWidth = 6;
            this.colNomLivre.Name = "colNomLivre";
            this.colNomLivre.ReadOnly = true;
            // 
            // colPrix
            // 
            this.colPrix.HeaderText = "Prix";
            this.colPrix.MinimumWidth = 6;
            this.colPrix.Name = "colPrix";
            this.colPrix.ReadOnly = true;
            // 
            // colAuteur
            // 
            this.colAuteur.HeaderText = "Auteur";
            this.colAuteur.MinimumWidth = 6;
            this.colAuteur.Name = "colAuteur";
            this.colAuteur.ReadOnly = true;
            // 
            // frmPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEmprunt);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnAchat);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.dgvPanier);
            this.Controls.Add(this.lblListe);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmPanier";
            this.Text = " Panier";
            this.Load += new System.EventHandler(this.frmPanier_Load);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiPageAccueil;
        private System.Windows.Forms.Label lblListe;
        private System.Windows.Forms.DataGridView dgvPanier;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnAchat;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnEmprunt;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeconnexion;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuteur;
    }
}