using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PipeLine_System
{
    public class Pump: Component
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
     
        //CONSTRUCTOR
        public Pump(int ID, Point componentLocation, double CurrentFlow) :
            base(ID, componentLocation, CurrentFlow)
        { 
        
        }

        //METHODS:
        /*The following methods return the outgoing pipeline neighbor of the Pump.*/
        public PipeLine getOutPipeLine()
        {
            return outPipeLine;
        }

        /*The following methods adds an outgoing pipeline neighbor to the Pump. If successful, it returns true otherwise
         * it returns a false.*/
        public bool addOutPipeLine(PipeLine OutPipeLine)
        {
            if (OutPipeLine != null)
            {
                outPipeLine = OutPipeLine;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "PU_" + base.ToString() + String.Format("_{0}_{1}", this.capacity.ToString(), this.outPipeLine.getId().ToString());
        }
    }
}
