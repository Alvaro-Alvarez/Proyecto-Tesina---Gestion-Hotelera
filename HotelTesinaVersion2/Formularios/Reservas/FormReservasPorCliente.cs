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
    public partial class FormReservasPorCliente : Form
    {
        public FormReservasPorCliente()
        {
            InitializeComponent();
            cboboxCliente.DataSource = ClienteDAL.TraerClientes();
            cboboxCliente.DisplayMember = "Cliente";
            cboboxCliente.ValueMember = "id";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReservaDAL.TraerReservasPorHabitacionPorCliente(Convert.ToInt32(cboboxCliente.SelectedValue));
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
