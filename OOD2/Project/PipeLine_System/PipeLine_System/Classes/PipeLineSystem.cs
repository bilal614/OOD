using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PipeLine_System
{
    public class PipeLineSystem
    {
        //Instances variables
        private static bool saved = false;
        private static Network currentNetwork = new Network();
        private static FileHandler fileHandler = null;
        private static Component tempComponent = null;
        private static PipeLine tempPipeLine = null;

        //Properties
        public static bool Saved
        {
            get { return saved; }
            set { saved = value; }
        }
        public static Network Network
        {
            get { return currentNetwork; }
            set { currentNetwork = value; }
        }
        public static FileHandler FileHander
        {
            get { return fileHandler; }
            set { fileHandler = value; }
        }
        public static Component TempComponent
        {
            get { return tempComponent; }
            set { tempComponent = value; }
        }
        public static PipeLine TempPipeline
        {
            get { return tempPipeLine; }
            set { tempPipeLine = value; }
        }
        public bool OpenNetwork()
        {
            return false;
        }
        public void SaveNetwork() { }
        public void DrawComponent(Graphics gr, List<Image> image, Component compnt) { }
        public void drawLine(Graphics gr) { }
        public void refreshDrawing() { }
    }
}
