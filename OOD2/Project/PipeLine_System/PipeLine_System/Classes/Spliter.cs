using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    class Spliter : Component
    {
        private double upperOut;
        private double lowerOut;
        private PipeLine inPipeline;
        private PipeLine outPipeLine1;
        private PipeLine outPipeLine2;
        private Point upperLocation;
        private Point lowerLocation;

        //CONSTRUCTOR
        public Spliter(int ID, Point componentLocation, double CurrentFlow) :
            base(ID, componentLocation, CurrentFlow)
        { 
        
        }

        //METHODS
        /*The following methods return the outgoing and incoming pipeline neighbors of the Splitter.*/
        public PipeLine getOutPipeLine1()
        {
            return outPipeLine1;
        }
        public PipeLine getOutPipeLine2()
        {
            return outPipeLine2;
        }
        public PipeLine getInPipeLine()
        {
            return inPipeline;
        }
        /*The following methods add incoming and outgoing pipeline neighbors to the Merger. If successful, it returns true otherwise
        * it returns a false.*/
        public bool addOutPipeLine1(PipeLine OutPipeLine1)
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

        //public bool addOutPipeLine1(PipeLine OutPipeLine2)
        //{
        //    if (OutPipeLine2 != null)
        //    {
        //        outPipeLine2 = OutPipeLine2;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public bool addInPipeLine1(PipeLine InPipeLine)
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
    }
}
