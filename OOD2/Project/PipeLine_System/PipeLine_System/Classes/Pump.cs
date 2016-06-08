using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    class Pump: Component
    {
        /*The Pump class is a child class of the Component class and inherits the properties and methods of the Component class. This class
         * represents the pump component in the pipe-line network. 
         */

        /*PROPERTIES:
         * The Pump class has properties in addition to the ones it inherits from its parent Component class. Those additional properties
         * include the allowed capacity for each pump and an outPipeline indicating the pipe-line connected to the pump which pumps oil 
         * out of the pump component. Also all the attributes for thic class have been kept private and would be accessed via various 
         * methods 
         */
        private double capacity;
        private PipeLine outPipeLine;
        //private PipeLine outPipeLine;
    }
}
