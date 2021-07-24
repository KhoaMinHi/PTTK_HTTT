using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUNGTAMTINHOC.TangNghiepVu;
using Oracle.DataAccess.Client;

namespace TRUNGTAMTINHOC.TangDB
{
    class DangKyXemLopMonHocDB
    {
        public static List<DangKyXemLopMonHoc> selectListLopMon()
        {
            List<DangKyXemLopMonHoc> lopmons = new List<DangKyXemLopMonHoc>();
            string query = "select * from lop";

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
                            DangKyXemLopMonHoc lopmon = new DangKyXemLopMonHoc();
                            lopmon.Idlop = reader.GetString(0);
                            lopmon.Idmon = reader.GetString(1);
                            lopmon.Soluong = reader.GetDecimal(2);
                            lopmon.Ngaymo = reader.GetDateTime(3);
                            lopmon.Siso = reader.GetDecimal(4);
                            lopmon.Phonghoc = reader.GetString(5);
                            lopmon.Lichhoc = reader.GetString(6);
                            lopmons.Add(lopmon);
                        }

                    }
                    else
                    {
                        return null;
                    }

                    connection.Close();
                    reader.Dispose();
                    return lopmons;
                }
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message); //Them using System.Windows.Forms;
            }

            return lopmons;
        }

        public static List<DangKyXemLopMonHoc> selectListLopMonHocDaDangKy(string idhv)
        {
            List<DangKyXemLopMonHoc> lopmons = new List<DangKyXemLopMonHoc>();
            string query = "select l.* from hocvien h join ketqualop k on h.id_hv=k.id_hv join lop l on l.id_lop=k.id_lop where h.id_hv = " + idhv;

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
                            DangKyXemLopMonHoc lopmon = new DangKyXemLopMonHoc();
                            lopmon.Idlop = reader.GetString(0);
                            lopmon.Idmon = reader.GetString(1);
                            lopmon.Soluong = reader.GetDecimal(2);
                            lopmon.Ngaymo = reader.GetDateTime(3);
                            lopmon.Siso = reader.GetDecimal(4);
                            lopmon.Phonghoc = reader.GetString(5);
                            lopmon.Lichhoc = reader.GetString(6);
                            lopmons.Add(lopmon);
                        }

                    }
                    else
                    {
                        return null;
                    }

                    connection.Close();
                    reader.Dispose();
                    return lopmons;
                }
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.Message); //Them using System.Windows.Forms;
            }

            return lopmons;
        }
    }
}
