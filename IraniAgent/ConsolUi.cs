using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IraniAgent
{
    internal class ConsoleUi
    {
        public void ShowStartMessage()
        {
            Console.WriteLine("======== משחק חשיפת סוכן איראני ========");
            Console.WriteLine("מטרתך: לחשוף את כל חולשות הסוכן באמצעות סנסורים.");
            Console.WriteLine();
        }

        public void ShowTurnIntro()
        {
            Console.WriteLine("---------- סיבוב חדש ----------");
        }

        public void ShowSensorChoices()
        {
            Console.WriteLine("בחר סנסור:");
            Console.WriteLine("1. Audio");
            Console.WriteLine("2. Thermal");
            Console.WriteLine("3. Pulse");
            Console.WriteLine("4. Heat");
        }

        public void ShowResult(int matchCount, int total)
        {
            Console.WriteLine($"התאמות: {matchCount} מתוך {total}");
        }

        public void ShowVictory()
        {
            Console.WriteLine("🎯 כל החולשות נחשפו! ניצחת!");
        }
    }

}
