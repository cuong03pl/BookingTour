﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace BookingTour.Models
{

    [Table("Tours")]
    public class Tours
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên chuyến du lịch")]
        [Required( ErrorMessage ="Bắt buộc phải nhập tên chuyến du lịch")]
        public string Name { get; set; }

        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        [Display(Name = "Đánh giá")]
        [Range(0, 5, ErrorMessage ="Nhập dánh giá từ 0 đến 5 sao")]
        public int? Rate { get; set; }

        [Display(Name = "Giá người lớn")]
        [Required(ErrorMessage = "Bắt buộc phải nhập giá người lớn")]
        public decimal PriceAdult { get; set; }

        [Display(Name = "Giá trẻ em")]
        [Required(ErrorMessage = "Bắt buộc phải nhập giá trẻ em")]
        public decimal PriceChildren { get; set; }

        [Display(Name = "Số lượng còn lại")]
        [Required(ErrorMessage = "Bắt buộc phải nhập số lượng còn lại")]
        public int AvailableSeats { get; set; }

        [Display(Name = "Chuỗi định danh (url)", Prompt = "Nhập hoặc để trống tự phát sinh theo Title")]
        [StringLength(160, MinimumLength = 5, ErrorMessage = "{0} dài {1} đến {2}")]
        [RegularExpression(@"^[a-z0-9-]*$", ErrorMessage = "Chỉ dùng các ký tự [a-z0-9-]")]
        public string? Slug { set; get; }

        [Display(Name = "Thời gian bắt đầu")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Thời gian kết thúc")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Địa điểm")]
        public int? LocationID { get; set; }

        [ForeignKey("LocationID")]
        [Display(Name = "Địa điểm")]
        public Location? Location { set; get; }

        [Display(Name = "Hình ảnh")]
        public string? Image { set; get; }


        [Display(Name = "Thông tin khách sạn")]
        public string? HotelInfo { set; get; }

        [Display(Name = "Tên hướng dẫn viên")]
        public string? HDVName {  get; set; }

        [Display(Name = "Lịch trình")]
        public string? Schedule { get; set; }

        [Display(Name = "Ngày tập trung")]
        public DateTime? FocusDay { get; set; }

        [Display(Name = "Địa điểm tập trung")]
        public string? FocusPlace { get; set; }

        [Display(Name = "Chi tiết tour")]
        public string? Note { set; get; }

        public ICollection<ImageTour>? imgs { get; set; }

    }
}
