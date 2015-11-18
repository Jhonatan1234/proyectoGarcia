using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace proyecto
{
    public class empleado
    {
        [Key]public int idempleado { get; set; }
        public String nombre { get; set; }
        public String Apellido { get; set; }
        public int cedula { get; set; }
        public String telefono { get; set; }
        public String direccion{ get; set; }
        public String codigo { get; set; }
        public String genero { get; set; }
       
    }
}
