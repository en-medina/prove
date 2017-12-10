using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_App
{
    public class Item
    {
        public string name;
        public string quantity;
        public string id;
        public string price;
        public Item(string p_name, string p_quantity, string p_id, string p_price)
        {
            name = p_name;
            quantity = p_quantity;
            id = p_id;
            price = p_price;
        }
    }
    public class Order
    {
        public int id;
        public int id_customer;
        public int id_employee;
        public string date_of_check;
        public string date_of_ship;

        public Order(int pid,int pid_customer, int p_id_employee, string pdate_of_check, string pdate_of_ship)
        {
            id = pid;
            id_customer = pid_customer;
            id_employee = p_id_employee;
            date_of_check = pdate_of_check;
            date_of_ship = pdate_of_ship;
        }
    }
    public class People
    {
        public int id;
        public string name;
        public string lstname;
        public string zipcode;

        public People(int pid, string n, string lstn, string zip)
        {
            id = pid;
            name = n;
            lstname = lstn;
            zipcode = zip;
        }
    }
}
