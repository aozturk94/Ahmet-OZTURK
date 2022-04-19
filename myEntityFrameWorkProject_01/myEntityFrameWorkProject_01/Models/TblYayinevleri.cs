using System;
using System.Collections.Generic;

#nullable disable

namespace myEntityFrameWorkProject_01.Models
{
    public partial class TblYayinevleri
    {
        public TblYayinevleri()
        {
            TblKitaplars = new HashSet<TblKitaplar>();
        }

        public int Id { get; set; }
        public string YayineviAd { get; set; }
        public string YayineviAdres { get; set; }
        public string YayineviTel { get; set; }

        public virtual ICollection<TblKitaplar> TblKitaplars { get; set; }
    }
}
