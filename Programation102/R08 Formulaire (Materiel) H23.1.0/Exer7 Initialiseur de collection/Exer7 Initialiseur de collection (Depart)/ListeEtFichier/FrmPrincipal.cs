using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace ListeEtFichier
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        //----------- variables membres ----------------------------------------------------------
        private List<Personne> m_colPersonnes;

        //=======================================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 01 : Utiliser un initialiseur de collection ainsi qu'un initialiseur d'objet afin d'ajouter 3 personnes
            // dans la collection des personnes. Voici les informations des 3 personnes :
            // Personne #1 : Robert Lapointe, 276187261
            // Personne #2 : Louise Tremblay, 527189354
            // Personne #3 : Denis Verreau,782356273
            m_colPersonnes = new List<Personne>()
            {
                new Personne(){ Nom = "Robert Lapointe", Nas = "276187261"},
                new Personne(){ Nom = "Louise Tremblay", Nas = "527189354"},
                new Personne(){ Nom = "Denis Verreau", Nas = "782356273"}
            };



            // TODO 02 : Ajouter une boucle afin d'afficher les informations des personnes dans lstPersonnes
            foreach (Personne personne in m_colPersonnes)
            {
                lstPersonnes.Items.Add(personne.Nom + " : " +personne.Nas );
            }


        }
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
