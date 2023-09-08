using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.BL
{
    class CostumerBL : PersonBL
    {

       public static  List<string> reviewList = new List<string>();

        public static double PriceWithDiscount(int days, double price)
        {
           
            double total = days * price;

            double disc = (10 * 1 / 100) * total;

            double totalPrice = total - disc;
            return totalPrice;


        }
        public static double PriceWithoutDiscount(int days, double price)
        {
            double total = days * price;
            return total;
        }


        public static bool checkIfPromoIsAvailable(string promo)
        {
            int i = 0;
            foreach (string p in AdminDL.promoCodes)
            {
                if (promo == AdminDL.promoCodes[i])
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
        public static bool setReview(string review)
        {
            if (review != null)
            {
                return true;
            }
            return false;
        }
        public static void addReviewInList(string review)
        {
            reviewList.Add(review);
        }

      
        public CostumerBL(string name, string password, string role) : base(name, password, role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public CostumerBL() : base()
        {

        }
        public CostumerBL(string userRole)
        {
            this.role = userRole;
        }
        public bool setCostumer(string name, string password, string role)
        {
            if (name == null)
            {
                return false;
            }
            return true;
        }
        public string getCostumer()
        {
            return null;
        }
        public bool isCostumer()
        {
            if (role == "admin" || role == "ADMIN" || role == "Admin")

            {
                return true;

            }
            return false;
        }
        public void comparePrice()
        {

        }
        public void giveReview()
        {

        }
        //this is a common fuction for both admin and costumer





        //this is a common fuction for both admin and costumer
        public override void checkAvailablity()
        {
            Console.WriteLine("THis is costumer check availablitla");
        }

        //this is a common fuction for both admin and costumer

    }
}
