using System;

namespace Thermostat
{
    /// ------------------------------------------------------------------------------------
    /// <summary>
    /// Repr�sente un thermostat �lectronique contr�lant la temp�rature d'une 
    /// plinthe de chauffage,ce qui correspond g�n�ralement � une pi�ce d'un �tablissement.
    /// </summary>
    /// ------------------------------------------------------------------------------------
    public class Thermostat
    {
        #region Constantes
        /// ================================================================================
        /// <summary>
        /// Temp�rature minimale autoris�e par un Thermostat
        /// </summary>
        public const double MIN_TEMPERATURE = 5.0;
       
        /// ================================================================================
        /// <summary>
        /// Temp�rature maximale autoris�e par un Thermostat
        /// </summary>
        public const double MAX_TEMPERATURE = 35.0;
       
        /// ================================================================================
        /// <summary>
        /// Temp�rature initiale d'un Thermostat
        /// </summary>
        private const double TEMPERATURE_D�FAUT = 20.0;

        #endregion

        // TODO 01 : En vous r�f�rant au diagramme "Ex2 Thermostat.png" compl�ter cette classe


    }
}
