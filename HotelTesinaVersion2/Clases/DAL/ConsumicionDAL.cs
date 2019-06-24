using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using HotelTesinaVersion2.Clases.Entidades;
using System.Data;
namespace HotelTesinaVersion2.Clases.DAL
{
    public class ConsumicionDAL
    {
        public static int Agregar(Consumicion pConsumicion)
        {
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into consumiciones (id, nombre, precio) values ('{0}','{1}','{2}')",
                pConsumicion.Id, pConsumicion.Nombre, pConsumicion.Precio), conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
            }

            return retorno;
        }
        public static int Actualizar(Consumicion pConsumicion)
        {
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            int retorno = 0;
            try
            {
                MySqlConnection Conexion = conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(string.Format("Update consumicion set nombre='{0}',precio='{1}' where id={2}", pConsumicion.Nombre, pConsumicion.Precio, pConsumicion.Id), Conexion);
                retorno = comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error, actualice los datos", "Error" + e);
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
                MySqlCommand comando = new MySqlCommand(string.Format("Delete From consumiciones where id={0}", pId), Conexion);
                retorno = comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
            }
            return retorno;
        }
        public static DataTable TraerConsumicionesNombreyPrecio()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT CONCAT(nombre, ' ', precio) as Consumicion, id from consumiciones";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
        public static DataTable TraerConsumiciones()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT nombre, precio from consumiciones";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
        public static DataTable TraerConsumicionesPorHabitacion(string pfecha1, string pfecha2, int pidhabitacion)
        {
            DataTable dt = new DataTable();
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            string strmysql = @"SELECT ch.id,c.nombre, c.precio, h.num_habitacion,COUNT(c.nombre) as 'Total Consumido',c.precio*COUNT(c.nombre) as 'Total a Pagar' FROM consumiciones c INNER JOIN consumiciones_has_habitaciones ch on c.id=ch.Consumiciones_id INNER JOIN habitaciones h on h.id=ch.Habitaciones_id WHERE ch.fecha BETWEEN '" + pfecha1 + "' AND '" + pfecha2 + "' and h.id='" + pidhabitacion + "' GROUP by c.nombre";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);
            return dt;
        }
        //
        public static DataTable TraerTodasConsumicionesPorHabitaciones()
        {
            DataTable dt = new DataTable();
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            string strmysql = @"SELECT ch.id,c.nombre, c.precio, h.num_habitacion, ch.fecha FROM consumiciones c INNER JOIN consumiciones_has_habitaciones ch on c.id=ch.Consumiciones_id INNER JOIN habitaciones h on h.id=ch.Habitaciones_id ORDER BY `ch`.`fecha` DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);
            return dt;
        }

        public static DataTable TraerTodaslasConsumicionesPorHabitacionesPorFechas(string pfecha1, string pfecha2)
        {
            DataTable dt = new DataTable();
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            string strmysql = @"SELECT ch.id,c.nombre, c.precio, h.num_habitacion, ch.fecha FROM consumiciones c INNER JOIN consumiciones_has_habitaciones ch on c.id=ch.Consumiciones_id INNER JOIN habitaciones h on h.id=ch.Habitaciones_id  WHERE ch.fecha BETWEEN '" + pfecha1 + "' AND '" + pfecha2 + "' ORDER BY `ch`.`fecha` DESC ";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);
            return dt;
        }
    }
}
