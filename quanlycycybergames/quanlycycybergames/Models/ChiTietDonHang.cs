
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quanlycycybergames.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public string MaDH { get; set; }
        public string ID_DV { get; set; }
        public string soluong { get; set; }
        public Nullable<decimal> tongGia { get; set; }
    
        public virtual DichVu DichVu { get; set; }
        public virtual DonHang DonHang { get; set; }
    }
}
