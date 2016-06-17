using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipeLine_System;
using System.Collections.Generic;
using System.Drawing;

namespace UnitTestProject_Pipeline
{
    [TestClass]
    public class TestRemove
    {
        [TestMethod]
        public void TestRemoveComp()
        {
            Network nw = new Network();
            List<PipeLine> pipelines = new List<PipeLine>();
            Component c1 = new Pump(1, new Point(100, 200), 150.5);
            nw.Addcomponent(c1);
            Component c2 = new Sink(2, new Point(253, 500), 350);
            nw.Addcomponent(c2);
            Component c3 = new Merger(3, new Point(200, 300), 150);
            nw.Addcomponent(c3);
            Component c4 = new Spliter(4, new Point(300, 205), 500);
            nw.Addcomponent(c4);
            Component c5 = new AdjustableSpliter(5, new Point(300, 500), 30, 56);
            nw.Addcomponent(c5);
            PipeLine pi = new PipeLine(6, 100, c1, c2);
            nw.AddPipeLine(pi);

            pi = new PipeLine(100, 200, c3, c4);
            nw.AddPipeLine(pi);
            pipelines.Add(pi);
        
            nw.RemovePipeline(pi);
            int expected = 0;
            Assert.AreEqual(expected, pipelines.Count);
            //Test Remove
        }
    }
}
