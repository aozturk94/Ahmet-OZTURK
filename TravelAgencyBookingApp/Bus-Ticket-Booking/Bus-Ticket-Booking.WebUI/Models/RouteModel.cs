using Bus_Ticket_Booking.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.WebUI.Models
{
    public class RouteModel
    {
        public int RouteId { get; set; }

        [Required(ErrorMessage = "Lütfen başlangıç noktasını seçiniz!")]
        public string StartLocation { get; set; }

        [Required(ErrorMessage = "Lütfen ilk durağı seçiniz!")]
        public string FirstStation { get; set; }

        [Required(ErrorMessage = "Lütfen ikinci durağı seçiniz!")]
        public string SecondStation { get; set; }

        [Required(ErrorMessage = "Lütfen üçüncü durağı seçiniz!")]
        public string ThirdStation { get; set; }

        [Required(ErrorMessage = "Lütfen bitiş noktasını seçiniz!")]
        public string EndLocation { get; set; }

        [Required(ErrorMessage = "Lütfen tarih seçiniz!")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Lütfen saat bilgisini giriniz!")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz!")]
        public double Price { get; set; }
        public List<City> Cities { get; set; }
    }
}
