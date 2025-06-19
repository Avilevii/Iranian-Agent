using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IraniAgent
{
    public abstract class Sensor
    {
        public string Type { get; set; }

        public Sensor(string type)
        {
            Type = type;
        }

        public abstract bool Activate(); 
    }






    public class Pulse: Sensor
    {
        private int PulsCount = 0;
        public bool Bool = true;
        public Pulse(): base("Plase")
        {

        }

        public override bool Activate()
        {
            if (Bool)
            {
                PulsCount++;
               
            }
            
            if(PulsCount >= 3)
            {
                Bool = false;
                Console.WriteLine("מימשת כבר 3 פעמים הסנסור שבור");

                return false;
            }
            return true;
        }
    }





    public class Thermal: Sensor
    {
        public Thermal(): base("Thermal") { }

        public override bool Activate()
        {
            return true; 
        }
    }


    public class Audio: Sensor
    {
        public Audio(): base("Audio") { }

        public override bool Activate()
        {
            return true;
        }
    }


    public class Heat: Sensor
    {
        public Heat(): base("Heat") { }

        public override bool Activate()
        {
            return true;
        }
    }



    public class SensorManger
    {
        public List<Sensor> GetAllSensor()
        {
            return new List<Sensor>
            {


                new Audio(),
                new Thermal(),
                new Pulse(),
                new Heat(),

            };

    
        }
    }
   
}
