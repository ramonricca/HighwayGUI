using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace HighwayGUI
{
    public partial class InitHighway : Form
    {
        private int highwayMiles;
        private int maxVeh;
        private int numMinutes;
        public HWindow highwayWindow;
        public InitHighway()
        {
            InitializeComponent();
        }

        private void createHighway_Click(object sender, EventArgs e)
        {
            try
            {
                highwayMiles = Convert.ToInt32(hLengthText.Text);
                maxVeh = Convert.ToInt32(maxVehiclesText.Text);
                numMinutes = Convert.ToInt32(totalMinText.Text);
            }
            catch
            {
                DialogResult msgboxID = MyErrorDialog(
                    "All input parameters must be integers",
                    "Input is Invalid");
            }

            if ((validateInt("Number of Miles", highwayMiles, 1, 100)) 
                && (validateInt("Max number of Vehicles", maxVeh, 1, 50))
                && (validateInt("Number of Minutes", numMinutes, 1, 5000)))
            {
                highwayWindow = new HWindow(highwayMiles, maxVeh, numMinutes);
                highwayWindow.Show();
            }
        }

        private bool validateInt(string idOfVal, int val, int lower, int upper)
        {
            if ((val < lower) || (val > upper))
            {
                DialogResult msgboxID = MyErrorDialog(
                    $"The {idOfVal} parameter needs to be between {lower} and {upper}.",
                    "Error: Value is not valid");
                return false;
            }
            else
            {
                return true;
            }
        }

        private DialogResult MyErrorDialog(string message, string title)
        {
            DialogResult msgboxID = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK
            );

            return msgboxID;
        }
    }
}
