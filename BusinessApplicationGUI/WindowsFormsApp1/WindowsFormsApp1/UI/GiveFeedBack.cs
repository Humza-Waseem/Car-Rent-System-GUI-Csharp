using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DL;
using WindowsFormsApp1.BL;

namespace WindowsFormsApp1.UI
{
    public partial class GiveFeedBack : Form
    {
        public GiveFeedBack()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string review = txbNotify.Text;

            if (CostumerBL.setReview(review))
            {


               
                CostumerDL.storeReviews("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Reviews.txt", review);
                CostumerBL.addReviewInList(review);
                MessageBox.Show("Thanks For Giving a Review.");
            }


            else
                MessageBox.Show("Invalid Input");
        }
    }
}
