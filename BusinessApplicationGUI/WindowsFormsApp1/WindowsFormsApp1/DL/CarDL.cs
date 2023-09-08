using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BL;
using System.IO;

namespace WindowsFormsApp1.DL
{
    class CarDL
    {
        //   >>>>>>   List of CARS 
        public static List<CarBL> listOfCars = new List<CarBL>();

        //Funtion for adding carintoo list
        public static void addCarsIntoCarList(CarBL c)
        {
            listOfCars.Add(c);
            

        }
        public static void removeCarFromList(CarBL c)
        {
            listOfCars.Remove(c);
          
        }
        public static void storeIntoFile(string path, CarBL car)
        {
            StreamWriter f = new StreamWriter(path, true);
        
            f.WriteLine(car.getCarName() + "," + car.getCompanyName() + "," + car.getPrice() + "," + car.getColorCar());
            f.Flush();
            f.Close();
          
           
        }

        public static void StoreIntoFileAfterRemoving(string path)
        {
            StreamWriter filevar = new StreamWriter(path);
            foreach (CarBL car in listOfCars)
            {
                filevar.WriteLine(car.getCarName() + "," + car.getCompanyName() + "," + car.getPrice() + "," + car.getColorCar());
                filevar.Flush();
            }
           
            filevar.Close();
        }
        public static CarBL isCarNameAvail(CarBL carToDelete,string carName,string company)
        {
            foreach (CarBL car in listOfCars)
            {
                if (car.getCarName() == carName && car.getCompanyName() ==company)
                {
                    carToDelete = car;
                    return car;
                    
                }
               
            }
            return null;
        }
        public static void deleteCarFromList(CarBL car, string path)
        {
            for (int index = 0; index < listOfCars.Count; index++)
            {
                if (listOfCars[index].getCarName() == car.getCarName() && listOfCars[index].getCompanyName() == car.getCompanyName() && listOfCars[index].getPrice() == car.getPrice()&& listOfCars[index].getColorCar() == car.getColorCar())
                {
                    listOfCars.RemoveAt(index);
                }
            }
            StoreTrainListintoFile(listOfCars, path); 
        }

        public static void StoreTrainListintoFile(List<CarBL> Carlist, string path)
        {
           
            using (StreamWriter file = new StreamWriter(path, false))
            {
                foreach (CarBL Car in Carlist)
                {
                    file.WriteLine(Car.getCarName() + "," + Car.getCompanyName() + "," + Car.getPrice() + "," + Car.getColorCar());
                }
            }
        }

        public static bool readFromCarsFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');

                                                     
                    string name = splittedRecord[0];                            
                    string company = splittedRecord[1];
                    double price = double.Parse(splittedRecord[2]);
                    string color = splittedRecord[3];

                    CarBL car = new CarBL(name, company, price, color);
                    if (car != null)
                    {
                        addCarsIntoCarList(car);
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
        public static bool readCarsFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = PersonDL.parseData(record, 1);
                    string company = PersonDL.parseData(record, 2);
                    double price = double.TryParse(PersonDL.parseData(record, 3), out double parsedValue) ? parsedValue : 0.0;
                    string color = PersonDL.parseData(record, 4);

                    CarBL p = new CarBL(name, company, price, color);

                    if (p != null)
                    {
                        addCarsIntoCarList(p);

                    }
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public static bool removeCar(string name)
        {

            foreach (CarBL car in listOfCars)
            {
                if (name == car.getCarName())
                {
                    removeCarFromList(car);
                   


                    return true;
                }
                else
                {
                    continue;
                }

            }
            return false;

        }
    }
}
