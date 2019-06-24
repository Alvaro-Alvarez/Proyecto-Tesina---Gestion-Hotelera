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
    public partial class FormTodasLasConsumicionesPorHabitaciones : Form
    {
        public FormTodasLasConsumicionesPorHabitaciones()
        {
            InitializeComponent();
            dataGridView1.DataSource = ConsumicionDAL.TraerTodasConsumicionesPorHabitaciones();
            dataGridView1.Columns["id"].Visible = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ConsumicionDAL.TraerTodaslasConsumicionesPorHabitacionesPorFechas(dateTimePicker1.Text, dateTimePicker2.Text);
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
