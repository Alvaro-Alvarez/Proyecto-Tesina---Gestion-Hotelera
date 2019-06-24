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

namespace HotelTesinaVersion2.Formularios.Clientes
{
    public partial class FormVerClientes : Form
    {
        public FormVerClientes()
        {
            InitializeComponent();
            dataGridView1.DataSource = ClienteDAL.TraerClientes();
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
