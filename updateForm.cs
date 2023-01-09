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
    public partial class updateForm : Form
    {

        //this string connects to the database when used with SQLConnection
        string connectionToDatabaseString = "Data Source = DESKTOP-TVGNFNP;Database=ToolsDatabase;Integrated Security = false;User Id=liamadmin;pwd=password";



        //runs the updateForm form
        public updateForm()
        {
            InitializeComponent();
        }


        //changes to warehouseTable if the button is clicked
        private void backToStockButton_Click(object sender, EventArgs e)
        {
            Form loadUpForm2 = new warehouseTable();
            loadUpForm2.Show();
            this.Hide();
        }


        //connects to database and displays each and every stock that is in demand if clicked
        private void checkForStockIDButton_Click(object sender, EventArgs e)
        {
            try
            {
                int requestedStockID = Convert.ToInt32(textBox1.Text);
                SqlConnection con = new SqlConnection(connectionToDatabaseString);
                con.Open();
                string query = "Select * from ToolStockTable";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (requestedStockID == Convert.ToInt32(reader.GetValue(0)))
                    {
                        stockNameTextBox.Text = reader.GetValue(1).ToString();
                        stockTextBox.Text = reader.GetValue(2).ToString();
                    }
                }
                con.Close();
            }
            catch { MessageBox.Show("Unfortunately we couldn't access the database"); }
        }


        //when clicked it will update the stock of the id they inputted with the number they inputted
        private void updateStockbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionToDatabaseString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update dbo.ToolStockTable set Stock=@Stock where ToolID = @ToolID", con);
                cmd.Parameters.AddWithValue("@Stock", int.Parse(updateStockTextBox.Text));
                cmd.Parameters.AddWithValue("@ToolID", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                stockTextBox.Text = updateStockTextBox.Text;
                MessageBox.Show("Successfully Updated");
            }
            catch { MessageBox.Show("Unfortunately we couldn't make an updates"); }
        }
    }
}
