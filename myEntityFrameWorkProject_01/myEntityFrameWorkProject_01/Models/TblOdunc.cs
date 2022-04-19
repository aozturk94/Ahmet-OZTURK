using System;
using System.Collections.Generic;

#nullable disable

namespace myEntityFrameWorkProject_01.Models
{
    public partial class TblOdunc
    {
        public int Id { get; set; }
        public int UyeId { get; set; }
        public int KitapIsbn { get; set; }
        public string OduncVerilmeTarihi { get; set; }
        public string TeslimEdilmesiGerekenTarih { get; set; }
        public string TeslimTarihi { get; set; }

        public virtual TblKitaplar KitapIsbnNavigation { get; set; }
        public virtual TblUyeler Uye { get; set; }
    }
}
