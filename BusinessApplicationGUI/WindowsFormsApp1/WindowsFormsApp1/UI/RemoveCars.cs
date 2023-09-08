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
    public partial class RemoveCars : Form
    {
        public RemoveCars()
        {
            InitializeComponent();
        }

        private void RemoveCars_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string CarName = txbCarName.Text;
            string company = txbCompany.Text;

            CarBL nCar = null;
            CarBL RemovalCar = CarDL.isCarNameAvail(nCar,CarName,company);

          
                if (RemovalCar != null)
                {
                CarDL.deleteCarFromList(RemovalCar, "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\cars.txt");
                  //  CarDL.StoreIntoFileAfterRemoving("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\cars.txt");
                    MessageBox.Show("Car successfully Removed");
                ClearText();
                }
                else 
                {
                    MessageBox.Show("Car already not available");

                }
    
        }
        private void ClearText()
        {
            txbCarName.Text = "";
            txbCompany.Text = "";
        }
       
        
    }
}
