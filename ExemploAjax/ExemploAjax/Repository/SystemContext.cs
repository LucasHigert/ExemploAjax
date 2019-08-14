using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SystemContext : DbContext
    {
        public SystemContext() : base("SqlServerConnection")
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }





    }
}
