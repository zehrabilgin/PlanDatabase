﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanDatabase.Models
{
    public class Kisi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string KullaniciAdi { get; set; }
        public IList<Plan> Planlar { get; set; }

    }
}
