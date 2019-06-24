using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelTesinaVersion2.Formularios.Clientes;
using HotelTesinaVersion2.Formularios.Consumiciones;
using HotelTesinaVersion2.Formularios.ConsumicionesPorHabitaciones;
using HotelTesinaVersion2.Formularios.Habitaciones;
using HotelTesinaVersion2.Formularios.Reservas;
using System.Windows.Forms;

namespace HotelTesinaVersion2.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

      

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarCliente cliente = new FormAgregarCliente();
            cliente.Show();
            cliente.MdiParent = this;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarCliente cliente = new FormModificarCliente();
            cliente.Show();
            cliente.MdiParent = this;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarCliente cliente = new FormEliminarCliente();
            cliente.Show();
            cliente.MdiParent = this;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAgregarConsumicion consu = new FormAgregarConsumicion();
            consu.Show();
            consu.MdiParent = this;
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormModificarConsumicion consu = new FormModificarConsumicion();
            consu.Show();
            consu.MdiParent = this;
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEliminarConsumicion consu = new FormEliminarConsumicion();
            consu.Show();
            consu.MdiParent = this;

        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAgregarHabitacion habita = new FormAgregarHabitacion();
            habita.Show();
            habita.MdiParent = this;
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormModificarHabitacion habit = new FormModificarHabitacion();
            habit.Show();
            habit.MdiParent = this;
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormEliminarHabitacion habita = new FormEliminarHabitacion();
            habita.Show();
            habita.MdiParent = this;
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAgregarReserva reserva = new FormAgregarReserva();
            reserva.Show();
            reserva.MdiParent = this;
        }

        private void eliminarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormEliminarReserva reserva = new FormEliminarReserva();
            reserva.Show();
            reserva.MdiParent = this;
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormAgregarConsumicionPorHabitacion consu = new FormAgregarConsumicionPorHabitacion();
            consu.Show();
            consu.MdiParent = this;
        }

        private void eliminarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormEliminarConsumicionPorHabitacion consu = new FormEliminarConsumicionPorHabitacion();
            consu.Show();
            consu.MdiParent = this;
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTodasLasReservas reserva = new FormTodasLasReservas();
            reserva.Show();
            reserva.MdiParent = this;
        }

        private void todasLasConsumionesPorHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTodasLasConsumicionesPorHabitaciones consu = new FormTodasLasConsumicionesPorHabitaciones();
            consu.Show();
            consu.MdiParent = this;
        }

        private void consumicionesPorHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservasPorCliente reserva = new FormReservasPorCliente();
            reserva.Show();
            reserva.MdiParent = this;
        }

        private void reservasPorHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservasPorHabitaciones reserva = new FormReservasPorHabitaciones();
            reserva.Show();
            reserva.MdiParent = this;
        }

        private void consumicionesPorHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsumicionesPorHabitacion consu = new FormConsumicionesPorHabitacion();
            consu.Show();
            consu.MdiParent = this;
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVerClientes cliente = new FormVerClientes();
            cliente.Show();
            cliente.MdiParent = this;
        }

        private void consumicionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVerConsumiciones consu = new FormVerConsumiciones();
            consu.Show();
            consu.MdiParent = this;
        }

        private void habitacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVerHabitaciones habi = new FormVerHabitaciones();
            habi.Show();
            habi.MdiParent = this;
        }

        private void formaDePagoMasUsadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerFormasPago fpago = new FormVerFormasPago();
            fpago.Show();
            fpago.MdiParent = this;
        }
    }
}
