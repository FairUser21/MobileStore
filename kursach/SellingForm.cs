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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        //подключение Базы данных
        SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kursach\kursach\MobStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        //Вывод в DGV
        private void populate()
        {
            Connect.Open();
            string query = "select ProdName, ProdPrice from ProductTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProdDGV1.DataSource = ds.Tables[0];
            Connect.Close();
        }
        //Вывод данных с другой таблицы
        private void populateReceipt()
        {
           
            
            Connect.Open();
            string query = "select * from ReceiptTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Connect);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ReceiptDGV.DataSource = ds.Tables[0];
            Connect.Close();
            
        }
        //Вывод во все DGV, сразу после загрузки формы
        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populateReceipt();
            fillcombo();
            SellerLbl.Text = LoginForm.SellerName;
        }
        
        //Вывод текущей даты
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateLbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        int Grdtotal = 0, n = 0;
        
        //Add
        private void button3_Click(object sender, EventArgs e)
        {

            if (Receipt.Text == "")
            {
                MessageBox.Show("Missing ReceiptID");
            }
            else
            { 
            
            }
                try
                {
                    Connect.Open();
                    string query = "insert into ReceiptTable values(" + receiptID.Text + ",'" + SellerLbl.Text + "','" + DateLbl.Text + "'," + AmtTotal.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully");
                    Connect.Close();
                    populateReceipt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        //ненужно
        private void AmtTotal_Click(object sender, EventArgs e)
        {

        }
        //Print
        private void button4_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void ReceiptDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Выбор необходимой ячейки в DGV, на текст боксы
        private void ProdDGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ProdDGV1.Rows[e.RowIndex];

                ProdName.Text = row.Cells["ProdName"].Value.ToString();
                ProdPrice.Text = row.Cells["ProdPrice"].Value.ToString();
                
            }
        }
        //оформление и принт документа, для кнопки print
        private int numberPerPage = 0;
        private int CountedNo = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var pen = new Pen(Color.Black, width: 2);
            var font1 = new Font(familyName: "Century Gothic", emSize:14, FontStyle.Bold);
            var font2 = new Font(familyName: "Century Gothic", emSize: 12, FontStyle.Bold);
            var blackBrush = new SolidBrush(Color.Black);
            e.Graphics.DrawString(s: "Datagridview Data printing", font1, blackBrush, new PointF(x: 290, y: 25));
            e.Graphics.DrawLine(pen, x1: 10, y1: 60, x2: 800, y2: 60);
            e.Graphics.DrawString(s: "ID.", font2, blackBrush, new PointF(x: 10, y: 75));
            e.Graphics.DrawString(s: "Seller", font2, blackBrush, new PointF(x: 100, y: 75));
            e.Graphics.DrawString(s: "Date", font2, blackBrush, new PointF(x: 400, y: 75));
            e.Graphics.DrawString(s: "Total", font2, blackBrush, new PointF(x: 500, y: 75));
            e.Graphics.DrawLine(pen, x1: 10, y1: 100, x2: 800, y2: 100);
            var height = 110;
            for (int i = 0; i < ReceiptDGV.Rows.Count; i++)
            {
                var row = ReceiptDGV.Rows[i];
                numberPerPage++;
                if(numberPerPage < 47)
                {
                    CountedNo++;
                    if(CountedNo <= ReceiptDGV.Rows.Count)
                    {
                        //e.Graphics.DrawString(s: row.Cells[0].Value.ToString(), font2, blackBrush, new PointF(x: 10, y: height));
                        //e.Graphics.DrawString(s: row.Cells[1].Value.ToString(), font2, blackBrush, new PointF(x: 100, y: height));
                        //e.Graphics.DrawString(s: row.Cells[2].Value.ToString(), font2, blackBrush, new PointF(x: 400, y: height));
                        //e.Graphics.DrawString(s: row.Cells[3].Value.ToString(), font2, blackBrush, new PointF(x: 500, y: height));

                        height += 20;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    CountedNo = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            height += 10;
            e.Graphics.DrawLine(pen, x1: 10, y1: height, x2: 800, y2: height);
            CountedNo = 0;
            numberPerPage = 0;
        }

        

        //Add product - button
        private void button2_Click(object sender, EventArgs e)
            {

                if (ProdName.Text == "" || ProdQty.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                int total = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderDGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdName.Text;
                newRow.Cells[2].Value = ProdPrice.Text;
                newRow.Cells[3].Value = ProdQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPrice.Text) * Convert.ToInt32(ProdQty.Text);
                OrderDGV.Rows.Add(newRow);
                n++;
                Grdtotal = Grdtotal + total;
                AmtTotal.Text = ""+Grdtotal;
            }

        
        //Переход к форме авторизации
        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void fillcombo()//Метод для комбобокса
        {

            Connect.Open();
            SqlCommand cmd = new SqlCommand("select BrandName from BrandTable", Connect);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BrandName", typeof(string));
            dt.Load(rdr);
            //BrandCB.ValueMember = "BrandName";
            //BrandCB.DataSource = dt;
            Connect.Close();

        }
    }

    }


