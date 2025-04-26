namespace GUi_QLNhaSach
{
    partial class formDanhSachSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTTsach = new System.Windows.Forms.TextBox();
            this.rdioTimMa = new System.Windows.Forms.RadioButton();
            this.rdioTimTen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(891, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTTsach
            // 
            this.txtTTsach.Location = new System.Drawing.Point(297, 106);
            this.txtTTsach.Name = "txtTTsach";
            this.txtTTsach.Size = new System.Drawing.Size(180, 22);
            this.txtTTsach.TabIndex = 1;
            this.txtTTsach.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rdioTimMa
            // 
            this.rdioTimMa.AutoSize = true;
            this.rdioTimMa.Location = new System.Drawing.Point(531, 106);
            this.rdioTimMa.Name = "rdioTimMa";
            this.rdioTimMa.Size = new System.Drawing.Size(108, 20);
            this.rdioTimMa.TabIndex = 2;
            this.rdioTimMa.TabStop = true;
            this.rdioTimMa.Text = "Tìm Theo Mã";
            this.rdioTimMa.UseVisualStyleBackColor = true;
            this.rdioTimMa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdioTimTen
            // 
            this.rdioTimTen.AutoSize = true;
            this.rdioTimTen.Location = new System.Drawing.Point(681, 106);
            this.rdioTimTen.Name = "rdioTimTen";
            this.rdioTimTen.Size = new System.Drawing.Size(113, 20);
            this.rdioTimTen.TabIndex = 3;
            this.rdioTimTen.TabStop = true;
            this.rdioTimTen.Text = "Tìm Theo Tên";
            this.rdioTimTen.UseVisualStyleBackColor = true;
            this.rdioTimTen.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập Thông Tin Sách";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(101, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(817, 60);
            this.label7.TabIndex = 87;
            this.label7.Text = "Danh Sách Các Loại Sách";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 36);
            this.btnBack.TabIndex = 88;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // formDanhSachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 639);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdioTimTen);
            this.Controls.Add(this.rdioTimMa);
            this.Controls.Add(this.txtTTsach);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formDanhSachSach";
            this.Text = "form Danh sách";
            this.Load += new System.EventHandler(this.formDanhSachSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTTsach;
        private System.Windows.Forms.RadioButton rdioTimMa;
        private System.Windows.Forms.RadioButton rdioTimTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
    }
}