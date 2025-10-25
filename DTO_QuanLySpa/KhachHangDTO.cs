using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLySpa
{
    public class KhachHangDTO
    {
        //code...
        public List<string> MaDichVuSuDung { get; set; }
        public List<DichVuDTO> DichVuSuDung { get; set; }
    }
}
