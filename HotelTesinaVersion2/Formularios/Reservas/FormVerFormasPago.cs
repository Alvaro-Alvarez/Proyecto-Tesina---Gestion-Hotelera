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
    public partial class FormVerFormasPago : Form
    {
        public FormVerFormasPago()
        {
            InitializeComponent();
            dataGridView1.DataSource = ReservaDAL.TraerTotalFormaDePago();
        }
    }
}
