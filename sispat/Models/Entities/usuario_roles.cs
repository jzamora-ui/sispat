using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class usuario_roles
    {
        public int id { get; set; }
        public int usuario_id { get; set; }
        public int rol_id { get; set; }

        public usuario_roles()
        {
            this.id = 0;
            this.usuario_id = 0;
            this.rol_id = 0;
        }
    }
}