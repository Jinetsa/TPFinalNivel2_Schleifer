﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string codArticulo { get; set; }
        public string Nombre { get; set; }

        public Marca Marca { get; set; }
        [DisplayName("Precio")]
        public decimal Precio { get; set; }
        public Categoria Categoria { get; set; }

        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }

    }
}
