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
    public class HabitacionDAL
    {
        public static int Agregar(Habitacion pHabitacion)
        {
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into habitaciones (id, num_habitacion, estado, precio,tipo_de_habitacion_id) values ('{0}','{1}','{2}','{3}','{4}')",
                pHabitacion.codigo, pHabitacion.NumHabitacion, pHabitacion.Estado, pHabitacion.Precio, pHabitacion.IdTipoHabitacion), conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
            }

            return retorno;
        }

        public static int Actualizar(Habitacion pHabitacion)
        {
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            int retorno = 0;
            try
            {
                MySqlConnection Conexion = conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(string.Format("Update habitacion set num_habitacion='{0}',estado='{1}',precio='{2}',tipo_de_habitacion_id='{3}' where id={4}", pHabitacion.NumHabitacion, pHabitacion.Estado, pHabitacion.Precio, pHabitacion.IdTipoHabitacion, pHabitacion.codigo), Conexion);
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
                MySqlCommand comando = new MySqlCommand(string.Format("Delete From habitaciones where id={0}", pId), Conexion);
                retorno = comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
            }
            return retorno;
        }
        public static DataTable TraeHabitaciones()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT h.id, h.num_habitacion, h.estado, h.precio, th.tipo, th.num_ambientes FROM habitaciones h INNER JOIN tipo_de_habitaciones th on h.tipo_de_habitacion_id= th.id";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
        //

        public static DataTable TraerTipoHabitaciones()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT id, tipo,num_ambientes from tipo_de_habitaciones";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }

        public static DataTable TraerHabitacionesDisponibles(string pFecha1, string pFecha2)
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT h.id, CONCAT(h.num_habitacion, ' ' ,th.tipo ) as habitacion from habitaciones h INNER join tipo_de_habitaciones th on h.tipo_de_habitacion_id=th.id where h.id NOT IN( SELECT r.Habitaciones_id from reservas r WHERE r.fecha_ingreso BETWEEN '" + pFecha1 + "' AND '" + pFecha2 + "'  OR r.fecha_salida BETWEEN '" + pFecha1 + "' AND '" + pFecha2 + "')";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
    }


}
