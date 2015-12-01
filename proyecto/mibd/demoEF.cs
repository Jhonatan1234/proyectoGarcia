using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using proyecto.mibd;
using proyecto.Migrations;
namespace proyecto
{
    public class demoEF : DbContext
    {
        public DbSet <buss> BUS { get; set; }
        public DbSet <chofer> choferes { get; set; }
        public  DbSet <pasajero> pasajeros { get; set; }

         public  DbSet <empleado> Empleados { get; set; }

         public DbSet <boleto> boletos { get; set; }
         
       

    }
}
