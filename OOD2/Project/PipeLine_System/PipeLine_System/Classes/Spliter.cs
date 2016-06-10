using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    public class Spliter : Component
    {
        private double upperOut;
        private double lowerOut;
        private PipeLine inPipeline;
        private PipeLine outPipeLine1;
        private PipeLine outPipeLine2;
        private Point upperLocation;//This is the location relevant to the upper-left corner of the Splitter and component and is used to 
        //identify clicks by user within the top left quadrant of the Splitter Component.
        private Point lowerLocation;//This is the location relevant to the lower-left corner of the Splitter and component and is used to 
        //identify clicks by user within the lower left quadrant of the Splitter Component.
        private const int upperArea = 350;
        private const int lowerArea = 350;

        //CONSTRUCTOR
        public Spliter(int ID, Point componentLocation, double CurrentFlow) :
            base(ID, componentLocation, CurrentFlow)
        {
            upperLocation = componentLocation;
            lowerLocation = new Point(componentLocation.X, componentLocation.Y - 12);
            //the reason we create the lowerLocation reference point with Y component with -12 is because the images roughly have
            //a height of 24 pixels, so we want the lowerLocation to be from mid-lower left edge of the image 
        }

        //METHODS
        /*The following methods return the outgoing and incoming pipeline neighbors of the Splitter.*/
        public virtual PipeLine getOutPipeLine1()
        {
            return outPipeLine1;
        }
        public virtual PipeLine getOutPipeLine2()
        {
            return outPipeLine2;
        }
        public virtual PipeLine getInPipeLine()
        {
            return inPipeline;
        }
        /*The following methods add incoming and outgoing pipeline neighbors to the Merger. If successful, it returns true otherwise
        * it returns a false.*/
        public virtual bool addOutPipeLine1(PipeLine OutPipeLine1)
        {
            if (OutPipeLine1 != null)
            {
                outPipeLine1 = OutPipeLine1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool addOutPipeLine2(PipeLine OutPipeLine2)
        {
            if (OutPipeLine2 != null)
            {
                outPipeLine2 = OutPipeLine2;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool addInPipeLine(PipeLine InPipeLine)
        {
            if (InPipeLine != null)
            {
                inPipeline = InPipeLine;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The UpperContainsPoint and LowerContainsPoint methods return a true if the given input parameters which are mouse-clicks
        /// are located in the top left quadrant of the image for the UpperContainsPoint method and if they are located in the lower
        /// left quadrant of the image in the LowerContainsPoint method. Otherwise they return a false.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns>True or False</returns>
        public virtual bool UpperContainsPoint(int xmouse, int ymouse)
        {
            int temp = (xmouse - upperLocation.X) * (upperLocation.Y - ymouse);
            return temp <= upperArea && temp > 0;
        }

        public virtual bool LowerContainsPoint(int xmouse, int ymouse)
        {
            int temp = (xmouse - lowerLocation.X) * (lowerLocation.Y - ymouse);
            return temp <= lowerArea && temp > 0;
        }


        public override string ToString()
        {
            //TYPE_ID_PX_PY_CURRENTFLOW_UPPEROUT_LOWEROUT_INPIPELINE_OUTPIPELINE1_OUTPIPELINE2_UPPERLOCATION(X,Y)_LOWERLOCATION(X,Y)
            return "SP_" + base.ToString() + String.Format("_{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}",
                inPipeline.getId().ToString(), outPipeLine1.getId().ToString(), outPipeLine2.getId().ToString(),
                upperLocation.X.ToString(), upperLocation.Y.ToString(), lowerLocation.X.ToString(), lowerLocation.Y.ToString());
        }
    }
}
