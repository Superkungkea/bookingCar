using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTicketSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ParkingRecord> parkingRecords = new List<ParkingRecord>();
        List<ParkingRecord> checkedOutRecords = new List<ParkingRecord>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the live clock
            timer1.Start();

            

            // Set format for check-in DateTimePicker
            dateTimePickerIn.Format = DateTimePickerFormat.Custom;
            dateTimePickerIn.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            // Set format for check-out DateTimePicker
            dateTimePickerOut.Format = DateTimePickerFormat.Custom;
            dateTimePickerOut.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            // Optional: default values
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
        }

        private void btnF1P1_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F1";
            txtPark.Text = "P1";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF1P2_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F1";
            txtPark.Text = "P2";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF1P3_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F1";
            txtPark.Text = "P3";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF1P4_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F1";
            txtPark.Text = "P4";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF1P5_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F1";
            txtPark.Text = "P5";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF2P1_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F2";
            txtPark.Text = "P1";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF2P2_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F2";
            txtPark.Text = "P2";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF2P3_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F2";
            txtPark.Text = "P3";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF2P4_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F2";
            txtPark.Text = "P4";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF2P5_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F2";
            txtPark.Text = "P5";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF3P1_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F3";
            txtPark.Text = "P1";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF3P2_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F3";
            txtPark.Text = "P2";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF3P3_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F3";
            txtPark.Text = "P3";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF3P4_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F3";
            txtPark.Text = "P4";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        private void btnF3P5_Click(object sender, EventArgs e)
        {
            txtFloor.Text = "F3";
            txtPark.Text = "P5";
            // Set both date and time from dateTimePickerIn.Value, formatted exactly
            txtDate.Text = dateTimePickerIn.Value.ToString("dd/MM/yyyy");
            txtTime.Text = dateTimePickerIn.Value.ToString("HH:mm:ss");
        }

        //get button
        private Button GetButton(string floor, string park)
        {
            return Controls.Find($"btn{floor}{park}", true).FirstOrDefault() as Button;
        }


        //
        public class ParkingRecord
        {
            public string Floor { get; set; }
            public string Park { get; set; }
            public DateTime InTime { get; set; }
            public string Plate { get; set; }

            public DateTime? OutTime { get; set; }  // Nullable, set on checkout
            public int Fee { get; set; }            // Calculated on checkout
        }

        private int CalculateFee(DateTime inTime, DateTime outTime)
        {
            

            TimeSpan duration = outTime - inTime;

            if (inTime.Date != outTime.Date)
            {
                // Count calendar day difference (without +1)
                int days = (outTime.Date - inTime.Date).Days;

                // But if same day, set to 1 at minimum
                if (days == 0)
                    days = 1;

                return days * 20000;
            }

            // Same-day case
            if (duration.TotalMinutes < 60)
                return 0;

            int hours = (int)Math.Ceiling(duration.TotalHours);
            return hours * 1000;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Load Message if Text Fiel Null
            if (txtTime.Text == "" || txtDate.Text == "" || txtPlateNumber.Text == "")
            {
                MessageBox.Show("Please fill Date, Time and Plate Number.");
                return;
            }

            //check if Plate Number duplicate
            if (parkingRecords.Exists(r => r.Plate.ToLower() == txtPlateNumber.Text.ToLower()))
            {
                MessageBox.Show("This plate number has already been registered.");
                return;
            }



            DateTime inDate;
            string dateTimeStr = $"{txtDate.Text} {txtTime.Text}";
            string format = "dd/MM/yyyy HH:mm:ss";

            bool success = DateTime.TryParseExact(
                dateTimeStr,
                format,
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out inDate);

            if (!success)
            {
                MessageBox.Show("Invalid check-in date or time. Please use the format dd/MM/yyyy for date and HH:mm:ss for time.");
                return;
            }

            //store Input in record
            ParkingRecord record = new ParkingRecord
            {
                Floor = txtFloor.Text,
                Park = txtPark.Text,
                InTime = inDate, // ✅ now using editable text inputs
                Plate = txtPlateNumber.Text,
            };

            //store record in list
            parkingRecords.Add( record );

            //display in datagridview
            UpdateGrid();

            // Show confirmation
            MessageBox.Show("Car added successfully!");

            //Button go red as it click add
            Button btn = GetButton(txtFloor.Text, txtPark.Text);
            if (btn != null)
            {
                btn.BackColor = Color.Red;
                btn.Enabled = false;
            }


            // Clear input fields
            txtFloor.Clear();
            txtPark.Clear();
            txtTime.Clear();
            txtDate.Clear();
            txtPlateNumber.Clear();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = parkingRecords.Select(r => new
            {
                r.Floor,
                r.Park,
                Date = r.InTime.ToString("yyyy-MM-dd"),
                Time = r.InTime.ToString("HH:mm:ss"),
                PlateNumber = r.Plate
            }).ToList();
        }
        private void UpdateCheckedOutGrid()
        {
            dataGridView2.DataSource = null;

            dataGridView2.DataSource = checkedOutRecords.Select(r => new
            {
                r.Floor,
                r.Park,
                InDate = r.InTime.ToString("yyyy-MM-dd"),
                InTime = r.InTime.ToString("HH:mm:ss"),
                OutDate = r.OutTime?.ToString("yyyy-MM-dd") ?? "",
                OutTime = r.OutTime?.ToString("HH:mm:ss") ?? "",
                r.Plate,
                Fee = r.Fee
            }).ToList();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a car to check out.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            string plate = selectedRow.Cells["PlateNumber"].Value.ToString();

            var record = parkingRecords.FirstOrDefault(r => r.Plate.Equals(plate, StringComparison.OrdinalIgnoreCase));
            if (record == null)
            {
                MessageBox.Show("Selected car record not found.");
                return;
            }

            // ✅ Get time from textbox
            TimeSpan checkoutTime;
            if (!TimeSpan.TryParse(txtCheckOutTime.Text, out checkoutTime))
            {
                MessageBox.Show("Invalid checkout time. Use HH:mm:ss");
                return;
            }

            // ✅ Combine date from picker and time from textbox
            DateTime outTime = new DateTime(
                dateTimePickerOut.Value.Year,
                dateTimePickerOut.Value.Month,
                dateTimePickerOut.Value.Day,
                checkoutTime.Hours,
                checkoutTime.Minutes,
                checkoutTime.Seconds
            );

            if (outTime < record.InTime)
            {
                MessageBox.Show("Check-out time cannot be before check-in time.");
                return;
            }

            int fee = CalculateFee(record.InTime, outTime);
            record.OutTime = outTime;
            record.Fee = fee;

            parkingRecords.Remove(record);
            checkedOutRecords.Add(record);

            Button btn = GetButton(record.Floor, record.Park);
            if (btn != null)
            {
                btn.Enabled = true;
                btn.BackColor = Color.Green;
            }

            UpdateGrid();
            UpdateCheckedOutGrid();

            MessageBox.Show($"Car with plate {plate} has been checked out.\n" +
                            $"In Time: {record.InTime}\n" +
                            $"Out Time: {outTime}\n" +
                            $"Fee: {fee} riel.");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            var selectedRow = dataGridView1.SelectedRows[0];
            string plate = selectedRow.Cells["PlateNumber"].Value.ToString();

            var record = parkingRecords.FirstOrDefault(r => r.Plate.Equals(plate, StringComparison.OrdinalIgnoreCase));
            if (record != null)
            {
                // Set checkout time textbox to current DateTimePickerOut time or current time
                if (record.OutTime.HasValue)
                {
                    txtCheckOutTime.Text = record.OutTime.Value.ToString("HH:mm:ss");
                }
                else
                {
                    txtCheckOutTime.Text = DateTime.Now.ToString("HH:mm:ss");
                }

                // Optionally, set the date picker to current or record out date if exists
                dateTimePickerOut.Value = record.OutTime ?? DateTime.Now;
            }
        }

        private void txtPlateNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFloor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerOut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
