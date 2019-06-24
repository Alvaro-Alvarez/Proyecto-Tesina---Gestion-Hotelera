using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HotelTesinaVersion2.Clases.DAL;

namespace HotelTesinaVersion2.Formularios.ConsumicionesPorHabitaciones
{
    public partial class FormEliminarConsumicionPorHabitacion : Form
    {
        public FormEliminarConsumicionPorHabitacion()
        {
            InitializeComponent();
            dataGridViewConsumiciones.DataSource = ConsumicionPorHabitacionDAL.TraerConsumicionesPorHabitacion();
            dataGridViewConsumiciones.Columns["id"].Visible = false;
        }

        private void btnEliminarConsumicion_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewConsumiciones.CurrentRow;
            int idconsumicion = Convert.ToInt32(row.Cells["id"].Value);


            try
            {
                if (MessageBox.Show("Esta Seguro que desea eliminar el cliente Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ConsumicionPorHabitacionDAL.Eliminar(idconsumicion);
                    MessageBox.Show("Cliente Eliminado Correctamente!", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException )
            {


                MessageBox.Show("error ")  ;
            }
            dataGridViewConsumiciones.DataSource = ConsumicionPorHabitacionDAL.TraerConsumicionesPorHabitacion();
            dataGridViewConsumiciones.Columns["id"].Visible = false;


        }
    }
}
