using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problem_4
{
    internal class TrafficLight
    {
        private int time;

        public TrafficLight()
        {
            time = 0; 
        }

        public string GetLightColor()
        {
            
            if (time >= 0 && time < 5) 
            {
                return "Red";
            }
            else if (time >= 5 && time < 7) 
            {
                return "Yellow";
            }
            else if (time >= 7 && time < 12) 
            {
                return "Green";
            }
            else
            { 
                time = 0;
                return GetLightColor(); 
            }
 
        }

        public void IncrementTime()
        {
            time++; 
        }
    }
}
