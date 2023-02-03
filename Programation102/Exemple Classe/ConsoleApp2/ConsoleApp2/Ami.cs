using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Ami
    {
        public const int MIN_AGE = 0; //Constante de classe
        public const int MAX_AGE = 100; //Constante de classe

        //private string m_nom; //champs
        //public string Nom //propriété
        //{
        //    get { return m_nom; } //accès lecture
        //    set { m_nom = value; } //accès écriture
        //}

        public string Nom { get; set; } //propriété automatique

        private int m_age; //champs
        public int Age //propriété
        {
            get { return m_age; } //accès lecture
            set {

                if (value<MIN_AGE || value > MAX_AGE)
                {
                    throw new ArgumentOutOfRangeException("value"); //Méthode 1 (pas la meilleur),validation (fait planté le code si les limite ne sont pas respecter)
                }

                m_age = value; 
            } //accès écriture
        }

        public string Infos //propriété calculée
        {
            get { return "Nom = " + /*m_nom*/Nom + " : Age = " + m_age; }
        }

        public Ami(string pnom, int page) //constructeur
        {
            /*m_nom*/Nom = pnom;

            if (Age<MIN_AGE || Age>MAX_AGE)
            {
                throw new ArgumentOutOfRangeException(); //Méthode 2
            }
            Age = page;//Meilleur Méthode
            //validé dans la propriété et utiliser la propriété comme "variable"
            //m_age = page;
        }

        public void VieillirDunAn()
        {
            if (m_age>=MAX_AGE)
            {
                throw new ArgumentOutOfRangeException(); //Méthode 3
                m_age++;
            }
        }
    }
}
