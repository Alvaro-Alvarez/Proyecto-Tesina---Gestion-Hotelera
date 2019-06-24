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
namespace HotelTesinaVersion2.Formularios.ConsumicionesPorHabitaciones
{
    public partial class FormAgregarConsumicionPorHabitacion : Form
    {
        public FormAgregarConsumicionPorHabitacion()
        {
            InitializeComponent();
            datePickerConsumcion.Format = DateTimePickerFormat.Custom;
            datePickerConsumcion.CustomFormat = "yyyy-MM-dd";
            cboboxConsumicion.DataSource = ConsumicionDAL.TraerConsumicionesNombreyPrecio();
            cboboxConsumicion.DisplayMember = "Consumicion";
            cboboxConsumicion.ValueMember = "id";
            cboboxHabitacion.DataSource = HabitacionDAL.TraeHabitaciones();
            cboboxHabitacion.DisplayMember = "num_habitacion";
            cboboxHabitacion.ValueMember = "id";
        }

        private void btnRegistrarConsumicion_Click(object sender, EventArgs e)
        {
            ConsumicionPorHabitacion consumicion = new ConsumicionPorHabitacion();

            consumicion.IdConsumicion = Convert.ToInt32(cboboxConsumicion.SelectedValue);
            consumicion.IdHabitacion = Convert.ToInt32(cboboxHabitacion.SelectedValue);
            consumicion.fecha = datePickerConsumcion.Text;
            int resultado = ConsumicionPorHabitacionDAL.Agregar(consumicion);
            if (resultado > 0)
            {
                MessageBox.Show("Reserva guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la reserva", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
