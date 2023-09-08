using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;


namespace WindowsFormsApp1.UI
{
    public partial class AvailabiltyMenu : Form
    {
        public AvailabiltyMenu()
        {
            InitializeComponent();
        }

        private void AvailabiltyMenu_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            CarBL car = new CarBL(name);
            if (CarBL.setCarName(name))
            {
                if (CarBL.isCarNameAvailable(name))
                {
                    MessageBox.Show("Car is Available");
                }
                else
                    MessageBox.Show("Car Not Available");


            }
            else
                MessageBox.Show("Invalid Input");
        }
    }
}
