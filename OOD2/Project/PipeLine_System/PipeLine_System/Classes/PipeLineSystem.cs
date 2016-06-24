using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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
        public void SaveNetwork() 
        {

        }

        public static void AddTempComponent(int eX, int eY, double currentFlow, double upperPct)
        {
            if (PipeLineSystem.TempComponent != null)
            {
                PipeLineSystem.TempComponent.SetLocation(eX, eY);
                if (PipeLineSystem.TempComponent is Pump)
                {
                    PipeLineSystem.TempComponent.SetFlow(currentFlow);
                    PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                    PipeLineSystem.TempComponent = null;
                }
                else if (PipeLineSystem.TempComponent is Merger)
                {
                    PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                    PipeLineSystem.TempComponent = null;
                }
                else if (PipeLineSystem.TempComponent is Spliter)
                {
                    if (PipeLineSystem.TempComponent is AdjustableSpliter)
                    {
                        AdjustableSpliter tempSp = (AdjustableSpliter)PipeLineSystem.TempComponent;
                        tempSp.SetUpperPercent(upperPct);
                        PipeLineSystem.Network.Addcomponent(tempSp);
                        PipeLineSystem.TempComponent = null;
                    }
                    else
                    {
                        PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                        PipeLineSystem.TempComponent = null;
                    }
                }
                
                else if (PipeLineSystem.TempComponent is Sink)
                {
                    PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                    PipeLineSystem.TempComponent = null;
                }
            }
        }

        public static void AddTempPipeline(int eX, int eY)
        {
            if (PipeLineSystem.TempPipeline != null)
            {
                if (PipeLineSystem.TempPipeline.CompStart == null)
                {
                    foreach (Component c in PipeLineSystem.Network.GetListOfComponents())
                    {
                        if (c.ContainsPoint(eX, eY))
                        {
                            PipeLineSystem.TempPipeline.CompStart = c;
                            CalculateStartLocation();
                           
                            break;
                        }
                    }
                }
                else if (PipeLineSystem.TempPipeline.CompStart != null && PipeLineSystem.TempPipeline.CompEnd == null)
                {
                    Component temporaryComponent = null;

                    foreach (Component c in PipeLineSystem.Network.GetListOfComponents())
                    {
                        if (c.ContainsPoint(eX, eY) && c != PipeLineSystem.TempPipeline.CompStart)
                        {
                            temporaryComponent = c;
                            
                            break;
                        }
                    }
                    if (temporaryComponent != null)
                    {
                        PipeLineSystem.TempPipeline.CompEnd = temporaryComponent;
                        CalculateEndLocation();
                        if (PipeLineSystem.Network.AddPipeLine(PipeLineSystem.TempPipeline))
                        {
                        }
                        else
                        {
                            MessageBox.Show("Not allowed to connect those components.");
                        }
                        PipeLineSystem.TempPipeline = null;
                    }
                    else
                    {
                        Point pnt = new Point(eX, eY);
                        PipeLineSystem.TempPipeline.setMiddleLocation(pnt);
                    }

                }
            }
        }
       
        private static void CalculateStartLocation()
        {
            Component compStart = PipeLineSystem.TempPipeline.CompStart;
            if (compStart is Spliter)
            {
                Spliter sp = (Spliter)compStart;
                int count = 0;
                foreach(var p in currentNetwork.GetListOfPipeline())
                {
                    if(p.CompStart == compStart)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                   sp.SetUpperLocation(compStart.GetLocation());
                   PipeLineSystem.TempPipeline.setStartLocation(sp.GetUpperLocation());
                   
                }
                else
                {
                    sp.SetLowerLocation(compStart.GetLocation());
                    PipeLineSystem.TempPipeline.setStartLocation(sp.GetLowerLocation());
                }
            }
            else
            {
                PipeLineSystem.TempPipeline.setStartLocation(compStart.GetLocation());
            }
           
        }
        private static void CalculateEndLocation()
        {
            Component compEnd = PipeLineSystem.TempPipeline.CompEnd;
            if (compEnd is Merger)
            {
                Merger mg = (Merger)compEnd; 
                int count = 0;               
                foreach(var p in currentNetwork.GetListOfPipeline())
                {
                    if (p.CompEnd == compEnd)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    mg.SetUpperLocation(compEnd.GetLocation());
                    PipeLineSystem.TempPipeline.setEndLocation(mg.GetUpperLocation());
                }
                else
                {
                    mg.SetLowerLocation(compEnd.GetLocation());
                    PipeLineSystem.TempPipeline.setEndLocation(mg.GetLowerLocation());
                }
            }
            else
            {
                PipeLineSystem.TempPipeline.setEndLocation(compEnd.GetLocation());
            }
        }
    }
}
