using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    class FileHandler
    {
        private string path;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="path"></param>
        public FileHandler(string path)
        {
            this.path = path;
        }
        public bool WriteToFile(Network nw)
        {
            return false;
        }
        public Network ReadFromFile()
        {
            Network nw = new Network();
            return nw;
        }
    }
}
