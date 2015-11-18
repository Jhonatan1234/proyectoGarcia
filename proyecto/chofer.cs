using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
   public class chofer
   {
       public String Nombrecho {get;set;}
       public String Apellidocho { get; set; }
       public String Direccion {get;set;}
       public String tel {get;set;}
       public virtual String pasajeroDireccion { get; set; }


    }
}
