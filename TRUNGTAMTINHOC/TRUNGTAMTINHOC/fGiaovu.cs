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
    public partial class fGiaovu : Form
    {
        public fGiaovu()
        {
            InitializeComponent();
        }
        
        private void buttonMoLopMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericSiSo.Value <10)
                {
                    MessageBox.Show("Si so khong duoc nho hon 10!");
                    return;
                }
                if(numericSiSo.Value%1 != 0)
                {
                    MessageBox.Show("Vui long khong nhap so thap phan!");
                    return;
                }

                TangNghiepVu.MoLopMonHoc lopmon = new TangNghiepVu.MoLopMonHoc();
                lopmon.Idlop = textBoxIDLop.Text;
                lopmon.Idmon = comboBoxIDMon.Text;
                lopmon.Ngaymo = dateTimeNgayMo.Value;
                lopmon.Soluong = numericSongLuong.Value = 0;
                lopmon.Siso = numericSiSo.Value;
                lopmon.Phonghoc = textBoxPhongHoc.Text;
                lopmon.Lichhoc = textBoxLichHoc.Text;


                
                if(TangNghiepVu.MoLopMonHoc.openSubjectClass(lopmon) > 0)
                {
                    MessageBox.Show("Đã mở lớp!");
                }
                else
                {
                    MessageBox.Show("Mở lớp thất bại!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void fGiaovu_Load(object sender, EventArgs e)
        {
            foreach (string idmon in TangNghiepVu.MoLopMonHoc.getIdSubjects())
            {
                comboBoxIDMon.Items.Add(idmon);
            }
        }

        private void buttonKiemTraLopMon_Click(object sender, EventArgs e)
        {
            dataGridViewLopMon.DataSource = TangNghiepVu.MoLopMonHoc.getListLopMonHoc();
        }

    }
}
