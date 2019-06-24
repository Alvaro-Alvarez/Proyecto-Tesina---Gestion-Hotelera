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
    public partial class FormEliminarHabitacion : Form
    {
        public FormEliminarHabitacion()
        {
            InitializeComponent();
            comboBox1.DataSource = HabitacionDAL.TraeHabitaciones();
            comboBox1.DisplayMember="num_habitacion";
            comboBox1.ValueMember = "id";
        }

        private void btnEliminarHabitacion_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Esta Seguro que desea eliminar la Habitacion Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (HabitacionDAL.Eliminar(Convert.ToInt32(comboBox1.SelectedValue)) > 0)
                {
                    MessageBox.Show("Habitacion Eliminada Correctamente!", "Habitacion Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la Habitacion", "Habitacion No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
