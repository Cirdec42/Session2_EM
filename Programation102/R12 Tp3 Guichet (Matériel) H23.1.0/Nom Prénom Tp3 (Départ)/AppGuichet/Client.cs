using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGuichet
{
    public class Client
    {
        #region Const & Champs
        private string m_motDePasse;
        private string m_nom;
        private string m_numClient;
        private int m_solde;
        private SorteComptes m_sorteCompte;
        public const int MAX_SOLDE = 1000;
        #endregion

        #region Propriété
        public string MotDePasse
        {
            get { return m_motDePasse; }
        }

        public string Nom
        {
            get { return m_nom; }
        }

        public string NumClient
        {
            get { return m_numClient; }
        }

        public int Solde
        {
            get { return m_solde; }
        }

        public SorteComptes SorteCompte
        {
            get { return m_sorteCompte; }
        }
        #endregion

        #region Méthodes
        public Client(string pChaineLu)
        {
            char delims = ',';
            String[] tokens = pChaineLu.Split(delims);
            m_numClient = tokens[0];
            m_sorteCompte = (SorteComptes)int.Parse(tokens[1]);
            m_nom = tokens[2];
            m_solde = int.Parse(tokens[3]);
            m_motDePasse = tokens[4];
        }
        public Client(string pNumClient, SorteComptes pSorteCompte, string pNom, int pSolde, string pMotDePasse)
        {
            if (pSolde > MAX_SOLDE || pSolde < 0)
            {
                throw new ArgumentException("value");
            }
            m_numClient = pNumClient;
            m_sorteCompte = pSorteCompte;
            m_nom = pNom;
            m_solde = pSolde;
            m_motDePasse = pMotDePasse;


        }

        public bool PeutRetirer(int pMontant)
        {
            if (pMontant<=m_solde)
            {
                if (pMontant<=0)
                {
                    return false;
                }
                return true;
            }
            return false;   
        }

        public void Retirer(int pMontant)
        {
            if (pMontant>m_solde|| pMontant<0)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            m_solde = m_solde - pMontant;

        }

        public override string ToString()
        {
            return NumClient + "," + (int)SorteCompte + "," + Nom + "," + Solde + "," + MotDePasse;
        }

        
        #endregion
    }
}
