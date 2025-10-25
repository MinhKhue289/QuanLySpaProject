using DAL_QuanLySpa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLySpa;
namespace BLL_QuanLySpa
{
    public class QuanLySpaBLL
    {
        private QuanLySpaDAL qlDAL = new QuanLySpaDAL();
        public List<DichVuDTO> dvDTO = new List<DichVuDTO>();
        public List<KhachHangDTO> khDTO = new List<KhachHangDTO>();
        public QuanLySpaBLL()
        {
            qlDAL = new QuanLySpaDAL();
            dvDTO = new List<DichVuDTO>();
            khDTO = new List<KhachHangDTO>();
        }
        //GUI sẽ gọi hàm này để nạp dữ liệu từ file
        public void LoadData()
        {
            dvDTO = qlDAL.LoadDichVu();
            khDTO = qlDAL.LoadKhachHang();
        }
        public List<DichVuDTO> GetAllDichVu()
        {
            // Trả về danh sách Dịch Vụ mà BLL đang giữ
            return dvDTO;
        }
        public List<KhachHangDTO> GetAllKhachHang()
        {
            // Trả về danh sách Khách Hàng mà BLL đang giữ
            return khDTO;
        }
    }
}
