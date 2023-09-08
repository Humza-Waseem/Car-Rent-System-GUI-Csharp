using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;


namespace WindowsFormsApp1.BL
{

    class PersonBL
    {
        SignInMenu signInForm = new SignInMenu();
        SignUpMenu signUpForm = new SignUpMenu();
        protected string name;
        protected string password;
        protected string role;

        //    public  List<PersonBL> persons;
        public string getUserName()
        {
            return name;
        }
        public string getRole()
        {
            return role;
        }
        public string getPassword()
        {
            return password;
        }

      
        public virtual bool isCarNameAvailable(string name)
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
        public virtual double GetCarPrice(string name)
        {


            foreach (CarBL car in CarDL.listOfCars)
            {
                if (name != car.getCarName())
                {
                    continue;
                }
                else if (name == car.getCarName())
                {
                   

                    return car.getPrice();
                }
            }
            return 0;
        }


        
      

        public void setPersonName(string name)
        {
            this.name = name;
        }
        public PersonBL()
        {

        }



        public PersonBL(string name)
        {
            this.name = name;
        }
        //for taking input without role
        public PersonBL(string name, string password) : this(name)
        {

            this.password = password;

        }
        //for taking input with role
        public PersonBL(string name, string password, string role) : this(name, password)
        {

            this.role = role;

        }

        public static bool isUserNameAvailable(string UserName)
        {
            foreach (PersonBL p in PersonDL.persons)
            {
                if (UserName != p.name)
                {
                    continue;
                }
                else if (UserName == p.name)
                {
                    return true;
                }

            }
            return false;


        }
      
        public static string checkUserRole(string name, string password)
        {

            string userRole;
            for (int i = 0; i < PersonDL.persons.Count; i++)
            {
                if (name == PersonDL.persons[i].name && password == PersonDL.persons[i].password)
                {
                    userRole = PersonDL.persons[i].role;
                    return userRole;
                }

            }
            return null;
        }
      





        public static string GetUserRole(PersonBL p)
        {
            if (p.name != null && p.password != null)
            {
                if (PersonDL.persons.Count > 0)
                {
                    string userRole = PersonBL.checkUserRole(p.name, p.password);
                    return userRole;


                }
            }
            return null;
        }
        public static bool SetUserRole(string userRole, PersonBL p)
        {
            if (p.name != null && p.password != null && userRole != null)
            {
                return true;
            }
            return false;
        }






        //this is a common fuction for both admin and costumer
        public virtual void checkAvailablity()
        {

        }
        //this is a common fuction for both admin and costumer
        public virtual void checkPrice()
        {

        }
        public static PersonBL setUserRole(string userRole)
        {
            if (userRole == "admin " || userRole == "ADMIN " || userRole == "Admin ")

            {
                AdminBL a = new AdminBL(userRole);
                return a;

            }
            if (userRole == "costumer " || userRole == "COSTUMER " || userRole == "Admin")
            {
                CostumerBL c = new CostumerBL(userRole);
                return c;
            }
            return null;
        }





    }
}

