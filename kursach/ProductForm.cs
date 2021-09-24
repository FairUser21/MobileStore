using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kursach
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }
        //подключение к необходимой базе данных
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kursach\kursach\MobStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void fillcombo()//Метод для комбобокса
        {

            Connect.Open();
            SqlCommand cmd = new SqlCommand("select BrandName from BrandTable", Connect);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BrandName", typeof(string));
            dt.Load(rdr);
            BrandCB.ValueMember = "BrandName";
            BrandCB.DataSource = dt;
            Connect.Close();

        }
        //Вывод в DGV
        private void populate()
        {
            Connect.Open();
            string query = "select * from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            prodDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }
        //вывод данных сразу же после загрузки
        private void ProductForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcombo();
        }
        //переход в окно Brands
        private void button1_Click(object sender, EventArgs e)
        {
            BrandsForm brand = new BrandsForm();
            brand.Show();
            this.Hide();
        }

        //ADD
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                string query = "insert into ProductTable values(" + prodID.Text + ",'" + prodName.Text + "'," + prodQty.Text + "," + prodPrice.Text + ",'"+BrandCB.SelectedValue.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Connect.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Выбор необходимой ячейки в DGV, на текст боксы
        private void prodDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.prodDGV.Rows[e.RowIndex];

                prodID.Text = row.Cells["ProdID"].Value.ToString();
                prodName.Text = row.Cells["ProdName"].Value.ToString();
                prodQty.Text = row.Cells["ProdQty"].Value.ToString();
                prodPrice.Text = row.Cells["ProdPrice"].Value.ToString();
                BrandCB.Text = row.Cells["ProdCat"].Value.ToString();
            }
        }
        //переход в окно Seller
        private void button2_Click(object sender, EventArgs e)
        {
            SellerFrom seller = new SellerFrom();
            seller.Show();
            this.Hide();
        }
        //Delete
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodID.Text == "")
                {
                    MessageBox.Show("Select the Brand to Delete");
                }
                else
                {
                    Connect.Open();
                    string query = "delete from ProductTable where ProdID=" + prodID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Connect.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           //Edit
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodID.Text == "" || prodName.Text == "" || prodQty.Text == "" || prodPrice.Text == "" )
                {
                    MessageBox.Show("Missing data");
                }
                Connect.Open();
                string query = "update ProductTable set ProdName='" + prodName.Text + "',ProdQty=" + prodQty.Text + ",ProdPrice='" + prodPrice.Text + "',ProdCat='" + BrandCB.SelectedValue.ToString() + "'where ProdID=" + prodID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Connect); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product was successully updated");
                Connect.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            populate();
        }
        //переход в окно авторизации
        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
