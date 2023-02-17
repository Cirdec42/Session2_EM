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




            // TODO 02 : Ajouter une boucle afin d'afficher les informations des personnes dans lstPersonnes



        }
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
