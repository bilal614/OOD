using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PipeLine_System
{
    public class AdjustableSpliter : Spliter
    {
        int upperPercent;

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
            PipeLine outPipeline1, PipeLine outPipeline2, Point upperLocation, Point lowerLocation, int upperPercent) :
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
            base.SetFlow(getInPipeLine().CurrentFlow);
        }
    }
}
