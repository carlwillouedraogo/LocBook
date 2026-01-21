using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetLocBook
{
    public partial class FrmProfil : Form
    {
        public FrmProfil(IList<Entites.Membre> membre)
        {
            InitializeComponent();
            DisplayMembreInfo(membre);
        }

        private void tsmiPageAccueil_Click(object sender, EventArgs e)
        {
            //affiche la page d'accueil et ferme celle ci
            FrmPageAccueil accueil = new FrmPageAccueil ();
            accueil.Show();
            this.Hide();
        }

        private void tsmiHistorique_Click(object sender, EventArgs e)
        {
            //affiche la page historique et ferme celle ci
            frmHistorique historique = new frmHistorique();
            
            historique.ShowDialog();
            this.Hide();
        }

        private void tsmiPanier_Click(object sender, EventArgs e)
        {
            //affiche la fenêtre du panier et ferme celle ci
            frmPanier panier = new frmPanier();
            panier.Show();
            this.Hide();
        }

        private void mnsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiDeconnexion_Click(object sender, EventArgs e)
        {
            //message affiché avec l'icon question et les boutons oui ou non
            String message = "Etes vous sur ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //si oui deconnecte l'utilisateur et affiche la page de login
                frmLogin accueil = new frmLogin();
                accueil.Show();
                this.Hide();
            }
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {

        }

        private void tsmiParamètre_Click(object sender, EventArgs e)
        {
            //affiche la fenêtre paramètre
            frmParametre parametre = new frmParametre();
            parametre.Show();
            this.Hide();
        }

        private void DisplayMembreInfo(IList<Entites.Membre> membreInfo)
        {
            // Parse the JSON and display the information appropriately
            // This is a simple example assuming membreInfo is a JSON string
            // You may need to adjust this based on the actual structure of your JSON response

            

            if (membreInfo != null && membreInfo.Count > 0)
            {
                var membre = membreInfo[0];
                lblNom.Text = membre.mem_nom ??  "N/A";
                lblPrenom.Text = membre.mem_prenom ??  "N/A";
                lblAge.Text = membre.mem_age.ToString() ?? "N/A";
                lblEmail.Text = membre.email ?? "N/A";
            }
            else
            {
                MessageBox.Show("Aucune information trouvée pour ce membre.");
            }
        }
    }
}
