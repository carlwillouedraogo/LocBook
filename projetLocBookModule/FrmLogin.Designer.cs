
namespace projetLocBook
{
    partial class frmLogin
    {
       
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLocBook = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMotPass = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMotPass = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.llbEnregistrer = new System.Windows.Forms.LinkLabel();
            this.llbPasseOublier = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblLocBook
            // 
            this.lblLocBook.AutoSize = true;
            this.lblLocBook.Location = new System.Drawing.Point(45, 39);
            this.lblLocBook.Name = "lblLocBook";
            this.lblLocBook.Size = new System.Drawing.Size(63, 17);
            this.lblLocBook.TabIndex = 0;
            this.lblLocBook.Text = "LocBook";
            this.lblLocBook.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(300, 83);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(142, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblMotPass
            // 
            this.lblMotPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMotPass.AutoSize = true;
            this.lblMotPass.Location = new System.Drawing.Point(142, 199);
            this.lblMotPass.Name = "lblMotPass";
            this.lblMotPass.Size = new System.Drawing.Size(93, 17);
            this.lblMotPass.TabIndex = 4;
            this.lblMotPass.Text = "Mot de passe";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(249, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "test@test.com";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtMotPass
            // 
            this.txtMotPass.Location = new System.Drawing.Point(249, 199);
            this.txtMotPass.Name = "txtMotPass";
            this.txtMotPass.Size = new System.Drawing.Size(333, 22);
            this.txtMotPass.TabIndex = 5;
            this.txtMotPass.Text = "testmdp";
            this.txtMotPass.TextChanged += new System.EventHandler(this.txtMotPass_TextChanged);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnexion.Location = new System.Drawing.Point(303, 275);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(87, 27);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // llbEnregistrer
            // 
            this.llbEnregistrer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.llbEnregistrer.AutoSize = true;
            this.llbEnregistrer.Location = new System.Drawing.Point(146, 324);
            this.llbEnregistrer.Name = "llbEnregistrer";
            this.llbEnregistrer.Size = new System.Drawing.Size(89, 17);
            this.llbEnregistrer.TabIndex = 7;
            this.llbEnregistrer.TabStop = true;
            this.llbEnregistrer.Text = "S\'enregistrer";
            this.llbEnregistrer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbEnregistrer_LinkClicked);
            // 
            // llbPasseOublier
            // 
            this.llbPasseOublier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.llbPasseOublier.AutoSize = true;
            this.llbPasseOublier.Location = new System.Drawing.Point(442, 324);
            this.llbPasseOublier.Name = "llbPasseOublier";
            this.llbPasseOublier.Size = new System.Drawing.Size(140, 17);
            this.llbPasseOublier.TabIndex = 8;
            this.llbPasseOublier.TabStop = true;
            this.llbPasseOublier.Text = "Mot de passe oublier";
            this.llbPasseOublier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbPasseOublier_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 426);
            this.Controls.Add(this.llbPasseOublier);
            this.Controls.Add(this.llbEnregistrer);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMotPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblMotPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblLocBook);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(711, 473);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocBook;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMotPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMotPass;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.LinkLabel llbEnregistrer;
        private System.Windows.Forms.LinkLabel llbPasseOublier;
    }
}

