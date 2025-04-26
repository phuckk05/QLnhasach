namespace GUi_QLNhaSach
{
    partial class HoaDonKhachHang
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
            this.CryHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ThongKeSoLieu1 = new GUi_QLNhaSach.ThongKeSoLieu();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Location = new System.Drawing.Point(55, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 36);
            this.btnBack.TabIndex = 99;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CryHoaDon
            // 
            this.CryHoaDon.ActiveViewIndex = -1;
            this.CryHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.CryHoaDon.Location = new System.Drawing.Point(169, 23);
            this.CryHoaDon.Name = "CryHoaDon";
            this.CryHoaDon.Size = new System.Drawing.Size(1261, 735);
            this.CryHoaDon.TabIndex = 105;
            this.CryHoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.CryHoaDon.Load += new System.EventHandler(this.CryHoaDon_Load);
            // 
            // HoaDonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1554, 758);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.CryHoaDon);
            this.Name = "HoaDonKhachHang";
            this.Text = "HoaDonKhachHang";
            this.Load += new System.EventHandler(this.HoaDonKhachHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CryHoaDon;
        private ThongKeSoLieu ThongKeSoLieu1;
    }
}