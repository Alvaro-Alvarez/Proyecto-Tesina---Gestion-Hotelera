using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTesinaVersion2.Clases.Entidades
{
    public class Consumicion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public Consumicion() { }
        public Consumicion(int pId, string pNombre, string pPrecio)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Precio = pPrecio;
        }
    }
}
