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
    public partial class AddPromo : Form
    {
        public AddPromo()
        {
            InitializeComponent();
        }

        private void AddPromo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string promo = txbPromo.Text;
            if (promo != null)
            {
                AdminDL.StoreInFile("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\PromoCodes.txt", promo);
                AdminDL.AddPromoIntoList(promo);
                MessageBox.Show("Promo Added Successfully");
            }
            else
            {
                MessageBox.Show("Enter a valid Promo"); 
            }

        }

        private void txbPromo_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Visible = true;

        }

        /* private void label3_Click(object sender, EventArgs e)
         {

         }

         private void txbName_TextChanged(object sender, EventArgs e)
         {

         }*/
    }
}
