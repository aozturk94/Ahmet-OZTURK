using System;
using System.Collections.Generic;

#nullable disable

namespace myEntityFrameWorkProject_01.Models
{
    public partial class TblYazarlar
    {
        public TblYazarlar()
        {
            TblKitaplars = new HashSet<TblKitaplar>();
        }

        public int Id { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public string YazarCinsiyet { get; set; }
        public string YazarDogumTarihi { get; set; }
        public string YazarTel { get; set; }
        public string YazarMail { get; set; }

        public virtual ICollection<TblKitaplar> TblKitaplars { get; set; }
    }
}
