using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUNGTAMTINHOC.TangNghiepVu;
using Oracle.DataAccess.Client;

namespace TRUNGTAMTINHOC.TangDB
{
    class HOCVIENXEMDIEMDB
    {
        public static List<HOCVIENXEMDIEM> getSutdentPoint(decimal idhv)
        {
            string query = "select h.id_hv, h.hotenhv, k.diemthi, k.diemtb, l.id_lop, m.tenmonhoc " +
                "from HOCVIEN h join KETQUALOP k on h.id_hv = k.id_hv " +
                "join LOP l on l.id_lop = k.id_lop " +
                "join MONHOC m on m.id_mh = l.id_mh " +
                "where h.id_hv = " + idhv.ToString();
            List<HOCVIENXEMDIEM> studentpoints = new List<HOCVIENXEMDIEM>();

            try
            {
                using (OracleConnection connection = new OracleConnection(TruyCapDB.ConnStr))
                {
                    connection.Open();

                    OracleCommand command = new OracleCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            HOCVIENXEMDIEM studentpoint = new HOCVIENXEMDIEM();
                            studentpoint.Idhv = reader.GetDecimal(0);
                            studentpoint.Hotenhv = reader.GetString(1);
                            studentpoint.Diemthi = reader.GetDecimal(2);
                            studentpoint.Diemtb = reader.GetDecimal(3);
                            studentpoint.Idlop = reader.GetString(4);
                            studentpoint.Tenmonhoc = reader.GetString(5);
                            studentpoints.Add(studentpoint);
                        }
                        
                    }
                    else
                    {
                        return null;
                    }

                    connection.Close();
                    reader.Dispose();
                    return studentpoints;
                }
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message); //Them using System.Windows.Forms;
            }

            return null;
        }
    }
}
