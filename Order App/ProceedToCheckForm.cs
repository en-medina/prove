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
    public partial class ProceedToCheckForm : Form
    {
        int customerID, employeeID;
        string employeeName;
        PrincipalMenu principalmenu;
        Database database;
        public ProceedToCheckForm()
        {
            customerID = -1;
            database = new Database();
            InitializeComponent();
            listViewProceedToCheck.FullRowSelect = true;
            listViewProceedToCheck.GridLines = true;

            listViewProceedToCheck.Columns.Add("id", -2, HorizontalAlignment.Left);
            listViewProceedToCheck.Columns.Add("nombre", -2, HorizontalAlignment.Left);
            listViewProceedToCheck.Columns.Add("cantidad", -2, HorizontalAlignment.Left);
            listViewProceedToCheck.Columns.Add("precio", -2, HorizontalAlignment.Left);
        }
        public void getCart(PrincipalMenu data, int empID, string name)
        {
            principalmenu = data;
            employeeID = empID;
            employeeName = name;
            labelEmpName.Text = name;
            labelEmpID.Text = empID.ToString();
        }
        private void ProceedToCheckForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listViewProceedToCheck.Items.Clear();
            if (!database.checkCustomerID(ProceedCheckIDCustomer.Text)) {
                MessageBox.Show("El ID del cliente es incorrecto.");
                return;
            }
            labelIDCustomer.Text = ProceedCheckIDCustomer.Text;
            customerID = int.Parse(ProceedCheckIDCustomer.Text);
            if (!principalmenu.Cart.ContainsKey(customerID))
            {
                MessageBox.Show("El cliente con ID "+ labelIDCustomer.Text+" no tiene articulos en espera.");
                return;
            }
            if (principalmenu.Cart[customerID].Count == 0)
            {
                MessageBox.Show("El cliente con ID " + labelIDCustomer.Text + " no tiene articulos en espera.");
                return;
            }
            listViewProceedToCheck.Items.Clear();
            double total = 0;
            foreach (Item item in principalmenu.Cart[customerID])
            {
                string[] row ={
                        item.id,
                        item.name,
                        item.quantity,
                        item.price
                    };
                if(item.price != "")
                    total += double.Parse(item.price) * int.Parse(item.quantity);
                listViewProceedToCheck.Items.Add(new ListViewItem(row));
            }
            Total.Text = "$DOP "+ total.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (principalmenu.Cart.ContainsKey(customerID))
            {
                database.createOrder(customerID, employeeID, principalmenu.Cart[customerID]);
                principalmenu.Cart[customerID].Clear();
                MessageBox.Show("Se ha generado el pedido");
                this.Close();
            }
            else MessageBox.Show("El cliente con el ID "+ customerID.ToString() +" no tiene nada en su carrito");
        }
    }
}
