namespace QuanLyNhanSu
{
    partial class frmDeAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeAn));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.textID2 = new System.Windows.Forms.TextBox();
            this.textTime = new System.Windows.Forms.TextBox();
            this.textPlace = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFree = new System.Windows.Forms.Button();
            this.radView = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(25, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 224);
            this.panel2.TabIndex = 20;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.SteelBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 224);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đề án";
            this.columnHeader1.Width = 83;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên đề án";
            this.columnHeader2.Width = 155;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textID2);
            this.panel3.Controls.Add(this.textTime);
            this.panel3.Controls.Add(this.textPlace);
            this.panel3.Controls.Add(this.textName);
            this.panel3.Controls.Add(this.textID);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(309, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 224);
            this.panel3.TabIndex = 19;
            // 
            // textID2
            // 
            this.textID2.BackColor = System.Drawing.Color.White;
            this.textID2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textID2.Location = new System.Drawing.Point(99, 139);
            this.textID2.Name = "textID2";
            this.textID2.ReadOnly = true;
            this.textID2.Size = new System.Drawing.Size(140, 23);
            this.textID2.TabIndex = 31;
            // 
            // textTime
            // 
            this.textTime.BackColor = System.Drawing.Color.White;
            this.textTime.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textTime.Location = new System.Drawing.Point(99, 170);
            this.textTime.Name = "textTime";
            this.textTime.ReadOnly = true;
            this.textTime.Size = new System.Drawing.Size(140, 23);
            this.textTime.TabIndex = 28;
            // 
            // textPlace
            // 
            this.textPlace.BackColor = System.Drawing.Color.White;
            this.textPlace.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textPlace.Location = new System.Drawing.Point(99, 108);
            this.textPlace.Name = "textPlace";
            this.textPlace.ReadOnly = true;
            this.textPlace.Size = new System.Drawing.Size(140, 23);
            this.textPlace.TabIndex = 27;
            // 
            // textName
            // 
            this.textName.BackColor = System.Drawing.Color.White;
            this.textName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textName.Location = new System.Drawing.Point(99, 78);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(140, 23);
            this.textName.TabIndex = 25;
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.White;
            this.textID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textID.Location = new System.Drawing.Point(99, 47);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(140, 23);
            this.textID.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mã đơn vị";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Thời gian";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Địa điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tên đề án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã đề án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Thông tin";
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
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnFree);
            this.panel4.Controls.Add(this.radView);
            this.panel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(152, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 150);
            this.panel4.TabIndex = 18;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.White;
            this.textSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textSearch.Location = new System.Drawing.Point(152, 60);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(102, 23);
            this.textSearch.TabIndex = 25;
            // 
            // butSearch
            // 
            this.butSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butSearch.Location = new System.Drawing.Point(152, 97);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(102, 30);
            this.butSearch.TabIndex = 5;
            this.butSearch.Text = "Tìm kiếm";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butDel
            // 
            this.butDel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.butDel.Location = new System.Drawing.Point(79, 97);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(67, 30);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Xóa";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdd.Location = new System.Drawing.Point(22, 81);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(60, 21);
            this.radAdd.TabIndex = 4;
            this.radAdd.Text = "Thêm";
            this.radAdd.UseVisualStyleBackColor = true;
            this.radAdd.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEdit.Location = new System.Drawing.Point(22, 107);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(49, 21);
            this.radEdit.TabIndex = 4;
            this.radEdit.Text = "Sửa";
            this.radEdit.UseVisualStyleBackColor = true;
            this.radEdit.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chế độ";
            // 
            // btnFree
            // 
            this.btnFree.Enabled = false;
            this.btnFree.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFree.Location = new System.Drawing.Point(79, 56);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(67, 30);
            this.btnFree.TabIndex = 0;
            this.btnFree.Text = "Xem";
            this.btnFree.UseVisualStyleBackColor = true;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // radView
            // 
            this.radView.AutoSize = true;
            this.radView.Checked = true;
            this.radView.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radView.Location = new System.Drawing.Point(22, 55);
            this.radView.Name = "radView";
            this.radView.Size = new System.Drawing.Size(55, 21);
            this.radView.TabIndex = 2;
            this.radView.TabStop = true;
            this.radView.Text = "Xem";
            this.radView.UseVisualStyleBackColor = true;
            this.radView.CheckedChanged += new System.EventHandler(this.radView_CheckedChanged);
            // 
            // frmDeAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 440);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeAn";
            this.Text = "Đề Án";
            this.Load += new System.EventHandler(this.frmDeAn_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textID2;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.TextBox textPlace;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
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
    }
}