using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Web;

namespace KortKiralamaOdevi.Models.dbEntities
{
    public class Rezervasyon
    {
        public int ID { get; set; }
        public string FKUyeID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int FKKortID { get; set; }
        public int FKOdemeID { get; set; }
        public EnumRezervasyonDurumu EnumRezervasyonDurumu { get; set; }


        [ForeignKey("FKKortID")]
        public virtual Kort Kort { get; set; }

        [ForeignKey("FKUyeID")]
        public virtual ApplicationUser Uye { get; set; }
        [ForeignKey("FKOdemeID")]
        public virtual Odeme Odeme { get; set; }

    }
}