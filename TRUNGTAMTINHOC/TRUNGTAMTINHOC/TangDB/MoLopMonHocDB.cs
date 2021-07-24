using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using TRUNGTAMTINHOC.TangNghiepVu;

namespace TRUNGTAMTINHOC.TangDB
{
    class MoLopMonHocDB
    {
        public static int insertLopMonHoc(TangNghiepVu.MoLopMonHoc lopmon)
        {
            string query = "insert into lop(ID_LOP, ID_MH, SLHOCVIEN, NGAYMOLOP, SISOLOP, PHONGHOC, LICHHOC)" +
                "values(" +
                lopmon.Idlop + "," +  lopmon.Idmon + "," + lopmon.Soluong + "," + lopmon.Ngaymo + "," + lopmon.Siso + "," 
                + lopmon.Phonghoc + "," + lopmon.Lichhoc
                + ")" ;
            int result = 0;

            try
            {
                using (OracleConnection connection = new OracleConnection(TruyCapDB.ConnStr))
                {
                    connection.Open();

                    OracleCommand command = new OracleCommand();
                    command.Connection = connection;
                    command.CommandText = query;
                    result = command.ExecuteNonQuery();
                    
                    connection.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message); //Them using System.Windows.Forms;
            }

            return result;

        }

        public static List<string> selectListIDMon()
        {
            string query = "select id_mh from monhoc";
            List<string> idmons = new List<string>();

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
                            idmons.Add(reader.GetString(0));
                        }
                        
                    }
                    else
                    {
                        return null;
                    }

                    connection.Close();
                    reader.Dispose();
                    return idmons;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message); //Them using System.Windows.Forms;
            }

            return idmons;

        }

        public static List<MoLopMonHoc> selectListLopMon()
        {
            List<MoLopMonHoc> lopmons = new List<MoLopMonHoc>();
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
                            MoLopMonHoc lopmon = new MoLopMonHoc();
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
