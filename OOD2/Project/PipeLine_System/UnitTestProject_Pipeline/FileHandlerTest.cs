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
            FileHandler f = new FileHandler("E:\\GIT\\OOD\\OOD2\\Project\\PipeLine_System\\PipeLine_System\\NetworkFiles\\Network_02.txt");
            Network nw = new Network();
            Component p = new Pump(1, new Point(100, 200), 150.5);
            nw.Addcomponent(p);
            p = new Sink(2, new Point(253, 500), 350);
            nw.Addcomponent(p);
            p = new Merger(3, new Point(200, 300), 150);
            nw.Addcomponent(p);
            p = new Spliter(4, new Point(300, 205), 500);
            nw.Addcomponent(p);
            p = new AdjustableSpliter(5, new Point(300, 500), 30, 56);
            PipeLine pi = new PipeLine(6,100);
            nw.AddPipeLine(pi);
            pi = new PipeLine(100, 200);
            nw.AddPipeLine(pi);
            f.WriteToFile(nw);
            
        }
            
    }
}
