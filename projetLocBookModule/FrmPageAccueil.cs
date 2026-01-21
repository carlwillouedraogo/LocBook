using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Pour les requêtes
using System.Net.Http;
// Pour envoyer des entêtes (token par ex.)
using System.Net.Http.Headers;
// Pour traiter le Json
using System.Text;
using System.Text.Json;

namespace projetLocBook
{
    public partial class FrmPageAccueil : Form
    {
        string url = "http://127.0.0.1:8000/api/ouvrage/accueil";
        string urltri = "http://127.0.0.1:8000/api/ouvrage/bycatetgen";
        string urlGenre = "http://127.0.0.1:8000/api/genre";
        string urlCategorie = "http://127.0.0.1:8000/api/categorie";
        string urlName = "http://127.0.0.1:8000/api/ouvrage/byname";
        string urlById = "http://127.0.0.1:8000/api/ouvrage";
        string urlSupprimerLivre = "http://127.0.0.1:8000/api/ouvrage/supprimer";
        
        Entites.SessionManager sessionManager = Entites.SessionManager.getInstance();
        private Dictionary<string, Type> fenetres = new Dictionary<string, Type>();

        private FrmModifierLivre modifierLivre = null;
        private FrmLivre afficherLivre = null;
        // Pour les requêtes HTTP
        private static readonly HttpClient client = new HttpClient();
        public FrmPageAccueil()
        {
            InitializeComponent();
            remplirDataGridView();
            remplirComboBox();
            remplirComboBoxCategorie();
            dgvListeLivre.CellContentClick += dgvListeLivre_CellContentClick;
            
            cmbTriGenre.SelectedIndexChanged += cmbTriGenre_SelectedIndexChanged;
            cmbTriParCategorie.SelectedIndexChanged += cmbTriParCategorie_SelectedIndexChanged;
            // Lier l'événement de clic sur les cellules du DataGridView
            /*fenetres.Add("Seigneur des anneaux", typeof(FrmLivre));
            fenetres.Add("lol", typeof(FrmLivre));*/
            if (sessionManager.EstAdmin)
            {
                btnAjouterLivre.Visible = true;
                btnModifier.Visible = true;
                btnSupprimer.Visible = true;
            }
            else
            {
                btnAjouterLivre.Visible = false;
                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
            }

        }

        

        private async void remplirDataGridView()
        {
            //ajoute des valeurs au datagridview
            IList<Entites.Ouvrage> ouvrages = null;


            try
            {
                // Affichage de l'url pour la démo
                //lblUrl.Text = url;

                // Création de la requête
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                // Création de l'entête d'authorisation avec le Bearer token
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
                // Pour plusieurs requêtes, définir une entête par défaut
                // Par défaut: client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                // Envoyer la requête
                var response = await client.SendAsync(request);

                // Attendre la réponse
                response.EnsureSuccessStatusCode();

                // Lire le contenu de la réponse
                var responseBody = await response.Content.ReadAsStringAsync();

                // Affichage du retour pour la démo
                //txtResult.Text = responseBody;

                // Transformation du JSON en une liste de "User" (classe définie avec LES BONS ATTRIBUTS, nom et type...)
                ouvrages = JsonSerializer.Deserialize<IList<Entites.Ouvrage>>(responseBody);

                // Afficher dans le datagridview
                //dgvListeLivre.DataSource = ouvrages;

                if (dgvListeLivre.ColumnCount > 0)
                {
                    dgvListeLivre.Rows.Clear();

                    // Exemple de parcours et d'accès pour la démo:
                    foreach (Entites.Ouvrage u in ouvrages)
                    {

                        dgvListeLivre.Rows.Add(u.ouv_titre, u.ouv_auteur, u.gen_nom, u.cat_nom,u.ouv_id);
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erreur lors de la requêtes: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private void dgvListeLivre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvListeLivre.Columns["btnModifier"].Index)
                {
                    int cell = Convert.ToInt32(dgvListeLivre.Rows[e.RowIndex].Cells["colId"].Value);
                    OpenModificationForm(cell);
                }
                else if (e.ColumnIndex == dgvListeLivre.Columns["btnSupprimer"].Index)
                {
                    var cell = dgvListeLivre.Rows[e.RowIndex].Cells["colId"].Value;
                    if (cell != null && long.TryParse(cell.ToString(), out long ouvrageId))
                    {
                        supprimerLivre(ouvrageId);
                    }
                    else
                    {
                        MessageBox.Show("La valeur de l'id n'est pas valide");
                    }
                }
                else
                {
                    // Handle other cell clicks if needed
                    var cell = dgvListeLivre.Rows[e.RowIndex].Cells["colId"].Value;
                    if (cell != null && long.TryParse(cell.ToString(), out long ouvrageId))
                    {
                        detailLivre(ouvrageId);
                    }
                    else
                    {
                        MessageBox.Show("La valeur de l'id n'est pas valide");
                    }
                }
            }
        }

        private async void supprimerLivre(long cell)
        {
            string urlDelete = $"{urlSupprimerLivre}?id={cell}";
            var request = new HttpRequestMessage(HttpMethod.Delete, urlDelete);
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);

            try
            {
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Livre Supprimer");
                }
                else
                {
                    MessageBox.Show("Livre non supprimer");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Une erreure s'est produite lors de la suppression du livre");
            }
        }

