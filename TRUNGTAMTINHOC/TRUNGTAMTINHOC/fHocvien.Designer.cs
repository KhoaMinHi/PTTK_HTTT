
namespace TRUNGTAMTINHOC
{
    partial class fHocvien
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
            this.tabControlHocVien = new System.Windows.Forms.TabControl();
            this.tabPageXemHocPhi = new System.Windows.Forms.TabPage();
            this.dataGridViewXemHocPhi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXemHocPhi = new System.Windows.Forms.Button();
            this.textBoxIDHocVienHocPhi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageXemDiem = new System.Windows.Forms.TabPage();
            this.dataGridViewXemDiem = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonXemDiem = new System.Windows.Forms.Button();
            this.textBoxIDHVXemDiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageDangKyHocPhan = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDangKyLop = new System.Windows.Forms.Button();
            this.buttonXemLopDangKy = new System.Windows.Forms.Button();
            this.dataGridViewDangKyLop = new System.Windows.Forms.DataGridView();
            this.chonlop = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonDaDangKy = new System.Windows.Forms.Button();
            this.textBoxIDHocVienDangKyLopMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlHocVien.SuspendLayout();
            this.tabPageXemHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemHocPhi)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageXemDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDiem)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPageDangKyHocPhan.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKyLop)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlHocVien
            // 
            this.tabControlHocVien.Controls.Add(this.tabPageXemHocPhi);
            this.tabControlHocVien.Controls.Add(this.tabPageXemDiem);
            this.tabControlHocVien.Controls.Add(this.tabPageDangKyHocPhan);
            this.tabControlHocVien.Location = new System.Drawing.Point(2, 4);
            this.tabControlHocVien.Name = "tabControlHocVien";
            this.tabControlHocVien.SelectedIndex = 0;
            this.tabControlHocVien.Size = new System.Drawing.Size(1001, 473);
            this.tabControlHocVien.TabIndex = 0;
            // 
            // tabPageXemHocPhi
            // 
            this.tabPageXemHocPhi.Controls.Add(this.dataGridViewXemHocPhi);
            this.tabPageXemHocPhi.Controls.Add(this.panel1);
            this.tabPageXemHocPhi.Location = new System.Drawing.Point(4, 25);
            this.tabPageXemHocPhi.Name = "tabPageXemHocPhi";
            this.tabPageXemHocPhi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXemHocPhi.Size = new System.Drawing.Size(993, 444);
            this.tabPageXemHocPhi.TabIndex = 0;
            this.tabPageXemHocPhi.Text = "Xem học phí";
            this.tabPageXemHocPhi.UseVisualStyleBackColor = true;
            // 
            // dataGridViewXemHocPhi
            // 
            this.dataGridViewXemHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemHocPhi.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewXemHocPhi.Name = "dataGridViewXemHocPhi";
            this.dataGridViewXemHocPhi.RowHeadersWidth = 51;
            this.dataGridViewXemHocPhi.RowTemplate.Height = 24;
            this.dataGridViewXemHocPhi.Size = new System.Drawing.Size(653, 344);
            this.dataGridViewXemHocPhi.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXemHocPhi);
            this.panel1.Controls.Add(this.textBoxIDHocVienHocPhi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(676, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 139);
            this.panel1.TabIndex = 3;
            // 
            // buttonXemHocPhi
            // 
            this.buttonXemHocPhi.Location = new System.Drawing.Point(215, 36);
            this.buttonXemHocPhi.Name = "buttonXemHocPhi";
            this.buttonXemHocPhi.Size = new System.Drawing.Size(75, 35);
            this.buttonXemHocPhi.TabIndex = 2;
            this.buttonXemHocPhi.Text = "Xem";
            this.buttonXemHocPhi.UseVisualStyleBackColor = true;
            this.buttonXemHocPhi.Click += new System.EventHandler(this.buttonXemHocPhi_Click);
            // 
            // textBoxIDHocVienHocPhi
            // 
            this.textBoxIDHocVienHocPhi.Location = new System.Drawing.Point(98, 7);
            this.textBoxIDHocVienHocPhi.Name = "textBoxIDHocVienHocPhi";
            this.textBoxIDHocVienHocPhi.Size = new System.Drawing.Size(192, 22);
            this.textBoxIDHocVienHocPhi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID học viện:";
            // 
            // tabPageXemDiem
            // 
            this.tabPageXemDiem.Controls.Add(this.dataGridViewXemDiem);
            this.tabPageXemDiem.Controls.Add(this.panel2);
            this.tabPageXemDiem.Location = new System.Drawing.Point(4, 25);
            this.tabPageXemDiem.Name = "tabPageXemDiem";
            this.tabPageXemDiem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageXemDiem.Size = new System.Drawing.Size(993, 444);
            this.tabPageXemDiem.TabIndex = 1;
            this.tabPageXemDiem.Text = "Xem diểm";
            this.tabPageXemDiem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewXemDiem
            // 
            this.dataGridViewXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemDiem.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewXemDiem.Name = "dataGridViewXemDiem";
            this.dataGridViewXemDiem.RowHeadersWidth = 51;
            this.dataGridViewXemDiem.RowTemplate.Height = 24;
            this.dataGridViewXemDiem.Size = new System.Drawing.Size(653, 344);
            this.dataGridViewXemDiem.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonXemDiem);
            this.panel2.Controls.Add(this.textBoxIDHVXemDiem);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(673, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 139);
            this.panel2.TabIndex = 5;
            // 
            // buttonXemDiem
            // 
            this.buttonXemDiem.Location = new System.Drawing.Point(215, 35);
            this.buttonXemDiem.Name = "buttonXemDiem";
            this.buttonXemDiem.Size = new System.Drawing.Size(75, 35);
            this.buttonXemDiem.TabIndex = 2;
            this.buttonXemDiem.Text = "Xem";
            this.buttonXemDiem.UseVisualStyleBackColor = true;
            this.buttonXemDiem.Click += new System.EventHandler(this.buttonXemDiem_Click);
            // 
            // textBoxIDHVXemDiem
            // 
            this.textBoxIDHVXemDiem.Location = new System.Drawing.Point(98, 7);
            this.textBoxIDHVXemDiem.Name = "textBoxIDHVXemDiem";
            this.textBoxIDHVXemDiem.Size = new System.Drawing.Size(192, 22);
            this.textBoxIDHVXemDiem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID học viện:";
            // 
            // tabPageDangKyHocPhan
            // 
            this.tabPageDangKyHocPhan.Controls.Add(this.panel3);
            this.tabPageDangKyHocPhan.Controls.Add(this.dataGridViewDangKyLop);
            this.tabPageDangKyHocPhan.Location = new System.Drawing.Point(4, 25);
            this.tabPageDangKyHocPhan.Name = "tabPageDangKyHocPhan";
            this.tabPageDangKyHocPhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDangKyHocPhan.Size = new System.Drawing.Size(993, 444);
            this.tabPageDangKyHocPhan.TabIndex = 2;
            this.tabPageDangKyHocPhan.Text = "Đăng ký lớp";
            this.tabPageDangKyHocPhan.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxIDHocVienDangKyLopMon);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.buttonDaDangKy);
            this.panel3.Controls.Add(this.buttonDangKyLop);
            this.panel3.Controls.Add(this.buttonXemLopDangKy);
            this.panel3.Location = new System.Drawing.Point(682, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 153);
            this.panel3.TabIndex = 1;
            // 
            // buttonDangKyLop
            // 
            this.buttonDangKyLop.Location = new System.Drawing.Point(138, 47);
            this.buttonDangKyLop.Name = "buttonDangKyLop";
            this.buttonDangKyLop.Size = new System.Drawing.Size(75, 47);
            this.buttonDangKyLop.TabIndex = 0;
            this.buttonDangKyLop.Text = "Đăng ký";
            this.buttonDangKyLop.UseVisualStyleBackColor = true;
            // 
            // buttonXemLopDangKy
            // 
            this.buttonXemLopDangKy.Location = new System.Drawing.Point(219, 47);
            this.buttonXemLopDangKy.Name = "buttonXemLopDangKy";
            this.buttonXemLopDangKy.Size = new System.Drawing.Size(75, 47);
            this.buttonXemLopDangKy.TabIndex = 0;
            this.buttonXemLopDangKy.Text = "Xem";
            this.buttonXemLopDangKy.UseVisualStyleBackColor = true;
            this.buttonXemLopDangKy.Click += new System.EventHandler(this.buttonXemLopDangKy_Click);
            // 
            // dataGridViewDangKyLop
            // 
            this.dataGridViewDangKyLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDangKyLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chonlop});
            this.dataGridViewDangKyLop.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDangKyLop.Name = "dataGridViewDangKyLop";
            this.dataGridViewDangKyLop.RowHeadersWidth = 51;
            this.dataGridViewDangKyLop.RowTemplate.Height = 24;
            this.dataGridViewDangKyLop.Size = new System.Drawing.Size(626, 435);
            this.dataGridViewDangKyLop.TabIndex = 0;
            // 
            // chonlop
            // 
            this.chonlop.HeaderText = "chọn";
            this.chonlop.MinimumWidth = 3;
            this.chonlop.Name = "chonlop";
            this.chonlop.Width = 43;
            // 
            // buttonDaDangKy
            // 
            this.buttonDaDangKy.Location = new System.Drawing.Point(57, 47);
            this.buttonDaDangKy.Name = "buttonDaDangKy";
            this.buttonDaDangKy.Size = new System.Drawing.Size(75, 47);
            this.buttonDaDangKy.TabIndex = 0;
            this.buttonDaDangKy.Text = "Đã đăng ký";
            this.buttonDaDangKy.UseVisualStyleBackColor = true;
            this.buttonDaDangKy.Click += new System.EventHandler(this.buttonDaDangKy_Click);
            // 
            // textBoxIDHocVienDangKyLopMon
            // 
            this.textBoxIDHocVienDangKyLopMon.Location = new System.Drawing.Point(100, 6);
            this.textBoxIDHocVienDangKyLopMon.Name = "textBoxIDHocVienDangKyLopMon";
            this.textBoxIDHocVienDangKyLopMon.Size = new System.Drawing.Size(192, 22);
            this.textBoxIDHocVienDangKyLopMon.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID học viện:";
            // 
            // fHocvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 489);
            this.Controls.Add(this.tabControlHocVien);
            this.Name = "fHocvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHocVien";
            this.tabControlHocVien.ResumeLayout(false);
            this.tabPageXemHocPhi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemHocPhi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageXemDiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemDiem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageDangKyHocPhan.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDangKyLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHocVien;
        private System.Windows.Forms.TabPage tabPageXemHocPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDHocVienHocPhi;
        private System.Windows.Forms.TabPage tabPageXemDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonXemHocPhi;
        private System.Windows.Forms.DataGridView dataGridViewXemHocPhi;
        private System.Windows.Forms.DataGridView dataGridViewXemDiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonXemDiem;
        private System.Windows.Forms.TextBox textBoxIDHVXemDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageDangKyHocPhan;
        private System.Windows.Forms.DataGridView dataGridViewDangKyLop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDangKyLop;
        private System.Windows.Forms.Button buttonXemLopDangKy;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chonlop;
        private System.Windows.Forms.Button buttonDaDangKy;
        private System.Windows.Forms.TextBox textBoxIDHocVienDangKyLopMon;
        private System.Windows.Forms.Label label3;
    }
}