using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sispat.Models.Utils
{
    public class response
    {
        public int no_error { get; set; }
        public string mensaje { get; set; }
        public object _obj { get; set; }

        public response()
        {
            this.no_error = 0;
            this.mensaje = string.Empty;
        }
    }
}