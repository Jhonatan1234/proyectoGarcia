using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace proyecto
{
    public class demoEF : DbContext
    {
        public DbSet <buss> BUS { get; set; }
        public DbSet <chofer> choferes { get; set; }
        public  DbSet <pasajero> pasajeros { get; set; }
<<<<<<< HEAD
         public  DbSet <empleado> Empleados { get; set; }
        
=======
         public  DbSet <empleado> Empleados { get; set;}
>>>>>>> 0167a154b7e1d58f8a3b62208573bc180b217c77
    }
}
