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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string SellerName = "";//открытая переменная нужна для формы Selling
        private void label7_Click(object sender, EventArgs e) //label "Сlear"
        {
            uname.Text = "";
            pass.Text = "";
        }
        //фунция для авторизации
        private void button2_Click(object sender, EventArgs e)
        {
            //если поля пустые - то выводит ошибку
            if (uname.Text=="" || pass.Text == "")
            {
                MessageBox.Show("Please enter Username & Password");
            }
            
            else
            {
                if (roleCB.SelectedIndex > -1)
                {
                    if (roleCB.SelectedItem.ToString() == "Admin")
                    {
                        //иначе если Admin и Admin, то открывает соответсвующее окно
                        if (uname.Text == "Admin" && pass.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are the Admin, Enter the Correct Login and Password ");
                        }
                    }
                    // а здесь авторизация для продавцов
                    else
                    {
                        //подключаемся к базе продавцов
                        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kursach\kursach\MobStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
                        //выбираем подходящего юзера из базы
                        SqlCommand sqlCom = new SqlCommand("Select count(*) from SellerTable where SellerName='" + uname.Text + "'and SellerPass'" + pass.Text + "'", Connect);
                        sqlCom.Parameters.Add("uname", SqlDbType.VarChar).Value = this.uname.Text;
                        sqlCom.Parameters.Add("pass", SqlDbType.VarChar).Value = this.pass.Text;
                        //стандартная процедура sql запроса
                        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCom);
                        DataTable sqlDt = new DataTable();
                        SellerName = uname.Text;
                        SellingForm sell = new SellingForm();
                        sell.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }
    }
}
