using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipeLine_System;
using System.Drawing;
using System.Collections.Generic;

namespace UnitTestProject_Pipeline
{
    [TestClass]
    public class FileHandlerTest
    {
        [TestMethod]
        public void TestWriteToFile()
        { 
            FileHandler f = new FileHandler("../../PipeLine_System/NetworkFiles/Network_02.txt");
            List<Component> components = new List<Component>();
            Component p = new Pump(1, new Point(100, 200), 150.5);
            components.Add(p);
            p = new Sink(2, new Point(253, 500), 350);
            components.Add(p);
            p = new Merger(3, new Point(200, 300), 150);
            components.Add(p);
            p = new Spliter(4, new Point(300, 205), 500);
            components.Add(p);
            p = new AdjustableSpliter(5, new Point(300, 500), 30, 56);
            List<PipeLine> pipelines = new List<PipeLine>();
            PipeLine pi = new PipeLine(6,100);
            pipelines.Add(pi);
            pi = new PipeLine(100, 200);
            pipelines.Add(pi);

            Network nw = new Network();
            f.WriteToFile(nw);
        }
            
    }
}
