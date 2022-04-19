using System;
using System.Collections.Generic;

#nullable disable

namespace myEntityFrameWorkProject_01.Models
{
    public partial class TblKitaplar
    {
        public TblKitaplar()
        {
            TblOduncs = new HashSet<TblOdunc>();
        }

        public int Isbn { get; set; }
        public string KitapAd { get; set; }
        public string KitapSayfaSayisi { get; set; }
        public string KitapStokAdedi { get; set; }
        public int TurId { get; set; }
        public int YazarId { get; set; }
        public int YayinEviId { get; set; }

        public virtual TblTurler Tur { get; set; }
        public virtual TblYayinevleri YayinEvi { get; set; }
        public virtual TblYazarlar Yazar { get; set; }
        public virtual ICollection<TblOdunc> TblOduncs { get; set; }
    }
}
