namespace TinhTienDien
{
    partial class CalculateBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_last = new System.Windows.Forms.TextBox();
            this.txt_this = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.listBill = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastmonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thismonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.used = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_used = new System.Windows.Forms.Label();
            this.lb_bill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(353, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(130, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_name.Location = new System.Drawing.Point(267, 199);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(208, 25);
            this.txt_name.TabIndex = 2;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_phone.Location = new System.Drawing.Point(267, 246);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(208, 25);
            this.txt_phone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(130, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(619, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Month";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(618, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "This Month";
            // 
            // txt_last
            // 
            this.txt_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_last.Location = new System.Drawing.Point(739, 187);
            this.txt_last.Name = "txt_last";
            this.txt_last.Size = new System.Drawing.Size(100, 29);
            this.txt_last.TabIndex = 7;
            this.txt_last.TextChanged += new System.EventHandler(this.txt_last_TextChanged);
            // 
            // txt_this
            // 
            this.txt_this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_this.Location = new System.Drawing.Point(739, 244);
            this.txt_this.Name = "txt_this";
            this.txt_this.Size = new System.Drawing.Size(100, 29);
            this.txt_this.TabIndex = 8;
            this.txt_this.TextChanged += new System.EventHandler(this.txt_this_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(493, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amount of electricity used";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(548, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total electricity bill";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(474, 437);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 35);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(174, 437);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(109, 35);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(324, 437);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 35);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // listBill
            // 
            this.listBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.phone,
            this.lastmonth,
            this.thismonth,
            this.used,
            this.bill});
            this.listBill.Location = new System.Drawing.Point(134, 520);
            this.listBill.Name = "listBill";
            this.listBill.Size = new System.Drawing.Size(994, 170);
            this.listBill.TabIndex = 14;
            this.listBill.UseCompatibleStateImageBehavior = false;
            this.listBill.View = System.Windows.Forms.View.Details;
            this.listBill.SelectedIndexChanged += new System.EventHandler(this.listBill_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "CustomerName";
            this.name.Width = 196;
            // 
            // phone
            // 
            this.phone.Text = "Phone Number";
            this.phone.Width = 169;
            // 
            // lastmonth
            // 
            this.lastmonth.Text = "Last Month";
            this.lastmonth.Width = 161;
            // 
            // thismonth
            // 
            this.thismonth.Text = "This Month";
            this.thismonth.Width = 125;
            // 
            // used
            // 
            this.used.Text = "Amount Used";
            this.used.Width = 123;
            // 
            // bill
            // 
            this.bill.Text = "Total Bill";
            this.bill.Width = 188;
            // 
            // lb_used
            // 
            this.lb_used.AutoSize = true;
            this.lb_used.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_used.ForeColor = System.Drawing.Color.Red;
            this.lb_used.Location = new System.Drawing.Point(735, 309);
            this.lb_used.Name = "lb_used";
            this.lb_used.Size = new System.Drawing.Size(54, 24);
            this.lb_used.TabIndex = 15;
            this.lb_used.Text = "Used";
            this.lb_used.Visible = false;
            // 
            // lb_bill
            // 
            this.lb_bill.AutoSize = true;
            this.lb_bill.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_bill.ForeColor = System.Drawing.Color.Red;
            this.lb_bill.Location = new System.Drawing.Point(735, 364);
            this.lb_bill.Name = "lb_bill";
            this.lb_bill.Size = new System.Drawing.Size(40, 24);
            this.lb_bill.TabIndex = 16;
            this.lb_bill.Text = "Bill";
            this.lb_bill.Visible = false;
            // 
            // CalculateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 790);
            this.Controls.Add(this.lb_bill);
            this.Controls.Add(this.lb_used);
            this.Controls.Add(this.listBill);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_this);
            this.Controls.Add(this.txt_last);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculateBill";
            this.Text = "CalculateBill";
            this.Load += new System.EventHandler(this.CalculateBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_last;
        private System.Windows.Forms.TextBox txt_this;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListView listBill;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader lastmonth;
        private System.Windows.Forms.ColumnHeader thismonth;
        private System.Windows.Forms.ColumnHeader used;
        private System.Windows.Forms.ColumnHeader bill;
        private System.Windows.Forms.Label lb_used;
        private System.Windows.Forms.Label lb_bill;
    }
}