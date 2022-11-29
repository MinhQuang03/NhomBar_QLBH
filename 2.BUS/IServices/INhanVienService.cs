using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;

namespace _2.BUS.IServices
{
    public interface INhanVienService
    {
        bool AddNhanVien(NhanVien nhanVien);
        bool UpdateNhanVien(NhanVien nhanVien);

        bool DeleteNhanVien(NhanVien nhanVien);

        List<NhanVien> GetNhanVienFromDB();


    }
}
