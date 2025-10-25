using DTO_QuanLySpa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace DAL_QuanLySpa
{
    public class QuanLySpaDAL
    {
        //KET NOI TOI DTO
        private List<DichVuDTO> dsDV = new List<DichVuDTO>();
        private List<KhachHangDTO> dsKH = new List<KhachHangDTO>();

        private string filePath = "../../Data/QuanLySpa.xml"; // DAL tự quản lý đường dẫn

        public List<DichVuDTO> DsDV { get => dsDV; set => dsDV = value; }
        public List<KhachHangDTO> DsKH { get => dsKH; set => dsKH = value; }

        public List<DichVuDTO> LoadDichVu()
        {
            // Code đọc file XML và chỉ trả về danh sách Dịch Vụ
            // ...code...
        }

        public List<KhachHangDTO> LoadKhachHang()
        {
            // Code đọc file XML và chỉ trả về danh sách Khách Hàng
            // ...code...
        }

        public void SaveData(List<DichVuDTO> dsDV, List<KhachHangDTO> dsKH)
        {
            // Code nhận 2 danh sách và ghi đè vào file XML
            // ...code...
        }
        public QuanLySpaDAL() { }
        //DOC FILE XML
    }
}
