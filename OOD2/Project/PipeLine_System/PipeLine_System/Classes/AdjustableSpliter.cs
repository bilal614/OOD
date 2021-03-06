﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PipeLine_System
{
    public class AdjustableSpliter : Spliter
    {
        double upperPercent;

        //CONSTRUCTOR
        public AdjustableSpliter(int ID, Point componentLocation, double CurrentFlow, int upperPercent) :
            base(ID, componentLocation, CurrentFlow)
        {
            this.upperPercent = upperPercent;
        }

        /// <summary>
        /// Alternavite contructors
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
        /// <param name="upperPercent"></param>
        public AdjustableSpliter(int ID, Point componentLocation, double CurrentFlow, double upperFlow, double lowerFlow, PipeLine inPipeLine,
            PipeLine outPipeline1, PipeLine outPipeline2, Point upperLocation, Point lowerLocation, double upperPercent) :
            base(ID, componentLocation, CurrentFlow, upperFlow, lowerFlow,inPipeLine, outPipeline1, outPipeline2, upperLocation, lowerLocation)
        {
            this.upperPercent = upperPercent;
        }
        public override string ToString()
        {
            return "A" + base.ToString() + String.Format("_{0}", upperPercent.ToString());
        }

        public override void SetFlow(double flow)
        {
            /*base.SetFlow(getInPipeLine().CurrentFlow);*/
            base.SetFlow(flow);
        }

        public void SetUpperPercent(double pct)
        {
            this.upperPercent = pct;
        }
        public double GetUpperPercent()
        {
            return upperPercent;
        }
        public double GetOutUpperFlow()
        {
            return this.currentFlow * (this.upperPercent / 100);
        }

        public double GetOutLowerFlow()
        {
            return this.currentFlow - this.GetOutUpperFlow();
        }
        
        public static AdjustableSpliter createAdjustableSpliterFromStringArray(string[] ASpliterInfors)
        {
            AdjustableSpliter sp = null;
            int id = Convert.ToInt16(ASpliterInfors[1]);
            int x = Convert.ToInt32(ASpliterInfors[2]);
            int y = Convert.ToInt32(ASpliterInfors[3]);
            Point Location = new Point(x, y);
            double CurrentFlow = Convert.ToDouble(ASpliterInfors[4]);
            double upperFlow = Convert.ToDouble(ASpliterInfors[5]);
            double lowerFlow = Convert.ToDouble(ASpliterInfors[6]);
            PipeLine inpipeline = new PipeLine(Convert.ToInt32(ASpliterInfors[7]), 0);
            PipeLine outpipeline1 = new PipeLine(Convert.ToInt32(ASpliterInfors[8]), 0);
            PipeLine outpipeline2 = new PipeLine(Convert.ToInt32(ASpliterInfors[9]), 0);
            int upperX = Convert.ToInt32(ASpliterInfors[10]);
            int upperY = Convert.ToInt32(ASpliterInfors[11]);
            Point UpperLocation = new Point(upperX, upperY);
            int lowerX = Convert.ToInt32(ASpliterInfors[12]);
            int lowerY = Convert.ToInt32(ASpliterInfors[13]);
            Point LowerLocation = new Point(lowerX, lowerY);
            double adjustPer = Convert.ToDouble(ASpliterInfors[14]);
            sp = new AdjustableSpliter(id, Location, CurrentFlow, upperFlow, lowerFlow, inpipeline, outpipeline1, outpipeline2, UpperLocation, LowerLocation, adjustPer);
            return sp;
        }
    }
}
