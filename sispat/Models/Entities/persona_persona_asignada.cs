using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class persona_persona_asignada
    {
        public int id { get; set; }
        public int persona_id { get; set; }
        public int perona_id_ganada { get; set; }

        public persona_persona_asignada()
        {
            this.id = 0;
            this.persona_id = 0;
            this.perona_id_ganada = 0;
        }
    }
}