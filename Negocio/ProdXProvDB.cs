using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProdXProvDB
    {
        public void Agregar(int idProv,int idProd)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO PRODXPROV (IDPROVEEDOR,IDPRODUCTO) VALUES(";
            try
            {
                consulta += idProv + "," + idProd + ")";

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
