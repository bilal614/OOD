using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PipeLine_System
{
    class Sink: Component
    {
        private Component startComponent;
        /*The Sink class is a child class of the Component class and inherits the properties and methods of the Component class. This class
         * represents the sink component in the pipe-line network which acts as a point of consumption in the network. 
         */

        /*PROPERTIES:
         * The Sink class has properties in addition to the ones it inherits from its parent Component class. Those additional properties
         * only include a incoming pipe-line component
         */
        
        private PipeLine inPipeLine;

        //CONSTRUCTOR
        public Sink(int ID, Point componentLocation, double CurrentFlow) :
            base(ID, componentLocation, CurrentFlow)
        { 
        
        }

    }
}
