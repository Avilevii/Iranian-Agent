using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IraniAgent
{
    public class Sensor
    {
        public string Type { get; set; }

        public Sensor(string type)
        {
            Type = type;
        }
        public virtual void Activate()
        {
            Console.WriteLine("הפעלת הסנסור מתחילה:");
        }
        
    }





    public class Pulse: Sensor
    {
        public Pulse(): base("Plase") { }
    }





    public class Thermal: Sensor
    {
        public Thermal(): base("Thermal") { }
    }


    public class Audio: Sensor
    {
        public Audio(): base("Audio") { }
    }


    public class Heat: Sensor
    {
        public Heat(): base("Heat") { }
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
