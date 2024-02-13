using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace negocio
{
    public class ArticuloNegocio
        {
        private AccesoDatos datos = new AccesoDatos();
        public List<Articulo> listarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, a.ImagenUrl, a.IdMarca, a.IdCategoria, c.Descripcion Categoria, m.Descripcion Marca from ARTICULOS A, CATEGORIAS C, MARCAS M where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.codArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    //Validacion en caso de que la imagen en DB sea null
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];



                    articulos.Add(aux);
                }
                return articulos;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }


        public void agregar(Articulo nuevo) //Originalmmente en accesodatos 
        {
                try
                {
                    datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca,@IdCategoria, @ImagenUrl, @Precio)");
                    datos.setearParametros("@Codigo", nuevo.codArticulo);
                    datos.setearParametros("@Nombre", nuevo.Nombre);
                    datos.setearParametros("@Descripcion", nuevo.Descripcion);
                    datos.setearParametros("@IdMarca", nuevo.Marca.Id);
                    datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                    datos.setearParametros("@ImagenUrl", nuevo.ImagenUrl);
                    datos.setearParametros("@Precio", nuevo.Precio);

                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally { datos.cerrarConexion();}
        }

        public void modificar (Articulo modificar)
        {
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, ImagenUrl = @ImagenUrl, IdMarca = @IdMarca, IdCategoria = @IdCategoria where id = @Id");
                datos.setearParametros("@Id", modificar.Id);
                datos.setearParametros("@Codigo", modificar.codArticulo);
                datos.setearParametros("@Nombre", modificar.Nombre);
                datos.setearParametros("@Descripcion", modificar.Descripcion);
                datos.setearParametros("@IdMarca", modificar.Marca.Id);
                datos.setearParametros("@IdCategoria", modificar.Categoria.Id);
                datos.setearParametros("@ImagenUrl", modificar.ImagenUrl);
                datos.setearParametros("@Precio", modificar.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public void eliminar(int id){
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                datos.setearParametros("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Articulo> filtrar(int marca, int categoria, string cboRangoPrecio, string precio)
        {
            string consulta = "select a.Id, a.Codigo, a.Nombre, a.Descripcion, a.Precio, a.ImagenUrl, a.IdMarca, a.IdCategoria, c.Descripcion Categoria, m.Descripcion Marca from ARTICULOS A, CATEGORIAS C, MARCAS M where a.IdMarca = m.Id and a.IdCategoria = c.Id and ";
            List<Articulo> lista = new List<Articulo> ();
            try
            {
                consulta += "m.Id = " + marca;
                consulta += " and c.Id = " + categoria;
                if (cboRangoPrecio == "Desde")
                    consulta += " and a.Precio > " + precio;
                else
                    consulta += " and a.Precio < " + precio;

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.codArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    //Validacion en caso de que la imagen en DB sea null
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];

                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }

            return lista; 
        }
    }
}
