using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class persona
    {
        public int id { get; set; }
        public string curp { get; set; }
        public string nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public bool habilitado { get; set; }

        public persona()
        {
            this.id = 0;
            this.curp = string.Empty;
            this.nombre = string.Empty;
            this.primer_apellido = string.Empty;
            this.segundo_apellido = string.Empty;
            this.correo = string.Empty;
            this.celular = string.Empty;
            this.habilitado = true;
        }
    }
}