using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.UI
{
    public partial class NotifyAdmin : Form
    {
        public NotifyAdmin()
        {
            InitializeComponent();
        }

        private void NotifyAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string notF = txbNotify.Text;
            AdminBL d = new AdminBL(notF);
            if (AdminBL.setNotifications(notF))
            {
                AdminDL.StoreInFile("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\notifications.txt", notF);
                AdminDL.AddIntoNotificationList(d);
                MessageBox.Show("Notification added and all costumers will be Notified");
            }

        
            else
                MessageBox.Show("Invalid Input");
        }

        private void txbNotify_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Visible = true;
        }
    }
}
