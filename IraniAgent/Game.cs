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
                
                string input = Console.ReadLine();
                int num = int.Parse(input);
                Sensor s = AllSensor[num - 1];
                agent.AddAttachedSensors(s);

            }


        }
        public void RunTurn()
        {
            Game game = new Game();
            Agent agent = new Agent();
            ConsoleUi ui = new ConsoleUi();
            ui.ShowStartMessage();

            agent.GenerateSecretWeaknesses();
            int check = 0;
            int weaknesses = agent.Weaknesses.Count();
            while (check != weaknesses)
            {
                ui.ShowTurnIntro();
                ui.ShowSensorChoices();
                agent.GenerateSecretWeaknesses();
                game.AskThePlayer(agent);
               
                agent.CheckExposure();
                check = agent.CheckExposure();
                ui.ShowResult(check, weaknesses);

            }
            ui.ShowVictory();



        }
    }
}
