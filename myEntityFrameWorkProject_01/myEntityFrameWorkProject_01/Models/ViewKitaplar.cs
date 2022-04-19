using System;
using System.Collections.Generic;

#nullable disable

namespace myEntityFrameWorkProject_01.Models
{
    public partial class ViewKitaplar
    {
        public int Isbn { get; set; }
        public string KitapAd { get; set; }
        public string KitapSayfaSayisi { get; set; }
        public string KitapStokAdedi { get; set; }
        public string TurAd { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public string YayineviAd { get; set; }
    }
}
