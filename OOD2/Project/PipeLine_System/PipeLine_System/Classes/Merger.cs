using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    class Merger : Component
    {
        /*The Merger class is the child class for the Component class and represents one of the Component type items that may be drawn on
         * the drawing screen. The Merger class serves as the Component which can connect two PipeLine flows into a single PipeLine in 
         * the pipe-line network.
         */
        /*PROPERTIES:
         * Properties of the Merger class include those properties which are common to all the Component child classes and include 
         * attributes including the location, an id and a current-flow for each component. Moreover all the properties for the Merger
         * class have been kept private and can be accessed via various methods. The Merger has properties that are unique to it as well
         * which include the 2 starting Component properties to indicate the PipeLines that constitute the input of the current flow to the
         * Merger and an outgoing PipeLine as well. 
         */
        private PipeLine comStart1;
        private PipeLine comStart2;
        private PipeLine comEnd;
        public Merger() { }
    }
}
