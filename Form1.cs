namespace ShopingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal total = 0;
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgList.Rows.Add(dgList.Rows.Count + 1, txtBarcode.Text, 15, 100, 15 * 100);
                txtBarcode.Clear();

                for (int i = 0; i < dgList.Rows.Count; i++)
                {
                    total += Convert.ToDecimal(dgList.Rows[i].Cells[4].Value);
                }
                lbTotal.Text = total.ToString();
            }
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            total -= decimal.Parse(txtPayment.Text);
            lbRemaing.Text = total.ToString();
            dgPayment.Rows.Add("Credit Card", txtPayment.Text);
            if (total < 0)
            {
                //MessageBox.Show("Ödeme Miktarýndan Fazla Tutar");


                lbRemaing.Text = "Paraüstü = " + (-1 * total);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBarcode.Enabled = false;
            groupBox4.Visible = true;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            total -= decimal.Parse(txtPayment.Text);
            lbRemaing.Text = total.ToString();
            dgPayment.Rows.Add("Cash", txtPayment.Text);
            if (total < 0)
            {
                lbRemaing.Text = "Paraüstü = " + (-1 * total);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgList.Rows.Clear();
            dgPayment.Rows.Clear();
            lbRemaing.Text = "";
            lbTotal.Text = "";
            txtPayment.Text = "";
            txtBarcode.Enabled = true;
            total = 0;

        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgList.SelectedRows)
            {
                dgList.Rows.RemoveAt(item.Index);
                total -= Convert.ToDecimal(item.Cells[4].Value);
                lbTotal.Text = total.ToString();
            }
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }
    }
}