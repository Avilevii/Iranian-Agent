using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IraniAgent
{
    internal class Game
    {
        public void AskThePlayer(Agent agent)
        {
           
            SensorManger manger = new SensorManger();
            List<Sensor> AllSensor = manger.GetAllSensor();
            agent.AttachedSensors.Clear();
            for (int i = 0; i < agent.Weaknesses.Count; i++)
            {
                Console.WriteLine("בחר סנסור 1 = Audio 2 = Thermal 3 = Pulse 4 = Heat");
                string input = Console.ReadLine();
                int num = int.Parse(input);
                Sensor s = AllSensor[num - 1];
                agent.AddAttachedSensors(s);

            }


        }
    }
}
