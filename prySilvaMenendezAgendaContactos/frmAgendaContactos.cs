using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendezAgendaContactos
{
    public partial class frmAgendaContactos : Form
    {
        public frmAgendaContactos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar frmAgregar = new frmAgregar();
            frmAgregar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmBorrar borrarFormulario = new frmBorrar();
            borrarFormulario.ShowDialog();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
