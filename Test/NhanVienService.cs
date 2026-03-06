using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class NhanVienService
    {
        public string SuaNhanVien(NhanVien nv)
        {
            if(string.IsNullOrEmpty(nv.MaNV) ||
                 string.IsNullOrEmpty(nv.Ten)||
                string.IsNullOrEmpty(nv.PhongBan)
                )
            {
                return "Không được để trống";
            }
            if(nv.tuoi < 18 || nv.tuoi > 60)
            {
                return "Tuổi từ 18 đến 60";
            }
            return "Sửa nhân viên thành công";
        }
    }
}
