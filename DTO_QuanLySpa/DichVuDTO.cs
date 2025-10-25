using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLySpa
{
    public class DichVuDTO
    {
        private string loaiDichVu;
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
    }
}
