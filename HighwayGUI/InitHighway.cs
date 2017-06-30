//========================================================================
//  InitHighway.cs
//  This file is the Initial Parameter Form
//========================================================================
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
    //========================================================================
    //  This is the initial form that the user sees when the app is launched
    //========================================================================
    public partial class InitHighway : Form
    {
        private int highwayMiles;
        private int maxVeh;
        private int numMinutes;
        public HWindow highwayWindow;

        //========================================================================
        //  InitHighway
        //  Constructor
        //========================================================================
        public InitHighway()
        {
            InitializeComponent();
        }

        //========================================================================
        //  createHighway_Click
        //  This method is called when the user clicks the create highway button
        //========================================================================
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

        //========================================================================
        //  validateInt
        //  This method checks whether the input value is within bounds, and 
        //  throws an error window if necessary
        //========================================================================
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

        //========================================================================
        //  MyErrorDialog
        //  This method throws up an error window with certain parameters
        //========================================================================
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
