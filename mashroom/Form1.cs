using System;
using System.Drawing;
using System.Windows.Forms;

namespace mashroom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBicycleRental_Click(object sender, System.EventArgs e)
        {
            using (BicycleRentalForm form = new BicycleRentalForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnMushroomIdentification_Click(object sender, System.EventArgs e)
        {
            using (MushroomIdentificationForm form = new MushroomIdentificationForm())
            {
                form.ShowDialog(this);
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
