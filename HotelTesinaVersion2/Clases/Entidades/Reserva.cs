using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTesinaVersion2.Clases.Entidades
{
    public class Reserva
    {
        public int codigo { get; set; }
        public string FechaReserva { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaSalida { get; set; }
        public int IdCliente { get; set; }
        public int IdHabitacion { get; set; }
        public int IdFormaPago { get; set; }

        
        public Reserva() { }
        public Reserva(int pcodigo, string pFechaReserva, string pFechaIngreso, string pFechaSalida, int pIdCliente,int pIdHabitacion, int pIdFormaPago)
        {
            this.codigo = pcodigo;
            this.FechaReserva = pFechaReserva;
            this.FechaIngreso = pFechaIngreso;
            this.FechaSalida = pFechaSalida;
            this.IdCliente = pIdCliente;
            this.IdHabitacion=pIdHabitacion;
            this.IdFormaPago = pIdFormaPago;

        }
    }
}
