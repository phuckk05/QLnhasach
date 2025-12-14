namespace GUi_QLNhaSach
{
    partial class XuatHoaDonLien
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
            this.cachedCrystalReport11 = new GUi_QLNhaSach.CachedCrystalReport1();
            this.cryXuatLien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 36);
            this.btnBack.TabIndex = 90;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cryXuatLien
            // 
            this.cryXuatLien.ActiveViewIndex = -1;
            this.cryXuatLien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryXuatLien.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryXuatLien.Location = new System.Drawing.Point(100, 104);
            this.cryXuatLien.Name = "cryXuatLien";
            this.cryXuatLien.ShowGroupTreeButton = false;
            this.cryXuatLien.ShowParameterPanelButton = false;
            this.cryXuatLien.Size = new System.Drawing.Size(1261, 735);
            this.cryXuatLien.TabIndex = 91;
            this.cryXuatLien.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // XuatHoaDonLien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 871);
            this.Controls.Add(this.cryXuatLien);
            this.Controls.Add(this.btnBack);
            this.Name = "XuatHoaDonLien";
            this.Text = "XuatHoaDonLien";
            this.Load += new System.EventHandler(this.XuatHoaDonLien_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private CachedCrystalReport1 cachedCrystalReport11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryXuatLien;
    }
}