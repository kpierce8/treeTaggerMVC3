using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace treeTaggerMVC3.Models
{
    public class treeOBSEntities : DbContext
    {
        public DbSet<treeObservations> treeOBS { get; set; }
    }
}