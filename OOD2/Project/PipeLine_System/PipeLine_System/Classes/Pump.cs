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

        /// <summary>
        /// Constructor with all infors for loading from file
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="componentLoctaion"></param>
        /// <param name="CurrentFlow"></param>
        /// <param name="outPipeline"></param>
        public Pump(int ID, Point componentLoctaion, double CurrentFlow, PipeLine outPipeline)
            :base(ID, componentLoctaion, CurrentFlow)
        {
            this.outPipeLine = outPipeline;
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
            string outId = null;
            if(this.outPipeLine == null)
            {
                outId = "-1";
            }
            else
            {
                outId = this.outPipeLine.getId().ToString();
            }
            return "PU_" + base.ToString() + String.Format("_{0}_{1}", this.capacity.ToString(), outId);
        }

        /// <summary>
        /// Create an object of type Pump from string infors
        /// </summary>
        /// <param name="PumpInfors"></param>
        /// <returns></returns>
        static public Pump createPumpFromStringArray(string[] PumpInfors)
        {
            Pump p = null;
            int id = Convert.ToInt16(PumpInfors[1]);
            int x = Convert.ToInt32(PumpInfors[2]);
            int y = Convert.ToInt32(PumpInfors[3]);
            Point Location = new Point(x,y);
            double CurrentFlow = Convert.ToDouble(PumpInfors[4]);
            PipeLine outpipeline = new PipeLine(Convert.ToInt32(PumpInfors[5]), 0);
            p = new Pump(id, Location, CurrentFlow, outpipeline);
            return p;
        }
    }
}
