Ở class KhachHangDTO có thêm 2 thuộc tính: 
public List<string> MaDichVuSuDung
public List<DichVuDTO> DichVuSuDung

Lý do: Ở hàm LoadData() trong class QuanLySpaBLL:
MaDichVuSuDung là phiếu quà b muốn cho giáng sinh:)
DichVuSuDung là món quà thực tế b đã nhận được
Hàm LoadData() là ông già noel với nhiệm vụ:
    +Đến kho quà (dvDTO) để lấy quà thực tế
    +và loadData() đưa quà tới cho b

Hàm LoadData() sẽ có:
    //Bước 1: Lấy danh sách DV
    dvDTO = qlDAL.LoadDichVu(); 
    
    //Bước 2: Lấy danh sách KH
    khDTO = qlDAL.LoadKhachHang();
    -> Lúc này cả hai danh sách vẫn đang là danh sách rỗng, nên việc làm những câu sau sẽ gây lỗi dù logic đúng
    Nên ta có 1 hàm so sánh và thêm vào danh sách rỗng:

    foreach (var kh in khDTO) // Lấy ra KH001
    {
        // Duyệt qua cái danh sách CHUỖI MÃ
        // kh.MaDichVuSuDung đang là ["DV001", "DV002"]
        foreach (var maDV in kh.MaDichVuSuDung) 
        {
            // với maDV = "DV001", tìm trong dvDTO (Bước 1)
            DichVuDTO dichVuDayDu = dvDTO.FirstOrDefault(dv => dv.MaDV == maDV);
            
            if (dichVuDayDu != null) // Nếu tìm thấy
            {
                // Thêm đối tượng DỊCH VỤ ĐẦY ĐỦ
                // vào danh sách DỊCH VỤ CỦA KHÁCH
                kh.DichVuSuDung.Add(dichVuDayDu);
            }
        }
    }
}