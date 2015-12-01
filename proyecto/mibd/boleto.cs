using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace proyecto.mibd
{
    public class boleto
    {
        [Key]
        public int num_boleto { get; set; }
        public DateTime fecha { get; set; }
        public String Destino { get; set; }
        public int precio { get; set; }
        public virtual int idbus { get; set; }
        public virtual int idchofer {get;set;}
        public virtual int idpasajero { get; set; }
        public virtual int idempleado { get; set; }
    }
}
