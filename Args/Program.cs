using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Args
{
    class Program
    {
        static void Main(string[] args)
        {            
            var commandHandler = new CommandHandler();
            String inputString = Console.ReadLine();
            while (!commandHandler.isExitCommand(inputString))
            {
                commandHandler.exec(inputString);
                inputString = Console.ReadLine();
            }            
        }
    }
}
