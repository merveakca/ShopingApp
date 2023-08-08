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
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            lbTotal = new Label();
            groupBox4 = new GroupBox();
            lbRemaing = new Label();
            btnCC = new Button();
            btnAccept = new Button();
            btnCash = new Button();
            txtPayment = new TextBox();
            btnDeleteSelect = new Button();
            btnReset = new Button();
            dgPayment = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 53);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtBarcode
            // 
            txtBarcode.Dock = DockStyle.Fill;
            txtBarcode.Location = new Point(3, 19);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(400, 23);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgList);
            groupBox2.Location = new Point(12, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 504);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Quantity, Price, TotalPrice });
            dgList.Dock = DockStyle.Fill;
            dgList.Location = new Point(3, 19);
            dgList.Name = "dgList";
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(400, 482);
            dgList.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 35;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.Width = 60;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.Name = "TotalPrice";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Location = new Point(424, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(373, 53);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // lbTotal
            // 
            lbTotal.Dock = DockStyle.Fill;
            lbTotal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.Location = new Point(3, 19);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(367, 31);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "label1";
            lbTotal.TextAlign = ContentAlignment.MiddleCenter;
            lbTotal.Click += lbTotal_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbRemaing);
            groupBox4.Controls.Add(btnCC);
            groupBox4.Controls.Add(btnAccept);
            groupBox4.Controls.Add(btnCash);
            groupBox4.Controls.Add(txtPayment);
            groupBox4.Location = new Point(424, 71);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(373, 371);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // lbRemaing
            // 
            lbRemaing.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lbRemaing.Location = new Point(9, 162);
            lbRemaing.Name = "lbRemaing";
            lbRemaing.Size = new Size(352, 67);
            lbRemaing.TabIndex = 8;
            lbRemaing.Text = "0";
            lbRemaing.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCC
            // 
            btnCC.Location = new Point(6, 48);
            btnCC.Name = "btnCC";
            btnCC.Size = new Size(100, 100);
            btnCC.TabIndex = 1;
            btnCC.Text = "Credit Card";
            btnCC.UseVisualStyleBackColor = true;
            btnCC.Click += btnCC_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(6, 265);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(100, 100);
            btnAccept.TabIndex = 3;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            btnCash.Location = new Point(267, 48);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(100, 100);
            btnCash.TabIndex = 2;
            btnCash.Text = "Cash";
            btnCash.UseVisualStyleBackColor = true;
            btnCash.Click += btnCash_Click;
            // 
            // txtPayment
            // 
            txtPayment.Dock = DockStyle.Top;
            txtPayment.Location = new Point(3, 19);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(367, 23);
            txtPayment.TabIndex = 0;
            // 
            // btnDeleteSelect
            // 
            btnDeleteSelect.Location = new Point(912, 191);
            btnDeleteSelect.Name = "btnDeleteSelect";
            btnDeleteSelect.Size = new Size(100, 83);
            btnDeleteSelect.TabIndex = 9;
            btnDeleteSelect.Text = "Delete Select";
            btnDeleteSelect.UseVisualStyleBackColor = true;
            btnDeleteSelect.Click += btnDeleteSelect_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(1018, 191);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 83);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { Type, Total });
            dgPayment.Dock = DockStyle.Fill;
            dgPayment.Location = new Point(3, 19);
            dgPayment.Name = "dgPayment";
            dgPayment.RowHeadersVisible = false;
            dgPayment.RowTemplate.Height = 25;
            dgPayment.Size = new Size(373, 151);
            dgPayment.TabIndex = 5;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgPayment);
            groupBox5.Location = new Point(803, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(379, 173);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(806, 191);
            button1.Name = "button1";
            button1.Size = new Size(100, 83);
            button1.TabIndex = 8;
            button1.Text = "Bitir Ve Öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 677);
            Controls.Add(btnDeleteSelect);
            Controls.Add(button1);
            Controls.Add(btnReset);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
           
            Text = "Form1";
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private GroupBox groupBox3;
        private Label lbTotal;
        private GroupBox groupBox4;
        private Button btnCC;
        private Button btnCash;
        private TextBox txtPayment;
        private Button btnAccept;
        private Button btnReset;
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Total;
        private GroupBox groupBox5;
        private Label lbRemaing;
        private Button button1;
        private Button btnDeleteSelect;
    }
}