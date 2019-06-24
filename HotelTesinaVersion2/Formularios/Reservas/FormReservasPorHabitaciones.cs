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

namespace HotelTesinaVersion2.Formularios.Reservas
{
    public partial class FormReservasPorHabitaciones : Form
    {
        public FormReservasPorHabitaciones()
        {
            InitializeComponent();
            cboboxHabitacion.DataSource = HabitacionDAL.TraeHabitaciones();
            cboboxHabitacion.DisplayMember = "num_habitacion";
            cboboxHabitacion.ValueMember = "id";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }

        private void btnBuscarIngreso_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReservaDAL.TraerReservasPorHabitacionPorFechasIngreso(Convert.ToInt32(cboboxHabitacion.SelectedValue),dateTimePicker1.Text,dateTimePicker2.Text);
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReservaDAL.TraerReservasPorHabitacionPorFechasSalida(Convert.ToInt32(cboboxHabitacion.SelectedValue), dateTimePicker1.Text, dateTimePicker2.Text);
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReservaDAL.TraerReservasPorHabitacionPorFechasReserva(Convert.ToInt32(cboboxHabitacion.SelectedValue), dateTimePicker1.Text, dateTimePicker2.Text);
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
