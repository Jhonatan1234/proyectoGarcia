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
<<<<<<< HEAD
       public virtual ICollection<empleado> empleados { get; set; }
       public virtual int pasajeroidpasajero { get; set; }
=======
       public virtual String pasajeroDireccion { get; set;}
>>>>>>> 0167a154b7e1d58f8a3b62208573bc180b217c77
    }
}
