using System.Collections.Generic;
using System.Windows.Forms;

namespace AppGuichet
{
    public partial class FrmListeClients : Form
    {
        public FrmListeClients(List<Client> pColClients)
        {
            InitializeComponent();
            m_colClients = pColClients;
            AfficherListeCLients();
        }

        public void AfficherListeCLients()
        {
            lsvClients.Items.Clear();
            foreach (Client client in m_colClients)
            {
                ListViewItem objItem = new ListViewItem(client.NumClient);
                objItem.SubItems.Add(client.Nom);
                objItem.SubItems.Add(client.SorteCompte.ToString());
                objItem.SubItems.Add(client.Solde.ToString("C2"));
                objItem.SubItems.Add(client.MotDePasse);
                lsvClients.Items.Add(objItem);
            }
        }
        private void lsvClients_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private List<Client> m_colClients;


    }
}