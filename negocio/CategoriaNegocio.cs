using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace negocio
{
    public class CategoriaNegocio
    {
        List <Categoria> categorias = new List<Categoria> ();
        AccesoDatos datos = new AccesoDatos ();
        public List<Categoria> listaCategorias() 
            
        {
            datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                Categoria aux = new Categoria();
                aux.Id = (int)datos.Lector["Id"];
                aux.Descripcion = (string)datos.Lector["Descripcion"];
            }

            datos.cerrarConexion();
            return listaCategorias();
        }
    }
}
