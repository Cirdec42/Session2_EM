using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppGuichet
{
    public partial class FrmListeTransactions : Form
    {
        //----------------------------------------------------------------
        public FrmListeTransactions(List<Transaction> pColTransaction)
        {
            InitializeComponent();
            m_colTransaction = pColTransaction;
            cboOpération.SelectedIndex = 0;
        }

        public void AfficherListeTransaction(FiltreOperation pFiltreOpération)
        {
            int nbTransaction = 0;
            lsvTransactions.Items.Clear();
            switch (pFiltreOpération)
            {
                case FiltreOperation.Toutes:
                    for (int i = m_colTransaction.Count - 1; i >= 0; i--)
                    {
                        ListViewItem objItem = new ListViewItem(m_colTransaction[i].SorteTransaction.ToString());
                        objItem.SubItems.Add(m_colTransaction[i].NumClient);
                        objItem.SubItems.Add(m_colTransaction[i].Date.ToString());
                        if (m_colTransaction[i].SorteTransaction == SorteTransactions.Retrait)
                        {
                            objItem.SubItems.Add(m_colTransaction[i].Montant.ToString("C2"));
                        }
                        else
                        {
                            objItem.SubItems.Add("--");
                        }
                        lsvTransactions.Items.Add(objItem);
                        nbTransaction++;
                    }
                    break;
                case FiltreOperation.ConnexionDéconnexion:
                    for (int i = m_colTransaction.Count - 1; i >= 0; i--)
                    {
                        if (m_colTransaction[i].SorteTransaction != SorteTransactions.Retrait)
                        {
                            ListViewItem objItem = new ListViewItem(m_colTransaction[i].SorteTransaction.ToString());
                            objItem.SubItems.Add(m_colTransaction[i].NumClient);
                            objItem.SubItems.Add(m_colTransaction[i].Date.ToString());
                            objItem.SubItems.Add("--");
                            lsvTransactions.Items.Add(objItem);
                            nbTransaction++;
                        }
                    }

                    break;
                case FiltreOperation.Retrait:

                    for (int i = m_colTransaction.Count - 1; i >= 0; i--)
                    {
                        if (m_colTransaction[i].SorteTransaction == SorteTransactions.Retrait)
                        {
                            ListViewItem objItem = new ListViewItem(m_colTransaction[i].SorteTransaction.ToString());
                            objItem.SubItems.Add(m_colTransaction[i].NumClient);
                            objItem.SubItems.Add(m_colTransaction[i].Date.ToString());
                            objItem.SubItems.Add(m_colTransaction[i].Montant.ToString("C2"));
                            lsvTransactions.Items.Add(objItem);
                            nbTransaction++;
                        }
                    }

                    break;
                default:
                    break;
            }
            lblNbrTransactions.Text = nbTransaction.ToString();
        }

        //------------------------------------------------------------------------------
        private void cboOpération_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherListeTransaction((FiltreOperation)cboOpération.SelectedIndex);

        }

        private void lsvTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<Transaction> m_colTransaction;
    }
}