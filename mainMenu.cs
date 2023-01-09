using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools_Database_Stock
{
    public partial class mainMenu : Form
    {

        //runs the mainMenu form
        public mainMenu()
        {
            InitializeComponent();
        }


        //changes to warehouseTable if the button is clicked
        private void changeToWarehouseStockScreenButton_Click(object sender, EventArgs e)
        {           
            Form Form2 = new warehouseTable();
            Form2.Show();
            this.Hide();
        }


        //closes application if clicked
        private void quitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
