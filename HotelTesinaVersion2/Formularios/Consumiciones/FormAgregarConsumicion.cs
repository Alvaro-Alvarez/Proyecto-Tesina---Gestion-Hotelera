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
    public partial class FormAgregarConsumicion : Form
    {
        public FormAgregarConsumicion()
        {
            InitializeComponent();
        }

        private void btnAgregarConsumicion_Click(object sender, EventArgs e)
        {
            
            Consumicion consumicion = new Consumicion();
           
            consumicion.Nombre = txtNombre.Text.Trim();
            consumicion.Precio = txtPrecio.Text.Trim();

            int resultado = ConsumicionDAL.Agregar(consumicion);
            if (resultado > 0)
            {
                MessageBox.Show("consumicion guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la consumicion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
