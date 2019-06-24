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
    public partial class FormModificarCliente : Form
    {
        public FormModificarCliente()
        {
            InitializeComponent();
            cboboxCliente.DataSource = ClienteDAL.TraerClientes();
            cboboxCliente.DisplayMember = "Cliente";
            cboboxCliente.ValueMember = "id";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ClienteDAL clientesdao = new ClienteDAL();
            Cliente cliente = new Cliente();
           
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellido = txtApellido.Text.Trim();
            cliente.Dni = Convert.ToInt32(txtDNI.Text.Trim());
            cliente.Domicilio = txtDomicilio.Text.Trim();
            cliente.Sexo = cbSexo.Text;
            cliente.Telefono = Convert.ToInt32(txtTelefono.Text.Trim());
            cliente.Mail = txtMail.Text.Trim();
            cliente.Id = Convert.ToInt32(cboboxCliente.SelectedValue);
            int resultado = ClienteDAL.Actualizar(cliente);
            if (resultado > 0)
            {
                MessageBox.Show("Los datos del cliente se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
