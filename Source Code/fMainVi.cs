using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class fMainVi : Form
    {
        string CalTotal = string.Empty;
        float num1;
        float num2;
        string option = string.Empty;
        float result;
        string tempFilePath = Path.Combine(Path.GetTempPath(), "CalculatorHistory.txt");
        public fMainVi()
        {
            InitializeComponent();
        }

        private void SaveHistory()
        {
            using (StreamWriter writer = new StreamWriter(tempFilePath))
            {
                foreach (var item in lbHistory.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }
        private void SaveHistoryToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in lbHistory.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }
        private void ClearTempFile()
        {
            if (File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }
        }
        private void LoadHistory()
        {
            if (File.Exists(tempFilePath))
            {
                using (StreamReader reader = new StreamReader(tempFilePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lbHistory.Items.Add(line);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "3";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                option = "+";
                num1 = float.Parse(txbTotal.Text);
                txbTotal.Clear();
                txbTotal.PlaceholderText = num1 + " + ...";
                label2.Text = num1 + " + ...";
            }
            catch (Exception)
            {
                MessageBox.Show($"Bạn chưa nhập số nào hoặc bạn chọn 2 dấu (+,-,*,/) cùng 1 lúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "6";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                option = "*";
                num1 = float.Parse(txbTotal.Text);
                txbTotal.Clear();
                txbTotal.PlaceholderText = num1 + " * ...";
                label2.Text = num1 + " * ...";
            }
            catch (Exception)
            {
                MessageBox.Show($"Bạn chưa nhập số nào hoặc bạn chọn 2 dấu (+,-,*,/) cùng 1 lúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                option = "-";
                num1 = float.Parse(txbTotal.Text);
                txbTotal.Clear();
                txbTotal.PlaceholderText = num1 + " - ...";
                label2.Text = num1 + " - ...";
            }
            catch (Exception)
            {
                MessageBox.Show($"Bạn chưa nhập số nào hoặc bạn chọn 2 dấu (+,-,*,/) cùng 1 lúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                option = "/";
                num1 = float.Parse(txbTotal.Text);
                txbTotal.Clear();
                txbTotal.PlaceholderText = num1 + " / ...";
                label2.Text = num1 + " / ...";
            }
            catch (Exception)
            {
                MessageBox.Show($"Bạn chưa nhập số nào hoặc bạn chọn 2 dấu (+,-,*,/) cùng 1 lúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbTotal.Text = txbTotal.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTempFile();
            txbTotal.Clear();
            num1 = (0);
            num2 = (0);
            result = (0);
            txbTotal.PlaceholderText = "Nhập Số Ở Đây...";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            SaveHistory();
            try
            {
                num2 = float.Parse(txbTotal.Text);
                Console.WriteLine(num2);
                if (option.Equals("+"))
                    result = num1 + num2;
                if (option.Equals("-"))
                    result = num1 - num2;
                if (option.Equals("*"))
                    result = num1 * num2;
                if (option.Equals("/"))
                    result = num1 / num2;
                if (num1 == 0)
                {
                    num1 = num2;
                    option = "=";
                    result = num2;
                }
                if (result >= 999999999)
                {
                    txbTotal.Text = result.ToString("N0");
                }
                else
                {
                    txbTotal.Text = result.ToString();
                }
                txbTotal.PlaceholderText = "Kết quả là " + result + ".";
                label2.Text = "Kết quả là " + result + ".";
                lbHistory.Items.Add($"{num1} {option} {num2} = {result}");

            }
            catch (Exception)
            {
                MessageBox.Show($"Bạn chưa hoàn thành phép tính hoặc bạn nhập sai cú pháp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (lbHistory.SelectedItem != null)
            {
                lbHistory.Items.Remove(lbHistory.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 phép toán đề xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            //lbHistory.Items.Clear();
            //MessageBox.Show("Đã xóa lịch sử thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var result = MessageBox.Show("Bạn có chắc muốn xóa lịch sử ?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                lbHistory.Items.Clear();
                ClearTempFile();
            }
            else
            {
                return;
            }
        }
        private void txbTotal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveHistory();
            }
            if (e.KeyCode == Keys.Add)
            {
                UpdateNum1();
                btnPlus.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                UpdateNum1();
                btnMinus.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                UpdateNum1();
                btnMultiply.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                UpdateNum1();
                btnDivide.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                label2.Text = "Xem Trước Ở Đây...";
                btnClear.PerformClick();
            }

        }
        private void UpdateNum1()
        {
            num1 = float.Parse(txbTotal.Text);
        }
        private void txbTotal_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                e.Handled = true;
            }
        }
        private void lisenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLicenseVN f = new fLicenseVN();
            f.ShowDialog();
            this.Show();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain f = new fMain();
            f.ShowDialog();
        }

        private void fMainVi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            SaveHistory();
        }

        private void fMainVi_Load(object sender, EventArgs e)
        {
            LoadHistory();
            SaveHistory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tệp Chữ (*.txt)|*.txt|Tất Cả Tệp (*.*)|*.*";
            saveFileDialog.Title = "Lưu Lịch Sử";
            saveFileDialog.FileName = "Lịch_Sử_Tính_Toán";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveHistoryToFile(saveFileDialog.FileName);
                MessageBox.Show("Đã lưu lịch sử thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEqual_MouseEnter(object sender, EventArgs e)
        {
            btnEqual.BackColor = Color.FromArgb(127, 57, 250);
            btnEqual.ForeColor = Color.White;
        }

        private void btnEqual_MouseLeave(object sender, EventArgs e)
        {
            btnEqual.BackColor = Color.White;
            btnEqual.ForeColor = Color.Black;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
            btnClear.BackColor = Color.Red;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.Black;
            btnClear.BackColor = Color.White;
        }
    }
}
