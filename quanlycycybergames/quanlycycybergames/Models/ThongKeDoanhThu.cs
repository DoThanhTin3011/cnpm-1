using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace quanlycycybergames.Models
{
    public class ThongKeDoanhThu
    {
        [Display(Name = "Ngày thống kế")]
        public DateTime NgayThongKe { get; set; }

        [Display(Name = "Tổng doanh thu")]
        public decimal TongDoanhThu { get; set; }
    }
}