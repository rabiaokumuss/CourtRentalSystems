using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KortKiralamaOdevi.Models.dbEntities
{
    public class Odeme
    {
        public int ID { get; set; }
        public double OdenecekTutar { get; set; }
        public bool OdendiMi { get; set; }
    }
}