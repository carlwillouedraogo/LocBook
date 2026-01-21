
namespace projetLocBook
{
    partial class frmEmprunt
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
            this.dtpDebutEmprunt = new System.Windows.Forms.DateTimePicker();
            this.lblDebutEmprunt = new System.Windows.Forms.Label();
            this.lblDateFinEmprunt = new System.Windows.Forms.Label();
            this.dtpFinEmprunt = new System.Windows.Forms.DateTimePicker();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDebutEmprunt
            // 
            this.dtpDebutEmprunt.Location = new System.Drawing.Point(397, 125);
            this.dtpDebutEmprunt.Name = "dtpDebutEmprunt";
            this.dtpDebutEmprunt.Size = new System.Drawing.Size(200, 22);
            this.dtpDebutEmprunt.TabIndex = 2;
            // 
            // lblDebutEmprunt
            // 
            this.lblDebutEmprunt.AutoSize = true;
            this.lblDebutEmprunt.Location = new System.Drawing.Point(236, 125);
            this.lblDebutEmprunt.Name = "lblDebutEmprunt";
            this.lblDebutEmprunt.Size = new System.Drawing.Size(145, 17);
            this.lblDebutEmprunt.TabIndex = 1;
            this.lblDebutEmprunt.Text = "Date debut d\'emprunt";
            // 
            // lblDateFinEmprunt
            // 
            this.lblDateFinEmprunt.AutoSize = true;
            this.lblDateFinEmprunt.Location = new System.Drawing.Point(239, 214);
            this.lblDateFinEmprunt.Name = "lblDateFinEmprunt";
            this.lblDateFinEmprunt.Size = new System.Drawing.Size(124, 17);
            this.lblDateFinEmprunt.TabIndex = 3;
            this.lblDateFinEmprunt.Text = "Date fin d\'emprunt";
            // 
            // dtpFinEmprunt
            // 
            this.dtpFinEmprunt.Location = new System.Drawing.Point(397, 209);
            this.dtpFinEmprunt.Name = "dtpFinEmprunt";
            this.dtpFinEmprunt.Size = new System.Drawing.Size(200, 22);
            this.dtpFinEmprunt.TabIndex = 4;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(276, 297);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(87, 28);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(445, 297);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 28);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmEmprunt
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dtpFinEmprunt);
            this.Controls.Add(this.lblDateFinEmprunt);
            this.Controls.Add(this.lblDebutEmprunt);
            this.Controls.Add(this.dtpDebutEmprunt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmEmprunt";
            this.Text = "Emprunt";
            this.Load += new System.EventHandler(this.frmEmprunt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDebutEmprunt;
        private System.Windows.Forms.Label lblDebutEmprunt;
        private System.Windows.Forms.Label lblDateFinEmprunt;
        private System.Windows.Forms.DateTimePicker dtpFinEmprunt;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}