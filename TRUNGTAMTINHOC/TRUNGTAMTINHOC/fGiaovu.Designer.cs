
namespace TRUNGTAMTINHOC
{
    partial class fGiaovu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMoLopMonHoc = new System.Windows.Forms.TabPage();
            this.dataGridViewLopMon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKiemTraLopMon = new System.Windows.Forms.Button();
            this.buttonMoLopMon = new System.Windows.Forms.Button();
            this.comboBoxIDMon = new System.Windows.Forms.ComboBox();
            this.dateTimeNgayMo = new System.Windows.Forms.DateTimePicker();
            this.numericSongLuong = new System.Windows.Forms.NumericUpDown();
            this.numericSiSo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxPhongHoc = new System.Windows.Forms.TextBox();
            this.textBoxLichHoc = new System.Windows.Forms.TextBox();
            this.textBoxIDLop = new System.Windows.Forms.TextBox();
            this.tabPageCapNhatDiemThi = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageMoLopMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLopMon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSongLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSiSo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMoLopMonHoc);
            this.tabControl1.Controls.Add(this.tabPageCapNhatDiemThi);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1103, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMoLopMonHoc
            // 
            this.tabPageMoLopMonHoc.Controls.Add(this.dataGridViewLopMon);
            this.tabPageMoLopMonHoc.Controls.Add(this.panel1);
            this.tabPageMoLopMonHoc.Location = new System.Drawing.Point(4, 25);
            this.tabPageMoLopMonHoc.Name = "tabPageMoLopMonHoc";
            this.tabPageMoLopMonHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMoLopMonHoc.Size = new System.Drawing.Size(1095, 424);
            this.tabPageMoLopMonHoc.TabIndex = 0;
            this.tabPageMoLopMonHoc.Text = "Mở lớp môn học";
            this.tabPageMoLopMonHoc.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLopMon
            // 
            this.dataGridViewLopMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLopMon.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewLopMon.Name = "dataGridViewLopMon";
            this.dataGridViewLopMon.RowHeadersWidth = 51;
            this.dataGridViewLopMon.RowTemplate.Height = 24;
            this.dataGridViewLopMon.Size = new System.Drawing.Size(728, 405);
            this.dataGridViewLopMon.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonKiemTraLopMon);
            this.panel1.Controls.Add(this.buttonMoLopMon);
            this.panel1.Controls.Add(this.comboBoxIDMon);
            this.panel1.Controls.Add(this.dateTimeNgayMo);
            this.panel1.Controls.Add(this.numericSongLuong);
            this.panel1.Controls.Add(this.numericSiSo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.textBoxPhongHoc);
            this.panel1.Controls.Add(this.textBoxLichHoc);
            this.panel1.Controls.Add(this.textBoxIDLop);
            this.panel1.Location = new System.Drawing.Point(760, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 241);
            this.panel1.TabIndex = 0;
            // 
            // buttonKiemTraLopMon
            // 
            this.buttonKiemTraLopMon.Location = new System.Drawing.Point(162, 202);
            this.buttonKiemTraLopMon.Name = "buttonKiemTraLopMon";
            this.buttonKiemTraLopMon.Size = new System.Drawing.Size(75, 33);
            this.buttonKiemTraLopMon.TabIndex = 8;
            this.buttonKiemTraLopMon.Text = "Kiểm tra";
            this.buttonKiemTraLopMon.UseVisualStyleBackColor = true;
            this.buttonKiemTraLopMon.Click += new System.EventHandler(this.buttonKiemTraLopMon_Click);
            // 
            // buttonMoLopMon
            // 
            this.buttonMoLopMon.Location = new System.Drawing.Point(243, 202);
            this.buttonMoLopMon.Name = "buttonMoLopMon";
            this.buttonMoLopMon.Size = new System.Drawing.Size(75, 33);
            this.buttonMoLopMon.TabIndex = 7;
            this.buttonMoLopMon.Text = "Mở";
            this.buttonMoLopMon.UseVisualStyleBackColor = true;
            this.buttonMoLopMon.Click += new System.EventHandler(this.buttonMoLopMon_Click);
            // 
            // comboBoxIDMon
            // 
            this.comboBoxIDMon.FormattingEnabled = true;
            this.comboBoxIDMon.Location = new System.Drawing.Point(97, 31);
            this.comboBoxIDMon.Name = "comboBoxIDMon";
            this.comboBoxIDMon.Size = new System.Drawing.Size(221, 24);
            this.comboBoxIDMon.TabIndex = 1;
            // 
            // dateTimeNgayMo
            // 
            this.dateTimeNgayMo.Location = new System.Drawing.Point(97, 62);
            this.dateTimeNgayMo.Name = "dateTimeNgayMo";
            this.dateTimeNgayMo.Size = new System.Drawing.Size(221, 22);
            this.dateTimeNgayMo.TabIndex = 3;
            // 
            // numericSongLuong
            // 
            this.numericSongLuong.Location = new System.Drawing.Point(97, 89);
            this.numericSongLuong.Name = "numericSongLuong";
            this.numericSongLuong.Size = new System.Drawing.Size(221, 22);
            this.numericSongLuong.TabIndex = 4;
            // 
            // numericSiSo
            // 
            this.numericSiSo.Location = new System.Drawing.Point(97, 117);
            this.numericSiSo.Name = "numericSiSo";
            this.numericSiSo.Size = new System.Drawing.Size(221, 22);
            this.numericSiSo.TabIndex = 4;
            this.numericSiSo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "phòng học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "lich học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "sỉ số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "ngày mở:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "id môn:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(4, 8);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 17);
            this.label.TabIndex = 50;
            this.label.Text = "id lớp:";
            // 
            // textBoxPhongHoc
            // 
            this.textBoxPhongHoc.Location = new System.Drawing.Point(97, 146);
            this.textBoxPhongHoc.Name = "textBoxPhongHoc";
            this.textBoxPhongHoc.Size = new System.Drawing.Size(221, 22);
            this.textBoxPhongHoc.TabIndex = 5;
            // 
            // textBoxLichHoc
            // 
            this.textBoxLichHoc.Location = new System.Drawing.Point(97, 174);
            this.textBoxLichHoc.Name = "textBoxLichHoc";
            this.textBoxLichHoc.Size = new System.Drawing.Size(221, 22);
            this.textBoxLichHoc.TabIndex = 6;
            // 
            // textBoxIDLop
            // 
            this.textBoxIDLop.Location = new System.Drawing.Point(97, 5);
            this.textBoxIDLop.Name = "textBoxIDLop";
            this.textBoxIDLop.Size = new System.Drawing.Size(221, 22);
            this.textBoxIDLop.TabIndex = 0;
            // 
            // tabPageCapNhatDiemThi
            // 
            this.tabPageCapNhatDiemThi.Location = new System.Drawing.Point(4, 25);
            this.tabPageCapNhatDiemThi.Name = "tabPageCapNhatDiemThi";
            this.tabPageCapNhatDiemThi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCapNhatDiemThi.Size = new System.Drawing.Size(1095, 424);
            this.tabPageCapNhatDiemThi.TabIndex = 1;
            this.tabPageCapNhatDiemThi.Text = "Cập nhật diểm thi";
            this.tabPageCapNhatDiemThi.UseVisualStyleBackColor = true;
            // 
            // fGiaovu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "fGiaovu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fGiaovu";
            this.Load += new System.EventHandler(this.fGiaovu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMoLopMonHoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLopMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSongLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSiSo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMoLopMonHoc;
        private System.Windows.Forms.TabPage tabPageCapNhatDiemThi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxIDLop;
        private System.Windows.Forms.NumericUpDown numericSiSo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhongHoc;
        private System.Windows.Forms.TextBox textBoxLichHoc;
        private System.Windows.Forms.DateTimePicker dateTimeNgayMo;
        private System.Windows.Forms.Button buttonMoLopMon;
        private System.Windows.Forms.ComboBox comboBoxIDMon;
        private System.Windows.Forms.DataGridView dataGridViewLopMon;
        private System.Windows.Forms.Button buttonKiemTraLopMon;
        private System.Windows.Forms.NumericUpDown numericSongLuong;
        private System.Windows.Forms.Label label2;
    }
}