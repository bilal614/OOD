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
            Assert.AreEqual(225, testComponent.GetLocation().X);
            Assert.AreEqual(200, testComponent.GetLocation().Y);
            Assert.AreEqual(4, testComponent.GetComponentId());
        }

        [TestMethod]
        public void TestComponentContainsPoint()
        {
            int componentID = 4;
            Point componentPointLocation = new Point(225, 200);
            double CurrentFlow = 25.5;
            Component testComponent = new Component(componentID, componentPointLocation, CurrentFlow);
            int x1 = 229, y1 = 196, x2 = 300, y2 = 285;
            bool tempVal1 = testComponent.ContainsPoint(x1, y1);
            Assert.IsTrue(tempVal1);
            bool tempVal2 = testComponent.ContainsPoint(x2, y2);
            Assert.IsFalse(tempVal2);
        }


    }
}
