using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGuichet
{
    public class Transaction
    {
        private DateTime m_date;
        private int m_montant;
        private string m_numClient;
        private SorteTransactions m_sorteTransactions;

        public DateTime Date
        {
            get { return m_date; }
        }

        public int Montant
        {
            get { return m_montant; }
        }

        public string NumClient
        {
            get { return m_numClient; }
        }

        public SorteTransactions SorteTransactions
        {
            get { return m_sorteTransactions; }
        }


        public override string ToString()
        {
            return (int)SorteTransactions + "," + NumClient + "," + Date + "," + Montant;
        }

        public Transaction(SorteTransactions pSorte, string pNumClient,DateTime pDate, int pMontant)
        {
            m_date = pDate;
            m_montant = pMontant;
            m_numClient = pNumClient;
            m_sorteTransactions = pSorte;
        }

        public Transaction(string pChaineLue)
        {
            char delims = ',';
            String[] tokens = pChaineLue.Split(delims);
            m_sorteTransactions = (SorteTransactions)int.Parse(tokens[0]);
            m_numClient = tokens[1];
            m_date = (DateTime)DateTime.Parse(tokens[2]);
            m_montant = int.Parse(tokens[3]);
        }
    }
}
