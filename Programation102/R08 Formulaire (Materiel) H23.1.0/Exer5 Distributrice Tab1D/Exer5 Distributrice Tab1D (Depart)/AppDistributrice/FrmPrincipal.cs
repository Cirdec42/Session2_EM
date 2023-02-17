using System;
using System.Windows.Forms;

namespace ApplicationDistributrice
{
    // TODO 01 : Vous devez utiliser la classe Distributrice de l'exercice précédent puis la modifier 
    // afin d'utiliser un tableau à 1D en remplacement des 4 variables membres utilisées
    // pour les quantités. Consulter l'image du diagramme disponible avec le matériel. 

    ///==============================================================================
    /// <summary>
    /// Simule une machine distributrice qui contient différentes breuvages.
    /// </summary>
    /// =============================================================================
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";
        //=====================================================
        //  CHAMP:  Variable  membre de la classe FrmPrincipal
        //-----------------------------------------------------
        private Distributrice m_objMachine;

        //=====================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            //-----------------------
            m_objMachine = new Distributrice();
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
            txtNbCokes.Text = m_objMachine.Quantite(SorteBreuvage.Coke).ToString();
            txtNb7Up.Text = m_objMachine.Quantite(SorteBreuvage.SevenUp).ToString();
            txtNbJusDePommes.Text = m_objMachine.Quantite(SorteBreuvage.JusDePommes).ToString();
            txtNbTheGlace.Text = m_objMachine.Quantite(SorteBreuvage.TheGlace).ToString();

            int totalBreuvage = m_objMachine.Quantite(SorteBreuvage.Coke) + m_objMachine.Quantite(SorteBreuvage.SevenUp) +
                                m_objMachine.Quantite(SorteBreuvage.JusDePommes) + m_objMachine.Quantite(SorteBreuvage.TheGlace);
            txtEtat.Text = "Breuvages disponibles :        " + totalBreuvage;
        }
        //==============================================================================
        /// <summary>
        ///   Activer ou désactiver les boutons correspondant aux différents breuvages.
        /// </summary>
        /// ---------------------------------------------------------------------------
        private void MettreAJourBoutons()
        {
            btnObtenirUnCoke.Enabled = m_objMachine.EstDisponible(SorteBreuvage.Coke);
            btnObtenirUn7Up.Enabled = m_objMachine.EstDisponible(SorteBreuvage.SevenUp);
            btnObtenirUnJusDePommes.Enabled = m_objMachine.EstDisponible(SorteBreuvage.JusDePommes);
            btnObtenirUnTheGlace.Enabled = m_objMachine.EstDisponible(SorteBreuvage.TheGlace);
        }
        //=====================================================================================
        /// <summary>
        /// Ejecter le breuvage demandé et mettre à jours les boutons
        /// </summary>
        /// <param name="pBreuvage">breuvage demandé par le client</param>
        /// -----------------------------------------------------------------------------------
        private void ObtenirUnBreuvage(SorteBreuvage pBreuvage)
        {
            m_objMachine.Ejecter(pBreuvage);
            AfficherInfosMachine();
            MettreAJourBoutons();
        }
        //=====================================================================================
        private void btnObtenirUnCoke_Click(object sender, System.EventArgs e)
        {
            ObtenirUnBreuvage(SorteBreuvage.Coke);
        }
        //=====================================================================================
        private void btnObtenirUn7Up_Click(object sender, System.EventArgs e)
        {
            ObtenirUnBreuvage(SorteBreuvage.SevenUp);
        }
        //=====================================================================================
        private void btnObtenirUnJusDePommes_Click(object sender, System.EventArgs e)
        {
            ObtenirUnBreuvage(SorteBreuvage.JusDePommes);
        }
        //=====================================================================================
        private void btnObtenirUnTheGlace_Click(object sender, System.EventArgs e)
        {
            ObtenirUnBreuvage(SorteBreuvage.TheGlace);
        }

        //====================================================================================
        private void btnRecharger_Click(object sender, EventArgs e)
        {
            m_objMachine.Recharger();
            AfficherInfosMachine();
            MettreAJourBoutons();
        }
    }
}