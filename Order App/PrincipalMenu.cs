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
    public partial class PrincipalMenu : Form
    {
        public Dictionary<int, List<Item>> Cart;
        Database database;
        LogIn log;
        int customerForOrders;
        public PrincipalMenu()
        {
            this.FormClosed += PrincipalMenu_FormClosed;
            database = new Database();
            Cart = new Dictionary<int, List<Item>>();
            InitializeComponent();
            listViewOrder.FullRowSelect = true;
            listViewOrder.GridLines = true;
            listViewData.GridLines = true;
            listViewData.FullRowSelect = true;

            listViewOrder.Columns.Add("ID orden", -2,HorizontalAlignment.Left);
            listViewOrder.Columns.Add("ID empleado", -2, HorizontalAlignment.Left);
            listViewOrder.Columns.Add("dia procesado", -2, HorizontalAlignment.Left);
            listViewOrder.Columns.Add("dia de despacho", -2, HorizontalAlignment.Left);
               
        }

        public void receiveData(string name, string id, LogIn logIn)
        {
            log = logIn;
            NombreEmpleado.Text = name;
            IDEmpleado.Text = id;
        }
        private int convertInt(string data, string errInfo)
        {
            int ans = 0;
            if (data.Length >= 9) return -1;
            try
            {
                ans = int.Parse(data);
                if (ans < 0) {
                    MessageBox.Show(errInfo + " tiene un numero inválido");
                    return -1;
                }
                else return ans;
            }
            catch
            {
                MessageBox.Show(errInfo + " tiene un formato incorrecto..");
                return -1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBoxEmpleado.Visible = false;
            groupBoxArticulo.Visible = false;
            groupBoxCliente.Visible = false;
            switch (comboBox1.SelectedItem)
            {
                case "Empleado":
                    groupBoxEmpleado.Visible = true;
                    break;
                case "Articulo":
                    groupBoxArticulo.Visible = true;
                    break;
                case "Cliente":
                    groupBoxCliente.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (database.checkCustomerID(IDCustomer.Text)) MessageBox.Show("El ID fue encontrado");
            else MessageBox.Show("El ID no fue encontrado");
        }

        private bool addNewItem(int id)
        {

            Item item = database.checkItem(IDItem.Text, ItemQuantity.Text);
            if (item == null)
            {
                MessageBox.Show("Articulo no disponible.");
                ItemAdded.Visible = false;
                return false;
            }
            if (!Cart.ContainsKey(id))
                Cart.Add(id, new List<Item>());
            Cart[id].Add(item);
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            bool finish = false;
            if (!database.checkCustomerID(IDCustomer.Text)) {
                MessageBox.Show("El ID del cliente no fue encontrado");
                ItemAdded.Visible = false;
                return;
            }
            id = int.Parse(IDCustomer.Text);

            if (Cart.ContainsKey(id))
            {
                int index = Cart[id].FindIndex(x => x.id == IDItem.Text);
                if (index != -1)
                {
                    int amount = convertInt(ItemQuantity.Text, "el campo cantidad");
                    if (amount != -1)
                    {
                        string s_amount = (int.Parse(Cart[id][index].quantity) + amount).ToString();
                        Item a = database.checkItem(IDItem.Text, s_amount);
                        if (a != null)
                        {
                            Cart[id][index].quantity = s_amount;
                            finish = true;
                        }
                        else
                        {
                            MessageBox.Show("Articulo no disponible.");
                            ItemAdded.Visible = false;
                            return;
                        }
                    }
                    else return;
                }
                else finish = addNewItem(id);
            }
            else finish = addNewItem(id);

            if (finish)
            {
                ItemAdded.Text = "El articulo fue agregado ha " + IDCustomer.Text;
                ItemAdded.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!database.checkCustomerID(OrderIDCustomer.Text))
            {
                MessageBox.Show("El ID del cliente no fue encontrado");
                return;
            }
            customerForOrders = int.Parse(OrderIDCustomer.Text);
            List<Order> array = database.getOrders(customerForOrders);
            listViewOrder.Items.Clear();
            if (array == null)
                return;
            foreach(Order order in array)
            {
                string[] row ={
                        order.id.ToString(),
                        order.id_employee.ToString(),
                        order.date_of_check,
                        order.date_of_ship
                    };
                listViewOrder.Items.Add(new ListViewItem(row));
            }
        }
        public delegate void sendValueCheck(string orderID, int customerID, string empID, 
            string actualDate, string shipDate);

        private void listViewOrder_MouseDoubleClick(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count > 0)
            {
                string orderID = listViewOrder.SelectedItems[0].SubItems[0].Text;
                string empID = listViewOrder.SelectedItems[0].SubItems[1].Text;
                string dateCheck = listViewOrder.SelectedItems[0].SubItems[2].Text;
                string dateShip = listViewOrder.SelectedItems[0].SubItems[3].Text;

                CheckOrderForm m = new CheckOrderForm();
                sendValueCheck sendValue = new sendValueCheck(m.receiveData);
                sendValue(orderID, customerForOrders, empID, dateCheck, dateShip);
                m.Show();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int zip = convertInt(InsertCustomerZip.Text, "El zip code");
            if (zip == -1)
                return;
            if(InsertCustomerName.Text==""|| InsertCustomerLstName.Text=="")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            string respond = database.insertCustomer(InsertCustomerName.Text, InsertCustomerLstName.Text, zip);
            if (respond != null)
            {
                MessageBox.Show("El cliente fue agregado, su id es " + respond);
                InsertCustomerZip.Clear();
                InsertCustomerName.Clear();
                InsertCustomerLstName.Clear();
            }
            else MessageBox.Show("El cliente no pudo ser agregado");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int quantity = convertInt(InsertItemQuantity.Text,"La cantidad"), price = 0;
            if (quantity == -1) return;
            price = convertInt(InsertItemPrice.Text, "El precio");
            if (price == -1) return;
            if (InsertItemName.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            string respond = database.insertItem(InsertItemName.Text,quantity,price);
            if (respond != null)
            {
                MessageBox.Show("El item fue agregado, su id es " + respond);
                InsertItemQuantity.Clear();
                InsertItemPrice.Clear();
                InsertItemName.Clear();
            }
            else MessageBox.Show("El item no pudo ser agregado");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int zip = convertInt(InsertEmpZip.Text, "El zip code");
            if (zip == -1)
                return;
            if (InsertEmpName.Text == ""|| InsertEmpLstName.Text == "" ||
                InsertEmpPass.Text =="" || InsertEmpPass2.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }
            if(InsertEmpPass2.Text != InsertEmpPass.Text)
            {
                MessageBox.Show("Las claves no coinciden.");
                return;
            }
            string respond = database.insertEmployee(InsertEmpName.Text, InsertEmpLstName.Text, zip, InsertEmpPass.Text);
            if (respond != null)
            {
                MessageBox.Show("El empleado fue agregado, su id es " + respond);
                InsertEmpZip.Clear();
                InsertEmpName.Clear();
                InsertEmpLstName.Clear();
                InsertEmpPass.Clear();
                InsertEmpPass2.Clear();
            }
            else MessageBox.Show("El empleado no pudo ser agregado");
        }
        public delegate void sendClass(PrincipalMenu principalMenu, int id, string empname);
        private void button3_Click(object sender, EventArgs e)
        {
            ProceedToCheckForm m = new ProceedToCheckForm();
            sendClass sendValue = new sendClass(m.getCart);
            sendValue(this, int.Parse(IDEmpleado.Text), NombreEmpleado.Text);
            m.Show();
        }

        private void changeItem(List<Item> list)
        {
            listViewData.Clear();
            listViewData.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listViewData.Columns.Add("nombre", 130, HorizontalAlignment.Left);
            listViewData.Columns.Add("precio", 130, HorizontalAlignment.Left);
            listViewData.Columns.Add("cantidad", 150, HorizontalAlignment.Left);
            foreach (Item item in list)
            {
                string[] row ={
                        item.id.ToString(),
                        item.name,
                        item.price,
                        item.quantity
                    };
                listViewData.Items.Add(new ListViewItem(row));
            }
        }

        private void changePeople(List<People> list)
        {
            listViewData.Clear();
            listViewData.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listViewData.Columns.Add("Nombre", 130, HorizontalAlignment.Left);
            listViewData.Columns.Add("Apellido", 130, HorizontalAlignment.Left);
            listViewData.Columns.Add("Código postal", 150, HorizontalAlignment.Left);
            foreach (People item in list)
            {
                string[] row ={
                        item.id.ToString(),
                        item.name,
                        item.lstname,
                        item.zipcode
                        };
                listViewData.Items.Add(new ListViewItem(row));
            }
        }


        List<People> list_people_search;
        List<Item> list_item_search;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "Articulo":
                    list_item_search = database.getAllItem();
                    changeItem(list_item_search);
                    break;
                case "Empleado":
                    list_people_search = database.getAllEmployees();
                    changePeople(list_people_search);
                    break;
                case "Cliente":
                    list_people_search = database.getAllCustomers();
                    changePeople(list_people_search);
                    break;
                default:
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "Articulo":
                    changeItem(list_item_search.FindAll(
                        x=>x.name.Contains(textBoxSearch.Text)));
                    break;
                case "Empleado":
                    changePeople(list_people_search.FindAll(
                        x=>x.name.Contains(textBoxSearch.Text)
                        ));
                    break;
                case "Cliente":
                    changePeople(list_people_search.FindAll(
                        x => x.name.Contains(textBoxSearch.Text)
                        ));
                    break;
                default:
                    break;
            }
        }
        private void PrincipalMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Visible = true;
        }
        private void IDItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalMenu_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
