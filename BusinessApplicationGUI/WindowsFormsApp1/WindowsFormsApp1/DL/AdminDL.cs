using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BL;
using System.IO;

namespace WindowsFormsApp1.DL
{
    class AdminDL
    {
        public static List<AdminBL> notifications = new List<AdminBL>();
        public static List<string> promoCodes = new List<string>();



        public static void AddIntoNotificationList(AdminBL d)
        {
            notifications.Add(d);
           
        }
        public static void AddPromoIntoList(string promo)
        {
            promoCodes.Add(promo);
        }
      
        public static void StoreInFile(string path,string write)
        {
            StreamWriter f = new StreamWriter(path, true);

            f.WriteLine(write);
            f.Flush();
            f.Close();
        }


        public static bool ReadNotificationsFromFile(string path)
        {



            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split('.');
                    string notification = splittedRecord[0];

                    AdminBL a = new AdminBL(notification);
                    a.getNotifications(notification);
                    while (notifications.Count > 0)
                    {

                        AdminDL.AddIntoNotificationList(a);
                    }
                }
                f.Close();
                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool ReadPromo(string path)
        {

            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string promo = record;

                    AdminBL a = new AdminBL(promo);
                    a.gerPromo(promo);
                   AdminDL.AddPromoIntoList(promo);
                    
                }
                f.Close();
                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool readFromFile(string path)
        {

            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string password = splittedRecord[1];
                    string role = (splittedRecord[2]);

                    PersonBL p = new PersonBL(name, password, role);
                    while (PersonDL.persons.Count > 0)
                    {

                        PersonDL.AddIntoPersonList(p);
                    }
                }
                f.Close();
                return true;

            }
            else
            {
                return false;
            }



        }
    }
}
