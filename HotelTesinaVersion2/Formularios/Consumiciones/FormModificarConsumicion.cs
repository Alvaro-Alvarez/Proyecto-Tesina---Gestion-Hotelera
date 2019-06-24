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
namespace HotelTesinaVersion2.Formularios.Consumiciones
{
    public partial class FormModificarConsumicion : Form
    {
        public FormModificarConsumicion()
        {
            InitializeComponent();
            comboBox1.DataSource = ConsumicionDAL.TraerConsumicionesNombreyPrecio();
            comboBox1.DisplayMember = "Consumicion";
            comboBox1.ValueMember = "id";
        }

        private void btnAgregarConsumicion_Click(object sender, EventArgs e)
        {
            
            Consumicion consumicion = new Consumicion();
           
            consumicion.Nombre = txtNombre.Text.Trim();
            consumicion.Precio = txtPrecio.Text.Trim();
            consumicion.Id =Convert.ToInt32 (comboBox1.SelectedValue);
            int resultado = ConsumicionDAL.Actualizar(consumicion);
            if (resultado > 0)
            {
                MessageBox.Show("Los datos de la consumicion se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
