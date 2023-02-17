using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListeEtFichier
{
    /// -----------------------------------------------------------------------------------------------------
    /// <summary>
    ///	 Représente une personne : son numéro d'assurance sociale et son nom.
    /// </summary>
    /// -----------------------------------------------------------------------------------------------------
    public class Personne
    {
        //------------------------------------------------------
        private string m_nas;

        /// ----------------------------------------------------
        /// <summary>
        /// Obtient et définit le numéro sociale d'une personne.
        /// </summary>
        /// ----------------------------------------------------
        public string Nas
        {
            get { return m_nas; }
            set { m_nas = value; }
        }

        //------------------------------------------------------
        private string m_nom;
        /// ----------------------------------------------------
        /// <summary>
        /// Obtient et définit le nom d'une personne.
        /// </summary>
        /// ----------------------------------------------------
        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }

        //---------------------------------------------------------------
        /// <summary>
        /// Initialise un objet Personne
        /// </summary>
        /// -------------------------------------------------------------
        public Personne()
        {
            m_nas = "NON DÉFINI";
            m_nom = "SANS NOM";
        }
    }
}
