using System;
using System.Windows.Forms;

namespace Thermostat
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";
        /// ==================================================================================
        /// <summary>
        /// Variable membre permettant de référer sur un objet de la classe Thermostat
        /// </summary>
        /// ----------------------------------------------------------------------------------
       // TODO 02 : Déclarer une variable membre privée nommée m_objThermostat de type Thermostat

        
        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 03 : Instancier un objet Thermostat et l'affecter dans m_objThermostat

            // TODO 04 : Afficher la température courante dans lblTemperature

            // TODO 05 : Appeler la méthode ActualiserBoutonsSelonContexte

        }

        //====================================================================================
        private void btnAugmenter_Click(object sender, System.EventArgs e)
        {
            // TODO 06 : Augmenter la température du thermostat
            //  - Augmenter la température du thermostat
            //  - Afficher la température courante
            //  - Appeler la méthode ActualiserBoutonsSelonContexte




        }

        //====================================================================================
        private void btnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 07 : Diminuer la température du thermostat
            //  - Diminuer la température du thermostat
            //  - Afficher la température courante
            //  - Appeler la méthode ActualiserBoutonsSelonContexte




        }

        //====================================================================================
        private void mnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 08 : Afficher la température minimale d'un Thermostat


        }

        //====================================================================================
        private void mnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 09 : Afficher la température maximale d'un Thermostat


        }

        //====================================================================================
        private void mnuAffichageTempCourante_Click(object sender, EventArgs e)
        {
            // TODO 10 : Afficher la température courante du Thermostat


        }

        //====================================================================================

        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 11 : Actualiser les boutons selon le contexte
            // - btnDiminuer est actif seulement si la température courante est supérieure à MIN_TEMPERATURE
            // - btnAugmenter est actif seulement si la température courante est inférieure à MAX_TEMPERATURE



        }

        //====================================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}