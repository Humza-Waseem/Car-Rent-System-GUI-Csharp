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
using System.IO;

namespace WindowsFormsApp1.UI
{
    public partial class RentedCarsMenu : Form
    {
        List<string> cars;
        public RentedCarsMenu()
        {
            InitializeComponent();

            cars = CostumerDL.getList();
            cars.Clear();

         CostumerDL.readReviews("D:\\2ndSemester\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\RentedCars.txt");

            // Clear the existing columns and bindings
            RentedDataGrid.DataSource = cars;
            //  dataGridViewCostumers.Refresh();
            
            // dataGridViewCostumers.Show();
        }

        private void RentedCarsMenu_Load(object sender, EventArgs e)
        {

        }
        private void PopulateDataGridView(string filePath)
        {
            // Read the data from the file
            string[] lines = File.ReadAllLines(filePath);

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Assume the data is comma-separated
            string[] headers = lines[0].Split('.');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }

            // Skip the first line (headers) and populate the DataTable
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split('.');
                dataTable.Rows.Add(data);
            }

            // Bind the DataTable to the DataGridView
            RentedDataGrid.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentedDataGrid.Visible = true;
            string filePath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\RentedCars.txt";
            PopulateDataGridView(filePath);
        }
    }
}
