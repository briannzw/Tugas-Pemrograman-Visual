using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Sederhana
{
    public partial class Form1 : Form
    {
        Database DB = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOrderList();
            SetOrderID();
        }

        void LoadOrderList()
        {
            dataGridView1.DataSource = DB.LoadOrderList();
            dataGridView1.DataMember = "OrderList";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void SetOrderID()
        {
            lbl_orderID.Text = DB.LoadOrderID();
        }

        void ClearOrderInput()
        {
            tb_name.Clear();
            cb_drinks.SelectedItem = null;
            cb_cold.Checked = false;
            rb_small.Checked = false;
            rb_medium.Checked = false;
            rb_large.Checked = false;
            cb_boba.Checked = false;
            cb_jelly.Checked = false;
            cb_nata.Checked = false;
            cb_pudding.Checked = false;
        }

        void ClearEditInput()
        {

            tb_name_e.Clear();
            lbl_orderID_e.Text = "-";
            cb_drinks_e.SelectedItem = null;
            cb_cold_e.Checked = false;
            rb_small_e.Checked = false;
            rb_medium_e.Checked = false;
            rb_large_e.Checked = false;
            cb_boba_e.Checked = false;
            cb_jelly_e.Checked = false;
            cb_nata_e.Checked = false;
            cb_pudding_e.Checked = false;
        }

        bool OrderInputNull()
        {
            bool check = false;
            
            // Jika nama kosong
            if (string.IsNullOrEmpty(tb_name.Text)) check = true;

            // Jika drinks tidak dipilih dan radio button tidak dipilih
            check = (check || cb_drinks.SelectedItem == null || (rb_small.Checked == false
                && rb_medium.Checked == false && rb_large.Checked == false));

            return check;
        }

        bool EditInputNull()
        {
            bool check = false;

            // Jika nama kosong
            if (string.IsNullOrEmpty(tb_name_e.Text)) check = true;

            // Jika drinks tidak dipilih dan radio button tidak dipilih
            check = (check || cb_drinks_e.SelectedItem == null || (rb_small_e.Checked == false
                && rb_medium_e.Checked == false && rb_large_e.Checked == false));

            return check;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            if (OrderInputNull())
            {
                MessageBox.Show("Mohon isi terlebih dahulu");
                return;
            }

            string drinkSize = (rb_small.Checked) ? "Small" : (rb_medium.Checked) ? "Medium" : (rb_large.Checked) ? "Large" : "";

            // Masukkan topping ke dalam list
            List<string> toppings = new List<string>();
            if (cb_boba.Checked) toppings.Add("Boba");
            if (cb_jelly.Checked) toppings.Add("Jelly");
            if (cb_nata.Checked) toppings.Add("Nata De Coco");
            if (cb_pudding.Checked) toppings.Add("Pudding");
            string toppingList = string.Join(",", toppings);

            if(DB.AddOrder(tb_name.Text, cb_drinks.SelectedItem.ToString(), cb_cold.Checked, drinkSize, toppingList))
            {
                LoadOrderList();
                SetOrderID();
                ClearOrderInput();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tb_name_e.Text = row.Cells["Name"].Value.ToString();
                lbl_orderID_e.Text = row.Cells["OrderID"].Value.ToString();
                cb_drinks_e.SelectedItem = row.Cells["Drinks"].Value.ToString();
                cb_cold_e.Checked = (row.Cells["Cold"].Value.ToString() == "True") ? true : false;

                // Cek Size yang benar
                string checkSize = row.Cells["Size"].Value.ToString();
                if (checkSize == "Small") rb_small_e.Select();
                else if (checkSize == "Medium") rb_medium_e.Select();
                else if (checkSize == "Large") rb_large_e.Select();

                // Handle topping list
                string toppingList = row.Cells["Topping"].Value.ToString();
                List<string> toppings = toppingList.Split(',').ToList();

                foreach(string topping in toppings)
                {
                    if (topping == "Boba") cb_boba_e.Checked = true;
                    else if (topping == "Jelly") cb_jelly_e.Checked = true;
                    else if (topping == "Nata De Coco") cb_nata_e.Checked = true;
                    else if (topping == "Pudding") cb_pudding_e.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (EditInputNull())
            {
                MessageBox.Show("Mohon isi terlebih dahulu");
                return;
            }

            string drinkSize = (rb_small_e.Checked) ? "Small" : (rb_medium_e.Checked) ? "Medium" : (rb_large_e.Checked) ? "Large" : "";

            // Masukkan topping ke dalam list
            List<string> toppings = new List<string>();
            if (cb_boba_e.Checked) toppings.Add("Boba");
            if (cb_jelly_e.Checked) toppings.Add("Jelly");
            if (cb_nata_e.Checked) toppings.Add("Nata De Coco");
            if (cb_pudding_e.Checked) toppings.Add("Pudding");
            string toppingList = string.Join(",", toppings);

            if (DB.EditOrder(lbl_orderID_e.Text, tb_name_e.Text, cb_drinks_e.SelectedItem.ToString(),
                cb_cold_e.Checked, drinkSize, toppingList))
            {
                LoadOrderList();
                ClearEditInput();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(lbl_orderID_e.Text == "-")
            {
                MessageBox.Show("Mohon pilih order di List of Order terlebih dahulu.");
                return;
            }

            if (DB.DeleteOrder(lbl_orderID_e.Text))
            {
                LoadOrderList();
                SetOrderID();
                ClearEditInput();
            }
        }
    }
}
