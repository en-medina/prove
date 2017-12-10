using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_App
{
    public partial class CheckOrderForm : Form
    {
        public CheckOrderForm()
        {
            InitializeComponent();
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;

            listViewItems.Columns.Add("ID artículo", -2, HorizontalAlignment.Left);
            listViewItems.Columns.Add("nombre", -2, HorizontalAlignment.Left);
            listViewItems.Columns.Add("cantidad", -2, HorizontalAlignment.Left);
            listViewItems.Columns.Add("precio $US", -2, HorizontalAlignment.Left);
        }
        public void receiveData(string orderID, int customerID, string empID, string actualDate, string shipDate){
            labelIDOrder.Text = orderID;
            labelIDEmp.Text = empID;
            labelIDCustomer.Text = customerID.ToString();
            labelActualDate.Text = actualDate;
            labelShipDate.Text = shipDate;
            List<Item> arr = (new Database()).getItemsFromOrderDetails(orderID);
            if(arr == null)
            {
                MessageBox.Show("error en el id del pedido.");
                this.Close();
            }
            listViewItems.Items.Clear();
            double amount = 0;
            foreach (Item item in arr)
            {
                string[] row ={
                        item.id.ToString(),
                        item.name,
                        item.quantity,
                        item.price
                    };
                amount += double.Parse(item.price) * int.Parse(item.quantity);
                listViewItems.Items.Add(new ListViewItem(row));
            }
            labelTotal.Text ="DOP$ " + amount.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CheckOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
