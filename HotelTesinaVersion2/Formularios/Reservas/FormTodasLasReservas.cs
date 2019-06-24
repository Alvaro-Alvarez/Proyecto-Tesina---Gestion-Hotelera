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
    public partial class FormTodasLasReservas : Form
    {
        public FormTodasLasReservas()
        {
            InitializeComponent();
            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
        }

        private void btnBuscarIngreso_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReservaDAL.TraerReservasporIngreso( dateTimePicker1.Text, dateTimePicker2.Text);
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReservaDAL.TraerReservasporSALIDA(dateTimePicker1.Text,dateTimePicker2.Text);
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReservaDAL.TraerReservasporReserva(dateTimePicker1.Text,dateTimePicker2.Text);
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
