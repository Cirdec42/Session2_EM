using System;
using System.Windows.Forms;

namespace ExemFormulaire
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        //=====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            cboInstruments.SelectedIndex = 0;
        }
        //=====================================================================================
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //=====================================================================================
        private void mnuSpécialExemple1_Click(object sender, EventArgs e)
        {
            // TODO 01 : Instancier localement un nouveau formulaire de la classe FrmExemple1
            FrmExemple1 objFormulaire = new FrmExemple1();
            // TODO 02 : Afficher le nouveau formulaire
            objFormulaire.ShowDialog();
        }
        //=====================================================================================
        private void mnuSpécialExemple2_Click(object sender, EventArgs e)
        {
            string imageCheminComplet = "Images\\" + cboInstruments.Text + ".jpg";

            // TODO 03 : Instancier localement un nouveau formulaire de la classe FrmImage et l'afficher 
            FrmImage objFormulaire = new FrmImage(imageCheminComplet);

        }
    }
}
