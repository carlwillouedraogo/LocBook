using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetLocBook
{
    public partial class frmHistorique : Form
    {
        Entites.SessionManager sessionManager = Entites.SessionManager.getInstance();
        private static readonly HttpClient client = new HttpClient();
        string urlHistEmprunt = "http://127.0.0.1:8000/api/emprunt";
        string urlHistAchat = "http://127.0.0.1:8000/api/achat";
        string urlHistReserv = "http://127.0.0.1:8000/api/reservation";
        public frmHistorique()
        {
            InitializeComponent();
        }

        private async void tsmiProfil_Click(object sender, EventArgs e)
        {
            IList<Entites.Membre> membre = await sessionManager.GetMembreInfo();
            //affiche la page de profil et ferme la page de l'historique
            FrmProfil profil = new FrmProfil(membre);
            profil.Show();
            this.Hide();
        }

        private void tsmiPageAccueil_Click(object sender, EventArgs e)
        {
            //affiche la page d'accueil et ferme la page de l'historique
            FrmPageAccueil accueil = new FrmPageAccueil();
            accueil.Show();
            this.Hide();
        }

        private void tsmiPanier_Click(object sender, EventArgs e)
        {
            //affiche la page du panier et ferme la page de l'historique
            frmPanier panier = new frmPanier();
            panier.Show();
            this.Hide();
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();

        }

        private void tsmiDeconnexion_Click(object sender, EventArgs e)
        {
            //affiche le message l'icon et les boutons oui ou non
            String message = "Etes vous sur de vouloir vous déconnecter ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //si oui déconnecte l'utilisateur et retourne sur la page de login
                frmLogin accueil = new frmLogin();
                accueil.Show();
                this.Hide();
            }
        }

        private void frmHistorique_Load(object sender, EventArgs e)
        {

        }

        private void tsmiParametre_Click(object sender, EventArgs e)
        {
            //affiche la fenêtre parametre
            frmParametre parametre = new frmParametre();
            parametre.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async Task<List<Entites.Achat>> HistoriqueAchat()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, urlHistAchat);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
            
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            List<Entites.Achat> achats = JsonSerializer.Deserialize<List<Entites.Achat>>(responseBody);
            return achats;
        }

        private async Task<List<Entites.Reservation>> HistoriqueReservation()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, urlHistReserv);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            List<Entites.Reservation> reservs = JsonSerializer.Deserialize<List<Entites.Reservation>>(responseBody);
            return reservs;
        }

        private async Task<List<Entites.Emprunt>> HistoriqueEmprunt()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, urlHistEmprunt);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            List<Entites.Emprunt> emprunts = JsonSerializer.Deserialize<List<Entites.Emprunt>>(responseBody);
            return emprunts;
        }

        private async void btnHistoriqueAchat_Click(object sender, EventArgs e)
        {
            var achat = await HistoriqueAchat();
            afficherHistoriqueAchat(achat);
        }

        private async void btnReservation_Click(object sender, EventArgs e)
        {
            var reservation = await HistoriqueReservation();
            afficherHistoriqueReservation(reservation);
        }

        private async void btnEmprunt_Click(object sender, EventArgs e)
        {
            var emprunt = await HistoriqueEmprunt();
            afficherHistoriqueEmprunt(emprunt);
        }

        private void afficherHistoriqueReservation(List<Entites.Reservation> reservations)
        {
            InitializeDataGridViewForReservations();
            dgvHistorique.Rows.Clear();
            foreach(var res in reservations)
            {
                dgvHistorique.Rows.Add(res.ouv_titre, res.res_date_debut,res.res_date_fin);
            }
        }

        private void afficherHistoriqueAchat(List<Entites.Achat> achats)
        {
            InitializeDataGridViewForAchats();
            dgvHistorique.Rows.Clear();
            foreach (var achat in achats)
            {
                dgvHistorique.Rows.Add(achat.ouv_titre, achat.ouv_prix);
            }
        }

        private void afficherHistoriqueEmprunt(List<Entites.Emprunt> emprunts)
        {
            InitializeDataGridViewForEmprunt();
            dgvHistorique.Rows.Clear();
            foreach (var emp in emprunts)
            {
                dgvHistorique.Rows.Add(emp.ouv_titre, emp.ouv_prix,emp.emp_date_debut,emp.emp_date_fin);
            }
        }

        private void InitializeDataGridViewForReservations()
        {
            // Clear existing columns
            dgvHistorique.Columns.Clear();

            // Add columns for reservations
            dgvHistorique.Columns.Add("Titre", "Titre");
            dgvHistorique.Columns.Add("Date debut", "Date Debut");
            dgvHistorique.Columns.Add("Date fin ", "Date Fin");
        }

        private void InitializeDataGridViewForAchats()
        {
            // Clear existing columns
            dgvHistorique.Columns.Clear();

            // Add columns for reservations
            dgvHistorique.Columns.Add("Titre", "Titre");
            dgvHistorique.Columns.Add("Prix du livre", "Prix du livre");
        }

        private void InitializeDataGridViewForEmprunt()
        {
            // Clear existing columns
            dgvHistorique.Columns.Clear();

            // Add columns for reservations
            dgvHistorique.Columns.Add("Titre", "Titre");
            dgvHistorique.Columns.Add("Prix du livre", "Prix du livre");
            dgvHistorique.Columns.Add("Date debut", "Date Fin");
            dgvHistorique.Columns.Add("Date Fin", "Date Fin");
        }
    }
}
