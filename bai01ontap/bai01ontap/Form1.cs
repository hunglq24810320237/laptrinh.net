namespace bai01ontap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            // Validate and parse unit price
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text) || !double.TryParse(txtUnitPrice.Text, out double unitPrice))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return;
            }

            // Validate and parse quantity
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !double.TryParse(txtQuantity.Text, out double quantity))
            {
                MessageBox.Show("Vui lòng nhập Số lượng hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Validate and parse discount (percent). Empty is treated as 0.
            double discount = 0.0;
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                if (!double.TryParse(txtDiscount.Text, out discount))
                {
                    MessageBox.Show("Vui lòng nhập % Giảm hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDiscount.Focus();
                    return;
                }
            }

            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("% Giảm phải nằm trong khoảng 0 - 100.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiscount.Focus();
                return;
            }

            double total = (unitPrice * quantity) * (100.0 - discount) / 100.0;
            lblTotal.Text = total.ToString("N2");
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtUnitPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            lblTotal.Text = "0.00";
            txtUnitPrice.Focus();
        }
    }
}
