using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // set default selections
            rbNormal.Checked = true;
            cmbType.SelectedIndex = 0;
            dtpDate.Value = DateTime.Today;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png|All files|*.*";
                dlg.Title = "Chọn ảnh lỗi";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picError.Image?.Dispose();
                        picError.Image = System.Drawing.Image.FromFile(dlg.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("--- Tóm tắt phiếu yêu cầu ---");
            sb.AppendLine($"Mã phiếu: {txtTicketId.Text}");
            sb.AppendLine($"Người yêu cầu: {txtRequester.Text}");
            sb.AppendLine($"Ngày ghi nhận: {dtpDate.Value:d}");
            string priority = rbLow.Checked ? "Thấp" : rbNormal.Checked ? "Trung bình" : "Khẩn cấp";
            sb.AppendLine($"Mức độ ưu tiên: {priority}");
            sb.AppendLine($"Loại sự cố: {cmbType.SelectedItem}");
            var devices = new[] {
                cbDesktop.Checked ? "Máy tính bàn" : null,
                cbLaptop.Checked ? "Laptop" : null,
                cbPrinter.Checked ? "Máy in" : null,
                cbPhone.Checked ? "Điện thoại" : null
            }.Where(x => x != null).ToArray();
            sb.AppendLine($"Thiết bị ảnh hưởng: {(devices.Length > 0 ? string.Join(", ", devices) : "(không chọn)")}");
            sb.AppendLine($"Ảnh lỗi: {(picError.Image != null ? "Đã tải" : "Chưa tải")}");

            MessageBox.Show(sb.ToString(), "Phiếu yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTicketId.Clear();
            txtRequester.Clear();
            dtpDate.Value = DateTime.Today;
            rbNormal.Checked = true;
            cmbType.SelectedIndex = 0;
            cbDesktop.Checked = cbLaptop.Checked = cbPrinter.Checked = cbPhone.Checked = false;
            if (picError.Image != null)
            {
                picError.Image.Dispose();
                picError.Image = null;
            }
        }
    }
}
