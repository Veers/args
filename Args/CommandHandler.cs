using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Args
{
    class CommandHandler
    {
        private String command;
        private CommandParser commandParser;
        public CommandHandler()
        {
            this.commandParser = new CommandParser();
        }
        public CommandHandler(String inputCommand)
        {
            this.commandParser = new CommandParser();
            this.command = inputCommand;
        }
        public void exec(String command)
        {
            this.commandParser.parse(command);
        }
        public bool isExitCommand(String command)
        {
            if (command.ToLower().Equals("exit"))
                return true;
            else return false;
        }
    }
}
