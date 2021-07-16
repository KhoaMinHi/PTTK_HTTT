using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUNGTAMTINHOC.TangNghiepVu;
using System.Numerics;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace TRUNGTAMTINHOC.TangDB
{
    class XemHocPhiDB
    {
        public static List<HocPhi> getHocPhiDB(int ma_hv)
        {
            string query = "select * from hocphi where id_hv = " + ma_hv.ToString();
            List<HocPhi> hocphis = new List<HocPhi>();

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
                            HocPhi hocphi = new HocPhi();
                            hocphi.Id_hphi = reader.GetInt32(0);
                            hocphi.Id_hv = reader.GetInt32(1);
                            hocphi.Ngaydong = reader.GetDateTime(2);
                            hocphi.Handong = reader.GetDateTime(3);
                            hocphi.Tongtien = reader.GetDecimal(4);
                            hocphi.Tinhtrang = reader.GetString(5);
                            hocphis.Add(hocphi);
                        }
                        // Clean up
                        reader.Dispose();
                    }
                    else
                    {
                        return null;
                    }

                    connection.Close();
                    reader.Dispose();
                    return hocphis;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message); //Them using System.Windows.Forms;
            }

            return null;
            
        }
    }
}
