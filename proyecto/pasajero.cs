using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class pasajero
    {
        public String Nombre { get; set; }
        public int codigo_pasajero { get; set; }
        public String nacionalidad { get; set; }
        public String Direccion { get; set; }
        public String Destino { get; set; }
        public virtual int busscodigobus { get; set; }

    }
}
