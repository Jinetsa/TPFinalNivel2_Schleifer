using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        private void btnModImagen_Click(object sender, EventArgs e)
        {
            frmModificarImagen modificarImagen = new frmModificarImagen();
            modificarImagen.ShowDialog();
        }
    }
}
