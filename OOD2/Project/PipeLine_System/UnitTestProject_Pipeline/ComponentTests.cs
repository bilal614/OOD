using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Collections.Generic;
using PipeLine_System;

namespace UnitTestProject_Pipeline
{
    [TestClass]
    public class ComponentTests
    {
       
        [TestMethod]
        public void CreateComponent()
        {
            int componentID = 4;
            Point componentPointLocation = new Point(225, 200);
            double CurrentFlow = 25.5;
            Component testComponent = new Component(componentID, componentPointLocation, CurrentFlow);
            
        }
    }
}
