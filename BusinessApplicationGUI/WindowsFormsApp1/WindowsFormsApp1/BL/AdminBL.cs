using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DL;
namespace WindowsFormsApp1.BL
{
    class AdminBL : PersonBL
    {
        public string notification;
        public string promoCode;


        public static bool setPromoCode(string promoCode)
        {
            if (promoCode != null)
            {
                return true;
            }
            return false;
        }
        public AdminBL(string name, string password, string role) : base(name, password, role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }


        public AdminBL(string userRole)
        {
            this.role = userRole;
        }
        public AdminBL() : base()
        {

        }
        public string gerPromo(string promo)
        {
            this.promoCode = promo;

            return promoCode;
        }
        public string gerNOtification()
        {
            return notification;
        }
        public string getNotifications(string notF)
        {
            this.notification = notF;
            return notification;
        }


        public string getAdmin()
        {
            return null;
        }

        public static bool setNotifications(string notf)
        {
            if (notf != null)
            {
                return true;
            }
            else

                return false;

        }


       


        //this is a common fuction for both admin and costumer
        public override void checkAvailablity()
        {
           
        }
        //this is a common fuction for both admin and costumer
        public override void checkPrice()
        {

        }


    }
}
