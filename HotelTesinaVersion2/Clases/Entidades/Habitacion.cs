using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTesinaVersion2.Clases.Entidades
{
    public class Habitacion
    {
        public int codigo { get; set; }
        public int NumHabitacion { get; set; }
        public string Estado { get; set; }
        public string Precio { get; set; }
        public int IdTipoHabitacion { get; set; }


        public Habitacion() { }
        public Habitacion(int pcodigo, int pNumHabitacion, string pEstado, string pPrecio, int pIdTipoDeHabitacion)
        {
            this.codigo = pcodigo;
            this.NumHabitacion = pNumHabitacion;
            this.Estado = pEstado;
            this.Precio = pPrecio;
            this.IdTipoHabitacion = pIdTipoDeHabitacion;
        }
    }
}
