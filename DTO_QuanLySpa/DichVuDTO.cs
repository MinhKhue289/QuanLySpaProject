using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLySpa
{
    public class DichVuDTO
    {
        private string maDV;
        private string tenDV;
        private double gia;
        private string loaiDichVu;
        // Thuộc tính để lưu mã dịch vụ (ví dụ: "DV001")
        public string MaDV { get; set; }

        // Thuộc tính để lưu tên dịch vụ
        public string TenDV { get; set; }

        // Thuộc tính để lưu giá
        public double Gia { get; set; }
        public string LoaiDichVu
        {
            get { return loaiDichVu; }
            set
            {
                if (value == "ChamSocBody" || value == "DuongSinhTriLieu" || value == "ChamSocSacDep")
                {
                    loaiDichVu = value;
                }
                else
                    Console.WriteLine("Dich vu khong hop le!");
            }
        }
        public override string ToString()
        {
            return $"[{MaDV}] {TenDV} - {Gia:N0} VNĐ - (Loại: {LoaiDichVu})";
        }

    }
}
