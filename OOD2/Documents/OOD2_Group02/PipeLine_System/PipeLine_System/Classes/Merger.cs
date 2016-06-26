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
        private const int upperArea = 750;
        private const int lowerArea = 750;

        //CONSTRUCTOR
        public Merger(int ID, Point componentLocation, double CurrentFlow)
            : base(ID,componentLocation,CurrentFlow)
        {
            upperLocation = this.GetUpperLocation();
            lowerLocation = this.GetLowerLocation();
        }
        /// <summary>
        /// Alternative contructor
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="componentLocation"></param>
        /// <param name="CurrentFlow"></param>
        /// <param name="inPipeline1"></param>
        /// <param name="inPipeLine2"></param>
        /// <param name="outPipeLine"></param>
        /// <param name="upperLoc"></param>
        /// <param name="lowerLow"></param>
        public Merger(int ID, Point componentLocation, double CurrentFlow, PipeLine inPipeline1, PipeLine inPipeLine2, PipeLine outPipeLine,
            Point upperLoc, Point lowerLow)
            : base(ID, componentLocation, CurrentFlow)
        {
            this.inPipeline1 = inPipeline1;
            this.outPipeline = outPipeLine;
            this.inPipeline2 = inPipeLine2;
            this.upperLocation = upperLoc;
            this.lowerLocation = lowerLow;
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
        public override void UpdateSelfFlow()
        { inPipeline1.CurrentFlow = 0; }
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
        public override void SetFlow(double flow)
        {
            /*double Flow = inPipeline1.CurrentFlow + inPipeline2.CurrentFlow;
            base.SetFlow(Flow);*/
            base.SetFlow(flow);
        }

        /// <summary>
        /// The UpperContainsPoint and LowerContainsPoint methods return a true if the given input parameters which are mouse-clicks
        /// are located in the top left quadrant of the image for the UpperContainsPoint method and if they are located in the lower
        /// left quadrant of the image in the LowerContainsPoint method. Otherwise they return a false.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns>True or False</returns>
        public bool UpperContainsPoint(int xmouse, int ymouse)
        {
            int temp = (xmouse - upperLocation.X) * (upperLocation.Y - ymouse);
            return temp <= upperArea && temp > 0;
        }

        public bool LowerContainsPoint(int xmouse, int ymouse)
        {
            int temp = (xmouse - lowerLocation.X) * (lowerLocation.Y - ymouse);
            return temp <= lowerArea && temp > 0;
        }

        public void SetUpperLocation(Point compLocation)
        {
            this.upperLocation.X = compLocation.X;
            this.upperLocation.Y = compLocation.Y - 10;

        }
        public Point GetUpperLocation()
        {
            return this.upperLocation;
        }
        public void SetLowerLocation(Point compLocation)
        {
            this.lowerLocation.X = compLocation.X;
            this.lowerLocation.Y = compLocation.Y + 10;
        }
        public Point GetLowerLocation()
        {
            return this.lowerLocation;
        }

        public override string ToString()
        {
            string inPipeline1, inPipeline2, outPipeline = null;
            if(this.inPipeline1 == null)
            {
                inPipeline1 = "-1";
            }
            else
            {
                inPipeline1 = this.inPipeline1.getId().ToString();
            }
            if (this.inPipeline2 == null)
            {
                inPipeline2 = "-1";
            }
            else
            {
                inPipeline2 = this.inPipeline2.getId().ToString();
            }
            if (this.outPipeline == null)
            {
                outPipeline = "-1";
            }
            else
            {
                outPipeline = this.inPipeline1.getId().ToString();
            }
            //MG_ID_PX_PY_CURRENTFLOW_INPIPELINE1_INPIPELINE2_OUTPIPELINE_UPPERLOCATION(X,Y)_LOWERLOCATION(X,Y)
            return "MG_" + base.ToString() + String.Format("_{0}_{1}_{2}_{3}_{4}_{5}_{6}", 
                inPipeline1, inPipeline2, outPipeline,
                this.upperLocation.X.ToString(), this.upperLocation.Y.ToString(), this.lowerLocation.X.ToString(), this.lowerLocation.Y.ToString());
        }
        
        /// <summary>
        /// Create an object of type Merger from string infors
        /// </summary>
        /// <param name="MergerInfors"></param>
        /// <returns></returns>
        public static Merger createMergerFromStringArray(string[] MergerInfors)
        {
            Merger mg = null;
            int id = Convert.ToInt16(MergerInfors[1]);
            int x = Convert.ToInt32(MergerInfors[2]);
            int y = Convert.ToInt32(MergerInfors[3]);
            Point Location = new Point(x, y);
            double CurrentFlow = Convert.ToDouble(MergerInfors[4]);
            PipeLine inpipeline1 = new PipeLine(Convert.ToInt32(MergerInfors[5]), 0);
            PipeLine inpipeline2 = new PipeLine(Convert.ToInt32(MergerInfors[6]), 0);
            PipeLine outpipeline = new PipeLine(Convert.ToInt32(MergerInfors[7]), 0);
            int upperX = Convert.ToInt32(MergerInfors[8]);
            int upperY = Convert.ToInt32(MergerInfors[9]);
            Point UpperLocation = new Point(upperX, upperY);
            int lowerX = Convert.ToInt32(MergerInfors[10]);
            int lowerY = Convert.ToInt32(MergerInfors[11]);
            Point LowerLocation = new Point(lowerX, lowerY);
            mg = new Merger(id, Location, CurrentFlow, inpipeline1, inpipeline2, outpipeline, UpperLocation, LowerLocation);
            return mg;
        }
    }
}
