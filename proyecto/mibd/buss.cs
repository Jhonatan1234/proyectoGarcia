using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Collections;
using proyecto.mibd;



namespace proyecto
{
    public class buss
    {
        [Key] public int idbus {get;set;}
        public String clase_bus {get; set;}
        public String marca_bus { get; set; }
        public String color_bus { get; set; }
      
        public virtual ICollection<boleto> boletos { get; set; }


    }
}
