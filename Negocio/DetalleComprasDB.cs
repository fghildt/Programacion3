using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DetalleComprasDB
    {

        public IList<DetalleCompras> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<DetalleCompras> listadetallecompras = new List<DetalleCompras>();

            try
            {
                conexion.setearConsulta("SELECT ID,IDPRODUCTO,CANTIDAD,NROCOMPRA, PRECIO AS PRECIOCOMPRA FROM DETALLECOMPRAS");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {

                    DetalleCompras aux = new DetalleCompras();

                    aux.IdDetalle = conexion.Lector.GetInt32(0);
                    aux.IdProducto = conexion.Lector.GetInt32(1);
                    aux.Cantidad = conexion.Lector.GetInt32(2);
                    aux.IdCompra = conexion.Lector.GetInt32(3);
                    aux.Precio = conexion.Lector.GetDouble(4);
                    

                    listadetallecompras.Add(aux);
                }
                return listadetallecompras;

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

        public void Agregar(DetalleCompras detalleCompras)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO DETALLECOMPRAS (IDCOMPRA,IDPRODUCTO,CANTIDAD,PRECIO) VALUES (";
            try
            {
                consulta += detalleCompras.IdCompra + ", ";
                consulta += detalleCompras.IdProducto + ", ";
                consulta += detalleCompras.Cantidad + ", ";
                consulta += detalleCompras.Precio.ToString() + ")";

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

        public void Eliminar(int idCompra)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM DETALLECOMPRAS WHERE NROCOMPRA = '" + idCompra.ToString() + "'";

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
