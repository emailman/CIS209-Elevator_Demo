using System;
using System.Windows.Forms;

namespace CIS209_Elevator_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            // Display the name of the button pressed
            Console.WriteLine(sender.ToString());
            string[] tokens = sender.ToString().Split(':');
            lblFloorCalled.Text = "Call for " + tokens[1].Trim();

            // Change the back color of the button pressed to red
            Button floor = (Button)sender;
            floor.BackColor = System.Drawing.Color.Red;
        }
    }
}
