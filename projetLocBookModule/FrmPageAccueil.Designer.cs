
namespace projetLocBook
{
    partial class FrmPageAccueil
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
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.dgvListeLivre = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.mnsPageAccueil = new System.Windows.Forms.MenuStrip();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHistorique = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbTriGenre = new System.Windows.Forms.ComboBox();
            this.cmbTriParCategorie = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAjouterLivre = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeLivre)).BeginInit();
            this.mnsPageAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(42, 98);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(178, 22);
            this.txtRecherche.TabIndex = 2;
            this.txtRecherche.Text = "Recherche...";
            // 
            // dgvListeLivre
            // 
            this.dgvListeLivre.AllowUserToAddRows = false;
            this.dgvListeLivre.AllowUserToDeleteRows = false;
            this.dgvListeLivre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListeLivre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeLivre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colAuteur,
            this.colParGenre,
            this.colCategorie,
            this.colId,
            this.btnModifier,
            this.btnSupprimer});
            this.dgvListeLivre.Location = new System.Drawing.Point(42, 145);
            this.dgvListeLivre.Name = "dgvListeLivre";
            this.dgvListeLivre.ReadOnly = true;
            this.dgvListeLivre.RowHeadersWidth = 51;
            this.dgvListeLivre.RowTemplate.Height = 24;
            this.dgvListeLivre.Size = new System.Drawing.Size(738, 269);
            this.dgvListeLivre.TabIndex = 3;
            this.dgvListeLivre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeLivre_CellContentClick);
            // 
            // colNom
            // 
            this.colNom.HeaderText = "Nom du livre";
            this.colNom.MinimumWidth = 6;
            this.colNom.Name = "colNom";
            this.colNom.ReadOnly = true;
            // 
            // colAuteur
            // 
            this.colAuteur.HeaderText = "Auteur";
            this.colAuteur.MinimumWidth = 6;
            this.colAuteur.Name = "colAuteur";
            this.colAuteur.ReadOnly = true;
            // 
            // colParGenre
            // 
            this.colParGenre.HeaderText = "Genre";
            this.colParGenre.MinimumWidth = 6;
            this.colParGenre.Name = "colParGenre";
            this.colParGenre.ReadOnly = true;
            // 
            // colCategorie
            // 
            this.colCategorie.HeaderText = "Categorie";
            this.colCategorie.MinimumWidth = 6;
            this.colCategorie.Name = "colCategorie";
            this.colCategorie.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // btnModifier
            // 
            this.btnModifier.HeaderText = "Modifier";
            this.btnModifier.MinimumWidth = 6;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.ReadOnly = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "Supprimer";
            this.btnSupprimer.MinimumWidth = 6;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.ReadOnly = true;
            this.btnSupprimer.Text = "Supprimer";
            // 
            // mnsPageAccueil
            // 
            this.mnsPageAccueil.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsPageAccueil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.panierToolStripMenuItem,
            this.tsmiDeconnexion,
            this.tsmiHistorique});
            this.mnsPageAccueil.Location = new System.Drawing.Point(0, 0);
            this.mnsPageAccueil.Name = "mnsPageAccueil";
            this.mnsPageAccueil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnsPageAccueil.Size = new System.Drawing.Size(849, 28);
            this.mnsPageAccueil.TabIndex = 0;
            this.mnsPageAccueil.Text = "menuStrip1";
            this.mnsPageAccueil.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.profilToolStripMenuItem.Text = "Pr&ofil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.tsmiProfil_Click);
            // 
            // panierToolStripMenuItem
            // 
            this.panierToolStripMenuItem.Name = "panierToolStripMenuItem";
            this.panierToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.panierToolStripMenuItem.Text = "P&anier";
            this.panierToolStripMenuItem.Click += new System.EventHandler(this.tsmiPanier_Click);
            // 
            // tsmiDeconnexion
            // 
            this.tsmiDeconnexion.Name = "tsmiDeconnexion";
            this.tsmiDeconnexion.Size = new System.Drawing.Size(110, 24);
            this.tsmiDeconnexion.Text = "&Déconnexion";
            this.tsmiDeconnexion.Click += new System.EventHandler(this.tsmiDeconnexion_Click);
            // 
            // tsmiHistorique
            // 
            this.tsmiHistorique.Name = "tsmiHistorique";
            this.tsmiHistorique.Size = new System.Drawing.Size(92, 24);
            this.tsmiHistorique.Text = "&Historique";
            this.tsmiHistorique.Click += new System.EventHandler(this.tsmiHistorique_Click);
            // 
            // cmbTriGenre
            // 
            this.cmbTriGenre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTriGenre.FormattingEnabled = true;
            this.cmbTriGenre.Location = new System.Drawing.Point(444, 98);
            this.cmbTriGenre.Name = "cmbTriGenre";
            this.cmbTriGenre.Size = new System.Drawing.Size(152, 24);
            this.cmbTriGenre.TabIndex = 4;
            this.cmbTriGenre.Text = "tri par genre";
            this.cmbTriGenre.SelectedIndexChanged += new System.EventHandler(this.cmbTriGenre_SelectedIndexChanged);
            // 
            // cmbTriParCategorie
            // 
            this.cmbTriParCategorie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTriParCategorie.FormattingEnabled = true;
            this.cmbTriParCategorie.Location = new System.Drawing.Point(602, 98);
            this.cmbTriParCategorie.Name = "cmbTriParCategorie";
            this.cmbTriParCategorie.Size = new System.Drawing.Size(165, 24);
            this.cmbTriParCategorie.TabIndex = 5;
            this.cmbTriParCategorie.Text = "tri par categorie";
            this.cmbTriParCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbTriParCategorie_SelectedIndexChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(254, 98);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(119, 24);
            this.btnRechercher.TabIndex = 6;
            this.btnRechercher.Text = "rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnAjouterLivre
            // 
            this.btnAjouterLivre.Location = new System.Drawing.Point(42, 443);
            this.btnAjouterLivre.Name = "btnAjouterLivre";
            this.btnAjouterLivre.Size = new System.Drawing.Size(119, 24);
            this.btnAjouterLivre.TabIndex = 7;
            this.btnAjouterLivre.Text = "AjouterLivre";
            this.btnAjouterLivre.UseVisualStyleBackColor = true;
            this.btnAjouterLivre.Click += new System.EventHandler(this.btnAjouterLivre_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(42, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 33);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmPageAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 512);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAjouterLivre);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.cmbTriParCategorie);
            this.Controls.Add(this.cmbTriGenre);
            this.Controls.Add(this.dgvListeLivre);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.mnsPageAccueil);
            this.MainMenuStrip = this.mnsPageAccueil;
            this.MinimumSize = new System.Drawing.Size(841, 559);
            this.Name = "FrmPageAccueil";
            this.Text = "PageAccueil";
            this.Load += new System.EventHandler(this.FrmPageAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeLivre)).EndInit();
            this.mnsPageAccueil.ResumeLayout(false);
            this.mnsPageAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.DataGridView dgvListeLivre;
        private System.Windows.Forms.MenuStrip mnsPageAccueil;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeconnexion;
        private System.Windows.Forms.ComboBox cmbTriGenre;
        private System.Windows.Forms.ComboBox cmbTriParCategorie;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistorique;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnAjouterLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewButtonColumn btnModifier;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
        private System.Windows.Forms.Button btnRefresh;
    }
}