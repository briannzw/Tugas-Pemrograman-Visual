using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Program_Sederhana
{
    class Database
    {
        private SqlCommand cmd;

        public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = LAPTOP-VSQVNNEU; initial catalog=DB_Minuman; integrated security = true";
            return conn;
        }

        // READ
        public DataSet LoadOrderList()
        {
            SqlConnection conn = Connect();

            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM OrderList", conn);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "OrderList");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ds;
            }

            conn.Close();
            return ds;
        }

        // READ
        public string LoadOrderID()
        {
            SqlConnection conn = Connect();

            SqlDataReader rd;
            string orderID = "";

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM OrderList WHERE OrderID IN(SELECT max(OrderID) FROM OrderList) ORDER BY OrderID desc", conn);
                rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    long count = Convert.ToInt64(rd[0].ToString().Substring(rd[0].ToString().Length - 3, 3)) + 1;
                    string orderCode = "000" + count;
                    orderID = "ORD_" + orderCode.Substring(orderCode.Length - 3, 3);
                }
                else
                {
                    orderID = "ORD_001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return orderID;
            }

            conn.Close();
            return orderID;
        }

        // ADD
        public bool AddOrder(string name, string drinks, bool cold, string size, string topping)
        {
            SqlConnection conn = Connect();

            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO OrderList VALUES ('" + LoadOrderID() + "','" + name + "','" + drinks + "','" + cold
                    + "','" + size + "','" + topping + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add Order Success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("SQL Error : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            conn.Close();
            return true;
        }

        // EDIT or UPDATE
        public bool EditOrder(string orderID, string name, string drinks, bool cold, string size, string topping)
        {
            SqlConnection conn = Connect();

            try
            {
                conn.Open();
                cmd = new SqlCommand("UPDATE OrderList SET Name='" + name + "', Drinks='" + drinks + "', Cold='" + cold
                    + "', Size='" + size + "', Topping='" + topping + "' WHERE OrderID='" + orderID + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Order Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            conn.Close();
            return true;
        }

        // DELETE
        public bool DeleteOrder(string orderID)
        {
            SqlConnection conn = Connect();

            try
            {
                conn.Open();
                cmd = new SqlCommand("DELETE FROM OrderList WHERE OrderID='" + orderID + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Order Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error : " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            conn.Close();
            return true;
        }
    }
}
