using System;
using System.Collections.Generic;

#nullable disable

namespace myEntityFrameWorkProject_01.Models
{
    public partial class TblTurler
    {
        public TblTurler()
        {
            TblKitaplars = new HashSet<TblKitaplar>();
        }

        public int Id { get; set; }
        public string TurAd { get; set; }

        public virtual ICollection<TblKitaplar> TblKitaplars { get; set; }
    }
}
