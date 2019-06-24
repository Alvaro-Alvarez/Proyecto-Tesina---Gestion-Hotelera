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
using MySql.Data.MySqlClient;
namespace HotelTesinaVersion2.Formularios.Reservas
{
    public partial class FormEliminarReserva : Form
    {
        public FormEliminarReserva()
        {
            InitializeComponent();
            dataGridView1.DataSource = ReservaDAL.TraerReservas();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            int idreserva = Convert.ToInt32(row.Cells["id"].Value);


            try
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ReservaDAL.Eliminar(idreserva);
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException)
            {


                MessageBox.Show("error ");
            }
            dataGridView1.DataSource = ReservaDAL.TraerReservas();
            dataGridView1.Columns["id"].Visible = false;


        }
    }
}
