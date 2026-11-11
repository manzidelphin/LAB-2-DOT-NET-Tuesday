using System;
using System.Windows.Forms;

namespace mashroom
{
    public partial class BicycleRentalForm : Form
    {
        public BicycleRentalForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string startText = txtStartHour.Text.Trim();
            string endText = txtEndHour.Text.Trim();
            int startHour;
            int endHour;

            if (startText == "" || endText == "")
            {
                MessageBox.Show("Please enter both the starting hour and ending hour.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(startText, out startHour))
            {
                decimal decimalNumber;
                if (decimal.TryParse(startText, out decimalNumber))
                {
                    MessageBox.Show("Starting hour cannot be a decimal number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Starting hour must contain a whole number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            if (!int.TryParse(endText, out endHour))
            {
                decimal decimalNumber;
                if (decimal.TryParse(endText, out decimalNumber))
                {
                    MessageBox.Show("Ending hour cannot be a decimal number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ending hour must contain a whole number.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            if (startHour < 0 || startHour > 23)
            {
                MessageBox.Show("Starting hour must be an integer from 0 to 23.", "Invalid starting hour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartHour.Focus();
                return;
            }

            if (endHour < 1 || endHour > 24)
            {
                MessageBox.Show("Ending hour must be an integer from 1 to 24.", "Invalid ending hour", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndHour.Focus();
                return;
            }

            if (startHour >= endHour)
            {
                MessageBox.Show("Starting hour must be less than ending hour.", "Invalid rental period", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartHour.Focus();
                return;
            }

            int duration = endHour - startHour;
            int totalCost = CalculateRentalCost(startHour, endHour);

            lblDurationResult.Text = duration.ToString() + " hour(s)";
            lblTotalResult.Text = totalCost.ToString("N0") + " RWF";
        }

        private int CalculateRentalCost(int startHour, int endHour)
        {
            int totalCost = 0;

            // Add the rate for each hour in the rental period.
            for (int hour = startHour; hour < endHour; hour++)
            {
                int hourlyRate;
                if (hour < 7)
                {
                    hourlyRate = 500;
                }
                else if (hour < 14)
                {
                    hourlyRate = 1000;
                }
                else if (hour < 19)
                {
                    hourlyRate = 1500;
                }
                else if (hour < 21)
                {
                    hourlyRate = 1000;
                }
                else
                {
                    hourlyRate = 500;
                }

                totalCost += hourlyRate;
            }

            return totalCost;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStartHour.Clear();
            txtEndHour.Clear();
            lblDurationResult.Text = "—";
            lblTotalResult.Text = "—";
            txtStartHour.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
