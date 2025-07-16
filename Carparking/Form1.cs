using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carparking
{
    public partial class Form1 : Form
    {
        private Button button_name;
        private DateTime bookingDate;
        private string button_backend_name="";
        private const double value_per_hour = 1000;
        private int delete_row_index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void temp_add(string floor_text,Label lbl,Button btt)
        {
            string button_num = lbl.Text;
            txt_platnumber.Text= floor_text+button_num;
            this.button_name = btt;
            this.button_backend_name= btt.Name;
        }
        private void check_out(string button_name)
        {
            this.button_backend_name = button_name;
        }
        private void btnF1P1_Click(object sender, EventArgs e)
        {
            temp_add("F1",lbl_F1P1,this.btnF1P1);
        }

        private void btnF1P2_Click(object sender, EventArgs e)
        {
            temp_add("F1",lbl_F1P2, btnF1P2);
        }

        private void btnF1P3_Click(object sender, EventArgs e)
        {
            temp_add("F1",lbl_F1P3, btnF1P3);
        }

        private void btnF2P1_Click(object sender, EventArgs e)
        {
            temp_add("F2", lbl_F2P1, btnF2P1);
        }

        private void btnF2P2_Click(object sender, EventArgs e)
        {
            temp_add("F2",lbl_F2P2, btnF2P2);
        }

        private void btnF2P3_Click(object sender, EventArgs e)
        {
            temp_add("F2",lbl_F2P3, btnF2P3);
        }

        private void btnF3P1_Click(object sender, EventArgs e)
        {
            temp_add("F3", lbl_F3P1, btnF3P1);
        }

        private void btnF3P2_Click(object sender, EventArgs e)
        {
            temp_add("F3", lbl_F3P2, btnF3P2);
        }

        private void btnF3P3_Click(object sender, EventArgs e)
        {
            temp_add("F3", lbl_F3P3, btnF3P3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plat_id=txt_platnumber.Text;
            string phone_number=txt_phonenumber.Text;
            DateTime dateTimeBooking=DateTime.Now;
            if(phone_number==""|| phone_number == null)
            {
                MessageBox.Show("Please Input Phone Number","Missing Phone Number",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            this.button_name.Enabled=false; 
            this.button_name.BackColor=Color.Orange;
            txt_phonenumber.Text = "";
            txt_platnumber.Text = "";

            int i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = i + 1;
            dataGridView1.Rows[i].Cells[1].Value = plat_id;
            dataGridView1.Rows[i].Cells[2].Value = button_backend_name;
            dataGridView1.Rows[i].Cells[3].Value = phone_number;
            dataGridView1.Rows[i].Cells[4].Value = dateTimeBooking;
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(button_backend_name))
            {
                MessageBox.Show("Please select a record first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Control[] foundControls = this.Controls.Find(button_backend_name, true);
            if (foundControls.Length > 0 && foundControls[0] is Button btn)
            {
                btn.Enabled = true;
                btn.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Button not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int selectedRowIndex = -1;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            }

            button_backend_name = "";
            button_name = null;

            DateTime checkIn = bookingDate;
            DateTime checkOut = DateTime.Now;

            TimeSpan duration = checkOut - checkIn;
            double totalHours = Math.Ceiling(duration.TotalHours);
            double cost = 0;

            if (totalHours > 1)
            {
                cost = totalHours * 100;
                MessageBox.Show($"Duration: {duration.Hours}h {duration.Minutes}m\nCharged Hours: {totalHours}\nTotal Cost: ${cost}", "Total Fee Charge");
            }
            else
            {
                MessageBox.Show($"Duration: {duration.Hours}h {duration.Minutes}m\nLess than 1 hour, no charge.", "Total Fee Charge");
            }
            if (selectedRowIndex >= 0 && !dataGridView1.Rows[selectedRowIndex].IsNewRow)
            {
                dataGridView1.Rows.RemoveAt(selectedRowIndex);
            }
            txt_platnumber.Text = "";

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                
                if (selectedRow.IsNewRow)
                    return;
                if (selectedRow.Cells[2].Value != null && selectedRow.Cells[4].Value != null)
                {
                    this.delete_row_index = selectedRow.Index;
                    this.button_backend_name = selectedRow.Cells[2].Value.ToString();
                    this.bookingDate = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                    txt_platnumber.Text = selectedRow.Cells[1].Value?.ToString();
                }
            }
        }


    }
}
