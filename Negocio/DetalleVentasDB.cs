using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class DetalleVentasDB
    {
        public void Agregar(DetalleVentas detalleVentas)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO DETALLEVENTAS (NROVENTA,IDPRODUCTO,CANTIDAD,PRECIO) VALUES (";
            try
            {
                consulta += detalleVentas.IdVenta + ",";
                consulta += detalleVentas.IdProducto + ",";
                consulta += detalleVentas.Cantidad + ",";
                consulta += detalleVentas.Precio.ToString() + ")";

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
