using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUNGTAMTINHOC.TangNghiepVu
{
    public class HOCVIENXEMDIEM
    {
        decimal _idhv;
        string _hotenhv;
        decimal _diemthi;
        decimal _diemtb;
        string _idlop;
        string _tenmonhoc;

        public decimal Idhv { get => _idhv; set => _idhv = value; }
        public string Hotenhv { get => _hotenhv; set => _hotenhv = value; }
        public decimal Diemthi { get => _diemthi; set => _diemthi = value; }
        public decimal Diemtb { get => _diemtb; set => _diemtb = value; }
        public string Idlop { get => _idlop; set => _idlop = value; }
        public string Tenmonhoc { get => _tenmonhoc; set => _tenmonhoc = value; }

        public static List<HOCVIENXEMDIEM> getStudentPoint(decimal idhv)
        {
            
            return TangDB.HOCVIENXEMDIEMDB.getSutdentPoint(idhv);
        }
    }
}
