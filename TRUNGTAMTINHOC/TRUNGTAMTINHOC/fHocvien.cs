using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRUNGTAMTINHOC
{
    public partial class fHocvien : Form
    {
        public fHocvien()
        {
            InitializeComponent();
        }

        private void buttonXemHocPhi_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDHocVienHocPhi.Text == "")
                {
                    MessageBox.Show("Vui long nhap ID hoc vien!");
                    return;
                }
                for(int i=0; i<textBoxIDHocVienHocPhi.TextLength; i++)
                {
                    if(textBoxIDHocVienHocPhi.Text[i] > '9' || textBoxIDHocVienHocPhi.Text[i] < '0')
                    {
                        MessageBox.Show("Vui long nhap dung ID!");
                        return;
                    }
                }
                dataGridViewXemHocPhi.DataSource = TangNghiepVu.HocPhi.getHocPhi(Convert.ToInt32(textBoxIDHocVienHocPhi.Text));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return;
        }

        private void buttonXemDiem_Click(object sender, EventArgs e)
        {
            try
            {                
                if (textBoxIDHVXemDiem.Text == "")
                {
                    MessageBox.Show("Vui long nhap ID hoc vien!");
                    return;
                }
                for (int i = 0; i < textBoxIDHVXemDiem.TextLength; i++)
                {
                    if (textBoxIDHVXemDiem.Text[i] > '9' || textBoxIDHVXemDiem.Text[i] < '0')
                    {
                        MessageBox.Show("Vui long nhap dung ID!");
                        return;
                    }
                }

                
                dataGridViewXemDiem.DataSource = TangNghiepVu.HOCVIENXEMDIEM.getStudentPoint(Convert.ToDecimal(textBoxIDHVXemDiem.Text));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonXemLopDangKy_Click(object sender, EventArgs e)
        {
            dataGridViewDangKyLop.DataSource = TangNghiepVu.DangKyXemLopMonHoc.getListLopMonHoc();
        }

        private void buttonDaDangKy_Click(object sender, EventArgs e)
        {
            if (textBoxIDHocVienDangKyLopMon.Text == "")
            {
                MessageBox.Show("Vui long nhap ID hoc vien!");
                return;
            }
            for (int i = 0; i < textBoxIDHocVienDangKyLopMon.TextLength; i++)
            {
                if (textBoxIDHocVienDangKyLopMon.Text[i] > '9' || textBoxIDHocVienDangKyLopMon.Text[i] < '0')
                {
                    MessageBox.Show("Vui long nhap dung ID!");
                    return;
                }
            }
            dataGridViewDangKyLop.DataSource = TangNghiepVu.DangKyXemLopMonHoc.getListLopMonHocDaDangKy(textBoxIDHocVienDangKyLopMon.Text);
        }
    }
}
