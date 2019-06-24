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
    public class ReservaDAL
    {
        public static int Agregar(Reserva pRerseva)
        {
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into reservas (id, fecha_reserva, fecha_ingreso, fecha_salida, Clientes_id,Habitaciones_id, forma_de_pago_id) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                pRerseva.codigo, pRerseva.FechaReserva, pRerseva.FechaIngreso, pRerseva.FechaSalida, pRerseva.IdCliente, pRerseva.IdHabitacion, pRerseva.IdFormaPago), conexion.ObtenerConexion());

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
                MySqlCommand comando = new MySqlCommand(string.Format("Delete From reservas where id={0}", pId), Conexion);
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
        public static DataTable TraerReservas()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT c.nombre,c.apellido,r.id,r.fecha_reserva,r.fecha_ingreso,r.fecha_salida,h.num_habitacion,h.precio,fp.tipo_de_pago,( DATEDIFF(r.fecha_salida,r.fecha_ingreso)*h.precio) as 'total a pagar' from reservas r INNER JOIN habitaciones h on r.Habitaciones_id=h.id INNER JOIN clientes c on r.Clientes_id=c.id INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id  ORDER by r.fecha_reserva DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }

        public static DataTable TraerReservasporSALIDA(string pFecha1, string pFecha2)
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT c.nombre,c.apellido,r.id,r.fecha_reserva,r.fecha_ingreso,r.fecha_salida,h.num_habitacion,h.precio,fp.tipo_de_pago,( DATEDIFF(r.fecha_salida,r.fecha_ingreso)*h.precio) as 'total a pagar' from reservas r INNER JOIN habitaciones h on r.Habitaciones_id=h.id INNER JOIN clientes c on r.Clientes_id=c.id INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id    where      r.fecha_salida BETWEEN '" + pFecha1 + "' AND '" + pFecha2 + "'     ORDER by r.fecha_salida DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }

        public static DataTable TraerReservasporIngreso(string pFecha1, string pFecha2)
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT c.nombre,c.apellido,r.id,r.fecha_reserva,r.fecha_ingreso,r.fecha_salida,h.num_habitacion,h.precio,fp.tipo_de_pago,( DATEDIFF(r.fecha_salida,r.fecha_ingreso)*h.precio) as 'total a pagar' from reservas r INNER JOIN habitaciones h on r.Habitaciones_id=h.id INNER JOIN clientes c on r.Clientes_id=c.id INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id    where      r.fecha_ingreso BETWEEN '" + pFecha1 + "' AND '" + pFecha2 + "'     ORDER by r.fecha_ingreso DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }

        public static DataTable TraerReservasporReserva(string pFecha1, string pFecha2)
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT c.nombre,c.apellido,r.id,r.fecha_reserva,r.fecha_ingreso,r.fecha_salida,h.num_habitacion,h.precio,fp.tipo_de_pago,( DATEDIFF(r.fecha_salida,r.fecha_ingreso)*h.precio) as 'total a pagar' from reservas r INNER JOIN habitaciones h on r.Habitaciones_id=h.id INNER JOIN clientes c on r.Clientes_id=c.id INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id    where      r.fecha_reserva BETWEEN '" + pFecha1 + "' AND '" + pFecha2 + "'     ORDER by r.fecha_reserva DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }


        public static DataTable TraerFormasDePago()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"select id,tipo_de_pago from forma_de_pago ";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
        public static DataTable TraerReservasPorHabitacionPorFechasIngreso( int pIdHabitacion, string pFecha1,string pFecha2)
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT c.nombre,c.apellido,r.id,r.fecha_reserva,r.fecha_ingreso,r.fecha_salida,h.num_habitacion,h.precio,fp.tipo_de_pago,( DATEDIFF(r.fecha_salida,r.fecha_ingreso)*h.precio) as 'total a pagar' from reservas r INNER JOIN habitaciones h on r.Habitaciones_id=h.id INNER JOIN clientes c on r.Clientes_id=c.id INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id WHERE  r.fecha_ingreso BETWEEN '" + pFecha1 + "' AND '" + pFecha2 + "' and h.id='" + pIdHabitacion + "' ORDER by r.fecha_ingreso DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
        public static DataTable TraerReservasPorHabitacionPorFechasSalida(int pIdHabitacion, string pFecha1, string pFecha2)
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT c.nombre,c.apellido,r.id,r.fecha_reserva,r.fecha_ingreso,r.fecha_salida,h.num_habitacion,h.precio,fp.tipo_de_pago,( DATEDIFF(r.fecha_salida,r.fecha_ingreso)*h.precio) as 'total a pagar' from reservas r INNER JOIN habitaciones h on r.Habitaciones_id=h.id INNER JOIN clientes c on r.Clientes_id=c.id INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id WHERE  r.fecha_salida BETWEEN '" + pFecha1 + "' AND '" + pFecha2 + "' and h.id='" + pIdHabitacion + "' ORDER by r.fecha_salida DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
        public static DataTable TraerReservasPorHabitacionPorFechasReserva(int pIdHabitacion, string pFecha1, string pFecha2)
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT c.nombre,c.apellido,r.id,r.fecha_reserva,r.fecha_ingreso,r.fecha_salida,h.num_habitacion,h.precio,fp.tipo_de_pago,( DATEDIFF(r.fecha_salida,r.fecha_ingreso)*h.precio) as 'total a pagar' from reservas r INNER JOIN habitaciones h on r.Habitaciones_id=h.id INNER JOIN clientes c on r.Clientes_id=c.id INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id WHERE  r.fecha_reserva BETWEEN '" + pFecha1 + "' AND '" + pFecha2 + "' and h.id='" + pIdHabitacion + "' ORDER by r.fecha_reserva DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }
        public static DataTable TraerReservasPorHabitacionPorCliente(int pIdCliente)
        {
            DataTable dt = new DataTable();
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            string strmysql = @"SELECT c.nombre,c.apellido,r.id,r.fecha_reserva,r.fecha_ingreso,r.fecha_salida,h.num_habitacion,h.precio,fp.tipo_de_pago,( DATEDIFF(r.fecha_salida,r.fecha_ingreso)*h.precio) as 'total a pagar' from reservas r INNER JOIN habitaciones h on r.Habitaciones_id=h.id INNER JOIN clientes c on r.Clientes_id=c.id INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id WHERE  c.id='" + pIdCliente + "' ORDER by r.fecha_reserva DESC";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);
            return dt;
        }
        public static DataTable TraerTotalFormaDePago()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT fp.tipo_de_pago, count(r.forma_de_pago_id) as Total from reservas r INNER JOIN forma_de_pago fp on r.forma_de_pago_id=fp.id order by fp.tipo_de_pago ";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);

            return dt;
        }

    }
}
