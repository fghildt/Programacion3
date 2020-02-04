using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ClientesDB
    {
        public IList<Cliente> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Cliente> listaclientes = new List<Cliente>();

            try
            {
                conexion.setearConsulta("SELECT CUIT,MAIL,NOMBRE_APELLIDO,TELEFONO,FNAC,DIRECCION,ID FROM CLIENTES");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Cuit = conexion.Lector.GetString(0);
                    aux.Mail = conexion.Lector.GetString(1);
                    aux.NombreApellido = conexion.Lector.GetString(2);
                    aux.Telefono = conexion.Lector.GetString(3);
                    aux.Fnac = conexion.Lector.GetDateTime(4);
                    aux.Direccion = conexion.Lector.GetString(5);
                    aux.Id = conexion.Lector.GetInt32(6);
                    
                    listaclientes.Add(aux);
                }
                return listaclientes;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void Agregar(Cliente clienteNuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO CLIENTES (CUIT, NOMBRE_APELLIDO, FNAC, MAIL, DIRECCION, TELEFONO) VALUES ('";
            try
            {
                consulta += clienteNuevo.Cuit + "','";
                consulta += clienteNuevo.NombreApellido + "','";
                consulta += clienteNuevo.Fnac.ToShortDateString() + "','";
                consulta += clienteNuevo.Mail + "','";
                consulta += clienteNuevo.Direccion + "','";
                consulta += clienteNuevo.Telefono + "')";

                conexion.setearConsulta(consulta);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void Eliminar (int idClie)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM CLIENTES WHERE ID = " + idClie.ToString();
                conexion.setearConsulta(consulta);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void Modificar(Cliente clie)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE CLIENTES SET CUIT=@cuit, NOMBRE_APELLIDO=@nombre, FNAC=@fnac,MAIL=@mail, TELEFONO=@tel, DIRECCION=@direccion WHERE ID=@id";
            try
            {
                conexion.limpiarParametros();

                conexion.agregarParametro("@cuit", clie.Cuit);
                conexion.agregarParametro("@nombre", clie.NombreApellido);
                conexion.agregarParametro("@fnac", clie.Fnac.ToShortDateString());
                conexion.agregarParametro("@mail", clie.Mail);
                conexion.agregarParametro("@tel", clie.Telefono);
                conexion.agregarParametro("@direccion", clie.Direccion);
                conexion.agregarParametro("@id", clie.Id.ToString());

                conexion.setearConsulta(consulta);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
    }
}
