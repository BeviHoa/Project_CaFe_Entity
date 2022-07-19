using Project_Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Entity
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
        }

       

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadDataForDGV()
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            dataGridView1.DataSource = context.Nhanviens.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();    
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            LoadDataForDGV();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbId.Text = row.Cells[0].Value.ToString();
                txbName.Text = row.Cells[1].Value.ToString();
                if ((string)row.Cells[2].Value == "Nữ")
                {
                    rbGirl.Checked = true;
                }
                else
                {
                    rbBoy.Checked = true;
                }
                txbPhone.Text = row.Cells[3].Value.ToString();
            }
        }

        private Nhanvien GetNhanvienInfo()
        {
            Nhanvien s = new Nhanvien();
            if (txbId.Text != null && !string.IsNullOrWhiteSpace(txbId.Text))
            {
                s.Manv = Convert.ToInt32(txbId.Text);
            }
            s.Tenhanvien = txbName.Text.Trim();
            
            s.Gioitinh = rbGirl.Text.Trim();

            s.Dienthoai = txbPhone.Text.ToString();
            
            return s;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Nhanvien s = GetNhanvienInfo();
            context.Nhanviens.Add(s);
            context.SaveChanges();
            LoadDataForDGV();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Nhanvien s = GetNhanvienInfo();
            Nhanvien n = context.Nhanviens.FirstOrDefault(x => x.Manv == s.Manv);
            n.Manv = s.Manv;
            n.Tenhanvien = s.Tenhanvien;
            n.Gioitinh = s.Gioitinh;
            n.Dienthoai = s.Dienthoai;
            context.SaveChanges();
            LoadDataForDGV();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            Nhanvien s = GetNhanvienInfo();
            context.Nhanviens.Remove(s);
            context.SaveChanges();
            LoadDataForDGV();
        }
    }
}
