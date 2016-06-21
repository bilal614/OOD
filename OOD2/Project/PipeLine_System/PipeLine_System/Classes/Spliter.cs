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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="componentLocation"></param>
        /// <param name="CurrentFlow"></param>
        /// <param name="upperFlow"></param>
        /// <param name="lowerFlow"></param>
        /// <param name="inPipeLine"></param>
        /// <param name="outPipeline1"></param>
        /// <param name="outPipeline2"></param>
        /// <param name="upperLocation"></param>
        /// <param name="lowerLocation"></param>
        public Spliter(int ID, Point componentLocation, double CurrentFlow, double upperFlow, double lowerFlow, PipeLine inPipeLine,
            PipeLine outPipeline1, PipeLine outPipeline2, Point upperLocation, Point lowerLocation) :
            base(ID, componentLocation, CurrentFlow)
        {
            this.upperOut = upperFlow;
            this.lowerOut = lowerFlow;
            this.inPipeline = inPipeLine;
            this.outPipeLine1 = outPipeline1;
            this.outPipeLine2 = outPipeline2;
            this.upperLocation = upperLocation;
            this.lowerLocation = lowerLocation;
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
        public override void SetFlow(double flow)
        {
            base.SetFlow(inPipeline.CurrentFlow);
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
            string s_outPipeline1, s_outPipeLine2, s_inPipeLine = null;
            if(this.outPipeLine1 == null)
            {
                s_outPipeline1 = "-1";
            }
            else
            {
                s_outPipeline1 = this.outPipeLine1.getId().ToString();
            }
            if(this.outPipeLine2 == null)
            {
                s_outPipeLine2 = "-1";
            }
            else
            {
                s_outPipeLine2 = this.outPipeLine2.getId().ToString();
            }
            if(this.inPipeline == null)
            {
                s_inPipeLine = "-1";
            }
            else
            {
                s_inPipeLine = this.inPipeline.getId().ToString();
            }
            //TYPE_ID_PX_PY_CURRENTFLOW_UPPEROUT_LOWEROUT_INPIPELINE_OUTPIPELINE1_OUTPIPELINE2_UPPERLOCATION(X,Y)_LOWERLOCATION(X,Y)
            return "SP_" + base.ToString() + String.Format("_{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}",
                upperOut.ToString(), lowerOut.ToString(),
                s_inPipeLine, s_outPipeline1, s_outPipeLine2,
                upperLocation.X.ToString(), upperLocation.Y.ToString(), lowerLocation.X.ToString(), lowerLocation.Y.ToString());
        }
        /// <summary>
        ///  Create an object of type Spliter from string infors
        /// </summary>
        /// <param name="SpliterInfors"></param>
        /// <returns></returns>
        public static Spliter createSpliterFromStringArray(string[] SpliterInfors)
        {
            Spliter sp = null;
            int id = Convert.ToInt16(SpliterInfors[1]);
            int x = Convert.ToInt32(SpliterInfors[2]);
            int y = Convert.ToInt32(SpliterInfors[3]);
            Point Location = new Point(x, y);
            double CurrentFlow = Convert.ToDouble(SpliterInfors[4]);
            double upperFlow = Convert.ToDouble(SpliterInfors[5]);
            double lowerFlow = Convert.ToDouble(SpliterInfors[6]);
            PipeLine inpipeline = new PipeLine(Convert.ToInt32(SpliterInfors[7]), 0);
            PipeLine outpipeline1 = new PipeLine(Convert.ToInt32(SpliterInfors[8]), 0);
            PipeLine outpipeline2 = new PipeLine(Convert.ToInt32(SpliterInfors[9]), 0);
            int upperX = Convert.ToInt32(SpliterInfors[10]);
            int upperY = Convert.ToInt32(SpliterInfors[11]);
            Point UpperLocation = new Point(upperX, upperY);
            int lowerX = Convert.ToInt32(SpliterInfors[12]);
            int lowerY = Convert.ToInt32(SpliterInfors[13]);
            Point LowerLocation = new Point(lowerX, lowerY);
            sp = new Spliter(id, Location, CurrentFlow, upperFlow, lowerFlow, inpipeline, outpipeline1, outpipeline2, UpperLocation, LowerLocation);
            return sp;
        }
    }
}
