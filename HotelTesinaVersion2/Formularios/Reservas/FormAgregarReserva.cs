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

namespace HotelTesinaVersion2.Formularios.Reservas
{
    public partial class FormAgregarReserva : Form
    {
        public FormAgregarReserva()
        {
            InitializeComponent();
            datePickerReserva.Format = DateTimePickerFormat.Custom;
            datePickerReserva.CustomFormat = "yyyy-MM-dd";
            datePickerIngreso.Format = DateTimePickerFormat.Custom;
            datePickerIngreso.CustomFormat = "yyyy-MM-dd";
            datePickerSalida.Format = DateTimePickerFormat.Custom;
            datePickerSalida.CustomFormat = "yyyy-MM-dd";
            cboboxCliente.DataSource = ClienteDAL.TraerClientes();
            cboboxCliente.DisplayMember = "Cliente";
            cboboxCliente.ValueMember = "id";
          
            cboboxFormaPago.DataSource = ReservaDAL.TraerFormasDePago();
            cboboxFormaPago.DisplayMember = "tipo_de_pago";
            cboboxFormaPago.ValueMember = "id";
        }

        private void btnAgregarReserva_Click(object sender, EventArgs e)
        {
           
            Reserva reserva = new Reserva();
          
            reserva.FechaReserva = datePickerReserva.Text;
            reserva.FechaIngreso =datePickerIngreso.Text;
            reserva.FechaSalida = datePickerSalida.Text;
            reserva.IdCliente = Convert.ToInt32(cboboxCliente.SelectedValue);
            reserva.IdHabitacion = Convert.ToInt32(cboboxHabitacion.SelectedValue);
            reserva.IdFormaPago = Convert.ToInt32(cboboxFormaPago.SelectedValue);
            int resultado = ReservaDAL.Agregar(reserva);
            if (resultado > 0)
            {
                MessageBox.Show("Reserva guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar la reserva", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscarHabitacioens_Click(object sender, EventArgs e)
        {
            cboboxHabitacion.DataSource = HabitacionDAL.TraerHabitacionesDisponibles(datePickerIngreso.Text,datePickerSalida.Text);
            cboboxHabitacion.DisplayMember = "num_habitacion";
            cboboxHabitacion.ValueMember = "id";
        }

        private void FormAgregarReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
