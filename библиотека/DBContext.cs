using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classlibrary;

namespace библиотека
{
    public class DBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Special> Specials { get; set; }
        public DbSet<Group> Groups { get; set; }
        
        
    }
}
