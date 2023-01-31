using System;
using System.Windows.Forms;

namespace Thermostat
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        // TODO 01 : Dans le menu "Projet" de Visual Studio, choisir l'option "Ajouter un élément existant..."
        // Localiser le fichier "Thermostat.cs" se trouvant dans l'exercice #2 et l'ajouter au projet.

        // TODO 02 : En vous référant au diagramme "Ex4 Thermostat.png" ajouter le constructeur manquant.
        // Il s'agit du constructeur avec un paramètre, permettant de fixer la température initiale.

        /// =================================================================================
        /// <summary>
        /// Variables membres pour référer sur les 3 objets Thermostat
        /// </summary>
        /// ----------------------------------------------------------------------------------
        // TODO 03 : Déclarer les variables membres privées suivantes :
        // Thermostat m_objThermostatChambre;     // représente le thermostat de la chambre
        // Thermostat m_objThermostatCuisine;     // représente le thermostat de la cuisine
        // Thermostat m_objThermostatSalon;       // représente le thermostat du salon
        // Thermostat m_objThermostatCourant;     // représente le thermostat courant



        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 04 : Instancier les 3 thermostats différents.
            //         un dans la chambre à 25, un dans la cuisne à 20 et un dans le salon à 22
            //         au départ celui de la chambre est sélectionné.





            // TODO 05 : Fixer le m_objThermostatCourant courant à celui de la chambre


            // TODO 06 : Afficher la température du thermostat courant


        }

        //====================================================================================
        private void radChambre_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 07 : Fixer le m_objThermostatCourant courant à celui de la chambre
            // - Fixer le m_objThermostatCourant courant à celui de la chambre
            // - Afficher la température du thermostat courant
            // - Appeler la méthode ActualiserBoutonsSelonContexte




        }
        //====================================================================================
        private void radCuisine_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 08 : Fixer le m_objThermostatCourant courant à celui de la cuisine
            // - Fixer le m_objThermostatCourant courant à celui de la cuisine
            // - Afficher la température du thermostat courant
            // - Appeler la méthode ActualiserBoutonsSelonContexte



        }
        //====================================================================================
        private void radSalon_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 09 : Fixer le m_objThermostatCourant courant à celui du salon
            // - Fixer le m_objThermostatCourant courant à celui du salon
            // - Afficher la température du thermostat courant
            // - Appeler la méthode ActualiserBoutonsSelonContexte




        }

        //====================================================================================
        private void btnAugmenter_Click(object sender, System.EventArgs e)
        {
            // TODO 10 : Augmenter la température du thermostat courant
            //  - Augmenter la température du thermostat courant
            //  - Afficher la température du thermostat courant 
            //  - Appeler la méthode ActualiserBoutonsSelonContexte



        }

        //====================================================================================
        private void btnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 11 : Diminuer la température du thermostat courant
            //  - Diminuer la température du thermostat courant
            //  - Afficher la température du thermostat courant 
            //  - Appeler la méthode ActualiserBoutonsSelonContexte





        }

        //====================================================================================
        private void mnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 12 : Afficher la température minimale du Thermostat courant

        }

        //====================================================================================
        private void mnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 13 : Afficher la température maximale du Thermostat courant


        }

        //====================================================================================
        private void mnuAffichageTempCourante_Click(object sender, EventArgs e)
        {
            // TODO 14 : Afficher la température du Thermostat courant


        }

        //====================================================================================
        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 15 : Actualiser les boutons selon le contexte
            // - btnDiminuer est actif seulement si la température est supérieure à MIN_TEMPERATURE
            // - btnAugmenter est actif seulement si la température est inférieure à MAX_TEMPERATURE


        }

        //====================================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
       
    }
}