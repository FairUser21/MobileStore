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
    public partial class BrandsForm : Form
    {
        public BrandsForm()
        {
            InitializeComponent();
        }
        //подключение базы данных
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kursach\kursach\MobStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
       
        //Вывод в DGV
        private void populate()
        {
            Connect.Open();
            string query = "select * from BrandTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BrandDGV.DataSource = ds.Tables[0];
            Connect.Close();
        }
        //Вывод данных сразу же после загрузки
    private void BrandsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        //Кнопка ADD
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Connect.Open();
                string query = "insert into BrandTable values(" + BrandIdTbl.Text + ",'" + BrandNameTbl.Text + "','" + BrandDescTbl.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Brand Added Successfully");
                Connect.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //Выбор необходимой ячейки в DGV, на текст боксы
        private void BrandDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            //рабочий, но с багом
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.BrandDGV.Rows[e.RowIndex];

                BrandIdTbl.Text = row.Cells["BrandID"].Value.ToString();
                BrandNameTbl.Text = row.Cells["BrandName"].Value.ToString();
                BrandDescTbl.Text = row.Cells["BrandDescription"].Value.ToString();
            }

            
        }
        //Кнопка DELETE
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if(BrandIdTbl.Text == "")
                {
                    MessageBox.Show("Select the Brand to Delete");
                }
                else
                {
                    Connect.Open();
                    string query = "delete from BrandTable where BrandID=" + BrandIdTbl.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Brand Deleted Successfully");
                    Connect.Close();
                    populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Кнопка EDIT
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(BrandIdTbl.Text=="" || BrandNameTbl.Text=="" || BrandDescTbl.Text == "")
                {
                    MessageBox.Show("Missing data");
                }
                Connect.Open();
                string query = "update BrandTable set BrandName='" + BrandNameTbl.Text + "',BrandDescription='" + BrandDescTbl.Text + "'where BrandID=" + BrandIdTbl.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Brand was successully updated");
                Connect.Close();
                populate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Переход к Product Form
        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }
        // Переход к окну авторизации
        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
        // Переход к окну Seller
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellerFrom seller = new SellerFrom();
            seller.Show();
        }
    }
}
