using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace proyecto
{
    public class pasajero
    {
        [Key]public int idpasajero { get; set;}
        public String Nombre { get; set; }
        public int codigo_pasajero { get; set; }
        public String nacionalidad { get; set; }
        public String Direccion { get; set; }
        public String Destino { get; set; }
        public virtual int bussidbus { get; set; }

    }
}
