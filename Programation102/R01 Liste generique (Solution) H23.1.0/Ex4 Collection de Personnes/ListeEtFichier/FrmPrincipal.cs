using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ListeEtFichier
{
    public partial class FrmPrincipal : Form
    {
        private const string APP_INFO = "(DÉMO)";
        private const string LISTE_DES_PERSONNES = "Fichiers\\ListeDesPersonnes.txt";

        //----------- variables membres ----------------------------------------------------------
        private List<Personne> m_colPersonnes = new List<Personne>();
        private bool m_listeEstModifiée = false;

        //=======================================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();

            Text += APP_INFO;

            ChargerPersonnes(LISTE_DES_PERSONNES);
        }
        //======================================================================================================
        /// <summary>
        /// TODO 1 :  Lire les informations dans le fichier et les charger en mémoire dans la liste générique.
        ///           S'assurer que le fichier existe sur le disque, sinon afficher un MessageBox.
        ///           Afficher la première personne de la liste.
        /// </summary>
        /// <param name="pNomDuFichier">nom du fichier à lire</param>
        /// ----------------------------------------------------------------------------------------------------
        private void ChargerPersonnes(string pNomDuFichier)
        {
            //--------------------------------------------------------------------------------
            m_colPersonnes.Clear();

            //---- lecture dans le fichier ----------------------------------------------------
            StreamReader objStreamReader = new StreamReader(pNomDuFichier);
            while (!objStreamReader.EndOfStream)
            {
                string uneLigneLue = objStreamReader.ReadLine();
                string[] tabInfos = uneLigneLue.Split(',');
                Personne unePersonne = new Personne(tabInfos[0], tabInfos[1]);
                m_colPersonnes.Add(unePersonne);
            }
            objStreamReader.Close();

            // --- affiche la première personne de la liste
            Personne personne = m_colPersonnes[0];
            mtxNAS.Text = personne.Nas;
            txtNom.Text = personne.Nom;

            //ou directement
            //mtxNAS.Text = m_colPersonnes[0].Nas;
            //txtNom.Text = m_colPersonnes[0].Nom;
        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// TODO 2 : Vérifie si une personne avec ce NAS existe dans la collection
        /// </summary>
        /// <param name="pNAS">Numéro assurance sociale recherché</param>
        /// <returns>Retourne true si le NAS existe dans la collection, sinon retourne false</returns>
        private bool NASExiste(string pNAS)
        {
            foreach (Personne personne in m_colPersonnes)
            {
                if (personne.Nas == pNAS)
                {
                    return true;
                }
            }

            return false;
        }
        ///-----------------------------------------------------------------------------------
        /// <summary>
        /// TODO 3 : Ajoute une personne à la fin de la liste générique.
        ///           On ne fait aucune validation sur le format du NAS mais on vérifie qu'il n'existe pas déjà dans la liste
		///           Voir la démo sur les messages à écrire.
		/// Si vous modifiez la liste, faites en sorte que la variable booléene m_listeEstModifiée l'indique
        /// </summary>
        /// ----------------------------------------------------------------------------------
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nas = mtxNAS.Text;
            string nom = txtNom.Text;

            
            
            Personne unePersonne = new Personne(nas, nom);

            if (NASExiste(nas))
            {
                MessageBox.Show("Impossible d'ajouter cette personne car ce NAS existe déjà dans la liste ",
                                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m_colPersonnes.Add(unePersonne);

                m_listeEstModifiée = true;

                MessageBox.Show(m_colPersonnes[m_colPersonnes.Count - 1].Nom + " a été ajouté.", "Liste générique");
                txtNom.Clear();
                mtxNAS.Clear();
            }
        }
        /// ----------------------------------------------------------------------------------
        /// <summary>
        /// TODO 4 : Recherche dans la liste générique, l'index de la personne dont le nas est spécifié.
        /// </summary>
        /// <param name="pNasRecherché">Nas à rechercher dans la liste</param>
        /// <returns>position de la personne, -1 si non trouvée</returns>
        /// ---------------------------------------------------------------------------------
        private int IndexPersonneSelonNas(string pNasRecherché)
        {
            for (int index = 0; index < m_colPersonnes.Count; index++)
            {
                if (m_colPersonnes[index].Nas == pNasRecherché)
                {
                    return index;  
                }
            }
            return -1;

        }
        ///-----------------------------------------------------------------------------------
        /// <summary>
        /// TODO 5 : Supprimer la personne affichée de la liste générique.
		/// Si vous modifiez la liste, faites en sorte que la variable booléene m_listeEstModifiée l'indique
        /// </summary>
        ///-----------------------------------------------------------------------------------
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string nasRecherché = mtxNAS.Text;

            int index = IndexPersonneSelonNas(nasRecherché);

            if (index != -1)
            {  
                MessageBox.Show(m_colPersonnes[index].Nom + " a été supprimé.", "Liste générique");
                m_colPersonnes.RemoveAt(index);
               
                m_listeEstModifiée = true;
                
                txtNom.Clear();
                mtxNAS.Clear();
            }
            else
                MessageBox.Show("Impossible de trouver le NAS : " + nasRecherché,
                                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        ///--------------------------------------------------------------------------------------
        /// <summary>
        /// TODO 6 : Recherche et affiche la personne dont le NAS (numéro d'assurance sociale) est indiqué.
        /// </summary>
        ///--------------------------------------------------------------------------------------
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string nasRecherché = mtxNAS.Text;

            int index = IndexPersonneSelonNas(nasRecherché);

            if (index != -1)
            {
                txtNom.Text = m_colPersonnes[index].Nom;
            }
            else
            {
                txtNom.Clear();
                MessageBox.Show("Impossible de trouver le NAS : " + nasRecherché,
                                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
        //=================================================================================================
        /// <summary>
        /// TODO 7 :  Sauvegarde la liste de personnes dans le fichier Texte.
        ///            On sépare les données d'une personne par une virgule.
        ///            Voici un exemple: 205456789,Hector Larivière
        /// </summary>
        /// -----------------------------------------------------------------------------------------------
        private void SauvegarderListe()
        {
            StreamWriter objStreamWriter = new StreamWriter(LISTE_DES_PERSONNES);
            foreach (Personne objPersonne in m_colPersonnes)
            {
                objStreamWriter.Write(objPersonne.Nas + ",");
                objStreamWriter.WriteLine(objPersonne.Nom);
            }
            objStreamWriter.Close();
        }
        //================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //==============================================================================================================
       /// <summary>
       /// TODO 8 : Au moment de quitter, s'il y a eu des modifications à la liste, on la sauvegarde dans un fichier.
       /// </summary>
       /// ------------------------------------------------------------------------------------------------------------
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_listeEstModifiée)
            {
                SauvegarderListe();
            }
        }
        //==============================================================================================================
        private void btnEffacerAffichage_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            mtxNAS.Clear();
        }
        //==============================================================================================================
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
