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
    public partial class FrmLivre : Form
    {
        Entites.SessionManager sessionManager = Entites.SessionManager.getInstance();
        bool isAdmin = Entites.SessionManager.getInstance().EstAdmin;
        private frmPanier panier = new frmPanier();
        private long id;
        public FrmLivre(Entites.Ouvrage ouvrage)
        {
            InitializeComponent();
            this.id = ouvrage.ouv_id;
            lblAuteur.Text = ouvrage.ouv_auteur;
            lblBibliotheque.Text = ouvrage.bib_nom;
            lblDisponibilite.Text = ouvrage.ouv_stock.ToString();
            lblGenre.Text = ouvrage.gen_nom;
            lblNomLivre.Text = ouvrage.ouv_titre;
            lblPrix.Text = ouvrage.ouv_prix.ToString();


        }

        private void tsmiPanier_Click(object sender, EventArgs e)
        {
            //affiche la fenêtre du panier et ferme la fenêtre actuel
            frmPanier panier = new frmPanier();
            
            panier.Show();
            this.Hide();
        }

        private async void tsmiProfil_Click(object sender, EventArgs e)
        {
            IList<Entites.Membre> membre = await sessionManager.GetMembreInfo();
            //affiche la fenêtre de profil et ferme la fenêtre actuel
            FrmProfil profil = new FrmProfil(membre);
            
            profil.Show();
            this.Hide();
        }

        private void tsmiPageAccueil_Click(object sender, EventArgs e)
        {
            //affiche la page d'accueil et ferme la fenêtre actuel
            FrmPageAccueil pageAccueil = new FrmPageAccueil();
            pageAccueil.Show();
            this.Hide();
        }

        private void btnAjoutPanier_Click(object sender, EventArgs e)
        {
            Entites.Ouvrage ouvrages = new Entites.Ouvrage
            {
                ouv_id = id,
                ouv_titre = lblNomLivre.Text,
                ouv_auteur = lblAuteur.Text,
                ouv_prix = Convert.ToDouble(lblPrix.Text),
            };
            Entites.Panier panier = Entites.Panier.GetInstance();
            panier.AjouterAuPanier(ouvrages);
            MessageBox.Show("Livre ajouté au panier");
        }

        private void tsmiDeconnexion_Click(object sender, EventArgs e)
        {
            //affiche un message son icon et les boutons oui ou non
            String message = "Etes vous sur de vouloir vous déconnecter ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //si oui deconnecte l'utilisateur et retourne à la page de login
                frmLogin accueil = new frmLogin();
                accueil.Show();
                this.Hide();
            }
        }

       

       

        private void FrmLivre_Load(object sender, EventArgs e)
        {

        }
    }
}
