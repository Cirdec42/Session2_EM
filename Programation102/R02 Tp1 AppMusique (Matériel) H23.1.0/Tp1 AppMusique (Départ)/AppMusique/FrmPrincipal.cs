using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace AppDeMusique
{
    /// ======================================================================================================
    /// <summary>
    /// Simule une application de musique sur un téléphone intelligent, affiche des morceaux ( artiste, album, titre, cote, durée).
    /// 
    /// - Actions possibles par l'utilisateur :
    ///     - aller au morceau suivant ou reculer vers le morceau précédent.
    ///     - supprimer le morceau courant de la liste
    ///     - créer une liste contenant les meilleurs morceaux disponibles de la liste courante
    ///     - mélanger les morceaux de la liste.
    /// - À tout moment, on peut recharger la bibliothèque, soit la liste complète des morceaux.
    /// 
    /// Au départ, on charge la liste de lecture à partir d'un fichier qui a été sauvegardée au moment de quitter.
    /// En quittant, on sauvegarde automatiquement la liste de lecture de l'utilisateur dans un fichier Texte.
    /// </summary>
    /// ======================================================================================================
    /// 
    public partial class FrmPrincipal : Form
    {
        private const string APP_INFO = "(Matériel)";

        #region TODO 00 : Analyser le code fourni 

        //------------ Constantes et variables --------------------------------
        private const string BIBLIOTHEQUE = "Fichiers\\Bibliothèque.txt";
        private const string LISTE_DE_LECTURE = "Fichiers\\ListeDeLecture.txt";

        private const int SEUIL_COTE_MEILLEUR_MORCEAU = 4;

        private List<Morceau> m_colMorceaux;

        private Random m_objRandom = new Random();
        //---------------------------------------------------------------------


        //==========================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            this.Text += APP_INFO;
            //-----------------------------------
            //compléter le constructeur du formulaire
            m_colMorceaux = new List<Morceau>();
            ChargerMorceaux(LISTE_DE_LECTURE);
            AfficherListeDeLecture();
            AfficherMorceauCourant();
            MettreAJourSelonContexte();
        }
        #endregion

        #region TODO 01 : Charger une liste de morceaux
        /// TODO 01 (15%) : Charger une liste de morceaux
        /// <summary>
        /// Lit les informations dans le fichier, les charge en mémoire dans la liste générique.
        /// </summary>
        /// <param name="pNomDuFichier">nom du fichier à lire</param>
        /// ----------------------------------------------------------------------------------------------------
        private void ChargerMorceaux(string pNomDuFichier)
        {
            // À COMPLÉTER...
            StreamReader objStreamReader = new StreamReader(pNomDuFichier);
            while (!objStreamReader.EndOfStream)
            {
                string uneLigneLue = objStreamReader.ReadLine();
                string[] tabInfos = uneLigneLue.Split('|');
                String[] temps = tabInfos[4].Split(':');
                int seconde = Int16.Parse(temps[0]) * 60 + Int16.Parse(temps[1]);
                Morceau unMorceau = new Morceau(tabInfos[0], tabInfos[1], tabInfos[2], Int16.Parse(tabInfos[3]), seconde);
                m_colMorceaux.Add(unMorceau);
            }
            objStreamReader.Close();

        }
        #endregion

        #region TODO 02 : Afficher la liste de lecture
        /// TODO 02 (15%) : Afficher la liste de lecture
        /// <summary>
        /// Affiche la liste des morceaux dans la zone de liste lstMorceaux
        /// Après avoir ajouté les morceaux à la liste lstMorceaux, faites en sorte que le premier
        /// morceau de cette liste soit sélectionné
        /// </summary>
        public void AfficherListeDeLecture()
        {
            // À COMPLÉTER...
            int cpt = 0;
            foreach (var morceau in m_colMorceaux)
            {
                lstMorceaux.Items.Add(m_colMorceaux[cpt].Titre + " par " + m_colMorceaux[cpt].Artiste);
                cpt++;
            }
            lstMorceaux.SelectedIndex = 0;
        }

        private void LstMorceaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            // NE PAS MODIFIER
            AfficherMorceauCourant();
        }
        #endregion

        #region TODO 03 : Afficher le morceau courant
        /// TODO 03 (15%) : Afficher le morceau courant
        /// <summary>
        /// Affiche les informations sur le morceau courant. 
        /// Avant d'afficher l'image, il faut s'assurer que l'image existe bien sur le disque.
        /// Utiliser if (File.Exists (nom du fichier))....Les images sont déposées dans le dossier Images.
        /// Le nom du fichier image est formé du nom de l'artiste, un trait d'union et du nom de l'album
        /// exemple: "Genesis-Live"
        /// picImage est un contrôle de type PictureBox. 
		/// Voyez sur Moodle comment afficher une image dans ce type de contrôle.
        /// </summary>
        /// -----------------------------------------------------------------------------------------------
        private void AfficherMorceauCourant()
        {
            // À COMPLÉTER...
            int durée = m_colMorceaux[lstMorceaux.SelectedIndex].Durée / 60 + m_colMorceaux[lstMorceaux.SelectedIndex].Durée % 60;
            lblAlbumCourant.Text = m_colMorceaux[lstMorceaux.SelectedIndex].Album;
            lblArtisteCourant.Text = m_colMorceaux[lstMorceaux.SelectedIndex].Artiste;
            lblTitreCourant.Text = m_colMorceaux[lstMorceaux.SelectedIndex].Titre;
            lblDuréeCourante.Text = durée.ToString();
            lblCote.Text = m_colMorceaux[lstMorceaux.SelectedIndex].Cote.ToString();
            lblMorceauCourant.Text = lstMorceaux.SelectedIndex+1 + " / " + lstMorceaux.Items.Count;
            if (File.Exists("Images/" + m_colMorceaux[lstMorceaux.SelectedIndex].Artiste + "-" + m_colMorceaux[lstMorceaux.SelectedIndex].Album + ".jpg"))
            {
                picAlbum.Image = Image.FromFile("Images/" + m_colMorceaux[lstMorceaux.SelectedIndex].Artiste + "-" + m_colMorceaux[lstMorceaux.SelectedIndex].Album + ".jpg");
            }
            else
            {
                picAlbum.Image = Image.FromFile("Images/Sans image.jpg");
            }

        }
        #endregion

        #region TODO 04 : Recharger la bibliothèque
        /// TODO 04 (5%) : Recharger la bibliothèque
        /// <summary>
        /// Recharge la bibliothèque dans la liste générique.
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        private void mnuFichierRecharger_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            m_colMorceaux.Clear();
            lstMorceaux.Items.Clear();
            StreamReader objStreamReader = new StreamReader(BIBLIOTHEQUE);
            while (!objStreamReader.EndOfStream)
            {
                string uneLigneLue = objStreamReader.ReadLine();
                string[] tabInfos = uneLigneLue.Split('|');
                String[] temps = tabInfos[4].Split(':');
                int seconde = Int16.Parse(temps[0]) * 60 + Int16.Parse(temps[1]);
                Morceau unMorceau = new Morceau(tabInfos[0], tabInfos[1], tabInfos[2], Int16.Parse(tabInfos[3]), seconde);
                m_colMorceaux.Add(unMorceau);
            }
            objStreamReader.Close();
            int cpt = 0;
            foreach (var morceau in m_colMorceaux)
            {
                lstMorceaux.Items.Add(m_colMorceaux[cpt].Titre + " par " + m_colMorceaux[cpt].Artiste);
                cpt++;
            }
            lstMorceaux.SelectedIndex = 0;

        }
        #endregion

        #region TODO 05 : Supprimer le morceau courant
        /// TODO 05 (10%) : Supprimer le morceau courant
        /// <summary>
        /// Permet de supprimer dans la collection de morceaux, le morceau courant de la liste.
		/// Rafraichir l'affichage - voyez la démo
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        private void mnuOpérationSupprimer_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...


        }
        #endregion

        #region TODO 06 : Enregistrer la liste au moment de quitter
        /// TODO 06 (15%) : Enregistrer la liste au moment de quitter
        /// <summary>
        /// Au moment de fermer l'application, on sauvegarde la liste de lecture dans le fichier Texte.
        /// On sépare chacune des données d'un morceau par les séparateurs | et : 
        /// Voici un exemple 
        ///  artiste|album|titre|cote|minutes:secondes
        ///  Susan Boyle|I Dreamed A Dream|Wild Horses|1|04:53
        /// </summary>
        /// -----------------------------------------------------------------------------------------------
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // À COMPLÉTER...
            StreamWriter objStreamWriter = new StreamWriter(LISTE_DE_LECTURE);
            
        }
        //==========================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region TODO 07 : Mélanger les morceaux dans la liste
        /// TODO 07 (15%) : Mélanger les morceaux dans la liste
        /// <summary>
        /// Permet de mélanger de façon aléatoire les morceaux dans la collection.
        /// Utiliser l'objet m_objRandom.Next(début, fin+1) pour générer vos nombres aléatoires
        ///     et utilisez ces nombres aléatoires comme indices des éléments de la collection de morceaux
		///     que vous voulez permutter.
        /// Utilisez une boucle for pour permutter la liste pour un nombre de 4 fois sa longueur. 
		/// (S'il y a 12 morceaux dans la liste, faites 48 permutations)
		/// Rafraichir l'affichage une fois que vous avez mélangés les morceaux
		/// </summary>
        /// ----------------------------------------------------------------------------------------
        private void mnuOpérationMélanger_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }
        #endregion

        #region TODO 08 : Conserver Meilleurs morceaux
        /// TODO 08 (10%) : Conserver Meilleurs morceaux
        /// <summary>
        /// Cette méthode va modifier la collection de morceaux pour ne conserver que les morceaux qui
        /// ont une cote égale ou suppérieure à SEUIL_COTE_MEILLEUR_MORCEAU
		/// Rafraichir l'affichage une fois que vous n'avez plus que les meilleurs morceaux
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        private void mnuOpérationMeilleursMorceaux_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }
        #endregion

        #region TODO 09 : Mettre à jour selon le contexte
        /// TODO 09 (10%) : Mettre à jour selon le contexte
        /// <summary>
        /// Rend disponible ou non les différents menus.
        /// Utiliser cette méthode aux bons endroits...
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        private void MettreAJourSelonContexte()
        {
            // À COMPLÉTER...
        }
        #endregion

        private void lblArtisteCourant_Click(object sender, EventArgs e)
        {

        }
    }
}
