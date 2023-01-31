using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationParcometre
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        // TODO 01 : Dans le menu "Projet" de Visual Studio, choisir l'option "Ajouter une classe..."
        // et nommer le nouveau fichier "Parcometre.cs"

        // TODO 02 : En vous référant au diagramme "Ex5 Parcometre.png" compléter le code de la classe Parcometre
        // - Rappel : Les constructeurs doivent initialiser tous les champs.
        // - Ajouter les constantes suivantes :        
        //          public const int COUT_PAR_MINUTE = 5; // 5 cents la minute
        //          public const int MONTANT_MINIMUM = 25; // 25 cents

        // TODO 03 : Compléter le reste de l'application pour qu'elle fonctionne comme la démo.


        //====================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;
            //----------------------------------------------------------------

            cboMontant.SelectedIndex = 0;
        }
        //============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //============================================================================
        private void tmrTemps_Tick(object sender, EventArgs e)
        {

        }
        // ======================================================================
        private void btnAjouterMontant_Click(object sender, EventArgs e)
        {


            MettreAJourSelonContexte();
            tmrTemps.Start();
        }
        // ======================================================================
        /// <summary>
        /// Mettre à jour l'interface graphique de l'application.
        /// txtTempsRestant, txtMontantTotal, panÉtat.BackColor et arrête le timer si nécessaire.
        /// </summary>
        private void MettreAJourSelonContexte()
        {



        }

        #region NE PAS MODIFIER (Pour gérer le menu temps)
        // ======================================================================
        private void mnuTemps_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemCourant = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in mnuTemps.DropDownItems)
                item.Checked = false;
            itemCourant.Checked = true;
            tmrTemps.Interval = int.Parse(itemCourant.Tag.ToString());

        }
        #endregion
    }
}