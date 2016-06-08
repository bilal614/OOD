using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    class Component
    {
        /*The Component class is the parent class for all the different child Component classes including Pump, Splitter, Merger, Sink and 
        the Pump class. The Component class serves as the blueprint for each of the different kind of components that are needed in the 
        the pipe-line network.
         */
        /*PROPERTIES:
         * Properties of the Component class include those properties which are common to all the Component child classes and include 
         * attributes including the location, an id and a current-flow for each component. Moreover all the properties for the Component
         * class have been kept private and can be accessed via various methods. 
         */
        private int id;
        private Point location;
        private double currentFlow;

        /*
         METHODS:
         * The Component class has the method updateCurrentFlow which takes no parameters and returns nothing. This method would be tied to 
         * an event which would be raised if the current-flow of the Component is changed. If so the current-flow of the neighbors are changed
         * by invoking their current-flow change event as well. 
         */
        void updateCurrentFlow()
        {
            //needs to be implemented 
        }
    }
}
