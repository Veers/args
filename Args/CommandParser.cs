using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Args
{
    class CommandParser
    {
        private Executor exec;
        public CommandParser()
        {
            this.exec = new Executor();
        }
        public void parse(String command)
        {
            if (command.ToLower().Equals("ls"))
            {
                this.exec.executeListFileCommand();
            }
            if (command.ToLower().Equals("pwd"))
            {
                this.exec.executePWDCommand();
            }
        }
    }
}
