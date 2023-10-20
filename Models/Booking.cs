﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingTour.Models
{
    [Table("Booking")]
    public class Booking : Common
    {
        [Key]
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public int TourID { get; set; }

        [Display(Name = "Ngày đặt")]
        public DateTime? BookingDate { get; set; }

        [Display(Name = "Số lượng người")]
        public int? NumberOfPeople { get; set; }

        [Display(Name = "Tổng tiền")]
        public decimal? TotalAmount { get; set; }

        public Tours? Tour { set; get; }

    }
}
