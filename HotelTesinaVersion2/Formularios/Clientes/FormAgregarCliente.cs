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
    public partial class FormAgregarCliente : Form
    {
        public FormAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
           
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text.Trim();
            cliente.Apellido = txtApellido.Text.Trim();
            cliente.Dni = Convert.ToInt32(txtDNI.Text.Trim());
            cliente.Domicilio = txtDomicilio.Text.Trim();
            cliente.Sexo = cbSexo.Text;
            cliente.Telefono = Convert.ToInt32(txtTelefono.Text.Trim());
            cliente.Mail = txtMail.Text.Trim();
            int resultado = ClienteDAL.Agregar(cliente);
            if (resultado > 0)
            {
                MessageBox.Show("cliente guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el clientes", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
