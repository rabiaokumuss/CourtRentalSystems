using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KortKiralamaOdevi.Models.dbEntities
{
    public class KortGunlukUcret
    {
        public int ID { get; set; }
        public int FKKortID { get; set; }
        public DayOfWeek Gun { get; set; }

        [ForeignKey("FKKortID")]
        public virtual Kort Kort { get; set; }
    }
}