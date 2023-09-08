using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BL;
using System.IO;

namespace WindowsFormsApp1.DL
{
    class CostumerDL
    {
        public static List<string> ListOfReviews = new List<string>();
        public static List<string> listForRentedCars = new List<string>();

       // internal static List<string> ListOfReviews { get => ListOfReviews; set => ListOfReviews = value; }

        public static List <string> getList()
        {
            return ListOfReviews;
        }

         public static void addIntoReviewList(string review)
        {
            ListOfReviews.Add(review);
          
        }
        public static void storeReviewsIntoFile(string path, string review, string car)
        {
            StreamWriter f = new StreamWriter(path, true);
          
            f.WriteLine(car + "==>" + review);
            f.Flush();
            f.Close();

            Console.ReadKey();


        }
        public static string readReviews(string reviewsPath)
        {
            try
            {
                // Open the file using a stream reader
                using (StreamReader sr = new StreamReader(reviewsPath))
                {
                    string fileContents = sr.ReadToEnd();
                    return fileContents;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public static bool ReadReviews(string path)
        {

            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split('.');
                    string review = splittedRecord[0];

                    AdminBL a = new AdminBL(review);
                    a.gerPromo(review);
                    while (ListOfReviews.Count > 0)
                    {

                        CostumerDL.addIntoReviewList(review);
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
        public static void storeRentedCars(string path, string car, int days, double price)
        {
            StreamWriter f = new StreamWriter(path, true);

            f.WriteLine(car + "." + days + "." + price);
            f.Flush();
            f.Close();
          


        }
        public static void storeReviews(string path,string review)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(review);
            f.Flush();
            f.Close();
        }
        public static void AddIntoRentedCarsList(string name)
        {
            listForRentedCars.Add(name);

        }
    }
}
