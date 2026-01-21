using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetLocBook
{
    public partial class frmPanier : Form
    {

        Entites.SessionManager sessionManager = Entites.SessionManager.getInstance();
        private Entites.Panier panier;

        public frmPanier()
        {
            InitializeComponent();
            panier = Entites.Panier.GetInstance();
            MettreAJourDGV();
            ConfigurerDataGridView();
        }

        public void MettreAJourDGV()
        {
            dgvPanier.Rows.Clear(); // Efface toutes les lignes existantes

            foreach (var ouvrage in panier.GetPanier())
            {
                dgvPanier.Rows.Add(ouvrage.ouv_titre, ouvrage.ouv_prix, ouvrage.ouv_auteur);
            }

        }

        public void AjouterLivre(Entites.Ouvrage ouvrage)
        {
            panier.AjouterAuPanier(ouvrage);
            MettreAJourDGV();
        }

        private void tsmiPageAccueil_Click(object sender, EventArgs e)
        {
            //affiche la page d'accueil et ferme la page panier
            FrmPageAccueil accueil = new FrmPageAccueil();
            accueil.Show();
            this.Hide();
        }

        private async void tsmiProfil_Click(object sender, EventArgs e)
        {
            IList<Entites.Membre> membre = await sessionManager.GetMembreInfo();
            FrmProfil profil = new FrmProfil(membre);
            profil.Show();
            this.Hide();
        }

        private void btnAchat_Click(object sender, EventArgs e)
        {
            //affiche la page achat et ferme la page panier
            frmAchat achat = frmAchat.getInstance();
            achat.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            //affiche la page réservation et ferme la page panier
            frmReservation reservation = frmReservation.getInstance();
            reservation.Show();
            this.Hide();
        }

        private void btnEmprunt_Click(object sender, EventArgs e)
        {
            //affiche la page emprunt et ferme la page panier
            frmEmprunt emprunt = frmEmprunt.getInstance();
            emprunt.Show();
            this.Hide();
        }

        private void frmPanier_Load(object sender, EventArgs e)
        {

        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            //vide le contenu du panier
            dgvPanier.Rows.Clear();
            panier.deletePanier();
        }

        private void ConfigurerDataGridView()
        {
            dgvPanier.AutoGenerateColumns = false; // Empêche la génération automatique de colonnes
        }



        private void tsmiDeconnexion_Click(object sender, EventArgs e)
        {
            //message affiché avec l'icon question et les boutons oui ou non
            String message = "Etes vous sur ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(this, message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                //si oui deconnecte l'utilisateur et affiche la page de login
                frmLogin accueil = new frmLogin();
                accueil.Show();
                this.Hide();
            }

        }

       

        private void dgvPanier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MettreAJourDGV();
            Console.WriteLine(panier.GetPanier());
        }
    }
}
