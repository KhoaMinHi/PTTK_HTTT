using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUNGTAMTINHOC.TangNghiepVu
{
    class DangKyXemLopMonHoc
    {
        string _idlop;
        string _idmon;
        DateTime _ngaymo;
        decimal _soluong;
        decimal _siso;
        string _phonghoc;
        string _lichhoc;



        public string Idlop { get => _idlop; set => _idlop = value; }
        public string Idmon { get => _idmon; set => _idmon = value; }
        public DateTime Ngaymo { get => _ngaymo; set => _ngaymo = value; }
        public decimal Siso { get => _siso; set => _siso = value; }
        public string Phonghoc { get => _phonghoc; set => _phonghoc = value; }
        public string Lichhoc { get => _lichhoc; set => _lichhoc = value; }
        public decimal Soluong { get => _soluong; set => _soluong = value; }

        
        public static List<DangKyXemLopMonHoc> getListLopMonHoc()
        {
            List<DangKyXemLopMonHoc> lopmon = new List<DangKyXemLopMonHoc>();
            lopmon = TangDB.DangKyXemLopMonHocDB.selectListLopMon();
            return lopmon;
        }

        public static List<DangKyXemLopMonHoc> getListLopMonHocDaDangKy(string idhv)
        {
            List<DangKyXemLopMonHoc> lopmon = new List<DangKyXemLopMonHoc>();
            lopmon = TangDB.DangKyXemLopMonHocDB.selectListLopMonHocDaDangKy(idhv);
            return lopmon;
        }
    }
}
