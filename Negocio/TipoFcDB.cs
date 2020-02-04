using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class TipoFcDB
    {
        public IList<TipoFC> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<TipoFC> tipoFCs = new List<TipoFC>();

            try
            {
                conexion.setearConsulta("SELECT IDTIPOFC,TIPO FROM TIPOFC");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    TipoFC aux = new TipoFC();

                    aux.idTipoFC = conexion.Lector.GetInt32(0);
                    aux.TipoFc = conexion.Lector.GetString(1);

                    tipoFCs.Add(aux);
                }
                return tipoFCs;

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
