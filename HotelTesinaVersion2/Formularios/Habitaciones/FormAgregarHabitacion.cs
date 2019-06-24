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
namespace HotelTesinaVersion2.Formularios.Habitaciones
{
    public partial class FormAgregarHabitacion : Form
    {
        public FormAgregarHabitacion()
        {
            InitializeComponent();
            cboxTipoHabitacion.DataSource = HabitacionDAL.TraerTipoHabitaciones();
            cboxTipoHabitacion.DisplayMember = "tipo";
            cboxTipoHabitacion.ValueMember = "id";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
            Habitacion habitacion = new Habitacion();
            habitacion.NumHabitacion = Convert.ToInt32(txtNumHabitacion.Text.Trim());
            habitacion.Estado = cboxEstado.Text.Trim();
            habitacion.Precio = txtPrecio.Text.Trim();
            habitacion.IdTipoHabitacion = Convert.ToInt32(cboxTipoHabitacion.SelectedValue);
            int resultado = HabitacionDAL.Agregar(habitacion);
            if (resultado > 0)
            {
                MessageBox.Show("Habitacion guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la Habitacion", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
