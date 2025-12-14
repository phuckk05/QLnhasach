using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace GUi_QLNhaSach
{
    public partial class XuatHoaDonLien : Form
    {
        private string _id;
        public XuatHoaDonLien(string id)
        {
            InitializeComponent();
            _id = id;

        }

        private void XuatHoaDonLien_Load(object sender, EventArgs e)
        {
            loadHoaDon();

        }
        private void loadHoaDon()
        {
            MessageBox.Show($"Mã hd {_id}");

            XuatHoaDon xhd = new XuatHoaDon();

            xhd.SetParameterValue("@mahd", _id);

            cryXuatLien.ReportSource = xhd;


            cryXuatLien.Refresh();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formThanhToan form = new formThanhToan();
            this.Hide();
            form.ShowDialog();
        }
    }
}
