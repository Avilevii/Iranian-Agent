
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IraniAgent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Agent agent = new Agent();
            Game game = new Game();
            agent.GenerateSecretWeaknesses();
            game.AskThePlayer(agent);
            string result = agent.CheckExposure();
            Console.WriteLine(result);
        }

    }
}
