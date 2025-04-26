using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET_QLNhaSach;
using BUS_QLNhaSach;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace GUi_QLNhaSach
{
    public partial class HoaDonKhachHang : Form
    {
        public HoaDonKhachHang()
        {
            InitializeComponent();
        }
        BUS_ThanhToan tt = new BUS_ThanhToan();
        private void btnBack_Click(object sender, EventArgs e)
        {
            formThanhToan hoadon = new formThanhToan();
            this.Hide();
            hoadon.Show();

        }

        private void CryHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void HoaDonKhachHang_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        private void  LoadHoaDon()
        {
            string a  = "HD0" + (int.Parse(tt.LayMAHD()) + 1);

            InHoaDon baocao = new InHoaDon();


            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue paravalue = new ParameterDiscreteValue();
            paravalue.Value = a.ToString();  // Lấy giá trị năm từ ComboBox
            para.Add(paravalue);

            // Tham số Tháng
       

            // Truyền giá trị tham số vào báo cáo
            baocao.DataDefinition.ParameterFields["@mahd"].ApplyCurrentValues(para);
       

            // Hiển thị báo cáo trên CrystalReportViewer
            CryHoaDon.ReportSource = baocao;
            CryHoaDon.Refresh();


        }
    }
}
