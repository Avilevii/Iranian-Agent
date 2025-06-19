using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IraniAgent
{
    internal class Game
    {
        public void AskThePlayer(Agent agent, List<Sensor> AllSensor)
        {
           
            agent.AttachedSensors.Clear();
            for (int i = 0; i < agent.Weaknesses.Count; i++)
            {
                
                string input = Console.ReadLine();
                int num = int.Parse(input);
                Sensor s = AllSensor[num - 1];
                if (s.Activate())
                {
                    agent.AddAttachedSensors(s);
                }
                else
                {
                    Console.WriteLine("מימשת את כל הפעמים");
                }
                


            }


        }
        public void RunTurn()
        {
            SensorManger manager = new SensorManger();
            List<Sensor> AllSensor = manager.GetAllSensor();
            Game game = new Game();
            Agent agent = new SquadLeader();
            ConsoleUi ui = new ConsoleUi();
            ui.ShowStartMessage();

            agent.GenerateSecretWeaknesses();
            int check = 0;
            int weaknesses = agent.Weaknesses.Count();
            while (check != weaknesses)
            {
                ui.ShowTurnIntro();
                ui.ShowSensorChoices();
                game.AskThePlayer(agent, AllSensor);
               
                agent.CheckExposure();
                check = agent.CheckExposure();
                ui.ShowResult(check, weaknesses);

            }
            ui.ShowVictory();



        }
    }
}