        private void OpenModificationForm(int cell)
        {
            if (modifierLivre == null || modifierLivre.IsDisposed)
            {
                modifierLivre = new FrmModifierLivre(cell);
                modifierLivre.Show();
                this.Hide();
            }
            else
            {
                modifierLivre.Focus();
            }
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void tsmiPanier_Click(object sender, EventArgs e)
        {
            //affiche la fenêtre panier et ferme la fenêtre accueil
                frmPanier panier = new frmPanier();
                panier.Show();
                this.Hide();
            
        }

        private async void tsmiProfil_Click(object sender, EventArgs e)
        {
            IList<Entites.Membre> membreInfo = await sessionManager.GetMembreInfo();

            if (membreInfo != null && membreInfo.Any())
            {
                //affiche la fenêtre profil et ferme la fenêtre accueil
                FrmProfil profil = new FrmProfil(membreInfo);
                profil.Show();
                this.Hide();
            }
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private async void tsmiDeconnexion_Click(object sender, EventArgs e)
        {
            //affiche un message avec son icon et les boutons oui ou non
            String message = "Etes vous sur ?";
            String caption = "Question";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            
            result = MessageBox.Show(caption, message, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool estDeconnecte = await sessionManager.DeconnecterUtilisateur();
                if (estDeconnecte)
                {
                    //si oui déconnecte l'utilisateur et retourne à la fenêtre de login
                    frmLogin accueil = new frmLogin();
                    accueil.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("la déconnextion à échoué");
                }
            }
        }

        private void FrmPageAccueil_Load(object sender, EventArgs e)
        {
            
        }

        private void tsmiHistorique_Click(object sender, EventArgs e)
        {
            //affiche la fenêtre historique
            frmHistorique historique = new frmHistorique();
            historique.Show();
            this.Hide();
        }

        

        private async void UpdateDataGridView()
        {
            try
            {
                string selectedCategory = cmbTriParCategorie.SelectedItem?.ToString();
                string selectedGenre = cmbTriGenre.SelectedItem?.ToString();

                // Construire l'URL avec les paramètres de requête
                string filterUrl = $"{urltri}?category={selectedCategory}&genre={selectedGenre}";

                var request = new HttpRequestMessage(HttpMethod.Get, filterUrl);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var ouvrages = JsonSerializer.Deserialize<IList<Entites.Ouvrage>>(responseBody);

                // Mettre à jour le DataGridView avec les données filtrées
                dgvListeLivre.Rows.Clear();
                foreach (var ouvrage in ouvrages)
                {
                    dgvListeLivre.Rows.Add(ouvrage.ouv_titre, ouvrage.ouv_auteur, ouvrage.gen_nom, ouvrage.cat_nom,ouvrage.ouv_id);
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erreur lors de la requête: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private async void remplirComboBox()
        {
            //ajoute des valeurs au datagridview
            IList<Entites.Genre> genres = null;


            try
            {
                // Affichage de l'url pour la démo
                //lblUrl.Text = url;

                // Création de la requête
                var request = new HttpRequestMessage(HttpMethod.Get, urlGenre);

                // Création de l'entête d'authorisation avec le Bearer token
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
                // Pour plusieurs requêtes, définir une entête par défaut
                // Par défaut: client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                // Envoyer la requête
                var response = await client.SendAsync(request);

                // Attendre la réponse
                response.EnsureSuccessStatusCode();

                // Lire le contenu de la réponse
                var responseBody = await response.Content.ReadAsStringAsync();

                // Affichage du retour pour la démo
                //txtResult.Text = responseBody;

                // Transformation du JSON en une liste de "User" (classe définie avec LES BONS ATTRIBUTS, nom et type...)
                genres = JsonSerializer.Deserialize<IList<Entites.Genre>>(responseBody);

                // Afficher dans le datagridview
                //dgvListeLivre.DataSource = ouvrages;
                cmbTriGenre.Items.Clear();
                cmbTriGenre.Items.Add("");
                foreach (var genre in genres)
                {
                    cmbTriGenre.Items.Add(genre.gen_nom);
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erreur lors de la requêtes: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private async void remplirComboBoxCategorie()
        {
            //ajoute des valeurs au datagridview
            IList<Entites.Categorie> categories = null;

            try
            {
                // Affichage de l'url pour la démo
                //lblUrl.Text = url;

                // Création de la requête
                var request = new HttpRequestMessage(HttpMethod.Get, urlCategorie);

                // Création de l'entête d'authorisation avec le Bearer token
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);
                // Pour plusieurs requêtes, définir une entête par défaut
                // Par défaut: client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                // Envoyer la requête
                var response = await client.SendAsync(request);

                // Attendre la réponse
                response.EnsureSuccessStatusCode();

                // Lire le contenu de la réponse
                var responseBody = await response.Content.ReadAsStringAsync();

                // Affichage du retour pour la démo
                //txtResult.Text = responseBody;

                // Transformation du JSON en une liste de "User" (classe définie avec LES BONS ATTRIBUTS, nom et type...)
                categories = JsonSerializer.Deserialize<IList<Entites.Categorie>>(responseBody);

                // Afficher dans le datagridview
                //dgvListeLivre.DataSource = ouvrages;
                cmbTriParCategorie.Items.Clear();
                cmbTriParCategorie.Items.Add("");
                foreach (var categorie in categories)
                {
                    cmbTriParCategorie.Items.Add(categorie.cat_nom);
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erreur lors de la requêtes: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        private async Task RechercherLivreParNom(string nomLivre)
        {

            IList<Entites.Ouvrage> ouvrage = null;
            try
            {
                // Construire l'URL de recherche
                string rechercheUrl = $"{urlName}?name={nomLivre}";

                // Créer une requête HTTP GET
                var request = new HttpRequestMessage(HttpMethod.Get, rechercheUrl);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);

                // Envoyer la requête HTTP
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                // Lire la réponse JSON
                var responseBody = await response.Content.ReadAsStringAsync();
                ouvrage = JsonSerializer.Deserialize<List<Entites.Ouvrage>>(responseBody);

                // Afficher les détails du livre dans le DataGridView
                dgvListeLivre.Rows.Clear();
                foreach (var ouv in ouvrage)
                {
                    dgvListeLivre.Rows.Add(ouv.ouv_titre, ouv.ouv_auteur, ouv.gen_nom, ouv.cat_nom,ouv.ouv_id);
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erreur lors de la requête: {httpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");
            }
        }

        

       

        private async void btnRechercher_Click(object sender, EventArgs e)
        {
            string nomLivre = txtRecherche.Text.Trim();

            // Vérifier si le champ de saisie n'est pas vide avant de lancer la recherche
            if (!string.IsNullOrWhiteSpace(nomLivre))
            {
                // Lancer la recherche
                await RechercherLivreParNom(nomLivre);
            }
            else
            {
                // Effacer le DataGridView si le champ de saisie est vide
                dgvListeLivre.Rows.Clear();
            }
        }

        private async void detailLivre(long livreId)
        {
            List<Entites.Ouvrage> ouvrages = null;
            try
            {
                string rechercheUrl = $"{urlById}?id={livreId}";

                // Créer une requête HTTP GET
                var request = new HttpRequestMessage(HttpMethod.Get, rechercheUrl);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Entites.AuthTokenManager.AuthToken);

                // Envoyer la requête HTTP
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                // Lire la réponse JSON
                var responseBody = await response.Content.ReadAsStringAsync();
                ouvrages = JsonSerializer.Deserialize<List<Entites.Ouvrage>>(responseBody);
                if (afficherLivre == null || afficherLivre.IsDisposed)
                {
                    if (ouvrages != null && ouvrages.Count > 0)
                    {
                        afficherLivre = new FrmLivre(ouvrages[0]);
                        afficherLivre.ShowDialog();
                    }
                    else
                    {

                        MessageBox.Show("Aucun livre trouvé");
                    }
                    afficherLivre.Focus();
                }
                
                
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Erreur lors de la requête: {httpEx.Message}");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}");

            }
        }

      

        

       
        private void cmbTriParCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void cmbTriGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
            frmAjouterLivre ajouterLivre = new frmAjouterLivre();
            ajouterLivre.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private async void RefreshData()
        {
            try
            {
                string urlLivre = url;

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var jsonData = await response.Content.ReadAsStringAsync();
                var ouvrages = JsonSerializer.Deserialize<List<Entites.Ouvrage>>(jsonData);
                dgvListeLivre.Rows.Clear();
                foreach (var ouv in ouvrages)
                {
                    dgvListeLivre.Rows.Add(ouv.ouv_titre, ouv.ouv_auteur, ouv.gen_nom, ouv.cat_nom, ouv.ouv_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("une erreur est survenue");
            }
        }
    }
    
}
