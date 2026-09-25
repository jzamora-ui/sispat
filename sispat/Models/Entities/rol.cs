using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public bool habilitado { get; set; }

        public rol()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.habilitado = true;
        }
    }    
}