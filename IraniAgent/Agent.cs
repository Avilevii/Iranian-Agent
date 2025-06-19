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
        public int Rank;
        public List<string> Weaknesses { get; set; }
        public List<Sensor> AttachedSensors { get; set; }



        public Agent(int rank)
        {
            Rank = rank;
            Weaknesses = new List<string>();
            AttachedSensors = new List<Sensor>();
        }

        public virtual void GenerateSecretWeaknesses()
        {
            Weaknesses.Clear();
            Random random = new Random();
            SensorManger manger = new SensorManger();
            List<Sensor> AllSensor = manger.GetAllSensor();
            for(int i = 0; i < Rank; i++)
            {
                int num = random.Next(0, 4);
                Weaknesses.Add(AllSensor[num].Type);
            }
            
        }

        public virtual void AddAttachedSensors(Sensor sensor)
        {
            AttachedSensors.Add(sensor);
        }
        public virtual int CheckExposure()
        {
            int sum = 0;
            foreach (Sensor s in AttachedSensors)
            {
                if ((Weaknesses.Contains(s.Type)))
                    sum++;
                
            }
            return sum;
           

        }
        public virtual void Counterattack()
        {

        }



    }
    
}

