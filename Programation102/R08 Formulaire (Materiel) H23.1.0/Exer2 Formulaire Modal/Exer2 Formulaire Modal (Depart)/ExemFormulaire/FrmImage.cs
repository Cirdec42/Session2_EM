using System.Drawing;
using System.Windows.Forms;

namespace ExemFormulaire
{
    public partial class FrmImage : Form
    {
        /// <summary>
        /// Le constructeur à été modifié afin de lui ajouter un paramètre
        /// </summary>
        public FrmImage(string pNomImage)
        {
            InitializeComponent();
            picImage.Image = Image.FromFile(pNomImage);
        }
    }
}
