using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class usuarios
    {
        public int id { get; set; }
        public int persona_id { get; set; }
        public string usuario { get; set; }
        public string pass { get; set; }
        public bool habilitado { get; set; }       

    }
}