using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelTesinaVersion2.Clases.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
namespace HotelTesinaVersion2.Clases.DAL
{
    public class ConsumicionPorHabitacionDAL
    {
        public static int Agregar(ConsumicionPorHabitacion pConsumicionPorHabitacion)
        {
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into consumiciones_has_habitaciones (id, Consumiciones_id, Habitaciones_id, fecha) values ('{0}','{1}','{2}','{3}')",
                pConsumicionPorHabitacion.Id, pConsumicionPorHabitacion.IdConsumicion, pConsumicionPorHabitacion.IdHabitacion, pConsumicionPorHabitacion.fecha), conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
            }

            return retorno;
        }
        public static int Eliminar(int pId)
        {
            int retorno = 0;
            try
            {
                ConnectionBaseDatos conexion = new ConnectionBaseDatos();
                MySqlConnection Conexion = conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(string.Format("Delete From consumiciones_has_habitaciones where id={0}", pId), Conexion);
                retorno = comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
            }
            return retorno;
        }
        //  

        public static DataTable TraerConsumicionesPorHabitacion()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT ch.id, c.nombre, c.precio, h.num_habitacion, ch.fecha from consumiciones_has_habitaciones ch INNER JOIN consumiciones c on ch.Consumiciones_id= c.id INNER JOIN habitaciones h on ch.Habitaciones_id= h.id";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
    }
}
