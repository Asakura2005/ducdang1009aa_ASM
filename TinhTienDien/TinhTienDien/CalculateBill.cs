using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTienDien
{
    public partial class CalculateBill : Form
    {
        public CalculateBill()
        {
            InitializeComponent();
        }

        private void CalculateBill_Load(object sender, EventArgs e)
        {
            
        }

       
        private void txt_this_TextChanged(object sender, EventArgs e)
        {
            float temp;

            if (txt_this.TextLength >= 1 && !float.TryParse(txt_this.Text, out temp) )
            {
                MessageBox.Show("Please enter a valid number.");
                txt_this.Clear();
                return;
            }

            if (!string.IsNullOrEmpty(txt_this.Text) && !string.IsNullOrEmpty(txt_last.Text))
            {
                float used = 0;
                float current = float.Parse(txt_this.Text);
                float last = float.Parse(txt_last.Text);
                used = current - last;
                lb_used.Text = used.ToString();
                lb_used.Visible = true;
                calculate();
            }
        }

      

        private void btn_add_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text;
            String phone = txt_phone.Text;
            String lastMonth = txt_last.Text;
            String thisMonth = txt_this.Text;
            String used = lb_used.Text;
            String bill = lb_bill.Text;

            if (!string.IsNullOrEmpty(name))
            {

                ListViewItem item = new ListViewItem(name);
                listBill.Items.Add(item);
                item.SubItems.Add(phone);
                item.SubItems.Add(lastMonth);
                item.SubItems.Add(thisMonth);
                item.SubItems.Add(used);
                item.SubItems.Add(bill);

                clearInput();
            }
        }

        private void calculate()
        {
            // Lấy giá trị điện năng tiêu thụ từ lb_used
            float current = float.Parse(lb_used.Text);

            float bill = 0;

            if (current <= 50)
            {
                bill = current * 1806;
            }
            else if (current <= 100)
            {
                bill = 50 * 1806 + (current - 50) * 1866;
            }
            else if (current <= 200)
            {
                bill = 50 * 1806 + 50 * 1866 + (current - 100) * 2167;
            }
            else if (current <= 300)
            {
                bill = 50 * 1806 + 50 * 1866 + 100 * 2167 + (current - 200) * 2729;
            }
            else if (current <= 400)
            {
                bill = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (current - 300) * 3050;
            }
            else
            {
                bill = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + 100 * 3050 + (current - 400) * 3151;
            }

            lb_bill.Visible = true;
            lb_bill.Text = bill.ToString();
        }

        private void clearInput()
        {
            txt_name.Text="";
            txt_phone.Text="";
            txt_last.Text="";
            txt_this.Text="";
            lb_used.Text="";
            lb_bill.Text="";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void txt_last_TextChanged(object sender, EventArgs e)
        {
            float temp;
            if (txt_last.TextLength >= 1 && !float.TryParse(txt_last.Text, out temp))
            {
                MessageBox.Show("Please enter a valid number.");
                txt_last.Clear();
                return;
            }
        }

        private void listBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBill.SelectedItems.Count > 0)
            {
               
                ListViewItem selectedItem = listBill.SelectedItems[0];

                txt_name.Text = selectedItem.SubItems[0].Text;
                txt_phone.Text = selectedItem.SubItems[1].Text;
                txt_last.Text = selectedItem.SubItems[2].Text;
                txt_this.Text = selectedItem.SubItems[3].Text;
                lb_used.Text = selectedItem.SubItems[4].Text;
                lb_bill.Text = selectedItem.SubItems[5].Text;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listBill.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listBill.SelectedItems[0];
                listBill.Items.Remove(selectedItem);
                clearInput();
            
                lb_used.Visible = false;
                lb_bill.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
    }
}
