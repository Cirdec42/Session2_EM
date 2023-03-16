using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace AppGuichet
{
    /// =====================================================================================================================
    /// <summary>
    /// Représente l’utilisation d’un guichet automatique. Un client peut se connecter avec son numéro et son mot de passe.
    /// Il peut retirer de l’argent si son solde le permet. L’administrateur du guichet peut demander la liste des clients
    /// où la liste des transactions effectuées sur le guichet.
    /// </summary>
    /// ======================================================================================================================
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        #region Constantes
        //--- CHAMPS: constantes ----------------------------------------------------------
        private const string NOM_FICHIER_CLIENTS = "Fichiers\\Clients.txt";
        public const string NOM_FICHIER_TRANSACTIONS = "Fichiers\\Transactions.txt";
        private const string NO_ADMIN = "000";
        public const string ERR_NUMERO_CLIENT = "Numéro de client non valide";
        private const string ERR_MOT_DE_PASSE = "Mot de passe incorrect";
        #endregion

        #region Champs et Propriétés : À RÉACTIVER lorsque vos classes Client et Transaction seront complétées
        public List<Client> m_colClients;
        public List<Client> ColClients
        {
            get { return m_colClients; }
        }

        public List<Transaction> m_colTransactions;
        public List<Transaction> ColTransactions
        {
            get { return m_colTransactions; }
        }

        private Client m_objClientCourant;
        public Client ClientCourant
        {
            get
            {
                return m_objClientCourant;
            }
            set
            {
                m_objClientCourant = value;
            }
        }
        #endregion

        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // À COMPLÉTER...

            // Initialiser vos 2 collections ainsi que le ClientCourant...
            m_colClients = new List<Client>();
            m_colTransactions = new List<Transaction>();
            m_objClientCourant = null;
            // Le programme doit charger les deux collections en débutant : NE PAS MODIFIER
            ChargerCollectionClients();
            ChargerCollectionTransactions();
            PermettreUneConnexion(true);
            mnuAdministrateur.Enabled = false;
            btnConnexion.Enabled = true;
            grpInfosClient.Enabled = false;
            grpIdentification.Enabled = true;
            mnuAdminListeClients.Enabled = false;
            mnuAdminListeTransactions.Enabled = false;
            lblNumClient.Enabled = true;

        }

        #region Méthodes pour Charger les 2 collections
        //------------------------------------------------------------------------------------------
        /// <summary>
        /// Lit les données dans le fichier de clients et les stocke dans la collection de clients.
        /// Les données lues sont séparées par une virgule.
        /// </summary>
        /// ----------------------------------------------------------------------------------------
        private void ChargerCollectionClients()
        {
            // À COMPLÉTER...
            StreamReader objStreamReader = new StreamReader(NOM_FICHIER_CLIENTS);
            while (!objStreamReader.EndOfStream)
            {
                string uneLigneLue = objStreamReader.ReadLine();
                Client unclient = new Client(uneLigneLue);
                m_colClients.Add(unclient);
            }
            objStreamReader.Close();
        }
        //----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Lits les données dans le fichier des transactions et les stocke dans la collection de transactions.
        /// Les données sont séparées par une virgule
        /// </summary>
        /// ---------------------------------------------------------------------------------------------------
        private void ChargerCollectionTransactions()
        {
            // À COMPLÉTER...
            StreamReader objStreamReader = new StreamReader(NOM_FICHIER_TRANSACTIONS);
            while (!objStreamReader.EndOfStream)
            {
                string uneLigneLue = objStreamReader.ReadLine();
                string[] tabInfos = uneLigneLue.Split(',');
                Transaction uneTransaction = new Transaction(uneLigneLue);
                m_colTransactions.Add(uneTransaction);
            }
            objStreamReader.Close();
        }

        #endregion

        #region Enregsitrer la collection de clients, Menu Quitter et Fermeture
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// Écrit dans le fichier de clients, les clients contenus dans la collection de clients.
        /// Puisque le solde du client a pu changer après le retrait.
        /// </summary>
        /// -------------------------------------------------------------------------------------
        public void EnregistrerCollectionClients()
        {
            // À COMPLÉTER...
            StreamWriter writer = new StreamWriter(NOM_FICHIER_CLIENTS);
            foreach (Client unclient in m_colClients)
            {
                writer.WriteLine(unclient.ToString());
            }
            writer.Close();
        }
        //---------------------------------------------------------------------------------
        private void mnuFichierQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        //---------------------------------------------------------------------------------
        public void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // À COMPLÉTER...
            EnregistrerCollectionClients();
            if (ClientCourant !=null)
            {
                EnregistrerLaTransaction(SorteTransactions.Déconnexion, 0);
            }
        }
        #endregion

        #region Menu Administrateur
        //---------------------------------------------------------------------------------
        private void mnuAdminListeClients_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            FrmListeClients objFrmClient = new FrmListeClients(m_colClients);
            objFrmClient.ShowDialog();
        }
        //---------------------------------------------------------------------------------
        private void mnuAdminListeTransactions_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            FrmListeTransactions objFrmTransaction = new FrmListeTransactions(m_colTransactions);
            objFrmTransaction.ShowDialog();
        }


        #endregion

        #region  Méthodes: Enregistrer la transaction, PermettreUneConnexion, MettreAjourSelonContexte, RechercherClient
        //-----------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Écrit dans le fichier de transactions, la nouvelle transaction qui vient de se produire, maintenant.
        /// Ajoute aussi cette nouvelle transaction dans la collection de transactions.
        /// </summary>
        /// <param name="pSorteTransaction">sorte de transaction</param>
        /// <param name="pMontantRetrait">montant du retrait, 0 si ce n'est pas un retrait</param>
        /// --------------------------------------------------------------------------------------------------------
        private void EnregistrerLaTransaction(SorteTransactions pSorteTransaction, int pMontantRetrait)
        {
            // À COMPLÉTER...
            Transaction derniereTransaction = new Transaction(pSorteTransaction, ClientCourant.NumClient, DateTime.Now, pMontantRetrait);
            m_colTransactions.Add(derniereTransaction);
            StreamWriter oFichier = new StreamWriter(NOM_FICHIER_TRANSACTIONS, true);
            oFichier.WriteLine(derniereTransaction.ToString());
            oFichier.Close();


        }

        //------------------------------------------------------------------------------------------------
        /// <summary>
        /// Modifie l'interface selon qu'un client se connecte ou se déconnecte. 
        /// </summary>
        /// <param name="pConnexionEstPermise">un client se connecte ou non</param>
        /// ---------------------------------------------------------------------------------------------
        private void PermettreUneConnexion(bool pConnexionEstPermise)
        {
            // À COMPLÉTER...
            txtNumClient.Enabled = pConnexionEstPermise;
            txtMotDePasse.Enabled = pConnexionEstPermise;
            lblMotDePasse.Enabled = pConnexionEstPermise;
            cboMontant.Enabled = !pConnexionEstPermise;
        }

        //--------------------------------------------------------------------------------------------
        /// <summary>
        /// Active ou désactive les menus et contrôles selon s'il s'agit de l'administrateur ou non.
        /// </summary>
        /// -----------------------------------------------------------------------------------------
        private void MettreAJourSelonContexte()
        {
            // À COMPLÉTER...
            txtNom.Text = ClientCourant.Nom;
            txtSorteCompte.Text = ClientCourant.SorteCompte.ToString();
            txtSolde.Text = ClientCourant.Solde.ToString("C0");
            //si admin client + transaction
            //    sinon non
            if (ClientCourant.NumClient == NO_ADMIN)
            {
                mnuAdministrateur.Enabled = true;
                mnuAdminListeClients.Enabled = true;
                mnuAdminListeTransactions.Enabled = true;
                grpInfosClient.Enabled = false;
            }
            else
            {
                mnuAdministrateur.Enabled = false;
                mnuAdminListeClients.Enabled = false;
                mnuAdminListeTransactions.Enabled = false;
                grpInfosClient.Enabled = true;
            }

        }

        /// -------------------------------------------------------------------------------
        /// <summary>
        /// Recherche le client dont le numéro est spécifié.
        /// Si ce numéro n'est pas dans la collection de clients, alors retourne null.
        /// </summary>
        /// <param name="pNumClient">numéro du client à rechercher</param>
        /// <returns>le client ou null si pas trouvé</returns>
        /// --------------------------------------------------------------------------------
        public Client RechercherClient(string pNumClient)
        {
            foreach (Client unclient in m_colClients)
            {
                if (pNumClient == unclient.NumClient)
                {
                    return unclient;
                }
            }
            return null;
        }
        #endregion

        #region Bouton Connexion/Déconnexion 
        //---------------------------------------------------------------------------------
        public void btnConnexion_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            ClientCourant = RechercherClient(txtNumClient.Text);
            errIdentification.Clear();

            if (btnConnexion.Text == "Se connecter")
            {
                if (ClientCourant == null)
                {
                    errIdentification.SetError(txtNumClient, ERR_NUMERO_CLIENT);
                    txtNumClient.Clear();
                }
                else if (ClientCourant.MotDePasse != txtMotDePasse.Text)
                {
                    errIdentification.SetError(txtMotDePasse, ERR_MOT_DE_PASSE);
                    txtMotDePasse.Clear();
                }
                else
                {
                    PermettreUneConnexion(false);
                    MettreAJourSelonContexte();
                    btnConnexion.Text = "Se déconnecter";
                    EnregistrerLaTransaction(SorteTransactions.Connexion, 0);
                }
            }
            else
            {
                btnConnexion.Text = "Se connecter";
                EnregistrerLaTransaction(SorteTransactions.Déconnexion, 0);
                ClientCourant = null;
                PermettreUneConnexion(true);

                //mettre a jour les infos
                mnuAdministrateur.Enabled = false;
                mnuAdminListeClients.Enabled = false;
                mnuAdminListeTransactions.Enabled = false;

                txtNom.Clear();
                txtMotDePasse.Clear();
                txtNumClient.Clear();
                txtSolde.Clear();
                txtSorteCompte.Clear();
                cboMontant.SelectedIndex = -1;
                btnRetirer.Enabled = false;
            }

        }
        #endregion

        #region Bouton Retirer et Événement Combo Montant à retirer
        //---------------------------------------------------------------------------------
        //Retire le montant choisi
        public void btnRetirer_Click(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            if (cboMontant.SelectedIndex!=-1)
            {
                int montantRetrait = int.Parse(cboMontant.SelectedItem.ToString());
                ClientCourant.Retirer(montantRetrait);
               EnregistrerLaTransaction(SorteTransactions.Retrait, montantRetrait);
                MettreAJourSelonContexte();
            }
        }

        //---------------------------------------------------------------------------------
        //Choix du montant à retirer
        private void cboMontant_SelectedIndexChanged(object sender, EventArgs e)
        {
            // À COMPLÉTER...
            if (cboMontant.SelectedIndex != -1 && ClientCourant.PeutRetirer(int.Parse(cboMontant.SelectedItem.ToString())))
            {
                btnRetirer.Enabled = true;
            }
            else
            {
                btnRetirer.Enabled = false;
            }
        }

        #endregion

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }
    }
}