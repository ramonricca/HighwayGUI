using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayGUI
{
    //========================================================================
    //  Class:  Vechicle
    //          This class defines a vechicle on the highway. There are 
    //          various internal properties that define the representation
    //          of this object on a highway.
    //========================================================================
    class Vehicle
    {
        private int numWheels;
        private bool isMotorized;
        private int mpg;
        private int mass;
        private float numMiles;
        private float currentSpeed;

        public System.Drawing.Color MyVehicleColor { get; private set; }
        public int MyVehicleLength { get; private set; }
        //====================================================================
        //  Method: NumMiles
        //          get/set the number of miles the vehicle has travelled
        //====================================================================
        public float NumMiles
        {
            get
            {
                return numMiles;
            }
        }

        //====================================================================
        //  Method: MPG
        //          Accessor for mpg
        //====================================================================
        public int MPG
        {
            get
            {
                return mpg;
            }
        }

        //====================================================================
        //  Method: Vehicle
        //          Constructor for the vehicle. It instantiates the object
        //====================================================================
        public Vehicle()
        {
            //  Does a random vehicle
            Random rand1 = new Random();
            if (rand1.Next(1000) < 100)
            {
                numWheels = rand1.Next(1, 4);
                isMotorized = false;
                mpg = rand1.Next(10, 100);
                mass = rand1.Next(100);
                currentSpeed = rand1.Next(10);
            }
            else
            {
                numWheels = rand1.Next(4, 20);
                isMotorized = true;
                mpg = rand1.Next(5, 50);
                mass = rand1.Next(3000);
                currentSpeed = rand1.Next(100);
            }

            numMiles = 0;
        }

        //====================================================================
        //  Method: Vehicle
        //          Constructor for the vehicle. It instantiates the object
        //====================================================================
        public Vehicle(int wheels, bool hasMotor, int milesgallon, int masskg)
        {
            numWheels = wheels;
            isMotorized = hasMotor;
            mpg = milesgallon;
            mass = masskg;
            currentSpeed = mass / 100;
            numMiles = 0;
            this.MyVehicleColor = System.Drawing.Color.Red;
            this.MyVehicleLength = 20;
        }

        //====================================================================
        //  Method: Vehicle
        //          Constructor for the vehicle. It instantiates the object
        //====================================================================
        public Vehicle(int wheels, bool hasMotor, int milesgallon, int masskg, int colorIdx)
        {
            numWheels = wheels;
            isMotorized = hasMotor;
            mpg = milesgallon;
            mass = masskg;
            currentSpeed = mass / 100;
            numMiles = 0;

            switch (colorIdx)
            {
                case 0:
                    this.MyVehicleColor = System.Drawing.Color.Azure;
                    this.MyVehicleLength = 10;
                    break;
                case 1:
                    this.MyVehicleColor = System.Drawing.Color.CadetBlue;
                    this.MyVehicleLength = 10;
                    break;
                case 2:
                    this.MyVehicleColor = System.Drawing.Color.Red;
                    this.MyVehicleLength = 20;
                    break;
                case 3:
                    this.MyVehicleColor = System.Drawing.Color.PowderBlue;
                    this.MyVehicleLength = 50;
                    break;
            }
        }

        //====================================================================
        //  Method: ToString
        //          Override object method
        //====================================================================
        public override string ToString()
        {
            return "NumWheels = " + numWheels + "; isMotorized = " + isMotorized + "; mpg = " + mpg + "; speed = " + currentSpeed + " mph; miles travelled = " + numMiles.ToString("0.000");
        }

        //====================================================================
        //  Method: increaseSpeed
        //          Increases this vehicles speed
        //====================================================================
        public void increaseSpeed()
        {
            currentSpeed++;
        }

        //====================================================================
        //  Method: calcCurrentDistanceTick
        //          Each time unit is one tick. This calculates the new
        //          total distance travelled
        //====================================================================
        public void calcCurrentDistanceTick()
        {
            numMiles += currentSpeed / 15;
        }

        //====================================================================
        //  Method: DescribeVehicle
        //          Lets a vehicle describe itself with a string.
        //====================================================================
        public string DescribeVehicle(int howfar)
        {
            string hasMotor;
            float fuelEfficiency = (float)howfar / (float)mpg;

            if (isMotorized)
            {
                hasMotor = "Motorized at " + mpg + " mpg consuming " + fuelEfficiency.ToString("0.000") + " gallons";
            }
            else
            {
                hasMotor = "Human Powered at " + mpg + " miles/bowl of Wheaties consuming " + fuelEfficiency.ToString("0.000") + " bowls";
            }

            return hasMotor;
        }
    }
}
