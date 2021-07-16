using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRUNGTAMTINHOC.TangNghiepVu
{
    class HocPhi
    {
        int _id_hphi;
        int _id_hv;
        DateTime _ngaydong;
        DateTime _handong;
        Decimal _tongtien;
        string _tinhtrang;

        public int Id_hphi { get => _id_hphi; set => _id_hphi = value; } //Ctrl + r + e
        public int Id_hv { get => _id_hv; set => _id_hv = value; }
        public DateTime Ngaydong { get => _ngaydong; set => _ngaydong = value; }
        public DateTime Handong { get => _handong; set => _handong = value; }
        public Decimal Tongtien { get => _tongtien; set => _tongtien = value; }
        public string Tinhtrang { get => _tinhtrang; set => _tinhtrang = value; }

        public HocPhi() { }

        public HocPhi(int id_hphi, int id_hv, DateTime ngaydong, DateTime handong, Decimal tongtien, string tinhtrang)
        {
            Id_hphi = id_hphi;
            Id_hv = id_hv;
            Ngaydong = ngaydong;
            Handong = handong;
            Tongtien = tongtien;
            Tinhtrang = tinhtrang;
        }


        public static List<HocPhi> getHocPhi(int id_hv)
        {
            return TangDB.XemHocPhiDB.getHocPhiDB(id_hv);
        }
    }
}
