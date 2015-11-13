using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace proyecto
{
    public class inicio :DbContext{
    
        public DbSet <ejemplo> ejemplos { get; set; }
    }
}
