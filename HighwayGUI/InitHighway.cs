using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            highwayMiles = Convert.ToInt32(hLengthText.Text);
            maxVeh = Convert.ToInt32(maxVehiclesText.Text);
            numMinutes = Convert.ToInt32(totalMinText.Text);

            highwayWindow = new HWindow(highwayMiles, maxVeh, numMinutes);
            highwayWindow.Show();
        }
    }
}
