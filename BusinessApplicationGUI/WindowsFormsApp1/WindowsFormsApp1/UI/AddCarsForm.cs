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
    public partial class AddCarsForm : Form
    {
        public AddCarsForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string carName = txbName.Text;
            string company = txbCompany.Text;
            double price = Convert.ToDouble(txbPrice.Text);
            string color = txbColor.Text;



         
            bool check = CarBL.setCar(carName, company, price, color);
            CarBL nCar = new CarBL(carName,company,price,color);
            nCar.getCarName();
            nCar.getCompanyName();
            nCar.getColorCar();
            nCar.getPrice();

            if (check == false)
            {
                MessageBox.Show("Invalid Input.");
                MessageBox.Show("Car Color cannot be PINK , PURPLE OR ORANGE if you type these colors then change it");
                MessageBox.Show("Car Price can not Exceed 30000 (30k)");

            }
            if(check)
            {
                bool flag = CarBL.isCarNameAvailable(carName);
                //for checking ir carColor is same
                bool var = CarBL.isCarColorSame(color,carName);

                //if both car name and color are available in the list then do not add New Car
                if (check == true && var == true)
                {
                    MessageBox.Show("car is already available");

  
                }
                if (check == true && var == false)
                {
                    CarDL.addCarsIntoCarList(nCar);
                    CarDL.storeIntoFile("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\cars.txt", nCar);
                    //MessageBox.Show("Added into list and file");
                    MessageBox.Show("Mubarik ho");
                    MessageBox.Show("Car Added Successfully !!!");
                   
                }
            }


            if (string.IsNullOrEmpty(carName) || string.IsNullOrEmpty(company) || string.IsNullOrEmpty(Convert.ToString(price)) || string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Please Enter All Fields");
                return;
            }
            
        }

        private void Color_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbColor.Text = "";
            txbName.Text = "";
            txbPrice.Text = "";
            txbCompany.Text = "";
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCarsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
