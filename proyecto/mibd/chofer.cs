using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace proyecto
{
   public class chofer
   {
       [Key]public int idchofer { get; set; }
       public String Nombrecho {get;set;}
       public String Apellidocho { get; set; }
       public String Direccion {get;set;}
       public String tel {get;set;}
       public virtual ICollection<empleado> empleados { get; set; }
       public virtual int pasajeroidpasajero { get; set; }
    }
}
