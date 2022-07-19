using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class fHome : Form
    {

        public static int TableWidth = 125;
        public static int TableHeight = 125;
        public fHome()
        {
            InitializeComponent();
            formLoad();
        }

        private void formLoad()
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            List<Ban> Table = context.Bans.ToList<Ban>();
            foreach (var item in Table)
            {
                Button btn = new Button() { Width = TableWidth, Height = TableWidth};
                

                Random random = new Random();
                btn.Location = new Point(random.Next(0, TableHeight), TableHeight);
                btn.Text = "Bàn " + item.Soban + Environment.NewLine + item.Tinhtrang;
                if (item.Tinhtrang.Equals("Trống"))
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.White;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public List<Button> GetButtonTable()
        {
            List<Button> list = new List<Button>();
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            List<Ban> Table = context.Bans.ToList();
            foreach (var item in Table)
            {
                Button btn = new Button();
                btn.Text = "Bàn " + item.Soban + Environment.NewLine + item.Tinhtrang;
                
                if (item.Tinhtrang.Equals("Trống"))
                {
                    btn.BackColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.Red;
                }

                list.Add(btn);

            }
            return list;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            List<Button> list = GetButtonTable();
            foreach (var item in list)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }



        //Category
       



        private void fHome_Load(object sender, EventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            cbFood.DataSource = context.Douongs.Select(x => x.Tendouong).Distinct().ToList();
            if (Account.role == 0)
            {
                btFoodManager.Visible = false;
                btManagerAccount.Visible = false;
                btNhanVien.Visible = false;
            }
            
                
            
            
        }


        void ShowBill()
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            dgvBill.DataSource = context.CtHds.ToList();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QuanLyQuanCaFeContext context = new QuanLyQuanCaFeContext();
            
        }

        private void btControl_Click(object sender, EventArgs e)
        {
            fStaff staff = new fStaff();
            
            staff.ShowDialog();
        }


        private void btFoodManager_Click(object sender, EventArgs e)
        {

                fFoodManager fFoodManager = new fFoodManager();
                fFoodManager.ShowDialog();
                fFoodManager.Hide();
            
        }

        private void btManagerAccount_Click(object sender, EventArgs e)
        {
           
            fRegister fRegister = new fRegister();
            fRegister.ShowDialog();
            fRegister.Hide();
        }
    }
}
