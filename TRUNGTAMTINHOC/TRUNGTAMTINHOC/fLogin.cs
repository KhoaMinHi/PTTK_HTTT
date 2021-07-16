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
                //Kiem tra DB co user khong
                TangNghiepVu.UserLogin userlogin = new TangNghiepVu.UserLogin(comboBoxServiceName.Text, txbUserName.Text, txbPassword.Text);
                bool hasuser = TangNghiepVu.UserLogin.isUser(userlogin);
                if (hasuser == false)
                {
                    MessageBox.Show("Sai tai khoan hoac mat khau!");
                    return;
                }

                //Kiem tra connection co phai muon ket noi den user SYS
                if (txbUserName.Text == "SYS" && TangNghiepVu.UserLogin.getLoginedUserName() == "SYS")
                {
                    fAdmin fadmin = new fAdmin();
                    this.Hide();
                    fadmin.ShowDialog();
                    this.Show();
                    return;
                }

                //Đoạn này tui không check nguoi dung, kiểu không làm giống môn ATBM. Làm như này cho nó tiện.
                string vaitro = txbUserName.Text;
                
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
