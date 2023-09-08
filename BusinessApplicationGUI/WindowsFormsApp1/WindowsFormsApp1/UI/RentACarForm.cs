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
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1.UI
{
    public partial class RentACarForm : Form
    {
        public RentACarForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string company = txbCompany.Text;
            int days = int.Parse(txbDays.Text);

            if (name == null || company == null || days <= 0)
            {
                MessageBox.Show("Please ENter all above fields");

            }
            else
            {


                if (CarBL.setCarName(name))
                {
                    if (CarBL.isCarNameAvailable(name))
                    {
                        PersonBL p = new PersonBL();
                        double price = p.GetCarPrice(name);
                        string promo = txbPromo.Text;
                        double finalPrice = 0;
                        if (promo != null)
                        {
                            bool check = CostumerBL.checkIfPromoIsAvailable(promo);
                            if (check)
                            {

                                finalPrice = CostumerBL.PriceWithDiscount(days, price);

                                MessageBox.Show("Promo  applied ");
                                ShowBillForm form = new ShowBillForm();
                                form.Show();

                             


                            }
                            if (!check)
                            {
                                finalPrice = CostumerBL.PriceWithoutDiscount(days, price);
                                MessageBox.Show("Promo could not be applied ");
                                ShowBillForm form = new ShowBillForm();
                                form.Show();

                            }

                            CostumerDL.storeRentedCars("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\RentedCars.txt", name, days, finalPrice);

                            CostumerDL.AddIntoRentedCarsList(name);

                        }
                    }
                    else if (!CarBL.isCarNameAvailable(name))
                    {
                        MessageBox.Show("Car is not available");

                    }

                }
            }
            MessageBox.Show("Thanks For Coming. Hope to See You soon");
            Close();
        }

        private void txbDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearInputs();
        }
        private void clearInputs()
        {
            txbCompany.Text = "";
            txbName.Text = "";
            txbDays.Text = "";
            txbPromo.Text = "";
        }
    }
}
