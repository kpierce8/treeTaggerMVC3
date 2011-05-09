using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace treeTaggerMVC3.Models
{
    public class treeObservations
    {
       
        public int Id { get; set; }
        public string species { get; set; }
        public float lat { get; set; }
        public float longitude { get; set; }
        public float radius { get; set; }
        public DateTime date { get; set; }
    }
}