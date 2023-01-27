using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace EditeurListeMots
{
    /// <summary>
    /// Cet exemple est la suite de l'exemple précédent dans lequel on mémorise une liste de mots dans une liste dynamique.
    /// On ajoute les fonctionnalités suivantes :
    ///     - Ajout d'un mot
    ///     - Suppression d'un mot
    ///     - Vider la liste de mots
    ///     - Charger une liste de mots
    ///     - Enregistrer la liste des mots
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        const String APP_INFO = "(DÉMO)";
        const String NOM_FICHIER_DE_MOTS = "ListeDeMots.txt";

        private List<String> m_colMots = new List<String>(); // une liste dynamique de String
        private int m_indexMotCourant = -1;

        //==============================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
        }


        #region Code pour ajouter ou supprimer un mot
        //==============================================================================================
        //TODO 1: Ajouter le mot en minuscule dans la liste dynamique.
        //Contraintes: Le mot est unique. Le mot est non vide.
        //Vous utiliserez des points d'arrêt pour vérifier le contenu de m_ColMots
        private void btnAjouterMot_Click(object sender, EventArgs e)
        {
            string nouveauMot = txtNouveauMot.Text.ToLower();
            if (nouveauMot.Length > 0 && !m_colMots.Contains(nouveauMot)) // Pour ne pas ajouter le même mot plusieurs fois
            {
                m_colMots.Add(nouveauMot);
                m_indexMotCourant = m_colMots.Count - 1;
                AfficherMotCourant();
                txtNouveauMot.Clear();
                txtNouveauMot.Select();
            }
        }
        //==============================================================================================
        //TODO 2: Supprimer le mot de la liste et affiche le suivant ou le dernier
        //          Attention à la suppression du dernier élément
        //Vous utiliserez des points d'arrêt pour vérifier le contenu de m_ColMots
        private void btnSupprimerMot_Click(object sender, EventArgs e)
        {
            m_colMots.RemoveAt(m_indexMotCourant);
            if (m_indexMotCourant == m_colMots.Count)
            {
                m_indexMotCourant = m_colMots.Count - 1;
            }

            AfficherMotCourant();

        }

        //==============================================================================================
        private void numIndexMotCourant_ValueChanged(object sender, EventArgs e)
        {
            btnSupprimerMot.Enabled = numIndexMotCourant.Value != -1;
        }
        #endregion

        #region Code pour Charger,Vider et Enregistrer une liste de mots
        //==============================================================================================
        //TODO 3: Vider la liste de mots en mémoire et ajuster l'affichage
        private void mnuFichierViderListeDeMots_Click(object sender, EventArgs e)
        {
            m_colMots.Clear();
            m_indexMotCourant = -1;
            AfficherMotCourant();
        }

        //==============================================================================================
        //TODO 4: Charger la liste dynamique m_colMots à partir du fichier  NOM_FICHIER_DE_MOTS
        //Vous utiliserez des points d'arrêt pour vérifier le contenu de m_ColMots
        private void mnuFichierChargerListeDeMots_Click(object sender, EventArgs e)
        {
            m_colMots.Clear();

            StreamReader objFichier = new StreamReader(NOM_FICHIER_DE_MOTS);
            while (!objFichier.EndOfStream)
            {
                string motLu = objFichier.ReadLine();
                m_colMots.Add(motLu);
            }
            objFichier.Close();
            m_indexMotCourant = 0; 
            if (m_colMots.Count == 0)
            {
                m_indexMotCourant = -1;
            }
           
            AfficherMotCourant();
            
        }

        //==============================================================================================
        //TODO 5: Enregistrer la liste dynamique dans le fichier  NOM_FICHIER_DE_MOTS
        private void mnuFichierEnregistrerListeDeMots_Click(object sender, EventArgs e)
        {
            StreamWriter objFichier = new StreamWriter(NOM_FICHIER_DE_MOTS);

            foreach (string mot in m_colMots)
            {
                objFichier.WriteLine(mot);
            }

            objFichier.Close();
        }
        #endregion

        #region Affichage et boutons Suivant Précédent
        //==============================================================================================
        //TODO 6: Afficher le mot courant et indiquer son index dans la zone numérique
        //Vérifiez que les TODO1 jusqu'à TODO4 appellent bien la méthode AfficherMotCourant et que le tout fonctionne correctement

        private void AfficherMotCourant()
        {
           
            if (m_indexMotCourant >= 0 && m_indexMotCourant < m_colMots.Count)
            {
                txtMotCourant.Text = m_colMots[m_indexMotCourant];
            }
            else
            {
                 
                txtMotCourant.Clear();
            }

            numIndexMotCourant.Value = m_indexMotCourant;
        }

        //==============================================================================================
        //TODO 7: Afficher le mot suivant
        //Remarque, le suivant du dernier est le premier.
        //Attention à la liste vide et n'oubliez pas de rafraichir l'affichage
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (m_colMots.Count == 0) //Condition de garde
            {
                return;
            }

            m_indexMotCourant++;
            if (m_indexMotCourant >= m_colMots.Count)
            {
                m_indexMotCourant = 0;
            }
            AfficherMotCourant();
        }

        //==============================================================================================
        //TODO 8: Afficher le mot précédent
        //Remarque, le précédent du premier est le dernier
        //Attention à la liste vide et n'oubliez pas de rafraichir l'affichage
        private void btnPrécédent_Click(object sender, EventArgs e)
        {
            if (m_colMots.Count == 0)   //Condition de garde
            {
                return;
            }

            m_indexMotCourant--;
            if (m_indexMotCourant < 0)
            {
                m_indexMotCourant = m_colMots.Count - 1;
            }
            AfficherMotCourant();
        }

        //==============================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

       
    }
}
