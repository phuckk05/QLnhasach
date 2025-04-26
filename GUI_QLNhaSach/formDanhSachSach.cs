using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS_QLNhaSach;
using ET_QLNhaSach;
using System.Windows.Forms;

namespace GUi_QLNhaSach
{
    public partial class formDanhSachSach : Form
    {
        public formDanhSachSach()
        {
            InitializeComponent();
        }
         
        BUS_DanhSachSach bus = new BUS_DanhSachSach();
        ET_Sach et = new ET_Sach();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
               if(txtTTsach.Text== "")
            {
              rdioTimMa.Checked = false;
            }
            else
            {
                et.IDSach1 = txtTTsach.Text;

                dataGridView1.DataSource = bus.LoadTimMaa(et);
            }
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("Không Tháy Thứ Bạn Cần Tìm ");
                

                    LoadDS();
                  
                    txtTTsach.Focus();
                 

                }
            
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtTTsach.Text == "")
            {
                rdioTimMa.Checked = false;
                rdioTimTen.Checked = false;

                LoadDS();
            }
        }
         
        private void formDanhSachSach_Load(object sender, EventArgs e)
        {
            LoadDS();
          
        }
        private void LoadRDIO()
        {
           
             
            
        }
        private void LoadDS()
        {
            dataGridView1.DataSource = bus.LoadDS();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


            if (txtTTsach.Text == "")
            {
                rdioTimTen.Checked = false;
            }
            else
            {
                et.TenSach1 = txtTTsach.Text;
                dataGridView1.DataSource = bus.LoadTimTen(et);
            }
        
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("Không Tháy Thứ Bạn Cần Tìm ");

                 
                    txtTTsach.Focus();
                    LoadDS();
                }
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formTrangChu fom = new formTrangChu();
            this.Hide();
            fom.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
