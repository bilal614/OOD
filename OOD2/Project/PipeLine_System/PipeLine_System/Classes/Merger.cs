using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    public class Merger : Component
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
        private PipeLine inPipeline1;
        private PipeLine inPipeline2;
        private PipeLine outPipeline;
        private Point upperLocation;//This is the location relevant to the upper-left corner of the Merger and component and is used to 
        //identify clicks by user within the top left quadrant of the Merger Component.
        private Point lowerLocation;//This is the location relevant to the lower-left corner of the Merger and component and is used to 
        //identify clicks by user within the lower left quadrant of the Merger Component.
        private const int upperArea = 20;
        private const int lowerArea = 20;

        //CONSTRUCTOR
        public Merger(int ID, Point componentLocation, double CurrentFlow)
            : base(ID,componentLocation,CurrentFlow)
        {

        }

        //METHODS:
        /*The following methods return the outgoing and incoming pipeline neighbors of the Merger.*/
        public PipeLine getInPipeLine1()
        {
            return inPipeline1;
        }
        public PipeLine getInPipeLine2()
        {
            return inPipeline2;
        }
        public PipeLine getOutPipeLine()
        {
            return outPipeline;
        }

        /*The following methods add incoming and outgoing pipeline neighbors to the Merger. If successful, it returns true otherwise
         * it returns a false.*/
        public bool addInPipeLine1(PipeLine InPipeLine1)
        {
            if (InPipeLine1 != null)
            {
                inPipeline1 = InPipeLine1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool addInPipeLine2(PipeLine InPipeLine2)
        {
            if (InPipeLine2 != null)
            {
                inPipeline2 = InPipeLine2;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool addOutPipeLine(PipeLine OutPipeLine)
        {
            if (OutPipeLine != null)
            {
                outPipeline = OutPipeLine;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpperContainsPoint(int xmouse, int ymouse)
        {
            return (xmouse - upperLocation.X) * (upperLocation.Y - ymouse) <= upperArea;
        }

        public bool LowerContainsPoint(int xmouse, int ymouse)
        {
            return (xmouse - lowerLocation.X) * (lowerLocation.Y - ymouse) <= upperArea;
        }

        public override string ToString()
        {
            //MG_ID_PX_PY_CURRENTFLOW_INPIPELINE1_INPIPELINE2_OUTPIPELINE_UPPERLOCATION(X,Y)_LOWERLOCATION(X,Y)
            return "MG_" + base.ToString() + String.Format("_{0}_{1}_{2}_{3}_{4}_{5}_{6}", 
                this.inPipeline1.getId().ToString(), this.inPipeline2.getId().ToString(), this.outPipeline.getId().ToString(),
                this.upperLocation.X.ToString(), this.upperLocation.Y.ToString(), this.lowerLocation.X.ToString(), this.lowerLocation.Y.ToString());
        }
    }
}
