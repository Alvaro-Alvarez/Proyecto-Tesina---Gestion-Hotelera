using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelTesinaVersion2.Clases.DAL;
using System.Windows.Forms;

namespace HotelTesinaVersion2.Formularios.ConsumicionesPorHabitaciones
{
    public partial class FormConsumicionesPorHabitacion : Form
    {
        public FormConsumicionesPorHabitacion()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            cboboxHabitacion.DataSource = HabitacionDAL.TraeHabitaciones();
            cboboxHabitacion.DisplayMember = "num_habitacion";
            cboboxHabitacion.ValueMember = "id";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ConsumicionDAL.TraerConsumicionesPorHabitacion(dateTimePicker1.Text,dateTimePicker2.Text,Convert.ToInt32(cboboxHabitacion.SelectedValue));
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
