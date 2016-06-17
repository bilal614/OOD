using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PipeLine_System
{
    public class Sink: Component
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

        //METHODS
        /*The following methods return the outgoing pipeline neighbor of the Sink.*/
        public PipeLine getInPipeLine1()
        {
            return inPipeLine;
        }

        /*The following method adds an incoming pipeline neighbor to the Sink. If successful, it returns true otherwise
         * it returns a false.*/
        public bool addInPipeLine(PipeLine InPipeLine)
        {
            if (InPipeLine != null)
            {
                inPipeLine = InPipeLine;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void SetFlow(double flow)
        {
            base.SetFlow(inPipeLine.CurrentFlow);
        }

        public override string ToString()
        {
            string inPipeline = null;
            if (this.inPipeLine == null)
            {
                inPipeline = "-1";
            }
            else
            {
                inPipeline = this.inPipeLine.getId().ToString();
            }
            return "SK_" + base.ToString() + String.Format("_{0}_{1}", inPipeline);
        }
    }
}
