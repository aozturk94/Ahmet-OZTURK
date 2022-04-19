using System;
using System.Collections.Generic;

#nullable disable

namespace myEntityFrameWorkProject_01.Models
{
    public partial class TblUyeler
    {
        public TblUyeler()
        {
            TblOduncs = new HashSet<TblOdunc>();
        }

        public int Id { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public string UyeTc { get; set; }
        public string UyeTel { get; set; }
        public string UyeMail { get; set; }

        public virtual ICollection<TblOdunc> TblOduncs { get; set; }
    }
}
