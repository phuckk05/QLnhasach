using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET_QLNhaSach;
using BUS_QLNhaSach;


namespace GUi_QLNhaSach
{
    public partial class formThanhToan : Form
    {
        BUS_ThanhToan tt = new BUS_ThanhToan();
        BUS_QLSach busach = new BUS_QLSach();
        public formThanhToan()
        {
            InitializeComponent();
    
        }

        
        private void btnQua_Click(object sender, EventArgs e)
        {
            //rtb1.BringToFront();
        }
       
       
       
     
        private void formThanhToan_Load(object sender, EventArgs e)
        {
            //    cbMaNV.DropDownStyle = ComboBoxStyle.DropDownList;
            //    cbSL.DropDownStyle = ComboBoxStyle.DropDownList;

            NapMANV();
            TaoSo();
            LoadNgayTODay();
            //LoadDLKH();
            ////try
            //{





            //txtMaHD.
            //}
            //catch (Exception) { }
        }
        private void LoadNgayTODay()
        {
            dateNgayBan.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void LoadHoaDOnchitiet()
        {
            ET_HoaDonChiTiet et = new ET_HoaDonChiTiet();
            et.MaHD1 = txtMaHD.Text;
            databill.DataSource = tt.LayHoaDonChiTietG(et);
        }
        private void LoadMAHDCT()
        {
            
        }
    
       
        private void LoadDLKH()
        { 
            ET_KhachHang et = new ET_KhachHang();
            et.SDT1 = txtSDT.Text;
           txtTenKH.Text = tt.LayTenKH(et);
               
        
        
        }
        private void TaoSo()
        {
            txtMaHD.Text = "HD0" +(int.Parse(tt.LayMAHD()) + 1) ;
        }
        private void NapMANV()
        {
            cbMaNV.DataSource = tt.LoadTenNhanVien();
            cbMaNV.DisplayMember = "TenNV";
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
          
            //ET_HoaDonChiTiet ehdct2 = new ET_HoaDonChiTiet();
            //ET_HoaDonChiTiet ehdct3 = new ET_HoaDonChiTiet();
            //ehdct.ID1 = MAHDCT;
            //ehdct2.ThanhTien1 = txtThanhTien.Text;
            //ehdct3.SL1 = int.Parse(cbSL.Text);
            //ET_HoaDon ethd = new ET_HoaDon();
            //ethd.ID1 = txtMaHD.Text;

            //ET_Sach etsach = new ET_Sach();
            //etsach.IDSach1 = txtMaSach.Text;
            if (txtMaSach.Text != "" && txtSDT.Text != "" && cbSL.Text != "" && dateNgayBan.Text != "")
            {
                
 
                //DialogResult  kq =   MessageBox.Show("Thông Báo Người Dùng ", "Bạn Có Muốn Mã Hóa Đơn mới Không ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (kq == DialogResult.Yes )
                //{
                   
                bool hasRun = false;


                if (!hasRun)
                {
                    int a = Convert.ToInt32(txtTongTien.Text);
                    ET_NhanVien ett = new ET_NhanVien(cbMaNV.Text);

                    string b = tt.LoadMaTheoTen(ett);
                    MessageBox.Show($"Mã nhân viên {b.ToString()}", "Thông Báo Người Dùng ", MessageBoxButtons.OK);


                    ET_HoaDon et = new ET_HoaDon(txtMaHD.Text, dateNgayBan.Text, txtMaKH.Text, b.ToString(), a);
                    if (tt.LayMaHDTRONG(et) == true)
                    {
                        MessageBox.Show("Tạo hóa đơn thành công ! ", "Thông Báo Người Dùng ", MessageBoxButtons.OK);
                    }

                    hasRun = true;
                }

                //}

                    int MAHDCT = tt.LayHoaDon() + 1;
                    int n = Convert.ToInt32(cbSL.Text);
                    int d = Convert.ToInt32(txtThanhTien.Text);
                    //MessageBox.Show(MAHDCT.ToString());
                    //MessageBox.Show(txtMaSach.Text.ToString());
                    ET_HoaDonChiTiet ehdct = new ET_HoaDonChiTiet(MAHDCT, txtMaSach.Text, n, d, txtMaHD.Text);
                    if (tt.LayHoaDonChiteit(ehdct) == true)
                    {

                           ET_Sach etsach = new ET_Sach();
                           etsach.IDSach1 = txtMaSach.Text;

                           int sl = tt.LaySoLuong(etsach) - n;


                            ET_Sach sach2 = new ET_Sach(txtMaSach.Text, sl);
                           if (busach.UpdateSlSach(sach2) == true)
                           {
                           MessageBox.Show("Thêm Thành Công ", "Thông Báo Người Dùng ", MessageBoxButtons.OK);
 
                           }
                           int a = 0;
                           int b = 0;
                           int.TryParse(txtThanhTien.Text, out a);
                           int.TryParse(txtTongTien.Text, out b);
                           int tong = a + b;
                           txtTongTien.Text = tong.ToString();
                    //string b = txtTongTien.Text;
                    //int tong = int.Parse(a + b);

                           txtMaSach.Clear();
                           txtTenSach.Clear();
                           txtThanhTien.Clear();

                           cbSL.SelectedIndex = -1;
                           txtDonGia.Clear();
                           LoadHoaDOnchitiet();
                  

                   //int.TryParse(txtThanhTien.Text, out a);
                   // //string b = txtTongTien.Text;
                   // //int tong = int.Parse(a + b);
                   // MessageBox.Show(a.ToString());
                    //txtTongTien.Text = tong.ToString();
            

                        //TaoSo();


                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành  Công ", "Thông Báo Người Dùng ", MessageBoxButtons.OK);
                    }
                



            }
            else
            {
                MessageBox.Show("Thông Tin Không Được Để Trống ", "Thông Báo Người Dùng ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            ET_KhachHang et = new ET_KhachHang();
            et.SDT1 = txtSDT.Text;
            txtTenKH.Text = tt.LayTenKH(et);
            txtMaKH.Text = tt.LayMaKh(et);
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            ET_Sach et = new ET_Sach();
            et.IDSach1 = txtMaSach.Text;

          
            txtDonGia.Text = tt.LayDonGia(et).ToString();
            txtTenSach.Text = tt.LayTenSach(et);
            cbSL.Text = tt.LaySoLuong(et).ToString();
            


        

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {


            


        }

        private void cbSL_TextChanged(object sender, EventArgs e)
        {
            int Sl = int.Parse(cbSL.Text);
            ET_Sach et = new ET_Sach();
            et.IDSach1 = txtMaSach.Text;
            int DonGia = Convert.ToInt32(txtDonGia.Text);
            int Sldb = Convert.ToInt32(tt.LaySoLuong(et));
            int tong = 0;
             if(cbSL.Items.Count > Sldb)
            {
                cbSL.Items.Clear();
            }


            for (int i = 1; i <= Sldb; i++)
                {
                   if(i < Sldb)
                {
                    cbSL.Items.Add(i);
                }


                if (i == Sl)
                {
                    tong = Sl * DonGia;

                }

            }



            txtThanhTien.Text = tong.ToString();
        }

        private void cbSL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadDSTrong()
        {
            databill.DataSource = new object[] { };
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
              if(databill.Rows.Count == 0)
            {
                MessageBox.Show("Thông Tin Không Được Để Trống ", "Thông Báo Người Dùng ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int a = Convert.ToInt32(txtTongTien.Text);
                ET_HoaDon et = new ET_HoaDon(txtMaHD.Text, a);
                if (tt.UpdateTongtien(et) == true)
                {
                    //btnReset.Enabled = true;
                    DialogResult result = MessageBox.Show("Có muốn in hóa đơn không? ", "Thông báo đến người dùng !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        XuatHoaDonLien form = new XuatHoaDonLien(txtMaHD.Text);
                        this.Hide();
                        form.Show();
                    }
                    txtDonGia.Clear();
                    txtMaHD.Clear();
                    txtTongTien.Text = 0.ToString();
                    txtTenKH.Clear();
                    txtTenSach.Clear();
                    txtMaSach.Clear();
                    cbMaNV.SelectedIndex = -1;
                    txtSDT.Clear();
                    
                    LoadDSTrong();
                    TaoSo();
                
                }
                else
                {
                    MessageBox.Show("Thanh Toán Không Thành Công");
                }
            }

        }
        private void txtSDT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnXuatKhoaDon_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (databill.Rows.Count == 0)
            {
                formTrangChu form = new formTrangChu();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Bạn Chưa Lưu Hóa Đơn !", "Thông Báo Người Dùng ", MessageBoxButtons.OK);
            }
 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(databill.Rows.Count == 0)
            {
                txtDonGia.Clear();
                txtMaHD.Clear();
                //txtTongTien.Clear();
                txtTenKH.Clear();
                txtTenSach.Clear();
                txtMaSach.Clear();
                cbMaNV.SelectedIndex = -1;
                txtSDT.Clear();
   
                LoadDSTrong();
                TaoSo();
            }
            else
            {
                MessageBox.Show(" Bạn Chưa Lưu Hóa Đơn !","Thông Báo Người Dùng ", MessageBoxButtons.OK);
            }
            

        }

        private void txtMaSach_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (databill.Rows.Count == 0)
            {
                formTrangChu form = new formTrangChu();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Bạn Chưa Thanh Toán Hóa Đơn !", "Thông Báo Người Dùng ", MessageBoxButtons.OK);
            }
        }

        private void dateNgayBan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonKhachHang form = new HoaDonKhachHang();
            this.Hide();
            form.ShowDialog();
        }
    }
}
