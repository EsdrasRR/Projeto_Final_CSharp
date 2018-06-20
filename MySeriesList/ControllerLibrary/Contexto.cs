using ModelLibrary;
using System.Collections.Generic;
using System.Data.Entity;

namespace ControllerLibrary
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            
        }
        public DbSet<Serie> Series { get; set; }

    }


}
}
