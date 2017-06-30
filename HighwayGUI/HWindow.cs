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
    public partial class HWindow : Form
    {
        private const int graphicsmargin = 10;
        private Highway myWay;
        private int currentMinute;
        private int maxMinutes;
        private int highwayLength;
        private bool startstop;
        private int maxVeh;
        private Rectangle gPicBox;

        public HWindow()
        {
            InitializeComponent();
        }

        public HWindow(int len, int max, int minutes)
        {
            InitializeComponent();
            myWay = new Highway(len, max);
            highwayLength = len;
            maxVeh = max;
            currentMinute = 0;
            maxMinutes = minutes;
            setMinuteText();
            gPicBox = new Rectangle(
                this.Left + graphicsmargin,
                this.Top + graphicsmargin,
                this.Width - (4 * graphicsmargin),
                reportText.Top - (2 * graphicsmargin));
            startstop = false;
            DrawVehicles();
        }

        public void setMinuteText()
        {
            string cur = "(" + currentMinute + " / " + maxMinutes + ")";
            minuteText.Text = cur;
        }

        private void bikeBtn_Click(object sender, EventArgs e)
        {
            Random rand1 = new Random();

            Vehicle bike = new Vehicle(2, false, rand1.Next(10, 100), 100, 0);
            reportText.AppendText(myWay.OnRamp(bike) + "\n");
        }

        private void motoBtn_Click(object sender, EventArgs e)
        {
            Vehicle moto = new Vehicle(2, true, 50, 300, 1);
            reportText.AppendText(myWay.OnRamp(moto) + "\n");
        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            Vehicle car = new Vehicle(4, true, 30, 550, 2);
            reportText.AppendText(myWay.OnRamp(car) + "\n");
        }

        private void truckBtn_Click(object sender, EventArgs e)
        {
            Vehicle truck = new Vehicle(18, true, 5, 3000, 3);
            reportText.AppendText(myWay.OnRamp(truck) + "\n");
        }

        private void trafficBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !startstop;
            startstop = !startstop;
            setStartStop();
        }

        private void setStartStop()
        {
            if (startstop == true)
            {
                trafficBtn.Text = "Stop";
            }
            else
            {
                trafficBtn.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentMinute < maxMinutes)
            {
                myWay.IncreaseDistanceAll();
                currentMinute++;
                setMinuteText();
                //reportText.AppendText(myWay.List());
                string exitstring = myWay.CheckIfExited();
                if (exitstring.Length > 0)
                    reportText.AppendText(exitstring + "\n");
                DrawVehicles();
            }
            else
            {
                reportText.AppendText("End of Simulation.\n");
                timer1.Enabled = false;
            }
        }

        private void DrawVehicles()
        {
            System.Drawing.Graphics graphics = this.CreateGraphics();
            System.Drawing.SolidBrush myBackBrush = new SolidBrush(System.Drawing.Color.DarkGray);
            graphics.FillRectangle(myBackBrush, gPicBox);
            List<Vehicle> vList = myWay.List();
            for (int i = 0; i < vList.Count; i++)
            {
                System.Drawing.SolidBrush myCarBrush = new SolidBrush(vList[i].MyVehicleColor);
                Rectangle[] vehRects = calculateDistance(vList[i], i);
                graphics.FillRectangle(myBackBrush, vehRects[0]);
                graphics.FillRectangle(myCarBrush, vehRects[1]);
            }
        }

        private Rectangle[] calculateDistance(Vehicle v, int idx)
        {
            float pixPerMile = gPicBox.Width / highwayLength;
            float pixPerVeh = gPicBox.Height / maxVeh;
            float horiz = pixPerMile * v.NumMiles;
            int x = gPicBox.Left; 
            int y = gPicBox.Top + (idx * (int)pixPerVeh);
            int width = gPicBox.Left + (int)horiz;
            int height = gPicBox.Top + (int)pixPerVeh - 5;

            if (width > gPicBox.Width)
                width = gPicBox.Width;

            Rectangle myRect = new Rectangle(x, y, width, height);

            int newX = myRect.Right - v.MyVehicleLength;
            int newW = v.MyVehicleLength;
            Rectangle carRect = new Rectangle(newX, myRect.Y, newW, myRect.Height);
            Rectangle[] returnRects = { myRect, carRect };
            return returnRects;
        }
    }
}
