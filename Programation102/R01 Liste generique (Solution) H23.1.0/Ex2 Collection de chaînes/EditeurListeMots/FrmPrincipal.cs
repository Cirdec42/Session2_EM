using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EditeurListeMots
{
    /// <summary>
    /// Concept : liste générique.
    /// Propriété : Count
    /// Méthode   : Add
    /// Ce exemple illustre comment stocker des mots dans une liste dynamique en utilisant un objet de type liste générique.
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        //--- Les constantes ---
        const String NOM_ETUDIANT = "(DÉMO)";

        //--- Les variables membres ---
        // m_colMots est une liste dynamique de string
        private List<String> m_colMots = new List<String>(); 

        private int m_indexMotCourant = -1; 

        //==============================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += NOM_ETUDIANT;
            //---
            //TODO 1: Ajouter les éléments suivants à la liste m_colMots
            //        "1- Auto","2- Avion","3- Camion","4- Train"
            m_colMots.Add("1- Auto");
            m_colMots.Add("2- Avion");
            m_colMots.Add("3- Camion");
            m_colMots.Add("4- Train");

            //TODO 2: Le premier mot de la liste est le mot courant, afficher-le à l'aide de la méthode AfficherMotCourant du TODO 3 
            m_indexMotCourant = 0;
            AfficherMotCourant();
        }

        //==============================================================================================
        //TODO 3: Afficher le mot courant et indiquer son index dans la zone numérique
        private void AfficherMotCourant()
        {
            txtMotCourant.Text = m_colMots[m_indexMotCourant];
            numIndexMotCourant.Value = m_indexMotCourant;
        }

        //==============================================================================================
        //TODO 4: Afficher le mot suivant
        //Remarque, le suivant du dernier est le premier.
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            m_indexMotCourant++;
            if (m_indexMotCourant >= m_colMots.Count)
            {
                m_indexMotCourant = 0;
            }
            AfficherMotCourant();
        }

        //==============================================================================================
        //TODO 4: Afficher le mot précédent
        //Remarque, le précédent du premier est le dernier
        private void btnPrécédent_Click(object sender, EventArgs e)
        {
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
    }
}
