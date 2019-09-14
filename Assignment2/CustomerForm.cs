using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (txtNameInput.Text == "")
            {
                MessageBox.Show("Please Write Your Name");
            }
            else if (txtContactInput.Text == "")
            {
                MessageBox.Show("Please Write Your Phone Number");
            }
            else if (txtAddressInput.Text == "")
            {
                MessageBox.Show("Please Write Your Address");
            }
            else if (comboBoxItem.Text == "")
            {
                MessageBox.Show("Please Select Your Item");
            }
            else if (txtQuantityInput.Text == "")
            {
                MessageBox.Show("Please Write Your Item Quantity");
            }
            else
            {
                string name = txtNameInput.Text;
                string contact = txtContactInput.Text;
                string address = txtAddressInput.Text;
                string item = comboBoxItem.Text;
                string quantity = txtQuantityInput.Text;
                int quantityofitem = Convert.ToInt32(quantity);

                int totalprice;
                string showbill;
                if (item == "Black Coffee")
                {
                    totalprice = 120 * quantityofitem;
                    showbill = Convert.ToString(totalprice);
                }
                else if (item == "Cold Coffee")
                {
                    totalprice = 100 * quantityofitem;
                    showbill = Convert.ToString(totalprice);
                }
                else if (item == "Hot Coffee")
                {
                    totalprice = 90 * quantityofitem;
                    showbill = Convert.ToString(totalprice);
                }
                else if (item == "Reguler Coffee")
                {
                    totalprice = 80 * quantityofitem;
                    showbill = Convert.ToString(totalprice);
                }
                else
                {
                    showbill = "0 tk.";
                }
                MoneyReceipt.AppendText("Customer Name : " + name + "\n\n");
                MoneyReceipt.AppendText("Customer Contact Number : " + contact + "\n\n");
                MoneyReceipt.AppendText("Customer Address : " + address + "\n\n");
                MoneyReceipt.AppendText("Customer Ordered Item : " + item + "\n\n");
                MoneyReceipt.AppendText("Quantity of this item  : " + quantity + "\n\n");
                MoneyReceipt.AppendText("Your tatal bill : " + showbill);
            }
        }
    }
}
