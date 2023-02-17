using System.Windows.Forms;

namespace ApplicationMontre
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        public Montre m_objMontre;

        //==================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 01 : Instancier un objet de la classe Montre et utiliser un initialiseur d'objet
            // pour fixer les valeurs des propriétés Heures, Minutes et Secondes comme suit : 12:35:57
            Montre m_objMontre = new Montre() { Heures=12,Minutes=35,Secondes=57};

            // TODO 02 : Afficher le temps courant de la montre à l'aide de la méthode ObtenirTempsCourant()
            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();
        }

        //============================================================================
        // Evénement associé au tick de l'horloge. À chaque tick, on avance d'une seconde.
        private void btnAvancer_Click(object sender, System.EventArgs e)
        {
            m_objMontre.AvancerUneSeconde();
            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();
        }

        //============================================================================
        private void btnDemarrerArreterHorloge_Click(object sender, System.EventArgs e)
        {
            tmrHorloge.Enabled = !tmrHorloge.Enabled;
        }

        //============================================================================
        private void btnInitialiserMontre_Click(object sender, System.EventArgs e)
        {
            m_objMontre.Heures = 59;
            m_objMontre.Minutes = 59;
            m_objMontre.Secondes = 59;

            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();
        }
        //============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void txtAffichageMontre_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
