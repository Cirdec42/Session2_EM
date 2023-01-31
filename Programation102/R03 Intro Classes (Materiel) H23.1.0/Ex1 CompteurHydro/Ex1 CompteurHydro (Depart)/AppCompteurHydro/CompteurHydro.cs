namespace AppCompteurHydro
{
    /// ------------------------------------------------------------------------------------
    /// <summary>
    /// Représente un compteur hydro électrique 
    /// </summary>
    /// ------------------------------------------------------------------------------------
    public class CompteurHydro
    {
        // TODO 01 : Compléter cette classe en se basant sur le diagramme "Ex1 CompteurHydro.png"
        private int m_consomationActuelle;

        public int ConsomationActuelle
        {
            get { return m_consomationActuelle; }
        }
        public CompteurHydro()
        {
            m_consomationActuelle = 0;
        }
        public void Consommer(int pQuantitéKw)
        {
            m_consomationActuelle += pQuantitéKw;
        }

    }
}
