using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class estructura
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int meta { get; set; }

        public estructura()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.meta = 0;
        }
    }
}