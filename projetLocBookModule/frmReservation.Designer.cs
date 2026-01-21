
namespace projetLocBook
{
    partial class frmReservation
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
            this.lblDateReservation = new System.Windows.Forms.Label();
            this.lblDateReception = new System.Windows.Forms.Label();
            this.dtpDateEmprunt = new System.Windows.Forms.DateTimePicker();
            this.lblPrixAchat = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDateReservation
            // 
            this.lblDateReservation.AutoSize = true;
            this.lblDateReservation.Location = new System.Drawing.Point(213, 95);
            this.lblDateReservation.Name = "lblDateReservation";
            this.lblDateReservation.Size = new System.Drawing.Size(128, 17);
            this.lblDateReservation.TabIndex = 1;
            this.lblDateReservation.Text = "Date de résevation";
            // 
            // lblDateReception
            // 
            this.lblDateReception.AutoSize = true;
            this.lblDateReception.Location = new System.Drawing.Point(213, 174);
            this.lblDateReception.Name = "lblDateReception";
            this.lblDateReception.Size = new System.Drawing.Size(121, 17);
            this.lblDateReception.TabIndex = 2;
            this.lblDateReception.Text = "Date de réception";
            // 
            // dtpDateEmprunt
            // 
            this.dtpDateEmprunt.Location = new System.Drawing.Point(417, 168);
            this.dtpDateEmprunt.Name = "dtpDateEmprunt";
            this.dtpDateEmprunt.Size = new System.Drawing.Size(200, 22);
            this.dtpDateEmprunt.TabIndex = 3;
            // 
            // lblPrixAchat
            // 
            this.lblPrixAchat.AutoSize = true;
            this.lblPrixAchat.Location = new System.Drawing.Point(213, 253);
            this.lblPrixAchat.Name = "lblPrixAchat";
            this.lblPrixAchat.Size = new System.Drawing.Size(81, 17);
            this.lblPrixAchat.TabIndex = 4;
            this.lblPrixAchat.Text = "Prix d\'achat";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(258, 328);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(81, 27);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(417, 328);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(81, 27);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmReservation
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblPrixAchat);
            this.Controls.Add(this.dtpDateEmprunt);
            this.Controls.Add(this.lblDateReception);
            this.Controls.Add(this.lblDateReservation);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmReservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateReservation;
        private System.Windows.Forms.Label lblDateReception;
        private System.Windows.Forms.DateTimePicker dtpDateEmprunt;
        private System.Windows.Forms.Label lblPrixAchat;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}