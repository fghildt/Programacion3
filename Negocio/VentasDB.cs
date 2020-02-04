using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class VentasDB
    {
        public IList<Venta> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Venta> listaventas = new List<Venta>();

            try
            {
                conexion.setearConsulta("SELECT IDVENTA,PREFIJOFC,NROFC,TIPOFC,FECHA,IDCLIENTE FROM VENTAS");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Venta aux = new Venta();

                    aux.IdVenta = conexion.Lector.GetInt32(0);
                    aux.PrefijoFc = conexion.Lector.GetInt32(1);
                    aux.Factura = conexion.Lector.GetInt32(2);
                    aux.idTipoFC = conexion.Lector.GetInt32(3);
                    aux.Fecha = conexion.Lector.GetDateTime(4);
                    aux.IdCliente = conexion.Lector.GetInt32(5);

                    listaventas.Add(aux);
                }
                return listaventas;

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

        public int UltimaVenta(int tipofc)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT ULTIMAFCVENTA FROM TIPOFC WHERE IDTIPOFC=";
            try
            {
                consulta += tipofc;
                int ultimaventa = 0;
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                if (conexion.Lector.Read())
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

        public void ActualizarUltimaVenta(Venta venta)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE TIPOFC SET ULTIMAFCVENTA=";
            try
            {
                consulta += venta.Factura.ToString() + " WHERE IDTIPOFC=" + venta.idTipoFC.ToString();

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

        public void Agregar(Venta ventaNueva)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SET DATEFORMAT 'DMY' INSERT INTO VENTAS(NROFC,TIPOFC,FECHA,IDCLIENTE) VALUES (";
            try
            {
                consulta += ventaNueva.Factura.ToString() + ",";
                consulta += ventaNueva.idTipoFC.ToString() + ",'";
                consulta += ventaNueva.Fecha.ToShortDateString() + "',";
                consulta += ventaNueva.IdCliente.ToString() + ")";

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

        public int UltimoIdVenta()
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "SELECT MAX(IDVENTA) FROM VENTAS";
            try
            {
                int ultimaventa = 0;
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                if (conexion.Lector.Read())
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
    }
}
