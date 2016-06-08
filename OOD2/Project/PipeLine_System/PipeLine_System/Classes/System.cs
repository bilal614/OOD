using PipeLineProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System.Classes
{
    class System : Network
    {
        public bool seved;
        private Network currentNetwork;
        private FileHandler fileHandler;
        private Component tempComponent;
        private PipeLine tempPipeLine;

        public System() { }

        public void OpenNetwork() { }
        public void SaveNetwork() { }
        public void DrawComponent() { }
        public void drawLine() { }
    }
}
