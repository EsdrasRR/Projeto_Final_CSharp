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
        public ISet<Serie> Series { get; set; }

    }


}
}
