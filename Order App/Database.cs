using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Order_App
{
    class Database
    {
        private int convertInt(string data)
        {
            int ans = 0;
            try
            {
                if (data.Length > 9) return -1;
                ans = int.Parse(data);
                if (ans < 0) return -1;
                else return ans;
            }
            catch
            {
                return -1;
            }
        }

        public string authUser(string id, string password)
        {
            int m_id = convertInt(id);
            if (m_id == -1) return null;
            SqlParameter output = new SqlParameter("@name", SqlDbType.VarChar, 30);
            output.Direction = ParameterDirection.Output;
            SqlCommand cmd = (SqlCommand)RunStoredProc("checkEmployeeID", false,
                new SqlParameter("@id_emp", id),
                new SqlParameter("@pass", password),
                output
                );
            string ans = cmd.Parameters["@name"].Value.ToString();
            if (ans == "") return null;
            return ans;
        }
        public Item checkItem(string id, string quantity)
        {
            int m_id = convertInt(id);
            int m_quantity = convertInt(quantity);
            if (m_id == -1 || m_quantity == -1) return null;
            SqlDataReader rdr = (SqlDataReader)RunStoredProc("checkItem", true,
                new SqlParameter("@id", m_id),
                new SqlParameter("@quantity", m_quantity)
                );
            Item item = null;
            if (rdr == null) return null;
            while (rdr.Read())
            {
                item = new Item(
                        rdr.GetString(rdr.GetOrdinal("PartName")),
                        quantity,
                        id,
                        rdr.GetSqlMoney(rdr.GetOrdinal("Price")).ToString()
                    );
            }
            if (rdr != null)
                rdr.Close();
            return item;
        }
        public bool checkCustomerID(string id)
        {
            int m_id = convertInt(id);
            if (m_id == -1) return false;
            SqlParameter output = new SqlParameter("@name", SqlDbType.VarChar, 30);
            output.Direction = ParameterDirection.Output;
            SqlCommand cmd = (SqlCommand)RunStoredProc("checkCustomerID", false,
                new SqlParameter("@id", id),
                output
                );
            string ans = cmd.Parameters["@name"].Value.ToString();
            if (ans == "") return false;
            return true;
        }
        public string insertItem(string name, int quantity, int price)
        {
            SqlParameter output = new SqlParameter("@id", 0);
            output.Direction = ParameterDirection.Output;
            SqlCommand cmd = (SqlCommand)RunStoredProc("insertItem", false,
                new SqlParameter("@name", name),
                new SqlParameter("@quantity", quantity),
                new SqlParameter("@price", price),
                output
                );
            string ans = cmd.Parameters["@id"].Value.ToString();
            if (ans == "") return null;
            return ans;
        }
        public string insertEmployee(string name, string lastname, int zipcode, string password)
        {
            SqlParameter output = new SqlParameter("@id", 0);
            output.Direction = ParameterDirection.Output;
            SqlCommand cmd = (SqlCommand)RunStoredProc("insertEmployee", false,
                new SqlParameter("@name", name),
                new SqlParameter("@ltname", lastname),
                new SqlParameter("@zipcode", zipcode),
                new SqlParameter("@pass", password),
                output
                );
            string ans = cmd.Parameters["@id"].Value.ToString();
            if (ans == "") return null;
            return ans;
        }
        public string insertCustomer(string name, string lastname, int zipcode)
        {
            SqlParameter output = new SqlParameter("@id", 0);
            output.Direction = ParameterDirection.Output;
            SqlCommand cmd = (SqlCommand)RunStoredProc("insertCustomer", false,
                new SqlParameter("@name", name),
                new SqlParameter("@ltname", lastname),
                new SqlParameter("@zipcode", zipcode),
                output
                );
            string ans = cmd.Parameters["@id"].Value.ToString();
            if (ans == "") return null;
            return ans;
        }
        public List<Item> getItemsFromOrderDetails(string orderID)
        {
            int id = convertInt(orderID);
            if (id == -1) return null;
            SqlDataReader rdr = (SqlDataReader)RunStoredProc("getItemsFromOrderDetails", true,
                new SqlParameter("@id", id)
                );
            if (rdr == null) return null;
            List<Item> ans = new List<Item>();
            while (rdr.Read())
            {
                ans.Add(new Item(
                        rdr.GetString(rdr.GetOrdinal("PartName")),
                        rdr.GetSqlInt16(rdr.GetOrdinal("Quantity")).ToString(),
                        rdr.GetSqlInt32(rdr.GetOrdinal("PartID")).ToString(),
                        rdr.GetSqlMoney(rdr.GetOrdinal("Price")).ToString()
                    ));
            }
            if (rdr != null) rdr.Close();
            if (ans.Count == 0) return null;
            return ans;
        }

        public bool createOrder(int customerID, int employeeID, List<Item> items)
        {
            int order_id = -1;
            foreach (Item item in items)
            {
                SqlParameter output = new SqlParameter("@id_order", 0);
                output.Direction = ParameterDirection.Output;
                SqlCommand cmd = (SqlCommand)RunStoredProc("createOrder", false,
                    new SqlParameter("@id", order_id),
                    new SqlParameter("@id_emp", employeeID),
                    new SqlParameter("@id_customer", customerID),
                    new SqlParameter("@id_item", int.Parse(item.id)),
                    new SqlParameter("@item_quantity", Int16.Parse(item.quantity)),
                    output
                    );
                if(order_id == -1)
                    order_id = int.Parse(cmd.Parameters["@id_order"].Value.ToString());
            }
            return true;
        }
        

        public List<Order> getOrders(int customerID)
        {
            SqlDataReader rdr = (SqlDataReader)RunStoredProc("getOrders", true,
                new SqlParameter("@id", customerID)
                );
            if (rdr == null) return null;
            List<Order> ans = new List<Order>();
            while (rdr.Read())
            {
                ans.Add(new Order(
                        int.Parse(rdr.GetSqlInt32(rdr.GetOrdinal("OrderID")).ToString()),
                        int.Parse(rdr.GetSqlInt32(rdr.GetOrdinal("CustomerID")).ToString()),
                        int.Parse(rdr.GetSqlInt32(rdr.GetOrdinal("EmployeeID")).ToString()),
                        rdr.GetSqlDateTime(rdr.GetOrdinal("OrderDate")).ToString(),
                        rdr.GetSqlDateTime(rdr.GetOrdinal("ShippedDate")).ToString()
                    ));
            }
            if (rdr != null) rdr.Close();
            if (ans.Count == 0) return null;
            return ans;
        }
        public List<Item> getAllItem()
        {
            List<Item> ans = new List<Item>();
            SqlDataReader rdr = (SqlDataReader)RunStoredProc("getAllItems", true,
                null
                );
            if (rdr == null) return ans;
            while (rdr.Read())
            {
                ans.Add(new Item(
                        rdr.GetString(rdr.GetOrdinal("PartName")),
                        rdr.GetSqlInt16(rdr.GetOrdinal("UnitStock")).ToString(),
                        rdr.GetSqlInt32(rdr.GetOrdinal("PartID")).ToString(),
                        rdr.GetSqlMoney(rdr.GetOrdinal("Price")).ToString()
                    ));
            }
            if (rdr != null) rdr.Close();
            return ans;
        }
        private List<People> getPeople(string db, params string[] fields)
        {
            List<People> ans = new List<People>();
            SqlDataReader rdr = (SqlDataReader)RunStoredProc(db, true,
                null
                );
            if (rdr == null)
                return ans;
            while (rdr.Read())
            {
                ans.Add(new People(
                        int.Parse(rdr.GetSqlInt32(rdr.GetOrdinal(fields[0])).ToString()),
                        rdr.GetString(rdr.GetOrdinal(fields[1])),
                        rdr.GetString(rdr.GetOrdinal(fields[2])),
                        rdr.GetSqlInt32(rdr.GetOrdinal(fields[3])).ToString()
                    ));
            }
            if (rdr != null) rdr.Close();
            return ans;
        }
        public List<People> getAllCustomers()
        {
            return getPeople("getAllCustomers", "CustomerID", "C_FirstName",
                "C_LastName", "C_ZipCode");
        }
        public List<People> getAllEmployees()
        {
            return getPeople("getAllEmployees", "EmployeeID", "FirstName",
                "LastName", "ZipCode");
        }
        private object RunStoredProc(string storedProcedureName, bool is_table, params SqlParameter[] data)
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            SqlCommand cmd = null;
            try
            {
                // create and open a connection object
                conn = new
                    SqlConnection("Data Source=MEDINA-LAPTOP\\SQLEXPRESS;Initial Catalog=Mail_Order;Integrated Security=True");
                conn.Open();

                // 1. create a command object identifying
                // the stored procedure
                cmd = new SqlCommand(
                    "dbo."+storedProcedureName, conn);

                // 2. set the command object so it knows
                // to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //3. add the parameters to the stored procedure
                if (data != null)
                {
                    foreach (SqlParameter p in data)
                        cmd.Parameters.Add(p);
                }
                // execute the command
                if (is_table) rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                else cmd.ExecuteNonQuery(); 
            }
            finally
            {
                if (conn != null&&!is_table)
                {
                    conn.Close();
                }
            }
            if (is_table) return rdr;
            else return cmd;
        }

    }
}
