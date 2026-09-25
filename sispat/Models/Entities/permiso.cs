using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class permiso
    {
        public int id { get; set; }
        public int plataforma_id { get; set; }
        public string nombre { get; set; }
        public permiso()
        {
            this.id = 0;
            this.plataforma_id = 0;
            this.nombre = string.Empty;
        }
    }
}