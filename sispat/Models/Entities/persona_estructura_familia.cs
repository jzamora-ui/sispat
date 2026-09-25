using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class persona_estructura_familia
    {
        public int id { get; set; }
        public int persona_id {get;set;}
        public int estructura_id { get; set; }
        public int persona_id_padre { get; set; }

        public persona_estructura_familia()
        {
            this.id = 0;
            this.persona_id = 0;
            this.estructura_id = 0;
            this.persona_id_padre = 0;
        }
    }
}