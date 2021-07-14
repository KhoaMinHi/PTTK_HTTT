using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRUNGTAMTINHOC.TangDB;

namespace TRUNGTAMTINHOC
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //xu ly login vao mot user
                string nameandpass = comboBoxServiceName.Text + ";DBA Privilege = SYSDBA; User Id=" + this.txbUserName.Text + "; Password=" + this.txbPassword.Text;//User Id = c##bv_schema;Password=bv_schema;";
                TruyCapDB.ConnStr = "DATA SOURCE=localhost:1521/" + nameandpass;
                string vaitro = "";
                //TruyCapDB dataPro = new TruyCapDB();
                //int result = dataPro.ExecuteParameterNonQuery("select * from dual");
                string query = "select username from dba_users where username = '" + txbUserName.Text + "'";
                int result = TruyCapDB.Instance.ExecuteParameterQuery(query).Rows.Count;

                //MessageBox.Show(TruyCapDB.Instance.ExecuteScalar("SELECT SYS_CONTEXT ('USERENV', 'SESSION_USER') FROM DUAL").ToString());

                if (result <= 0)
                {
                    MessageBox.Show("Sai tai khoan hoac mat khau!");
                    return;
                }


                if (txbUserName.Text == "SYS" && TruyCapDB.Instance.ExecuteScalar("SELECT SYS_CONTEXT ('USERENV', 'SESSION_USER') FROM DUAL").ToString() == "SYS")
                {
                    fAdmin fadmin = new fAdmin();
                    this.Hide();
                    fadmin.ShowDialog();
                    this.Show();
                    return;
                }

                //Lấy vai trò để điều khiển truy cập vào form tương ứng
                //query = "select vaitro from bv_schema.nhanvien where tennv = '" + txbUserName.Text + "'";
                //vaitro = TruyCapDB.Instance.ExecuteScalar(query).ToString();
                vaitro = txbUserName.Text;
                //Change sys connection to user connection
                //TruyCapDB.Instance.ExecuteParameterNonQuery("disconnect");
                //nameandpass = comboBoxServiceName.Text + ";" + " User Id=" + this.txbUserName.Text + "; Password=" + this.txbPassword.Text;//User Id = c##bv_schema;Password=bv_schema;";
                //TruyCapDB.ConnStr = "DATA SOURCE=localhost:1521/" + nameandpass;
                //if (TruyCapDB.Instance.ExecuteScalar("SELECT SYS_CONTEXT ('USERENV', 'SESSION_USER') FROM DUAL").ToString() != "0")
                //{
                    switch (vaitro)
                    {
                        case "GIAOVU":
                            fGiaovu fgiaovu = new fGiaovu();
                            this.Hide();
                            fgiaovu.ShowDialog();
                            this.Show();
                            break;
                        case "THUNGAN":
                            fThungan fthungan = new fThungan();
                            this.Hide();
                            fthungan.ShowDialog();
                            this.Show();
                            break;
                        case "HOCVIEN":
                            fHocvien fhocvien = new fHocvien();
                            this.Hide();
                            fhocvien.ShowDialog();
                            this.Show();
                            break;
                    }

                    return;
                //}
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            //MessageBox.Show("Sai tai khoan hoac mat khau!");
        }
              
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
               
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
