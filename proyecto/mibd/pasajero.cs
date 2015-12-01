using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using proyecto.mibd;
namespace proyecto
{
    public class pasajero
    {
        [Key]public int idpasajero { get; set;}
        public String Nombre { get; set; }
        public String nacionalidad { get; set; }
        public String Direccion { get; set; }
        public virtual ICollection<boleto> boletos { get; set; }
    }
}
