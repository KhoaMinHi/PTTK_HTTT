using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUNGTAMTINHOC.TangNghiepVu
{
    class MoLopMonHoc
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

        public static int openSubjectClass(MoLopMonHoc lopmon)
        {
            int result = 0;
            result = TangDB.MoLopMonHocDB.insertLopMonHoc(lopmon);
            return result;
        }

        public static List<string>getIdSubjects()
        {
            List<string> idmons = new List<string>();
            idmons = TangDB.MoLopMonHocDB.selectListIDMon();
            return idmons;
        }

        public static List<MoLopMonHoc> getListLopMonHoc()
        {
            List<MoLopMonHoc> lopmon = new List<MoLopMonHoc>();
            lopmon = TangDB.MoLopMonHocDB.selectListLopMon();
            return lopmon;
        }
    }
}
