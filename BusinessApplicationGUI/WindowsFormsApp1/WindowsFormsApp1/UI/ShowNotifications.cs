using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1.UI
{
    public partial class ShowNotifications : Form
    {
        public ShowNotifications()
        {
            InitializeComponent();
        }

        private void ShowNotifications_Load(object sender, EventArgs e)
        {

        }
       
        private void PopulateDataGridView(string filePath)
        {
          
            string[] lines = File.ReadAllLines(filePath);

          
            DataTable dataTable = new DataTable();

            
            string[] headers = lines[0].Split('.');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }

        
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                dataTable.Rows.Add(data);
            }

    
            CarsDataGridView.DataSource = dataTable;
            CarsDataGridView.Visible = true;
            button2.Visible = true;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\notifications.txt";
            PopulateDataGridView(filePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
