using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelTesinaVersion2.Clases.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Domicilio { get; set; }
        public string Sexo { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public Cliente() { }
        public Cliente(int pId, string pNombre, string pApellido, int pDni, string pDomicilio, string pSexo, int pTelefono, string pMail)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Dni = pDni;
            this.Domicilio = pDomicilio;
            this.Sexo = pSexo;
            this.Mail = pMail;
        }
    }
}
