using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class CategoriasDB
    {
        public IList<Tipo> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Tipo> listacategorias = new List<Tipo>();

            try
            {
                conexion.setearConsulta("SELECT IDCAT, CATEGORIA FROM CATEGORIAS");
                conexion.leerConsulta();

                while(conexion.Lector.Read())
                {
                    Tipo aux = new Tipo();
                    aux.Id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);

                    listacategorias.Add(aux);
                }
                return listacategorias;

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

        public void Agregar(Tipo categoriaNueva)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO CATEGORIAS (CATEGORIA) VALUES ('";
            try
            {
                consulta += categoriaNueva.Nombre + "')";

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

        public void Eliminar (int idCat)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM CATEGORIAS WHERE IDCAT = " + idCat.ToString();
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

        public void Modificar (Tipo cat)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE CATEGORIAS SET CATEGORIA=@categoria WHERE IDCAT=@idcat";
            try
            {
                conexion.limpiarParametros();

                conexion.agregarParametro("@categoria", cat.Nombre);
                conexion.agregarParametro("@idcat", cat.Id.ToString());

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
