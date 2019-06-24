using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTesinaVersion2.Clases.Entidades
{
    public class ConsumicionPorHabitacion
    {
        public int Id { get; set; }
        public int IdConsumicion { get; set; }
        public int IdHabitacion { get; set; }
        public string fecha { get ;  set ; }
        public ConsumicionPorHabitacion() { }
        public ConsumicionPorHabitacion(int pId, int pIdConsumicion, int pIdHabitacion,string pFecha)
        {
            this.Id = pId;
            this.IdConsumicion = pIdConsumicion;
            this.IdHabitacion = pIdHabitacion;
            this.fecha = pFecha;
        }
    }
}
