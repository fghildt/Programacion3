using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProductosDB
    {
        public IList<Producto> Listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Producto> listaproductos = new List<Producto>();

            try
            {
                conexion.setearConsulta("SELECT PRODUCTOS.IDMARCA, PRODUCTOS.NOMBRE,PRODUCTOS.PRECIOCOMPRA,PRODUCTOS.PORCENTAJEGANANCIA, MARCAS.DESCRIPCION, PRODUCTOS.IDCATEGORIA, CATEGORIAS.CATEGORIA, PRODUCTOS.ID, PRODUCTOS.STOCK, PRODUCTOS.STOCKMIN FROM PRODUCTOS INNER JOIN MARCAS ON MARCAS.IDMARCA=PRODUCTOS.IDMARCA INNER JOIN CATEGORIAS ON CATEGORIAS.IDCAT=PRODUCTOS.IDCATEGORIA");
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Marca.Id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.PrecioCompra = conexion.Lector.GetDouble(2);
                    aux.PorcentajeGanancia = conexion.Lector.GetDouble(3);
                    aux.Marca.Nombre = conexion.Lector.GetString(4);
                    aux.Tipo.Id = conexion.Lector.GetInt32(5);
                    aux.Tipo.Nombre = conexion.Lector.GetString(6);
                    aux.IdProducto = conexion.Lector.GetInt32(7);
                    aux.Stock = conexion.Lector.GetInt32(8);
                    aux.StockMin = conexion.Lector.GetInt32(9);


                    listaproductos.Add(aux);
                }
                return listaproductos;

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

        public void Agregar(Producto producto)
        {
            AccesoDatos conexion = new AccesoDatos();
            string consulta = "INSERT INTO PRODUCTOS(IDMARCA,IDCATEGORIA,NOMBRE,PRECIOCOMPRA,PORCENTAJEGANANCIA) VALUES ('";
            try
            {
                consulta += producto.Marca.Id.ToString() + "','";
                consulta += producto.Tipo.Id.ToString() + "','";
                consulta += producto.Nombre.ToString() + "','";
                consulta += producto.PrecioCompra.ToString() + "','";
                consulta += producto.PorcentajeGanancia.ToString() + "')";

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

        public void Eliminar(int idProd)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM PRODUCTOS WHERE ID = " + idProd.ToString();
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

        public void Modificar(Producto prod)
        {

            AccesoDatos conexion = new AccesoDatos();
            string consulta = "UPDATE PRODUCTOS SET ";
            try
            {
                consulta += "IDMARCA= " + prod.Marca.Id.ToString();
                consulta += ", IDCATEGORIA= " + prod.Tipo.Id.ToString();
                consulta += ", NOMBRE = '" + prod.Nombre.ToString();
                consulta += "', PRECIOCOMPRA= " + prod.PrecioCompra.ToString().Replace(",",".");
                consulta += ", PORCENTAJEGANANCIA= " + prod.PorcentajeGanancia.ToString();
                consulta += " WHERE ID=" + prod.IdProducto.ToString();

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

        public void LevantarStock(int idProd, int cantCompra)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                string consulta = "UPDATE PRODUCTOS SET STOCK=STOCK+" + cantCompra.ToString() + " WHERE ID=" + idProd;
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

        public IList<Producto> Listar(int idProv)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Producto> listaproductos = new List<Producto>();

            try
            {

                string consulta = "SELECT PRODUCTOS.IDMARCA, PRODUCTOS.NOMBRE,PRODUCTOS.PRECIOCOMPRA,PRODUCTOS.PORCENTAJEGANANCIA, MARCAS.DESCRIPCION, PRODUCTOS.IDCATEGORIA, CATEGORIAS.CATEGORIA, PRODUCTOS.ID, PRODUCTOS.STOCK, PRODXPROV.IDPROVEEDOR FROM PRODUCTOS INNER JOIN MARCAS ON MARCAS.IDMARCA=PRODUCTOS.IDMARCA INNER JOIN CATEGORIAS ON CATEGORIAS.IDCAT=PRODUCTOS.IDCATEGORIA FULL JOIN PRODXPROV ON PRODXPROV.IDPRODUCTO=PRODUCTOS.ID WHERE PRODXPROV.IDPROVEEDOR=" + idProv.ToString();
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Marca.Id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.PrecioCompra = conexion.Lector.GetDouble(2);
                    aux.PorcentajeGanancia = conexion.Lector.GetDouble(3);
                    aux.Marca.Nombre = conexion.Lector.GetString(4);
                    aux.Tipo.Id = conexion.Lector.GetInt32(5);
                    aux.Tipo.Nombre = conexion.Lector.GetString(6);
                    aux.IdProducto = conexion.Lector.GetInt32(7);
                    aux.Stock = conexion.Lector.GetInt32(8);


                    listaproductos.Add(aux);
                }
                return listaproductos;

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

        public IList<Producto> ListarNegado(int idProv)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Producto> listaproductos = new List<Producto>();

            try
            {

                string consulta = "SELECT PRODUCTOS.IDMARCA, PRODUCTOS.NOMBRE,PRODUCTOS.PRECIOCOMPRA,PRODUCTOS.PORCENTAJEGANANCIA, MARCAS.DESCRIPCION, PRODUCTOS.IDCATEGORIA, CATEGORIAS.CATEGORIA, PRODUCTOS.ID, PRODUCTOS.STOCK FROM PRODUCTOS INNER JOIN MARCAS ON MARCAS.IDMARCA=PRODUCTOS.IDMARCA INNER JOIN CATEGORIAS ON CATEGORIAS.IDCAT=PRODUCTOS.IDCATEGORIA WHERE PRODUCTOS.ID NOT IN (SELECT PRODUCTOS.ID FROM PRODUCTOS INNER JOIN MARCAS ON MARCAS.IDMARCA=PRODUCTOS.IDMARCA INNER JOIN CATEGORIAS ON CATEGORIAS.IDCAT=PRODUCTOS.IDCATEGORIA FULL JOIN PRODXPROV ON PRODXPROV.IDPRODUCTO=PRODUCTOS.ID WHERE PRODXPROV.IDPROVEEDOR=" + idProv.ToString() + ")";
                conexion.setearConsulta(consulta);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Marca.Id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.PrecioCompra = conexion.Lector.GetDouble(2);
                    aux.PorcentajeGanancia = conexion.Lector.GetDouble(3);
                    aux.Marca.Nombre = conexion.Lector.GetString(4);
                    aux.Tipo.Id = conexion.Lector.GetInt32(5);
                    aux.Tipo.Nombre = conexion.Lector.GetString(6);
                    aux.IdProducto = conexion.Lector.GetInt32(7);
                    aux.Stock = conexion.Lector.GetInt32(8);


                    listaproductos.Add(aux);
                }
                return listaproductos;

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
