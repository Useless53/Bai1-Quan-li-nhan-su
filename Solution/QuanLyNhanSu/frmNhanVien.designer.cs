﻿namespace QuanLyNhanSu
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.pn_Nhanvien = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.Nam = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radF = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.textWork = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textDoB = new System.Windows.Forms.TextBox();
            this.textManager = new System.Windows.Forms.TextBox();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.radView = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFree = new System.Windows.Forms.Button();
            this.pn_Nhanvien.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Nhanvien
            // 
            this.pn_Nhanvien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pn_Nhanvien.Controls.Add(this.panel2);
            this.pn_Nhanvien.Controls.Add(this.panel3);
            this.pn_Nhanvien.Controls.Add(this.panel4);
            this.pn_Nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Nhanvien.Location = new System.Drawing.Point(0, 0);
            this.pn_Nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Nhanvien.Name = "pn_Nhanvien";
            this.pn_Nhanvien.Size = new System.Drawing.Size(724, 472);
            this.pn_Nhanvien.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(16, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 276);
            this.panel2.TabIndex = 17;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SteelBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 276);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhân viên";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhân viên";
            this.columnHeader2.Width = 155;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Nam);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.radF);
            this.panel3.Controls.Add(this.radM);
            this.panel3.Controls.Add(this.textWork);
            this.panel3.Controls.Add(this.textAddress);
            this.panel3.Controls.Add(this.textDoB);
            this.panel3.Controls.Add(this.textManager);
            this.panel3.Controls.Add(this.textSalary);
            this.panel3.Controls.Add(this.textName);
            this.panel3.Controls.Add(this.textID);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(367, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 435);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nam.Location = new System.Drawing.Point(171, 195);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(35, 16);
            this.Nam.TabIndex = 36;
            this.Nam.Text = "Nam";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(274, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 16);
            this.label11.TabIndex = 35;
            this.label11.Text = "Nữ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // radF
            // 
            this.radF.AutoSize = true;
            this.radF.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radF.Location = new System.Drawing.Point(250, 194);
            this.radF.Margin = new System.Windows.Forms.Padding(4);
            this.radF.Name = "radF";
            this.radF.Size = new System.Drawing.Size(17, 16);
            this.radF.TabIndex = 32;
            this.radF.TabStop = true;
            this.radF.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.BackColor = System.Drawing.Color.Transparent;
            this.radM.Checked = true;
            this.radM.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radM.Location = new System.Drawing.Point(147, 194);
            this.radM.Margin = new System.Windows.Forms.Padding(4);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(17, 16);
            this.radM.TabIndex = 32;
            this.radM.TabStop = true;
            this.radM.UseVisualStyleBackColor = false;
            this.radM.CheckedChanged += new System.EventHandler(this.radM_CheckedChanged);
            // 
            // textWork
            // 
            this.textWork.BackColor = System.Drawing.Color.White;
            this.textWork.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textWork.Location = new System.Drawing.Point(149, 309);
            this.textWork.Margin = new System.Windows.Forms.Padding(4);
            this.textWork.Name = "textWork";
            this.textWork.ReadOnly = true;
            this.textWork.Size = new System.Drawing.Size(185, 22);
            this.textWork.TabIndex = 31;
            this.textWork.TextChanged += new System.EventHandler(this.textWork_TextChanged);
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.White;
            this.textAddress.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textAddress.Location = new System.Drawing.Point(149, 233);
            this.textAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textAddress.Name = "textAddress";
            this.textAddress.ReadOnly = true;
            this.textAddress.Size = new System.Drawing.Size(185, 22);
            this.textAddress.TabIndex = 30;
            this.textAddress.TextChanged += new System.EventHandler(this.textAddress_TextChanged);
            // 
            // textDoB
            // 
            this.textDoB.BackColor = System.Drawing.Color.White;
            this.textDoB.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textDoB.Location = new System.Drawing.Point(149, 155);
            this.textDoB.Margin = new System.Windows.Forms.Padding(4);
            this.textDoB.Name = "textDoB";
            this.textDoB.ReadOnly = true;
            this.textDoB.Size = new System.Drawing.Size(185, 22);
            this.textDoB.TabIndex = 29;
            this.textDoB.TextChanged += new System.EventHandler(this.textDoB_TextChanged);
            // 
            // textManager
            // 
            this.textManager.BackColor = System.Drawing.Color.White;
            this.textManager.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textManager.Location = new System.Drawing.Point(149, 347);
            this.textManager.Margin = new System.Windows.Forms.Padding(4);
            this.textManager.Name = "textManager";
            this.textManager.ReadOnly = true;
            this.textManager.Size = new System.Drawing.Size(185, 22);
            this.textManager.TabIndex = 28;
            this.textManager.TextChanged += new System.EventHandler(this.textManager_TextChanged);
            // 
            // textSalary
            // 
            this.textSalary.BackColor = System.Drawing.Color.White;
            this.textSalary.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textSalary.Location = new System.Drawing.Point(149, 271);
            this.textSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textSalary.Name = "textSalary";
            this.textSalary.ReadOnly = true;
            this.textSalary.Size = new System.Drawing.Size(185, 22);
            this.textSalary.TabIndex = 27;
            this.textSalary.TextChanged += new System.EventHandler(this.textSalary_TextChanged);
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.White;
            this.textName.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textName.Location = new System.Drawing.Point(149, 117);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(185, 22);
            this.textName.TabIndex = 25;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.White;
            this.textID.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textID.Location = new System.Drawing.Point(149, 79);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(185, 22);
            this.textID.TabIndex = 24;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 309);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Bộ phận";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 347);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Người quản lý";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(120, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Thông tin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textSearch);
            this.panel4.Controls.Add(this.butSearch);
            this.panel4.Controls.Add(this.butDel);
            this.panel4.Controls.Add(this.radAdd);
            this.panel4.Controls.Add(this.radEdit);
            this.panel4.Controls.Add(this.radView);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnFree);
            this.panel4.Location = new System.Drawing.Point(4, 309);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 152);
            this.panel4.TabIndex = 15;
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(211, 59);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(137, 37);
            this.textSearch.TabIndex = 25;
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.Location = new System.Drawing.Point(209, 102);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(139, 37);
            this.butSearch.TabIndex = 5;
            this.butSearch.Text = "Tìm kiếm";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDel
            // 
            this.butDel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.Location = new System.Drawing.Point(103, 103);
            this.butDel.Margin = new System.Windows.Forms.Padding(4);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(103, 37);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Xóa";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdd.Location = new System.Drawing.Point(11, 86);
            this.radAdd.Margin = new System.Windows.Forms.Padding(4);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(71, 23);
            this.radAdd.TabIndex = 4;
            this.radAdd.Text = "Thêm";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEdit.Location = new System.Drawing.Point(11, 114);
            this.radEdit.Margin = new System.Windows.Forms.Padding(4);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(57, 23);
            this.radEdit.TabIndex = 4;
            this.radEdit.Text = "Sửa";
            this.radEdit.UseVisualStyleBackColor = true;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radView
            // 
            this.radView.AutoSize = true;
            this.radView.Checked = true;
            this.radView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radView.Location = new System.Drawing.Point(11, 58);
            this.radView.Margin = new System.Windows.Forms.Padding(4);
            this.radView.Name = "radView";
            this.radView.Size = new System.Drawing.Size(64, 23);
            this.radView.TabIndex = 2;
            this.radView.TabStop = true;
            this.radView.Text = "Xem";
            this.radView.UseVisualStyleBackColor = true;
            this.radView.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chế độ";
            // 
            // btnFree
            // 
            this.btnFree.Enabled = false;
            this.btnFree.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFree.Location = new System.Drawing.Point(103, 59);
            this.btnFree.Margin = new System.Windows.Forms.Padding(4);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(103, 37);
            this.btnFree.TabIndex = 0;
            this.btnFree.Text = "Xem";
            this.btnFree.UseVisualStyleBackColor = true;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 472);
            this.Controls.Add(this.pn_Nhanvien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.pn_Nhanvien.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Nhanvien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textWork;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textDoB;
        private System.Windows.Forms.TextBox textManager;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.RadioButton radView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.RadioButton radF;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Nam;
    }
}