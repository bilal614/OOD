using PipeLineProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineLineProject.Classes
{
    class System : Network
    {
        public bool seved;
        private Network currentNetwork;
        private FileHandler fileHandler;
        private Component tempComponent;
        private PineLine tempPipeLine;

        public System() { }

        public void OpenNetwork() { }
        public void SaveNetwork() { }
        public void DrawComponent() { }
        public void drawLine() { }
    }
}
