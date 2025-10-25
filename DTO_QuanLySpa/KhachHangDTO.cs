using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DTO_QuanLySpa
{
    public class KhachHangDTO
    {
        //thuoc tinh...
        public List<string> MaDichVuSuDung { get; set; }
        [XmlIgnore]
        //Tiện cho bài 8.9 -> Chỉ cần in kh.DichVuSuDung.Count > 3 
        public List<DichVuDTO> DichVuSuDung { get; set; }

        public KhachHangDTO()
        {
            MaDichVuSuDung = new List<string>();
            DichVuSuDung = new List<DichVuDTO>();
        }
        //public override string ToString()
        //{
        //    return $"[{MaKH}] {TenKH} (SĐT: {SDT})";
        //}
    }
}
