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
namespace HotelTesinaVersion2.Formularios.Habitaciones
{
    public partial class FormVerHabitaciones : Form
    {
        public FormVerHabitaciones()
        {
            InitializeComponent();
            dataGridView1.DataSource = HabitacionDAL.TraeHabitaciones();
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
