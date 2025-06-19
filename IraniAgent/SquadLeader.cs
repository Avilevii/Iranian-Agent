using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IraniAgent
{
    internal class SquadLeader: Agent
    {
        private int Count = 0;


        public SquadLeader(): base(4) { }


        public override void AddAttachedSensors(Sensor sensor)
        {
            AttachedSensors.Add(sensor);
            Count++;
            if(Count % 3 == 0)
            {
                Counterattack();
            }
            
        }
        public override void Counterattack()
        {
            if(AttachedSensors.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(0, AttachedSensors.Count);
                Console.WriteLine($"הערך {AttachedSensors[index]} הוסר מהרשימה");
                AttachedSensors.RemoveAt(index);
            }
        }
    }


}
