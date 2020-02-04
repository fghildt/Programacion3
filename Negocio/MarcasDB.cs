using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcasDB
    {
        public IList<Marca> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Marca> listamarcas = new List<Marca>();

            try
            {
                conexion.setearConsulta("SELECT IDMARCA, DESCRIPCION FROM MARCAS");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);

                    listamarcas.Add(aux);
                }
                return listamarcas;

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

        public void Agregar(Marca marcaNueva)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO MARCAS(DESCRIPCION) VALUES('";
            try
            {
                consulta += marcaNueva.Nombre + "')";

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

        public void Eliminar(int idMarca)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM MARCAS WHERE IDMARCA = " + idMarca.ToString();
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

        public void Modificar(Marca cat)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE MARCAS SET DESCRIPCION=@marca WHERE IDMARCA=@idmarca";
            try
            {
                conexion.limpiarParametros();

                conexion.agregarParametro("@marca", cat.Nombre);
                conexion.agregarParametro("@idmarca", cat.Id.ToString());

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
