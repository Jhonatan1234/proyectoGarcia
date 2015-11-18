using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto.Migrations;
using System.ComponentModel.DataAnnotations;



namespace proyecto
{
    public class buss
    {
        [Key] public int idbus {get;set;}
        public String tipo_bus {get; set;}
        public String marca_bus {get;set;}
        public String color_bus { get; set; }
        public virtual ICollection<pasajero> pasajeros { get; set; }

    }
}
