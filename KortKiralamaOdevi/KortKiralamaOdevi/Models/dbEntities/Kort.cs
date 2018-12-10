using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KortKiralamaOdevi.Models.dbEntities
{
    public class Kort
    {
        public Kort()
        {
            GunlukKortUcretleri = new HashSet<KortGunlukUcret>();
        }
        public int ID { get; set; }
        public string KortAdi { get; set; }
        public virtual ICollection<KortGunlukUcret> GunlukKortUcretleri { get; set; }
    }
}