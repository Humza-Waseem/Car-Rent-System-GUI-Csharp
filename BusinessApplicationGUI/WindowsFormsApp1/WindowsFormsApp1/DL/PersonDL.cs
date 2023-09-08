using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BL;
using System.IO;



namespace WindowsFormsApp1.DL
{
    class PersonDL
    {
        public static List<PersonBL> persons = new List<PersonBL>();

        //Read data from person file
        //Write data to person file
        //sort data 
        //add data into list 
        //remove data from list

        public static List<PersonBL> getList()
        {
            return   persons;
        }
        public static void AddIntoPersonList(PersonBL p)
        {
            persons.Add(p);
            
           
        }
       
        public static void storeIntoFile(string path, PersonBL s)
        {
            StreamWriter f = new StreamWriter(path, true);
           
            f.WriteLine(s.getUserName() + "," + s.getPassword() + "," + s.getRole());
            f.Flush();
            f.Close();


          


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
                    string role = splittedRecord[2];


                    PersonBL p = new PersonBL(name, password, role);

                    if (p != null)
                    {
                        AddIntoPersonList(p);
                        
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
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }


        public static void removeFromList(PersonBL p)
        {
            persons.Remove(p);
        }


    }
}
