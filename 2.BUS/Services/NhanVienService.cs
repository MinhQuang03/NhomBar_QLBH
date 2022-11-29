using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Models;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class NhanVienService : INhanVienService
    {
        private INhanVienRepository _nhanVienRepository;
        private List<NhanVien> _nhanVienList;
        public NhanVienService()
        {
            _nhanVienList = new List<NhanVien>();
            _nhanVienRepository = new NhanVienRepository();
        }
        public bool AddNhanVien(NhanVien nhanVien)
        {
            _nhanVienRepository.Add(nhanVien);
            return true;
        }

        public bool DeleteNhanVien(NhanVien nhanVien)
        {
            _nhanVienRepository.Delete(nhanVien);
            return true;
        }

        public List<NhanVien> GetNhanVienFromDB()
        {
            _nhanVienList = _nhanVienRepository.GetAllNv();
            return _nhanVienList;
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            _nhanVienRepository.Update(nhanVien);
            return true;
        }
    }
}
