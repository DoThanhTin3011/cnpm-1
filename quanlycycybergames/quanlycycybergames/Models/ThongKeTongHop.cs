using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace quanlycycybergames.Models
{
    public class ThongKeTongHop
    {
        [Display(Name = "Ngày thống kê")]
        public DateTime NgayThongKe { get; set; }

        [Display(Name = "Tổng doanh thu đơn hàng")]
        public decimal TongDoanhThuDonHang { get; set; }

        [Display(Name = "Tổng tiền đã nạp")]
        public decimal TongSoTienNap { get; set; }

        [Display(Name = "Tổng tích lũy")]
        public decimal TongCongTichLuy { get; set; }
    }
}