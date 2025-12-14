using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhaSach;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace GUi_QLNhaSach
{
    public partial class formThongKe : Form
    {
        public formThongKe()
        {
            InitializeComponent();
        }
        BUS_ThongKe bus = new BUS_ThongKe();
        private void btnThongKe_Load(object sender, EventArgs e)
        {   

            LoadHDThang(); 
            LoadNam();
        }
        private void LoadHDThang()
        {
            int currentMonth = DateTime.Now.Month;

            // Tạo danh sách các tháng
            List<string> months = new List<string>();
            for (int i = 1; i <= currentMonth; i++)
            {
                months.Add(i.ToString());
            }

            // Gán danh sách vào ComboBo
            cbThang.DataSource = months;
        }
        private void LoadNam()
        {
            int currentYear = DateTime.Now.Year;

            // Tạo danh sách các tháng
            List<string> year = new List<string>();
            for (int i = (currentYear - 5) ; i <= currentYear; i++)
            {
                year.Add(i.ToString());
            }

            // Gán danh sách vào ComboBo
            cbNam.DataSource = year;
        }
        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if(cbTheLoai.Text == "Hóa Đơn")
            {
                HoaDon hoaDon = new HoaDon();  // Đối tượng báo cáo Crystal Report

                // Tham số Năm
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue paravalue = new ParameterDiscreteValue();
                paravalue.Value = cbNam.Text;  // Lấy giá trị năm từ ComboBox
                para.Add(paravalue);

                // Tham số Tháng
                ParameterValues para2 = new ParameterValues();
                ParameterDiscreteValue paravalue2 = new ParameterDiscreteValue();
                paravalue2.Value = cbThang.Text;  // Lấy giá trị tháng từ ComboBox
                para2.Add(paravalue2);

                // Truyền giá trị tham số vào báo cáo
                hoaDon.DataDefinition.ParameterFields["@thang"].ApplyCurrentValues(para2);
                hoaDon.DataDefinition.ParameterFields["@nam"].ApplyCurrentValues(para);

                // Hiển thị báo cáo trên CrystalReportViewer
                CryThongKe.ReportSource = hoaDon;
                CryThongKe.Refresh();
            }
            else if(cbTheLoai.Text == "Tổng Thống kê")
            {

                ThongKeSoLieu hoaDon = new ThongKeSoLieu();  // Đối tượng báo cáo Crystal Report

                // Tham số Năm
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue paravalue = new ParameterDiscreteValue();
                paravalue.Value = cbNam.Text;  // Lấy giá trị năm từ ComboBox
                para.Add(paravalue);

                // Tham số Tháng
                ParameterValues para2 = new ParameterValues();
                ParameterDiscreteValue paravalue2 = new ParameterDiscreteValue();
                paravalue2.Value = cbThang.Text;  // Lấy giá trị tháng từ ComboBox
                para2.Add(paravalue2);

                // Truyền giá trị tham số vào báo cáo
                hoaDon.DataDefinition.ParameterFields["@thang"].ApplyCurrentValues(para2);
                hoaDon.DataDefinition.ParameterFields["@nam"].ApplyCurrentValues(para);

                // Hiển thị báo cáo trên CrystalReportViewer
                CryThongKe.ReportSource = hoaDon;
                CryThongKe.Refresh();
            }
            else if (cbTheLoai.Text == "Sách")
            {



                BaoCaoSach rb = new BaoCaoSach();
                CryThongKe.ReportSource = rb;
                CryThongKe.Refresh();

            }
             else if (cbTheLoai.Text == "Khách Hàng")
            {
                BaoCaoKhachHang baocao = new BaoCaoKhachHang();


                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue paravalue = new ParameterDiscreteValue();
                paravalue.Value = cbNam.Text;  // Lấy giá trị năm từ ComboBox
                para.Add(paravalue);

                // Tham số Tháng
                ParameterValues para2 = new ParameterValues();
                ParameterDiscreteValue paravalue2 = new ParameterDiscreteValue();
                paravalue2.Value = cbThang.Text;  // Lấy giá trị tháng từ ComboBox
                para2.Add(paravalue2);

                // Truyền giá trị tham số vào báo cáo
                baocao.DataDefinition.ParameterFields["@thang"].ApplyCurrentValues(para2);
                baocao.DataDefinition.ParameterFields["@nam"].ApplyCurrentValues(para);

                // Hiển thị báo cáo trên CrystalReportViewer
                CryThongKe.ReportSource = baocao;
                CryThongKe.Refresh();


            }

            else if (cbTheLoai.Text == "Nhân Viên")
            {
                BaoCaoNhanVien baocaonhanvien = new BaoCaoNhanVien();


                //ParameterValues para = new ParameterValues();
                //ParameterDiscreteValue paravalue = new ParameterDiscreteValue();
                //paravalue.Value = cbNam.Text;  // Lấy giá trị năm từ ComboBox
                //para.Add(paravalue);

                //// Tham số Tháng
                //ParameterValues para2 = new ParameterValues();
                //ParameterDiscreteValue paravalue2 = new ParameterDiscreteValue();
                //paravalue2.Value = cbThang.Text;  // Lấy giá trị tháng từ ComboBox
                //para2.Add(paravalue2);

                // Truyền giá trị tham số vào báo cáo
                //baocao.DataDefinition.ParameterFields["@thang"].ApplyCurrentValues(para2);
                //baocao.DataDefinition.ParameterFields["@nam"].ApplyCurrentValues(para);

                // Hiển thị báo cáo trên CrystalReportViewer
                CryThongKe.ReportSource = baocaonhanvien;
                CryThongKe.Refresh();


            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formTrangChu form = new formTrangChu();
            this.Hide();
            form.ShowDialog();
        }

        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTheLoai.Text == "Sách")
            {
                cbThang.Enabled = false;
                cbNam.Enabled = false;
            }
            else
            {
                cbThang.Enabled = true;
                cbNam.Enabled = true;
            }
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CryThongKe_Load(object sender, EventArgs e)
        {

        }

        private void ThongKeSoLieu1_InitReport(object sender, EventArgs e)
        {

        }

        private void cryXuatHoaDonLien_Load(object sender, EventArgs e)
        {

        }
    }
}
