using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ExemTypeParEnumeration
{
    /// <summary>
    /// Démonstration de l'utilité d'un type énumration.
    /// Dans le problème nous avons besoins de distinguer entre trois alignements possibles. Nous utilisons trois
    /// valeurs qui représentent chacune un alignement.
    /// 
    /// Le problème est solutionné de quatre façons différentes. 
    /// </summary>
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Matériel)";

        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            cboChoix.SelectedIndex = 0;
        }

        #region Version #1 (avec des littéraux entiers)
        //=======================================================================================================
        private void btnExemple1_Click(object sender, EventArgs e)
        {
            int choix = cboChoix.SelectedIndex;

            // TODO 01 : Ajouter une instruction switch qui utilise les littéraux 0, 1 et 2






            txtVotreChoix.BackColor = Color.Aqua;
        }
        #endregion

        #region Version #2 (avec des constantes)
        //=======================================================================================================
        private void btnExemple2_Click(object sender, EventArgs e)
        {
            const int GAUCHE = 0;
            const int DROITE = 1;
            const int CENTRE = 2;

            int choix = cboChoix.SelectedIndex;

            // TODO 02 : Ajouter une instruction switch qui utilise les constantes GAUCHE, DROIT et CENTRE
            




            txtVotreChoix.BackColor = Color.Lime;
        }
        #endregion

        #region Version #3 (avec un type par énumération prédéfini)
        //=======================================================================================================
        // En utilisant de un type prédéfini HorizontalAlignment
        //        ATTENTION: Vous n'avez pas à créer cette énumération car elle est prédéfinies dans C# :
        //                   public enum HorizontalAlignment { Left=0, Right=1, Center=2 };
        // Cette énumération est utilisée dans de nombreuses classes.
        // Parmi ces classes figurent CheckedListBox, ColumnHeader, ComboBox, ControlPaint, Label, ListBox,
        // Control, RichTextBox et TextBox. 
        private void btnExemple3_Click(object sender, EventArgs e)
        {
            HorizontalAlignment choix = (HorizontalAlignment)cboChoix.SelectedIndex;

            // TODO 03 : Ajouter une instruction switch qui utilise le type par énumération HorizontalAlignment

            




            txtVotreChoix.BackColor = Color.Salmon;
        }
        #endregion

        #region Version #4 (en définissant notre propre type énumération)
        //=======================================================================================================
        // TODO 05 : Définir un nouveau type par énumération nommé ChoixAlignement avec 3 alignements
       
	   
	   
        private void btnExemple4_Click(object sender, EventArgs e)
        {
            // TODO 06 : Ajouter une variable appelée choix dont le type est ChoixAlignement 
			//    et qui a initialement
			//    la valeur du SelectedIndex de cboChoix, transtypée à ChoixAlignement
          
		  

            // TODO 07 : Ajouter une instruction switch qui utilise le type par énumération ChoixAlignement

           



            txtVotreChoix.BackColor = Color.Yellow;
        }
        #endregion

        #region types par énumération prédéfinis
        //=======================================================================================================
        //Exemples d'énumérations
        private void ExempleUtilisationEnum()
        {
            // Plusieurs énumérations existent dans .Net
            // Faire bouton droit sur le nom du type, puis atteindre la définition pour visualiser les valeurs
            ConflictOption variable1 = ConflictOption.OverwriteChanges;
            CheckState variable2 = CheckState.Indeterminate;
            MessageBoxButtons variable3 = MessageBoxButtons.YesNoCancel;
            AccessibleEvents variable4 = AccessibleEvents.DefaultActionChange;

        }
        #endregion

        private void cboChoix_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
