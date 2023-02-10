using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModeImage
{
    public class ModeImage
    {
        #region CONSTANTE
        //Valeur par défault
        public const int DÉFAUT_CONTRASTE = 65;
        public const int DÉFAUT_COULEUR = 50;
        public const int DÉFAUT_LUMINOSITÉ = 75;
        public const int DÉFAUT_TEINTE = 0;
        public const int DÉFAUT_NETTETÉ = 5;

        #endregion
        #region CHAMPS & PROPRIÉTÉ

        private int m_contraste; // Mémoriser la valeur reçu par Contraste
        public int Contraste //propriété
        {
            get { return m_contraste; } //accès lecture
            set {ValiderValeur(0, 100, value); m_contraste = value; } //accès écriture
        }

        private int m_couleur;// Mémoriser la valeur reçu par Couleur
        public int Couleur //Reçois la valeur et permet leur lecture
        {
            get { return m_couleur; } //accès lecture
            set { ValiderValeur(0, 100, value); m_couleur = value; } //accès écriture
        } 

        private int m_luminosité;// Mémoriser la valeur reçu par Luminosité
        public int Luminosité //Reçois la valeur et permet leur lecture
        {
            get { return m_luminosité; } //accès lecture
            set {ValiderValeur(0, 100, value); m_luminosité = value; } //accès écriture
        }

        private int m_teinte;// Mémoriser la valeur reçu par Teinte
        public int Teinte //Reçois la valeur et permet leur lecture
        {
            get { return m_teinte; } //accès lecture
            set {ValiderValeur(-10,10,value); m_teinte = value; } //accès écriture
        }

        private int m_netteté;// Mémoriser la valeur reçu par Netteté
        public int Netteté //Reçois la valeur et permet leur lecture
        {
            get { return m_netteté; } //accès lecture
            set { ValiderValeur(0, 10, value); m_netteté = value; } //accès écriture
        }

        public string Nom { get; private set; } //Permet de lire la valeur définie dans le constructeur
        #endregion
        #region MÉTHODE/CONSTRUCTEUR

        public ModeImage(string pNom) //constructeur
        {
            Nom = pNom;
            Contraste = DÉFAUT_CONTRASTE;
            Couleur = DÉFAUT_COULEUR;
            Luminosité = DÉFAUT_LUMINOSITÉ;
            Teinte = DÉFAUT_TEINTE;
            Netteté = DÉFAUT_NETTETÉ;
        }
        public ModeImage(string pNom, int pLuminosité, int pContraste, int pCouleur, int pTeinte, int pNetteté)
        {
            Nom = pNom;
            Luminosité = pLuminosité;
            Contraste = pContraste;
            Couleur = pCouleur;
            Teinte = pTeinte;
            Netteté = pNetteté;
        }
        public void ValiderValeur(int pMin, int pMax, int pValeur)
        {
            if (pValeur < pMin || pValeur > pMax)
            {
                throw new ArgumentOutOfRangeException("value");
            }
        }
        #endregion

    }
}
