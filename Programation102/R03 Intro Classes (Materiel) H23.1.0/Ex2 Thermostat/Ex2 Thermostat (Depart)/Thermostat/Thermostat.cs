using System;

namespace Thermostat
{
    /// ------------------------------------------------------------------------------------
    /// <summary>
    /// Représente un thermostat électronique contrôlant la température d'une 
    /// plinthe de chauffage,ce qui correspond généralement à une pièce d'un établissement.
    /// </summary>
    /// ------------------------------------------------------------------------------------
    public class Thermostat
    {
        #region Constantes
        /// ================================================================================
        /// <summary>
        /// Température minimale autorisée par un Thermostat
        /// </summary>
        public const double MIN_TEMPERATURE = 5.0;
       
        /// ================================================================================
        /// <summary>
        /// Température maximale autorisée par un Thermostat
        /// </summary>
        public const double MAX_TEMPERATURE = 35.0;
       
        /// ================================================================================
        /// <summary>
        /// Température initiale d'un Thermostat
        /// </summary>
        private const double TEMPERATURE_DÉFAUT = 20.0;

        #endregion

        // TODO 01 : En vous référant au diagramme "Ex2 Thermostat.png" compléter cette classe


    }
}
