using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Args
{
    class Executor
    {
        public void executeListFileCommand()
        {
            string dir = Directory.GetCurrentDirectory();
            var files = Directory.GetFiles(dir).Select(path => Path.GetFileName(path)).ToArray();
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }            
            Console.WriteLine();
        }

        public void executePWDCommand()
        {
            string dir = Directory.GetCurrentDirectory();
            Console.WriteLine(dir);            
        }
    }
}
