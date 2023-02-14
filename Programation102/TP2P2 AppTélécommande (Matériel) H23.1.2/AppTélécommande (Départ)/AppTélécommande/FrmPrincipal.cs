using System;
using System.Windows.Forms;

namespace AppTélécommande
{
    /// <summary>
    /// NOUVELLES NOTIONS : 
    ///     - Définir une classe qui lance des exceptions
    ///     - Définir et utiliser un membre statique
    ///     - Utiliser un tableau d'objets
    ///     - Utiliser l'environnement de test de VisualStudio
    /// TODO 01 : Ajouter dans le projet un élément existant, soit la classe ModeImage disponible dans la partie 1
    /// TODO 02 : Dans le fichier correcteur.cs activer les tests pour la classe ModeImage et les exécuter 
    /// TODO 03 : Compléter la classe en vous basant sur "Diagramme Téléviseur.png"
    /// TODO 04 : Dans le fichier correcteur.cs activer les tests pour la classe Téléviseur et les exécuter 
    /// TODO 05 : Compléter séquentiellement le fonctionnement des tests de la classe Téléviseur jusqu'à ce qu'elle soit parfaite
    /// TODO 06 : Compléter le code de ce formulaire afin d'obtenir un fonctionnement identique à la version démo
    /// TODO 07 : Activer les tests du formulaire et s'assurer qu'ils fonctionnent parfaitement	
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        // Activer le code ci-dessous lorsque votre classe Téléviseur sera fonctionnelle
        // public Téléviseur LeTéléviseur{ get; private set; }
        public FrmPrincipal()
        {
            InitializeComponent();

            // On va instancier notre Téléviseur
            // LeTéléviseur = new Téléviseur();

            // On va initialiser la source
            // cboSourceCourante.SelectedIndex = LeTéléviseur.IndexSource;

            AfficherÉtatTéléviseur();
        }

        public void AfficherÉtatTéléviseur()
        {
            // À COMPLÉTER...
        }

        public void AfficherModeImageCourant()
        {
            // À COMPLÉTER...
        }

        public void BtnModeImageSuivant_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }

        public void BtnMémoriser_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }

        public void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CboSourceCourante_SelectedIndexChanged(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }

        public void BtnCanalPlus_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }

        public void BtnCanalMoins_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }

        public void BtnVolumePlus_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }

        public void BtnVolumeMoins_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }

        public void BtnSourdine_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
        }
    }
}
