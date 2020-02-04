using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ComprasDB
    {
        public IList<Compra> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Compra> listacompras = new List<Compra>();

            try
            {
                conexion.setearConsulta("SELECT IDCOMPRA,PREFIJOFC,FC,TIPOFC,FECHA,IDPROVEEDOR FROM COMPRAS");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Compra aux = new Compra();

                    aux.IdCompra = conexion.Lector.GetInt32(0);
                    aux.PrefijoFc = conexion.Lector.GetInt32(1);
                    aux.Factura = conexion.Lector.GetInt32(2);
                    aux.idTipoFC = conexion.Lector.GetInt32(3);
                    aux.Fecha = conexion.Lector.GetDateTime(4);
                    aux.IdProveedor = conexion.Lector.GetInt32(5);

                    listacompras.Add(aux);
                }
                return listacompras;

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

        public void Agregar(Compra compraNueva)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SET DATEFORMAT 'DMY' INSERT INTO COMPRAS(PREFIJOFC,FC,TIPOFC,FECHA,IDPROVEEDOR) VALUES (";
            try
            {
                consulta += compraNueva.PrefijoFc.ToString() + ",";
                consulta += compraNueva.Factura.ToString() + ",";
                consulta += compraNueva.idTipoFC.ToString() + ",'";
                consulta += compraNueva.Fecha.ToShortDateString() + "',";
                consulta += compraNueva.IdProveedor.ToString() + ")";

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

        public int UltimaCompra()
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT MAX(IDCOMPRA) FROM COMPRAS";
            try
            {
                int ultimaventa = 0;
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                if(conexion.Lector.Read())
                {
                    ultimaventa = conexion.Lector.GetInt32(0);
                }

                return ultimaventa;
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

        /*public void Eliminar(int idCompra)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM COMPRAS WHERE FC = '" + idCompra.ToString() + "'";

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
        }*/

    }
}
