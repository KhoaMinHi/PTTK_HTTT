
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlHocVien.SuspendLayout();
            this.tabPageXemHocPhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemHocPhi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHocVien
            // 
            this.tabControlHocVien.Controls.Add(this.tabPageXemHocPhi);
            this.tabControlHocVien.Controls.Add(this.tabPage2);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1177, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fHocvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 489);
            this.Controls.Add(this.tabControlHocVien);
            this.Name = "fHocvien";
            this.Text = "fHocVien";
            this.tabControlHocVien.ResumeLayout(false);
            this.tabPageXemHocPhi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemHocPhi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHocVien;
        private System.Windows.Forms.TabPage tabPageXemHocPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDHocVienHocPhi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonXemHocPhi;
        private System.Windows.Forms.DataGridView dataGridViewXemHocPhi;
    }
}