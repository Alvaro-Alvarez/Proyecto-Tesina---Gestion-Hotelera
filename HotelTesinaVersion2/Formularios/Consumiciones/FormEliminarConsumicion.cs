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
namespace HotelTesinaVersion2.Formularios.Consumiciones
{
    public partial class FormEliminarConsumicion : Form
    {
        public FormEliminarConsumicion()
        {
            InitializeComponent();
            comboBox1.DataSource = ConsumicionDAL.TraerConsumicionesNombreyPrecio();
            comboBox1.DisplayMember = "Consumicion";
            comboBox1.ValueMember = "id";
        }

        private void btnAgregarConsumicion_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Esta Seguro que desea eliminar la Consumicion Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ConsumicionDAL.Eliminar(Convert.ToInt32(comboBox1.SelectedValue)) > 0)
                {
                    MessageBox.Show("Consumicion Eliminado Correctamente!", "Consumicion Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la Consumicion", "Consumicion No Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
