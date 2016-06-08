using PipeLineProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System.Classes
{
    class System
    {
        public static bool saved = false;
        public static Network currentNetwork = null;
        public static FileHandler fileHandler = null;
        public static Component tempComponent = null;
        public static PipeLine tempPipeLine = null;


        public bool OpenNetwork()
        {
        }
        public void SaveNetwork() { }
        public void DrawComponent() { }
        public void drawLine() { }
    }
}
