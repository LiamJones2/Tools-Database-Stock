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
using Tools_Database_Stock;

namespace Tools_Database_Stock
{
    public partial class warehouseTable : Form

    {

        //this string connects to the database when used with SQLConnection 
        string connectionToDatabaseString = "Data Source = DESKTOP-TVGNFNP;Database=ToolsDatabase;Integrated Security = false;User Id=liamadmin;pwd=password";


        //runs the form warehouseTable
        public warehouseTable()
        {
            InitializeComponent();            
        }

        //Loads data from the database into the table to be shown to users
        private void warehouseTable_Load(object sender, EventArgs e)
        {
            this.toolStockTableTableAdapter.Fill(this.toolsDatabaseDataSet.ToolStockTable);         
        }

        //changes to updateForm if the button is clicked
        private void updateStockButton_Click(object sender, EventArgs e)
        {
            Form loadUpUpdateForm = new updateForm();
            loadUpUpdateForm.Show();
            this.Hide();
        }

        //prints out what stock is needed from the database if it connects or it will show an error box
        private void printStockNeededButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionToDatabaseString);
                con.Open();
                string query = "Select * from ToolStockTable";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader.GetValue(3)) > Convert.ToInt32(reader.GetValue(2)))
                    {
                        string output = "STOCK NEEDED!!! Stock Name -" + reader.GetValue(1)+". Need's more stock to keep up with demand";
                        MessageBox.Show(output);
                    }
                }
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        //changes to mainMenu if the button is clicked
        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            Form loadUpForm1 = new mainMenu();
            loadUpForm1.Show();
            this.Close();
        }
    }
}


/*Torque Screwdrivers 'P' Type
 * NorTorque Adjustable 16mm Spigot (Dual Scale)
 * ProTronic Plus 30, 1/4", 1.5 - 30 N.m
 * HT-72/5.2, 1500 N·m, 1/2" in, 1" out
 * EBT-52-800 Single Speed, Single Trigger
 * PTM-72 with Right Angle Gearbox, 1350 N·m
 * Right Angle Gearbox
 * T-Box™ 2
 * Torque Wrench Calibrator 400 N·m
 * Calibration Disc
 * 
 */

