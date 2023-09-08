using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.BL
{
    class CarBL
    {
        public static List<CarBL> listOfCars = new List<CarBL>();
        protected string color;
        protected string CarName;
        protected string company;
        protected double price;

        public CarBL()
        {

        }
        public CarBL(string name)
        {
            this.CarName = name;
        }
        public string getCarName()
        {
            return CarName;
        }
        public string getCompanyName()
        {
            return company;

        }
        public string getColorCar()
        {
            return color;
        }
        public double getPrice()
        {
            return price;
        }
        public static bool setCarName(string name)
        {
            if (name != null)
                return true;
            return false;

        }
        public static bool setCar(string name, string company, double price, string color)
        {
            if (name == null || company == null || (price < 0 || price >= 30000) || (color == "purple" || color == "orange" || color == null || color == "pink"))
            {
                return false;
            }
            return true;


        }


        public CarBL(string name, string company, double price,string color)
        {
            this.price = price;
            this.CarName = name;
            this.company = company;
            this.color = color;
        }



        public static bool isCarColorSame(string color,string cName)
        {
            foreach (CarBL car in CarDL.listOfCars)
            {
                if (cName == car.getCarName())
                {
                    if (color != car.getColorCar())
                    {
                        continue;
                    }
                    else if (color == car.color)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        public static bool isCarNameAvailable(string name)
        {

            foreach (CarBL car in CarDL.listOfCars)
            {
                if (name != car.getCarName())
                {
                    continue;
                }
                else if (name == car.getCarName())
                {
                    return true;
                }
            }
            return false;
        }
      





        public void addCar()
        {

        }



    }
}
