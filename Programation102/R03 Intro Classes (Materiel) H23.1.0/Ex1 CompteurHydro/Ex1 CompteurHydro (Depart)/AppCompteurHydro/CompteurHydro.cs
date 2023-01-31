namespace AppCompteurHydro
{
    /// ------------------------------------------------------------------------------------
    /// <summary>
    /// Repr�sente un compteur hydro �lectrique 
    /// </summary>
    /// ------------------------------------------------------------------------------------
    public class CompteurHydro
    {
        // TODO 01 : Compl�ter cette classe en se basant sur le diagramme "Ex1 CompteurHydro.png"
        private int m_consomationActuelle;

        public int ConsomationActuelle
        {
            get { return m_consomationActuelle; }
        }
        public CompteurHydro()
        {
            m_consomationActuelle = 0;
        }
        public void Consommer(int pQuantit�Kw)
        {
            m_consomationActuelle += pQuantit�Kw;
        }

    }
}
