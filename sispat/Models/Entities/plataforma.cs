using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class plataforma
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public plataforma()
        {
            this.id = 0;
            this.nombre = string.Empty;
        }
    }
}