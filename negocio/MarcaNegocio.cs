using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    internal class MarcaNegocio
    {
        List<Marca> marcas = new List<Marca>();
        AccesoDatos datos = new AccesoDatos();

        public List<Marca> listaMarcas()
        {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                }

                return listaMarcas();
        }
    }
}
