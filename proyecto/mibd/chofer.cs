using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using proyecto.mibd;
namespace proyecto
{
   public class chofer
   {
       [Key]public int idchofer { get; set; }
       public String Nombrecho {get;set;}
       public String Apellidocho { get; set; }
       public String Direccion {get;set;}
    

       public virtual ICollection<boleto> boletos { get; set; }

    }
}
