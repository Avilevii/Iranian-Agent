using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IraniAgent;

namespace IraniAgent
{
    internal class Agent
    {
        public List<string> Weaknesses { get; set; }
        public List<Sensor> AttachedSensors { get; set; }



        public Agent()
        {
            Weaknesses = new List<string>();
            AttachedSensors = new List<Sensor>();
        }

        public void GenerateSecretWeaknesses()
        {
            Weaknesses.Clear();
            Random random = new Random();
            SensorManger manger = new SensorManger();
            List<Sensor> AllSensor = manger.GetAllSensor();
            int num1 = random.Next(0, 4);
            int num2 = random.Next(0, 4);
           Weaknesses.Add(AllSensor[num1].Type);
            Weaknesses.Add(AllSensor[num2].Type);
        }

        public void AddAttachedSensors(Sensor sensor)
        {
            AttachedSensors.Add(sensor);
        }
        public int CheckExposure()
        {
            int sum = 0;
            foreach (Sensor s in AttachedSensors)
            {
                if ((Weaknesses.Contains(s.Type)))
                    sum++;
                
            }
            return sum;
           

        }



    }
    
}

