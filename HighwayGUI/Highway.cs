using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighwayGUI
{
    //========================================================================
    //  Class:  Highway
    //          This class is like a container of vehicles, each with their
    //          own definitions. It allows a vehicle to get on and off the
    //          the highway, once it has travelled a certain distance
    //========================================================================
    class Highway
    {
        public List<Vehicle> vehicleList = new List<Vehicle>();
        private int milesToExitRamp;
        private int maxVehicles;

        public int CurrentMinute { get; private set; }

        //====================================================================
        //  Method: Highway
        //          Constructor, passed in miles to exit ramp and max cars
        //====================================================================
        public Highway(int miles, int max)
        {
            milesToExitRamp = miles;
            maxVehicles = max;
        }

        //====================================================================
        //  Method: OnRamp
        //          Adds a vehicle to the highway
        //====================================================================
        public string OnRamp(Vehicle newVehicle)
        {
            vehicleList.Add(newVehicle);

            return newVehicle.ToString();
        }

        //====================================================================
        //  Method: DistanceForIndex
        //          Given an index, takes a vehicle from the list and returns
        //          the total distance it has travelled
        //====================================================================
        public float DistanceForIndex(int vindex)
        {
            return vehicleList[vindex].NumMiles;
        }

        //====================================================================
        //  Method: IncreaseDistanceAll
        //          Does a tick of time, and increases all the total distances
        //          in the list
        //====================================================================
        public void IncreaseDistanceAll()
        {
            foreach (Vehicle v in vehicleList)
            {
                v.calcCurrentDistanceTick();
            }
        }

        //====================================================================
        //  Method: IncreaseSpeedForIndex
        //          Given an index, increases the speed for that particular
        //          vehicle.
        //====================================================================
        public void IncreaseSpeedForIndex(int vindex)
        {
            vehicleList[vindex].increaseSpeed();
        }

        //====================================================================
        //  Method: CheckIfExited
        //          Checks whether a vehicle has travelled the distance to
        //          the exit ramp. It removes all the vehicles that have 
        //          travelled the distance.
        //====================================================================
        public string CheckIfExited()
        {
            string tmp = "";
            List<Vehicle> removeList = new List<Vehicle>();
            for (int i = 0; i < vehicleList.Count(); i++)
            {
                if (vehicleList[i].NumMiles >= milesToExitRamp)
                {
                    int idx = i + 1;
                    tmp = idx + " has exited!";
                    tmp += AnnounceExitRamp(vehicleList[i]);
                    removeList.Add(vehicleList[i]);
                }
            }

            foreach (Vehicle v in removeList)
            {
                vehicleList.Remove(v);
            }

            return tmp;
        }

        //====================================================================
        //  Method: AnnounceExitRamp
        //          Describes the vehicle that just exited.
        //====================================================================
        private string AnnounceExitRamp(Vehicle vExited)
        {
            string selfdesc = vExited.DescribeVehicle(milesToExitRamp);

            return $"EXIT: {selfdesc}";
        }

        //====================================================================
        //  Method: IsAtCapacity
        //          Returns a boolean whether the highway is full
        //====================================================================
        public bool IsAtCapacity()
        {
            if (vehicleList.Count() < maxVehicles)
                return false;
            else
                return true;
        }

        //====================================================================
        //  Method: List
        //          Outputs the list of vehicles
        //====================================================================
        public List<Vehicle> List()
        {
            //string tmp = "";
            //for (int i = 0; i < vehicleList.Count(); i++)
            //{
            //    int idx = i + 1;
            //   tmp = idx + ") " + vehicleList[i].ToString();
           // }

            return vehicleList;
        }

        //====================================================================
        //  Method: ToString
        //          Override object method
        //====================================================================
        public override string ToString()
        {
            string tmp = "Highway has " + vehicleList.Count() + "vehicles.";

            return tmp;
        }
    }
}
