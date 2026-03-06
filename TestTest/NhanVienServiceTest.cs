using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace TestTest
{
    [TestFixture]
    public class NhanVienServiceTest
    {
        private NhanVienService nhanVienService;
        [SetUp]
        public void Setup()
        {
            nhanVienService = new NhanVienService();
        }
        [Test]
        public void Test_suaThanhCong()
        {
            NhanVien nv = new NhanVien
            {
                MaNV = "NV01",
                Ten = "Long",
                tuoi = 21,
                Luong = 5000,
                soNamLamViec = 2,
                PhongBan = "IT"
            };
            var result = nhanVienService.SuaNhanVien(nv);
            Assert.That(result, Is.EqualTo("Sửa nhân viên thành công"));
        }
        [Test]
        public void Test_MaNv_Rong()
        {
            NhanVien nv = new NhanVien
            {
                MaNV = "",
                Ten = "Long",
                tuoi = 21,
                Luong = 5000,
                soNamLamViec = 2,
                PhongBan = "IT"
            };
            var result = nhanVienService.SuaNhanVien(nv);
            Assert.That(result, Is.EqualTo("Không được để trống"));
        }
        [Test]
        public void Test_TenNv_Rong()
        {
            NhanVien nv = new NhanVien
            {
                MaNV = "NV01",
                Ten = "",
                tuoi = 21,
                Luong = 5000,
                soNamLamViec = 2,
                PhongBan = "IT"
            };
            var result = nhanVienService.SuaNhanVien(nv);
            Assert.That(result, Is.EqualTo("Không được để trống"));
        }
        [Test]
        public void Test_Tuoi_NhoHon18()
        {
            NhanVien nv = new NhanVien
            {
                MaNV = "NV01",
                Ten = "Long",
                tuoi = 17,
                Luong = 5000,
                soNamLamViec = 2,
                PhongBan = "IT"
            };
            var result = nhanVienService.SuaNhanVien(nv);
            Assert.That(result, Is.EqualTo("Tuổi từ 18 đến 60"));
        }
        [Test]
        public void Test_Tuoi_LonHon60()
        {
            NhanVien nv = new NhanVien
            {
                MaNV = "NV01",
                Ten = "Long",
                tuoi = 61,
                Luong = 5000,
                soNamLamViec = 2,
                PhongBan = "IT"
            };
            var result = nhanVienService.SuaNhanVien(nv);
            Assert.That(result, Is.EqualTo("Tuổi từ 18 đến 60"));
        }
    }
}
