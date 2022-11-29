using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IKhuyenMaiService
    {
        bool AddKhuyenMai(KhuyenMai khuyenMai);

        bool DeleteKhuyenMai(KhuyenMai khuyenMai);

        bool UpdateKhuyenMai(KhuyenMai khuyenMai);

        List<KhuyenMai> GetKhuyenMaiFromDB();

    }
}
