using System;
using System.Windows.Forms;

namespace ApplicationDistributrice
{
    ///==============================================================================
    /// <summary>
    /// Simule une machine distributrice qui contient différents breuvages.
    /// 
    /// TODO 01 : Ajouter une nouvelle classe nommée Distributrice (voir diagramme dans le matériel)
    /// TODO 02 : Ajouter dans le fichier Distributrice.cs un nouveau type par énumération (voir diagramme dans le matériel)
    /// TODO 03 : Ajouter dans la classe distributrice une constante MAX_QUANTITÉ = 5
    /// TODO 04 : Dans le constructeur sans paramètre initialiser les quantités à MAX_QUANTITÉ
    /// TODO 05 : Compléter le formulaire pour faire fonctionner l'application
    /// 
    /// </summary>
    /// =============================================================================
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";
        //=====================================================
        //  CHAMP:  Variable  membre de la classe FrmPrincipal
        //-----------------------------------------------------
        //private Distributrice m_objMachine;

        //=====================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            //-----------------------
            //m_objMachine = new Distributrice();
            AfficherInfosMachine();
        }
        //==============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        /// =================================================================================
        /// <summary>
        /// Affiche les informations dans la section "Infos sur la machine".
        /// </summary>
        /// =================================================================================
        private void AfficherInfosMachine()
        {

        }
        //==============================================================================
        /// <summary>
        ///   Activer ou désactiver les boutons correspondant aux différents breuvages.
        /// </summary>
        /// ---------------------------------------------------------------------------
        private void MettreAJourBoutons()
        {

        }
        //=====================================================================================
        /// <summary>
        /// Ejecter le breuvage demandé et mettre à jours les boutons
        /// </summary>
        /// <param name="pBreuvage">breuvage demandé par le client</param>
        /// -----------------------------------------------------------------------------------
        private void ObtenirUnBreuvage(/*SorteBreuvage pBreuvage*/)
        {


        }
        //=====================================================================================
        private void btnObtenirUnCoke_Click(object sender, System.EventArgs e)
        {

        }
        //=====================================================================================
        private void btnObtenirUn7Up_Click(object sender, System.EventArgs e)
        {

        }
        //=====================================================================================
        private void btnObtenirUnJusDePommes_Click(object sender, System.EventArgs e)
        {

        }
        //=====================================================================================
        private void btnObtenirUnTheGlace_Click(object sender, System.EventArgs e)
        {

        }

        //====================================================================================
        private void btnRecharger_Click(object sender, EventArgs e)
        {

        }
    }
}