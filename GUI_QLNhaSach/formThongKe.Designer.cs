namespace GUi_QLNhaSach
{
    partial class formThongKe
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
            this.btnBack = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.CryThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ThongKeSoLieu1 = new GUi_QLNhaSach.ThongKeSoLieu();
            this.cachedCrystalReport11 = new GUi_QLNhaSach.CachedCrystalReport1();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 36);
            this.btnBack.TabIndex = 89;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(870, 38);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(155, 50);
            this.btnThongKe.TabIndex = 91;
            this.btnThongKe.Text = "Xem Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(450, 50);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 24);
            this.cbThang.TabIndex = 92;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Tháng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "Năm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(244, 52);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(121, 24);
            this.cbNam.TabIndex = 95;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbNam_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Thể Loại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Items.AddRange(new object[] {
            "Tổng Thống kê",
            "Hóa Đơn",
            "Sách",
            "Khách Hàng",
            "Nhân Viên"});
            this.cbTheLoai.Location = new System.Drawing.Point(703, 50);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(121, 24);
            this.cbTheLoai.TabIndex = 98;
            this.cbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbTheLoai_SelectedIndexChanged);
            // 
            // CryThongKe
            // 
            this.CryThongKe.ActiveViewIndex = -1;
            this.CryThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.CryThongKe.Location = new System.Drawing.Point(130, 124);
            this.CryThongKe.Name = "CryThongKe";
            this.CryThongKe.Size = new System.Drawing.Size(1261, 735);
            this.CryThongKe.TabIndex = 96;
            this.CryThongKe.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CryThongKe.Load += new System.EventHandler(this.CryThongKe_Load);
            // 
            // ThongKeSoLieu1
            // 
            this.ThongKeSoLieu1.InitReport += new System.EventHandler(this.ThongKeSoLieu1_InitReport);
            // 
            // formThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 871);
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CryThongKe);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnBack);
            this.Name = "formThongKe";
            this.Text = "form Thống Kê";
            this.Load += new System.EventHandler(this.btnThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNam;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CryThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private ThongKeSoLieu ThongKeSoLieu1;
        private CachedCrystalReport1 cachedCrystalReport11;
    }
}