
namespace kursach
{
    partial class SellingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmtTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SellerLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.ProdDGV1 = new System.Windows.Forms.DataGridView();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReceiptDGV = new System.Windows.Forms.DataGridView();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.receiptID = new System.Windows.Forms.TextBox();
            this.Receipt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AmtTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.OrderDGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SellerLbl);
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.ProdDGV1);
            this.panel1.Controls.Add(this.ProdQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ReceiptDGV);
            this.panel1.Controls.Add(this.ProdPrice);
            this.panel1.Controls.Add(this.ProdName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.receiptID);
            this.panel1.Controls.Add(this.Receipt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 664);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Logout";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(562, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = " Amouth Rub";
            // 
            // AmtTotal
            // 
            this.AmtTotal.AutoSize = true;
            this.AmtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmtTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.AmtTotal.Location = new System.Drawing.Point(739, 255);
            this.AmtTotal.Name = "AmtTotal";
            this.AmtTotal.Size = new System.Drawing.Size(0, 31);
            this.AmtTotal.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(626, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 31);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sells List";
            // 
            // OrderDGV
            // 
            this.OrderDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            this.OrderDGV.Location = new System.Drawing.Point(380, 70);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDGV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDGV.Size = new System.Drawing.Size(600, 156);
            this.OrderDGV.TabIndex = 28;
            // 
            // ID
            // 
            this.ID.HeaderText = "ProdID";
            this.ID.Name = "ID";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.Name = "PName";
            // 
            // Price
            // 
            this.Price.HeaderText = "ProdPrice";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "ProdQty";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(745, 602);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 39);
            this.button4.TabIndex = 24;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(504, 602);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 39);
            this.button3.TabIndex = 23;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(105, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 43);
            this.button2.TabIndex = 22;
            this.button2.Text = "Add Product";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SellerLbl
            // 
            this.SellerLbl.AutoSize = true;
            this.SellerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerLbl.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SellerLbl.Location = new System.Drawing.Point(81, 5);
            this.SellerLbl.Name = "SellerLbl";
            this.SellerLbl.Size = new System.Drawing.Size(67, 25);
            this.SellerLbl.TabIndex = 21;
            this.SellerLbl.Text = "Seller";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.DateLbl.Location = new System.Drawing.Point(870, 19);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(63, 29);
            this.DateLbl.TabIndex = 20;
            this.DateLbl.Text = "Date";
            // 
            // ProdDGV1
            // 
            this.ProdDGV1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProdDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV1.Location = new System.Drawing.Point(18, 274);
            this.ProdDGV1.Name = "ProdDGV1";
            this.ProdDGV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProdDGV1.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdDGV1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdDGV1.Size = new System.Drawing.Size(327, 378);
            this.ProdDGV1.TabIndex = 19;
            this.ProdDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV1_CellContentClick);
            // 
            // ProdQty
            // 
            this.ProdQty.BackColor = System.Drawing.SystemColors.Window;
            this.ProdQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdQty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProdQty.Location = new System.Drawing.Point(155, 187);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(190, 22);
            this.ProdQty.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(32, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quantity";
            // 
            // ReceiptDGV
            // 
            this.ReceiptDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ReceiptDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceiptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptDGV.Location = new System.Drawing.Point(353, 352);
            this.ReceiptDGV.Name = "ReceiptDGV";
            this.ReceiptDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReceiptDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ReceiptDGV.Size = new System.Drawing.Size(636, 233);
            this.ReceiptDGV.TabIndex = 14;
            this.ReceiptDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReceiptDGV_CellContentClick);
            // 
            // ProdPrice
            // 
            this.ProdPrice.BackColor = System.Drawing.SystemColors.Window;
            this.ProdPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdPrice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProdPrice.Location = new System.Drawing.Point(155, 143);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(190, 22);
            this.ProdPrice.TabIndex = 8;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.SystemColors.Window;
            this.ProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProdName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProdName.Location = new System.Drawing.Point(155, 101);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(190, 22);
            this.ProdName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(39, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ProdName";
            // 
            // receiptID
            // 
            this.receiptID.BackColor = System.Drawing.SystemColors.Window;
            this.receiptID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiptID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.receiptID.Location = new System.Drawing.Point(155, 54);
            this.receiptID.Name = "receiptID";
            this.receiptID.Size = new System.Drawing.Size(190, 22);
            this.receiptID.TabIndex = 2;
            // 
            // Receipt
            // 
            this.Receipt.AutoSize = true;
            this.Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Receipt.ForeColor = System.Drawing.SystemColors.Window;
            this.Receipt.Location = new System.Drawing.Point(32, 52);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(91, 24);
            this.Receipt.TabIndex = 1;
            this.Receipt.Text = "ReceiptID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(497, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selling";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(989, 665);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellingForm";
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.DataGridView ProdDGV1;
        private System.Windows.Forms.TextBox ProdQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ReceiptDGV;
        private System.Windows.Forms.TextBox ProdPrice;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox receiptID;
        private System.Windows.Forms.Label Receipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SellerLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label AmtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label6;
    }
}