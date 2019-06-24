using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace HotelTesinaVersion2.Clases.DAL
{
    public class ConnectionBaseDatos
    {
        public MySqlConnection ObtenerConexion()
        {
            
            
           MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=hoteltesina; Uid=root; pwd=;");
            conectar.Open();
            return conectar;
        }
        public void desconectar()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=hoteltesina; Uid=root; pwd=;");

            conectar.Close();
        }
    }
}
