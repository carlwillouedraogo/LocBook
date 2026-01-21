
namespace projetLocBook
{
    partial class FrmModifierLivre
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
            this.lblModifier = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModifier
            // 
            this.lblModifier.AutoSize = true;
            this.lblModifier.Location = new System.Drawing.Point(201, 55);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(149, 17);
            this.lblModifier.TabIndex = 0;
            this.lblModifier.Text = "Modification d\'un Livre";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(84, 150);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(69, 17);
            this.lblCategorie.TabIndex = 1;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(84, 232);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 17);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(84, 316);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Location = new System.Drawing.Point(184, 145);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(220, 22);
            this.txtCategorie.TabIndex = 4;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(184, 233);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(220, 22);
            this.txtGenre.TabIndex = 5;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(184, 317);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(78, 22);
            this.txtStock.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(149, 380);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(220, 25);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(41, 30);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(77, 42);
            this.btnRetour.TabIndex = 8;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmModifierLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 430);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblModifier);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(524, 477);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(524, 477);
            this.Name = "FrmModifierLivre";
            this.Text = "FrmModifierLivre";
            this.Load += new System.EventHandler(this.FrmModifierLivre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifier;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
    }
}