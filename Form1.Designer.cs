namespace ShopingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtBarcode = new TextBox();
            groupBox2 = new GroupBox();
            dgList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            lbTotal = new Label();
            groupBox4 = new GroupBox();
            lbRemaing = new Label();
            btnCC = new Button();
            btnComplete = new Button();
            btnCash = new Button();
            txtPayment = new TextBox();
            btnDeleteSelect = new Button();
            btnReset = new Button();
            dgPayment = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            PaidMoney = new DataGridViewTextBoxColumn();
            groupBox5 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(580, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtBarcode
            // 
            txtBarcode.Dock = DockStyle.Fill;
            txtBarcode.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarcode.Location = new Point(4, 29);
            txtBarcode.Margin = new Padding(4, 5, 4, 5);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(572, 50);
            txtBarcode.TabIndex = 0;
            txtBarcode.Text = "ürün giriniz";
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgList);
            groupBox2.Location = new Point(17, 118);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(608, 840);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgList.BackgroundColor = SystemColors.ActiveBorder;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Id, ProductName, Quantity, Price, TotalPrice });
            dgList.Dock = DockStyle.Fill;
            dgList.Location = new Point(4, 29);
            dgList.Margin = new Padding(4, 5, 4, 5);
            dgList.Name = "dgList";
            dgList.RowHeadersWidth = 62;
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(600, 806);
            dgList.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 30;
            Id.Name = "Id";
            Id.Width = 30;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.HeaderText = "Name";
            ProductName.MinimumWidth = 8;
            ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 8;
            Quantity.Name = "Quantity";
            Quantity.Width = 90;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 50;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 90;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 90;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Location = new Point(606, 20);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(533, 88);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // lbTotal
            // 
            lbTotal.Dock = DockStyle.Fill;
            lbTotal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.Location = new Point(4, 29);
            lbTotal.Margin = new Padding(4, 0, 4, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(525, 54);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "ödenecek tutar";
            lbTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbRemaing);
            groupBox4.Controls.Add(btnCC);
            groupBox4.Controls.Add(btnComplete);
            groupBox4.Controls.Add(btnCash);
            groupBox4.Controls.Add(txtPayment);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(633, 118);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(506, 618);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // lbRemaing
            // 
            lbRemaing.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbRemaing.Location = new Point(3, 334);
            lbRemaing.Margin = new Padding(4, 0, 4, 0);
            lbRemaing.Name = "lbRemaing";
            lbRemaing.Size = new Size(503, 80);
            lbRemaing.TabIndex = 8;
            lbRemaing.Text = "kalan toplam";
            lbRemaing.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCC
            // 
            btnCC.BackColor = Color.RosyBrown;
            btnCC.ForeColor = SystemColors.ActiveCaptionText;
            btnCC.Location = new Point(107, 118);
            btnCC.Margin = new Padding(4, 5, 4, 5);
            btnCC.Name = "btnCC";
            btnCC.Size = new Size(143, 167);
            btnCC.TabIndex = 1;
            btnCC.Text = "Kredi Kartı";
            btnCC.UseVisualStyleBackColor = false;
            btnCC.Click += btnCC_Click;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.FromArgb(255, 128, 255);
            btnComplete.Location = new Point(179, 430);
            btnComplete.Margin = new Padding(4, 5, 4, 5);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(143, 167);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "İşlemi Tamamla";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnCash
            // 
            btnCash.BackColor = Color.OliveDrab;
            btnCash.Location = new Point(268, 118);
            btnCash.Margin = new Padding(4, 5, 4, 5);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(143, 167);
            btnCash.TabIndex = 2;
            btnCash.Text = "Nakit";
            btnCash.UseVisualStyleBackColor = false;
            btnCash.Click += btnCash_Click;
            // 
            // txtPayment
            // 
            txtPayment.BackColor = SystemColors.InactiveCaption;
            txtPayment.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtPayment.Location = new Point(43, 31);
            txtPayment.Margin = new Padding(4, 5, 4, 5);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(453, 50);
            txtPayment.TabIndex = 0;
            // 
            // btnDeleteSelect
            // 
            btnDeleteSelect.Location = new Point(1303, 318);
            btnDeleteSelect.Margin = new Padding(4, 5, 4, 5);
            btnDeleteSelect.Name = "btnDeleteSelect";
            btnDeleteSelect.Size = new Size(143, 138);
            btnDeleteSelect.TabIndex = 9;
            btnDeleteSelect.Text = "Delete Select";
            btnDeleteSelect.UseVisualStyleBackColor = true;
            btnDeleteSelect.Click += btnDeleteSelect_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1454, 318);
            btnReset.Margin = new Padding(4, 5, 4, 5);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(143, 138);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.BackgroundColor = SystemColors.ActiveBorder;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { Type, PaidMoney });
            dgPayment.Dock = DockStyle.Fill;
            dgPayment.Location = new Point(4, 29);
            dgPayment.Margin = new Padding(4, 5, 4, 5);
            dgPayment.Name = "dgPayment";
            dgPayment.RowHeadersVisible = false;
            dgPayment.RowHeadersWidth = 62;
            dgPayment.RowTemplate.Height = 25;
            dgPayment.Size = new Size(533, 254);
            dgPayment.TabIndex = 5;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            // 
            // PaidMoney
            // 
            PaidMoney.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PaidMoney.HeaderText = "PaidMoney";
            PaidMoney.MinimumWidth = 8;
            PaidMoney.Name = "PaidMoney";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgPayment);
            groupBox5.Location = new Point(1147, 20);
            groupBox5.Margin = new Padding(4, 5, 4, 5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 5, 4, 5);
            groupBox5.Size = new Size(541, 288);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(1151, 318);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(143, 138);
            button1.TabIndex = 8;
            button1.Text = "Bitir Ve Öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 1128);
            Controls.Add(btnDeleteSelect);
            Controls.Add(button1);
            Controls.Add(btnReset);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "ürün giriniz";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBarcode;
        private GroupBox groupBox2;
        private DataGridView dgList;
        private GroupBox groupBox3;
        private Label lbTotal;
        private GroupBox groupBox4;
        private Button btnCC;
        private Button btnCash;
        private TextBox txtPayment;
        private Button btnComplete;
        private Button btnReset;
        private DataGridView dgPayment;
        private GroupBox groupBox5;
        private Label lbRemaing;
        private Button button1;
        private Button btnDeleteSelect;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn PaidMoney;
    }
}