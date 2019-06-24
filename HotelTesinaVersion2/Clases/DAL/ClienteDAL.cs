using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using HotelTesinaVersion2.Clases.Entidades;

namespace HotelTesinaVersion2.Clases.DAL
{
    public class ClienteDAL
    {
        public static int Agregar(Cliente pCliente)
        {
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Insert into clientes (id, nombre, apellido, dni, domicilio, sexo, telefono, mail) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                pCliente.Id, pCliente.Nombre, pCliente.Apellido, pCliente.Dni, pCliente.Domicilio, pCliente.Sexo, pCliente.Telefono, pCliente.Mail), conexion.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
            }

            return retorno;
        }
        public static int Actualizar(Cliente pCliente)
        {
            ConnectionBaseDatos conexion = new ConnectionBaseDatos();
            int retorno = 0;
            try
            {
                MySqlConnection Conexion = conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(string.Format("Update clientes set nombre='{0}',apellido='{1}',dni='{2}',domicilio='{3}',sexo='{4}',telefono='{5}',mail='{6}' where id={7}", pCliente.Nombre, pCliente.Apellido, pCliente.Dni, pCliente.Domicilio, pCliente.Sexo, pCliente.Telefono, pCliente.Mail, pCliente.Id), Conexion);
                retorno = comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error, actualice los datos" + e, "Error");
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
                MySqlCommand comando = new MySqlCommand(string.Format("Delete From clientes where id={0}", pId), Conexion);
                retorno = comando.ExecuteNonQuery();
                Conexion.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error" + e);
            }
            return retorno;
        }
        public static DataTable TraerClientes()
        {
            DataTable dt = new DataTable();

            ConnectionBaseDatos conexion = new ConnectionBaseDatos();

            string strmysql = @"SELECT id, CONCAT(nombre, ' ' , apellido) as Cliente, dni, domicilio, sexo, telefono, mail from clientes ";
            MySqlDataAdapter daTraer = new MySqlDataAdapter(strmysql, conexion.ObtenerConexion());
            daTraer.Fill(dt);
           
            return dt;
        }
    }
}
