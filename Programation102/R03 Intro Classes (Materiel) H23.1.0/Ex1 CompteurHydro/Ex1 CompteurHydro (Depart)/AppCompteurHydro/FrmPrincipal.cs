using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppCompteurHydro
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        // TODO 02 : Déclarer une variable membre privée nommée m_objCompteurHydro de type CompteurHydro

        private CompteurHydro m_objCompteurHydro;

        //==================================================================================================
        // Constructeur du formulaire
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 03 : Instancier un objet CompteurHydro et l'affecter dans m_objCompteurHydro
            m_objCompteurHydro = new CompteurHydro();
        }
        //==================================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //==================================================================================================
        private void mnuOpérationConsommer100Kw_Click(object sender, EventArgs e)
        {
            // TODO 04 : Appeler la méthode Consommer du CompteurHydro avec 100Kw du CompteurHydro 
            m_objCompteurHydro.Consommer(100);

            // TODO 05 : Afficher la consommation actuelle dans le contrôle lblConsommation
            // Pour respecter l'affichage de la démo utliser ToString("000000")
            lblConsommation.Text = m_objCompteurHydro.ConsomationActuelle.ToString("000000");
        }
        //==================================================================================================
        private void mnuOpérationConsommer5250Kw_Click(object sender, EventArgs e)
        {
            // TODO 06 : Appeler la méthode Consommer du CompteurHydro avec 5250Kw du CompteurHydro 
            m_objCompteurHydro.Consommer(5250);
            // TODO 07 : Afficher la consommation actuelle dans le contrôle lblConsommation
            // Pour respecter l'affichage de la démo utliser ToString("000000")
            lblConsommation.Text = m_objCompteurHydro.ConsomationActuelle.ToString("000000");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
