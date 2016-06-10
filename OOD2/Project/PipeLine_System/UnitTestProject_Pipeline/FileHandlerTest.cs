using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipeLine_System;

namespace UnitTestProject_Pipeline
{
    [TestClass]
    public class FileHandlerTest
    {
        [TestMethod]
        public void TestWriteToFile()
        {
            FileHandler f = new FileHandler("../../PipeLine_System/NetworkFiles/Network_02.txt");


        }
            
    }
}
