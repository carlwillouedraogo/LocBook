
namespace projetLocBook
{
    partial class frmMotPasseOublier
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
            this.txtNouveauPasse = new System.Windows.Forms.TextBox();
            this.lblNouveauPasse = new System.Windows.Forms.Label();
            this.lblConfirmerPasse = new System.Windows.Forms.Label();
            this.txtConfirmerPasse = new System.Windows.Forms.TextBox();
            this.lblChangerMotDePasse = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNouveauPasse
            // 
            this.txtNouveauPasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNouveauPasse.Location = new System.Drawing.Point(272, 199);
            this.txtNouveauPasse.Name = "txtNouveauPasse";
            this.txtNouveauPasse.Size = new System.Drawing.Size(366, 22);
            this.txtNouveauPasse.TabIndex = 2;
            // 
            // lblNouveauPasse
            // 
            this.lblNouveauPasse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNouveauPasse.AutoSize = true;
            this.lblNouveauPasse.Location = new System.Drawing.Point(88, 204);
            this.lblNouveauPasse.Name = "lblNouveauPasse";
            this.lblNouveauPasse.Size = new System.Drawing.Size(154, 17);
            this.lblNouveauPasse.TabIndex = 1;
            this.lblNouveauPasse.Text = "Nouveau mot de passe";
            // 
            // lblConfirmerPasse
            // 
            this.lblConfirmerPasse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfirmerPasse.AutoSize = true;
            this.lblConfirmerPasse.Location = new System.Drawing.Point(91, 286);
            this.lblConfirmerPasse.Name = "lblConfirmerPasse";
            this.lblConfirmerPasse.Size = new System.Drawing.Size(158, 17);
            this.lblConfirmerPasse.TabIndex = 3;
            this.lblConfirmerPasse.Text = "Confirmer mot de passe";
            // 
            // txtConfirmerPasse
            // 
            this.txtConfirmerPasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmerPasse.Location = new System.Drawing.Point(272, 286);
            this.txtConfirmerPasse.Name = "txtConfirmerPasse";
            this.txtConfirmerPasse.Size = new System.Drawing.Size(366, 22);
            this.txtConfirmerPasse.TabIndex = 4;
            // 
            // lblChangerMotDePasse
            // 
            this.lblChangerMotDePasse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChangerMotDePasse.AutoSize = true;
            this.lblChangerMotDePasse.Location = new System.Drawing.Point(341, 60);
            this.lblChangerMotDePasse.Name = "lblChangerMotDePasse";
            this.lblChangerMotDePasse.Size = new System.Drawing.Size(166, 17);
            this.lblChangerMotDePasse.TabIndex = 0;
            this.lblChangerMotDePasse.Text = "Changer le mot de passe";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmer.Location = new System.Drawing.Point(305, 331);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(88, 26);
            this.btnConfirmer.TabIndex = 5;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(436, 331);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(88, 26);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(88, 137);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(272, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(366, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // frmMotPasseOublier
            // 
            this.AcceptButton = this.btnConfirmer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblChangerMotDePasse);
            this.Controls.Add(this.txtConfirmerPasse);
            this.Controls.Add(this.lblConfirmerPasse);
            this.Controls.Add(this.lblNouveauPasse);
            this.Controls.Add(this.txtNouveauPasse);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(918, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmMotPasseOublier";
            this.Text = "Mot de Passe Oublier";
            this.Load += new System.EventHandler(this.frmMotPasseOublier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNouveauPasse;
        private System.Windows.Forms.Label lblNouveauPasse;
        private System.Windows.Forms.Label lblConfirmerPasse;
        private System.Windows.Forms.TextBox txtConfirmerPasse;
        private System.Windows.Forms.Label lblChangerMotDePasse;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}