using System;
using System.Collections.Generic;
using System.Text;

namespace AppDeMusique
{
    // Version H20.1.0
    /// -----------------------------------------------------------------------------------------------------
    /// <summary>
    ///	 Mod�lise un morceau de musique. Les champs sont : artiste, album, titre, ann�e et dur�e.
    /// </summary>
    /// -----------------------------------------------------------------------------------------------------
    public class Morceau
    {
        #region CHAMPS - Variables MEMBRE (5) et PROPRI�T�S - NE PAS MODIFIER

        /// =====================================================================
        private readonly string m_artiste;
        /// --------------------------
        /// <summary>
        /// Obtient l'artiste.
        /// </summary>
        /// --------------------------
        public string Artiste
        {
            get { return m_artiste; }
        }

        /// =====================================================================
        private readonly string m_album;
        /// -------------------------
        /// <summary>
        /// Obtient l'album.
        /// </summary>
        /// -------------------------
        public string Album
        {
            get { return m_album; }
        }

        /// =====================================================================
        private readonly string m_titre;
        /// --------------------------
        /// <summary>
        /// Obtient le titre.
        /// </summary>
        /// --------------------------
        public string Titre
        {
            get { return m_titre; }
        }
        /// =====================================================================
        private readonly int m_cote;
        /// --------------------------
        /// <summary>
        /// Obtient la cote.
        /// </summary>
        /// --------------------------
        public int Cote
        {
            get { return m_cote; }
        }
        /// =====================================================================
        private readonly int m_dur�e;
        /// -------------------------------
        /// <summary>
        /// Obtient la dur�e en secondes.
        /// </summary>
        /// -------------------------------
        public int Dur�e
        {
            get { return m_dur�e; }
        }
        #endregion CHAMPS - Variables membre

        #region CONSTRUCTEURS - NE PAS MODIFIER
        ///==========================================================================================
        /// <summary>
        /// Initialise une instance de la classe Morceau avec les donn�es pass�es en param�tre.
        /// </summary>
        /// <param name="pArtiste">Nom de l'artiste ou du groupe</param>
        /// <param name="pAlbum">Nom de l'album</param>
        /// <param name="pTitre">Titre du morceau</param>
        /// <param name="pCote">Cote du morceau /5</param>
        /// <param name="pDur�e">Dur�e du morceau en secondes</param>
        /// ----------------------------------------------------------------------------------------
        public Morceau(string pArtiste, string pAlbum, string pTitre, int pCote, int pDur�e)
        {
            m_artiste = pArtiste;
            m_album = pAlbum;
            m_titre = pTitre;
            m_cote = pCote;
            m_dur�e = pDur�e;
        }
        #endregion CONSTRUCTEUR

        #region M�THODE - NE PAS MODIFIER 
        /// <summary>
        /// Fournis une version lisible incluant le nom de l'artiste ainsi que le titre
        /// </summary>
        /// <returns>L'artiste ainsi que le titre</returns>
        public override string ToString()
        {
            return m_titre + " par " + m_artiste;
        }
        #endregion
    }
}
