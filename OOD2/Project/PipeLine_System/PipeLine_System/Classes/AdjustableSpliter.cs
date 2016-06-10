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

        public override string ToString()
        {
            return "A" + base.ToString() + String.Format("_{0}", upperPercent.ToString());
        }
    }
}
