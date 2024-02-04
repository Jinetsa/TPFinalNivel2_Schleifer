using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select a.Codigo, a.Nombre, a.Descripcion, a.Precio, a.ImagenUrl, c.Descripcion Categoria, m.Descripcion Marca from ARTICULOS A, CATEGORIAS C, MARCAS M where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marca(); 
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];


                    lista.Add(aux); 
                }


                datos.cerrarConexion();
                return lista;

            }
            catch (Exception ex)
            {

                throw;
            }

         }

        public void agregar(Articulo nuevo)
        {

        }

        public void modificar (Articulo modificar)
        {
        
        }


    }
}
