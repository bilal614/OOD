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
            Component c1 = new Pump(1, new Point(100, 200), 150.5);
            nw.Addcomponent(c1);
            Component c2 = new Sink(2, new Point(253, 500), 350);
            nw.Addcomponent(c2);
            Component c3 = new Merger(3, new Point(200, 300), 150);
            nw.Addcomponent(c3);
            Component c4 = new Spliter(4, new Point(300, 205), 500);
            nw.Addcomponent(c4);
            Component c5 = new AdjustableSpliter(5, new Point(500, 500), 30, 56);
            nw.Addcomponent(c5);
            PipeLine pi = new PipeLine(6, 100, c1, c2);
            nw.AddPipeLine(pi);
            pi = new PipeLine(100, 200, c3, c4);
            nw.AddPipeLine(pi);
            f.WriteToFile(nw);
            
        }
        [TestMethod]
        public void TesReadFromFile()
        {
            FileHandler f = new FileHandler("E:\\GIT\\OOD\\OOD2\\Project\\PipeLine_System\\PipeLine_System\\NetworkFiles\\Network_02.txt");
            Network nw = f.ReadFromFile();
        }   
    }
}
