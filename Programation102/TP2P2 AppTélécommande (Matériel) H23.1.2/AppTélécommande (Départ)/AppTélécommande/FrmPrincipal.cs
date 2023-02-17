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
         public Téléviseur LeTéléviseur{ get; private set; }
        public FrmPrincipal()
        {
            InitializeComponent();
             //On va instancier notre Téléviseur
            LeTéléviseur = new Téléviseur();
            // On va initialiser la source
            cboSourceCourante.SelectedIndex = LeTéléviseur.IndexSource;

            AfficherÉtatTéléviseur();
        }

        public void AfficherÉtatTéléviseur()
        {
            // À COMPLÉTER...
            lblNomModeImage.Text = LeTéléviseur.ModeImageCourant.Nom;
            vsiContraste.Value = LeTéléviseur.ModeImageCourant.Contraste;
            vsiCouleur.Value = LeTéléviseur.ModeImageCourant.Couleur;
            vsiLuminosité.Value = LeTéléviseur.ModeImageCourant.Luminosité;
            vsiNetteté.Value = LeTéléviseur.ModeImageCourant.Netteté;
            vsiTeinte.Value = LeTéléviseur.ModeImageCourant.Teinte;
            if (LeTéléviseur.Sourdine==false)
            {
                lblÉtatSourdine.Text="OFF";
            }
            else
            {
                lblÉtatSourdine.Text = "ON";
            };
            vsiCanal.Value = LeTéléviseur.Canal;
            vsiVolume.Value = LeTéléviseur.Volume;
            cboSourceCourante.SelectedIndex = LeTéléviseur.IndexSource;

        }

        public void AfficherModeImageCourant()
        {
            // À COMPLÉTER...
        }

        public void BtnModeImageSuivant_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            LeTéléviseur.IndexModeImage++;
            if (LeTéléviseur.IndexModeImage==Téléviseur.NB_MODE_IMAGE)
            {
                LeTéléviseur.IndexModeImage = 0;
            }
            AfficherModeImageCourant();
            AfficherÉtatTéléviseur();
        }

        public void BtnMémoriser_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            LeTéléviseur.ModeImageCourant.Contraste = vsiContraste.Value;
            LeTéléviseur.ModeImageCourant.Couleur = vsiCouleur.Value;
            LeTéléviseur.ModeImageCourant.Luminosité = vsiLuminosité.Value;
            LeTéléviseur.ModeImageCourant.Netteté = vsiNetteté.Value;
            LeTéléviseur.ModeImageCourant.Teinte = vsiTeinte.Value;
        }

        public void MnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CboSourceCourante_SelectedIndexChanged(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            LeTéléviseur.IndexSource = cboSourceCourante.SelectedIndex;
            cboSourceCourante.Text = LeTéléviseur.Source;
            AfficherÉtatTéléviseur();
        }

        public void BtnCanalPlus_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            LeTéléviseur.AugmenterCanal();
            AfficherÉtatTéléviseur();

        }

        public void BtnCanalMoins_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            LeTéléviseur.DiminuerCanal();
            AfficherÉtatTéléviseur();
        }

        public void BtnVolumePlus_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            LeTéléviseur.AugmenterVolume();
            LeTéléviseur.Sourdine = false;
            AfficherÉtatTéléviseur();
        }

        public void BtnVolumeMoins_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            LeTéléviseur.DiminuerVolume();
            AfficherÉtatTéléviseur();
        }

        public void BtnSourdine_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            if (LeTéléviseur.Sourdine==false)
            {
                LeTéléviseur.Sourdine = true;
            }
            else
            {
                LeTéléviseur.Sourdine=false;
            };
            AfficherÉtatTéléviseur();
        }
    }
}
