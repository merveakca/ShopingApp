using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShopingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal total;
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!(txtBarcode.Text == "" || txtBarcode.Text == "ürün giriniz"))
                {
                    total = 0;
                    dgList.Rows.Add(dgList.Rows.Count + 1, txtBarcode.Text, 15, 100, 15 * 100);
                    txtBarcode.Clear();

                    for (int i = 0; i < dgList.Rows.Count; i++)
                    {
                        total += Convert.ToDecimal(dgList.Rows[i].Cells[4].Value);
                    }
                    lbTotal.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Ürün Adý Boþ Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        int Number;
        private void btnCC_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPayment.Text, out Number))
            {
                MessageBox.Show("Sadece numaretik deðerler girebilirsiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarcode.Text = "";
                return;
            }
            else
            {
                lbRemaing.Text = Number.ToString();
                total -= decimal.Parse(txtPayment.Text);
                lbRemaing.Text = total.ToString();
                dgPayment.Rows.Add("Credit Card", txtPayment.Text);
                txtPayment.Text = "";
                if (total < 0)
                {
                    //MessageBox.Show("Ödeme Miktarýndan Fazla Tutar");
                    lbRemaing.Text = "Paraüstü = " + (-1 * total);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBarcode.Enabled = false;
            groupBox4.Visible = true;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPayment.Text, out Number))
            {
                MessageBox.Show("Sadece numaretik deðerler girebilirsiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBarcode.Text = "";
                return;
            }
            else
            {
                total -= decimal.Parse(txtPayment.Text);
                lbRemaing.Text = total.ToString();
                dgPayment.Rows.Add("Cash", txtPayment.Text);
                txtPayment.Text = "";
                if (total < 0)
                {
                    lbRemaing.Text = "Paraüstü = " + (-1 * total);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
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

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (total <= 0)
            {
                if (MessageBox.Show("Alýþveriþe Devam etmek istiyor musunuz", "Durum", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Ödeme Tamamlanmadý");
            }
        }
    }
}