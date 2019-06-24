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
    public partial class FormModificarHabitacion : Form
    {
        public FormModificarHabitacion()
        {
            InitializeComponent();
            cboboxHabitacion.DataSource = HabitacionDAL.TraeHabitaciones();
            cboboxHabitacion.DisplayMember = "num_habitacion";
            cboboxHabitacion.ValueMember = "id";
            cboxTipoHabitacion.DataSource = HabitacionDAL.TraerTipoHabitaciones();
            cboxTipoHabitacion.DisplayMember = "tipo";
            cboxTipoHabitacion.ValueMember = "id";
        }

        private void btnModificarHabitacion_Click(object sender, EventArgs e)
        {
           
            Habitacion habitacion = new Habitacion();
            habitacion.NumHabitacion = Convert.ToInt32(txtNumHabitacion.Text.Trim());
            habitacion.Estado = cboxEstado.Text.Trim();
            habitacion.Precio = txtPrecio.Text.Trim();
            habitacion.IdTipoHabitacion = Convert.ToInt32(cboxTipoHabitacion.Text.Trim());
            habitacion.codigo =Convert.ToInt32(cboboxHabitacion.SelectedValue);
            int resultado = HabitacionDAL.Actualizar(habitacion);
            if (resultado > 0)
            {
                MessageBox.Show("Los datos de la Habitacion se Actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
