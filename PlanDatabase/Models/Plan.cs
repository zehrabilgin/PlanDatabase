using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanDatabase.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Kisi Kisi { get; set; }
        public int KisiId { get; set; }

        public bool SaatliMi { get; set; }
        public Saat Saat { get; set; }

        public int SaatId { get; set; }

    }
}
