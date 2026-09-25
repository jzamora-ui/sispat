using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Entities
{
    public class permisos_roles
    {
        public int id { get; set; }
        public int rol_id { get; set; }
        public int permiso_id { get; set; }

        public permisos_roles()
        {
            this.id = 0;
            this.rol_id = 0;
            this.permiso_id = 0;
        }
    }
}