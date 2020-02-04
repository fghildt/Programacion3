using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProveedoresDB
    {
        public IList<Proveedor> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Proveedor> listaproveedores = new List<Proveedor>();

            try
            {
                conexion.setearConsulta("SELECT CUIT, MAIL, NOMBRE_APELLIDO, TELEFONO, DIRECCION, ID FROM PROVEEDORES");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Proveedor aux = new Proveedor();
                    aux.Cuit = conexion.Lector.GetString(0);
                    aux.Mail = conexion.Lector.GetString(1);
                    aux.NombreApellido = conexion.Lector.GetString(2);
                    aux.Telefono = conexion.Lector.GetString(3);
                    aux.Direccion = conexion.Lector.GetString(4);
                    aux.Id = conexion.Lector.GetInt32(5);

                    listaproveedores.Add(aux);
                }
                return listaproveedores;

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

        public void Agregar(Proveedor proveedorNuevo)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO PROVEEDORES (CUIT, NOMBRE_APELLIDO, MAIL, DIRECCION, TELEFONO) VALUES ('";
            try
            {
                consulta += proveedorNuevo.Cuit + "','";
                consulta += proveedorNuevo.NombreApellido + "','";
                consulta += proveedorNuevo.Mail + "','";
                consulta += proveedorNuevo.Direccion + "','";
                consulta += proveedorNuevo.Telefono + "')";

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

        public void Eliminar(int idProv)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM PROVEEDORES WHERE ID = " + idProv;
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

        public void Modificar(Proveedor prov)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE PROVEEDORES SET CUIT=@cuit, NOMBRE_APELLIDO=@nombre, MAIL=@mail, TELEFONO=@tel, DIRECCION=@direccion WHERE ID=@id";
            try
            {
                conexion.limpiarParametros();

                conexion.agregarParametro("@cuit", prov.Cuit);
                conexion.agregarParametro("@nombre", prov.NombreApellido);
                conexion.agregarParametro("@mail", prov.Mail);
                conexion.agregarParametro("@tel", prov.Telefono);
                conexion.agregarParametro("@direccion", prov.Direccion);
                conexion.agregarParametro("@id", prov.Id.ToString());

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
