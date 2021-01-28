using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanDatabase.Models
{
    public class Saat
    {
        public int Id { get; set; }
        public int Akrep { get; set; }
        public int Yelkovan { get; set; }
        public IList<Plan> Planlar { get; set; }

    }
}
