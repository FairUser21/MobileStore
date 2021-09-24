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
    public partial class SellerFrom : Form
    {
        public SellerFrom()
        {
            InitializeComponent();
        }
        //инициализируем базу данных
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kursach\kursach\MobStoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        //Вывод в DGV
        private void populate()
        {
            Connect.Open();
            string query = "select * from SellerTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellerDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }
        //вывод сразу же после загрузки
        private void SellerFrom_Load(object sender, EventArgs e)
        {
            populate();
        }

        //ADD
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                string query = "insert into SellerTable values(" + SellerID.Text + ",'" + SellerName.Text + "','" + SellerSal.Text + "," + SellerPhone.Text + "," + SellerPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                Connect.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //DELETE
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerID.Text == "")
                {
                    MessageBox.Show("Select the Seller to Delete");
                }
                else
                {
                    Connect.Open();
                    string query = "delete from SellerTable where SellerID=" + SellerID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Connect.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //EDIT
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerID.Text == "" || SellerName.Text == "" || SellerSal.Text == "" || SellerPhone.Text == "" || SellerPass.Text == "")
                {
                    MessageBox.Show("Missing data");
                }
                Connect.Open();
                string query = "update SellerTable set SellerName='" + SellerName.Text + "',SellerSalary=" + SellerSal.Text + ",SellerPhone='" + SellerPhone.Text + "',SellerPass='" + SellerPass.Text + "'where SellerID=" + SellerID.Text + ";";
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
        //Выбор необходимой ячейки в DGV, на текст боксы
        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SellerDGV.Rows[e.RowIndex];

                SellerID.Text = row.Cells["SellerID"].Value.ToString();
                SellerName.Text = row.Cells["SellerName"].Value.ToString();
                SellerSal.Text = row.Cells["SellerSalary"].Value.ToString();
                SellerPhone.Text = row.Cells["SellerPhone"].Value.ToString();
                SellerPass.Text = row.Cells["SellerPass"].Value.ToString();
            }
        }
        //ADD
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                string query = "insert into SellerTable values(" + SellerID.Text + ",'" + SellerName.Text + "'," + SellerSal.Text + ",'" + SellerPhone.Text + "','" + SellerPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                Connect.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Переход к окну авторизации
        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
        //Переход к Product Form
        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }
        //Переход к Brand Form
        private void button1_Click(object sender, EventArgs e)
        {
            BrandsForm brand = new BrandsForm();
            brand.Show();
            this.Hide();
        }
    }
}
