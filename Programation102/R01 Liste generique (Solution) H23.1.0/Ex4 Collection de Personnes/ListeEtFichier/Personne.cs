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
        /// Instancie une personne avec les données passées en paramètre.
        /// </summary>
        /// <param name="pNas">nas de la personne à créer</param>
        /// <param name="pNom">nom de la personne à créer</param>
        /// -------------------------------------------------------------
        public Personne(string pNas, string pNom)
        {
            m_nas = pNas;
            m_nom = pNom;
        }
    }
}
