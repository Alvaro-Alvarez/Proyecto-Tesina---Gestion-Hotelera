using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelTesinaVersion2.Clases.DAL;
using HotelTesinaVersion2.Clases.Entidades;

namespace HotelTesinaVersion2.Formularios.Clientes
{
    public partial class FormEliminarCliente : Form
    {
        public FormEliminarCliente()
        {
            InitializeComponent();
            cboboxCliente.DataSource = ClienteDAL.TraerClientes();
            cboboxCliente.DisplayMember = "Cliente";
            cboboxCliente.ValueMember = "id";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Esta Seguro que desea eliminar el cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ClienteDAL.Eliminar(Convert.ToInt32(cboboxCliente.SelectedValue)) > 0)
                {
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar ea cliente", "Consumicion No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cboboxCliente.DataSource = ClienteDAL.TraerClientes();
        }
    }
}
