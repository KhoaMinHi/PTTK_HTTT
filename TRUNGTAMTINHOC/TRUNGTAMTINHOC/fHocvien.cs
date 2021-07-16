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
            if (textBoxIDHocVienHocPhi.Text == "")
            {
                MessageBox.Show("Vui long nhap ID hoc vien!");
                return;
            }
            dataGridViewXemHocPhi.DataSource = TangNghiepVu.HocPhi.getHocPhi(Convert.ToInt32(textBoxIDHocVienHocPhi.Text));
        }
    }
}
