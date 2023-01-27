using System;
using System.Windows.Forms;
using System.IO;
using VisualArrays;

namespace AppVentesTrimestre
{
    /// <summary>
    /// Manipulation de tableaux à 2D
    ///              d'un fichier en lecture
    ///              d'un fichier en écriture
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(DÉMO)";

        // tableau pré-initialisé à 1D des mois
        private string[] m_tabMois = { "Janvier", "Février", "Mars" };

        // tableau pré-initialisé à 1D des villes
        private string[] m_tabVilles = { "Boucherville", "Laval", "Longueuil", "Montréal" };


        //---------------------------------------------------------------------------------
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            PréparerLesEntêtesDesGrilles();
        }

        #region Préparation des grilles
        //---------------------------------------------------------------------------------
        /// <summary>
        /// Place, par programmation, les en-têtes des rangées et des colonnes
        /// vdaVentes.RowHeaderArray[index]
        /// vdaVentes.ColumnHeaderArray[index]
        /// </summary>
        private void PréparerLesEntêtesDesGrilles()
        {
            for (int index = 0; index < vdaVentes.RowCount; index++)
            {
                vdaVentes.RowHeaderArray[index] = m_tabVilles[index];
            }

            for (int index = 0; index < vdaVentes.ColumnCount; index++)
            {
                vdaVentes.ColumnHeaderArray[index] = m_tabMois[index];
            }

            vdaTotauxParMois.RowHeaderArray[0] = "Totaux / Mois";
            vdaTotauxVilles.ColumnHeaderArray[0] = "Totaux / Villes";
        }
        #endregion

        #region Options du menu Fichier
        //---------------------------------------------------------------------------------
        /// <summary>
        /// TODO : Vide le contenu de la grille des ventes
        /// </summary>		
        private void mnuFichierNouveau_Click(object sender, EventArgs e)
        {
            vdaVentes.Clear();
        }

        //====================================================================================
        /// <summary>
        /// TODO : Engeristre dans le fichier "Données.txt" le contenu de vdaVentes
        /// </summary>
        private void mnuFichierEnregistrer_Click(object sender, EventArgs e)
        {
            StreamWriter objFichier = new StreamWriter("Fichiers/Données.txt");

            for (int row = 0; row < vdaVentes.RowCount; row++)
            {
                for (int col = 0; col < vdaVentes.ColumnCount - 1; col++)
                {
                    objFichier.Write(vdaVentes[row, col] + ",");
                }
                objFichier.WriteLine(vdaVentes[row, vdaVentes.ColumnCount - 1]);
            }

            objFichier.Close();
        }

        /// <summary>
        /// TODO : Charge dans vdaVentes le contenu du fichier "Données.txt"
        /// </summary>
        private void mnuFichierCharger_Click(object sender, EventArgs e)
        {
            StreamReader objFichier = new StreamReader("Fichiers/Données.txt");

            int row = 0;
            while (!objFichier.EndOfStream)
            {
                string ligne = objFichier.ReadLine();
                string[] tabNombres = ligne.Split(',');

                for (int col = 0; col < tabNombres.Length; col++)
                {
                    vdaVentes[row, col] = decimal.Parse(tabNombres[col]);
                }
                row++;
            }

            objFichier.Close();
        }
        //---------------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Méthodes pour calculer les sommes
        //---------------------------------------------------------------------------------
        /// <summary>
        /// TODO : Calcule la somme d'une colonne de vdaVentes
        /// </summary>
        /// <param name="pColonne">index de la colonne à traiter</param>
        /// <returns>Retourne la somme de la colonne</returns>
        private decimal SommeDeLaColonne(int pColonne)
        {
            decimal accVentesDuMois = 0;
            for (int rangée = 0; rangée < vdaVentes.RowCount; rangée++)
            {
                accVentesDuMois += vdaVentes[rangée, pColonne];
            }
            return accVentesDuMois;
          
        }
        //---------------------------------------------------------------------------------
        /// <summary>
        /// TODO : Calcule la somme d'une rangée de vdaVentes
        /// </summary>
        /// <param name="pRangée">index de la rangée à traiter</param>
        /// <returns>Retourne la somme de la rangée</returns>
        private decimal SommeDeLaRangée(int pRangée)
        {
            decimal accVentesVille = 0;
            for (int colonne = 0; colonne < vdaVentes.ColumnCount; colonne++)
            {
                accVentesVille += vdaVentes[pRangée, colonne];
            }
            return accVentesVille;
          
        }
        //---------------------------------------------------------------------------------
        /// <summary>
        /// TOTO : Calcule le grand total de toutes les ventes dans vdaVentes
        /// </summary>
        /// <returns>Retourne la somme de toutes les cases de vdaVentes </returns>
        private decimal GrandTotal()
        {
            decimal grandTotal = 0;
            //Solution 1 en utilisant les ventes dans vdaVentes
            for (int rangée = 0; rangée < vdaVentes.RowCount; rangée++)
            {
                for (int colonne = 0; colonne < vdaVentes.ColumnCount; colonne++)
                {
                    grandTotal += vdaVentes[rangée, colonne];
                }
            }
            return grandTotal;
          
        }
        #endregion

        #region Événement ValueChanged
        //---------------------------------------------------------------------------------
        // TODO : Mise à jour des totaux.
        // Deux origines possibles du ValueChanged:
        // Premier cas:  un clic (par l'utilisateur) dans une cellule pour modifier le contenu
        //               dans ce cas le paramètre e.Address aura une valeur autre que Address.Empty
        //               on mettra à jour seulement les totaux affectés par cette cellule.
        // Deuxième cas: un changement de valeur  par programmation par le programmeur
        private void vdaVentes_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (e.Address != Address.Empty) //Valeur changée par un clic sur la cellule
            {
                vdaTotauxParMois[e.Column] = SommeDeLaColonne(e.Column);
                vdaTotauxVilles[e.Row] = SommeDeLaRangée(e.Row);
            }
            else // Valeur changée par programmation,
                // dans ce cas il faut tout mettre à jour
            {
                for (int rangée = 0; rangée < vdaVentes.RowCount; rangée++)
                {
                    vdaTotauxVilles[rangée] = SommeDeLaRangée(rangée);
                }
                for (int colonne = 0; colonne < vdaVentes.ColumnCount; colonne++)
                {
                    vdaTotauxParMois[colonne] = SommeDeLaColonne(colonne);
                }
            }

            vsdGrandTotal.Value = GrandTotal();
        }
        #endregion

    }
}
