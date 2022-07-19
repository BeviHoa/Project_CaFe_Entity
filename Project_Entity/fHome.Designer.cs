namespace Project_Entity
{
    partial class fHome
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.btFoodManager = new System.Windows.Forms.Button();
            this.btManagerAccount = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btPayment);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvBill);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.cbFood);
            this.panel2.Location = new System.Drawing.Point(418, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 495);
            this.panel2.TabIndex = 1;
            // 
            // btPayment
            // 
            this.btPayment.Location = new System.Drawing.Point(359, 459);
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(78, 25);
            this.btPayment.TabIndex = 7;
            this.btPayment.Text = "Payment";
            this.btPayment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(3, 37);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowTemplate.Height = 25;
            this.dgvBill.Size = new System.Drawing.Size(434, 416);
            this.dgvBill.TabIndex = 4;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(346, 8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 23);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(203, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(62, 8);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 23);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 493);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btNhanVien
            // 
            this.btNhanVien.Location = new System.Drawing.Point(6, 4);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btNhanVien.TabIndex = 3;
            this.btNhanVien.Text = "Nhân viên";
            this.btNhanVien.UseVisualStyleBackColor = true;
            this.btNhanVien.Click += new System.EventHandler(this.btControl_Click);
            // 
            // btFoodManager
            // 
            this.btFoodManager.Location = new System.Drawing.Point(87, 6);
            this.btFoodManager.Name = "btFoodManager";
            this.btFoodManager.Size = new System.Drawing.Size(75, 23);
            this.btFoodManager.TabIndex = 4;
            this.btFoodManager.Text = "Food Manager";
            this.btFoodManager.UseVisualStyleBackColor = true;
            this.btFoodManager.Click += new System.EventHandler(this.btFoodManager_Click);
            // 
            // btManagerAccount
            // 
            this.btManagerAccount.Location = new System.Drawing.Point(168, 6);
            this.btManagerAccount.Name = "btManagerAccount";
            this.btManagerAccount.Size = new System.Drawing.Size(116, 23);
            this.btManagerAccount.TabIndex = 5;
            this.btManagerAccount.Text = "Manager Account";
            this.btManagerAccount.UseVisualStyleBackColor = true;
            this.btManagerAccount.Click += new System.EventHandler(this.btManagerAccount_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.btManagerAccount);
            this.Controls.Add(this.btFoodManager);
            this.Controls.Add(this.btNhanVien);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "fHome";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.fHome_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Button btPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btControl;
        private System.Windows.Forms.Button btFoodManager;
        private System.Windows.Forms.Button btManagerAccount;
        private System.Windows.Forms.Button btNhanVien;
    }
}