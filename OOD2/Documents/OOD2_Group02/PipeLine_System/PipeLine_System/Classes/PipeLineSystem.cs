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
        public static bool Saved = false;
        public static bool SavedAs = false;
        public static Network Network = new Network();
        public static FileHandler FileHandler = null;
        public static Component TempComponent = null;
        public static PipeLine TempPipeline = null;
        public static bool DeleteSelected = false;
        public static bool Added = false;
        public static Component CompToBeDeleted = null;
        public static PipeLine PipeLineToBeDeleted = null;
        public static int DeleteClicked = 0;
        //Added components and pipeline for the first time, using these following variable
        //to prompt user about addding their input
        public static bool FirstPumpAdded = false;
        public static bool FirstAdjustSplitterAdded = false;
        public static bool FirstPipeLineAdded = false;
       
        //Update pumps or adjustatble spliter 
        public static int Updated = 0;
        public static Pump UpdatePump = null;
        public static AdjustableSpliter UpdateSpliter = null;
        /// <summary>
        /// Add temperory component 
        /// </summary>
        /// <param name="eX"></param>
        /// <param name="eY"></param>
        /// <param name="currentFlow"></param>
        /// <param name="upperPct"></param>
        public static void AddTempComponent(int eX, int eY, double currentFlow, double upperPct, double pumpMaxFlow)
        {
            if (PipeLineSystem.TempComponent != null)
            {
                PipeLineSystem.TempComponent.SetLocation(eX, eY);
                if (PipeLineSystem.TempComponent is Pump)
                {
                    PipeLineSystem.TempComponent.SetFlow(currentFlow);
                    ((Pump)PipeLineSystem.TempComponent).SetMaxFlow(pumpMaxFlow);
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
        /// <summary>
        /// Add temp pipeline
        /// </summary>
        /// <param name="eX"></param>
        /// <param name="eY"></param>
        public static void AddTempPipeline(int eX, int eY, double safeLimit)
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
                        //update safeLimit
                        PipeLineSystem.TempPipeline.SafeLimit = safeLimit;
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
       
        /// <summary>
        /// Caclulate the start location of the TempPipeline in term of the start comp is spliter
        /// </summary>
        private static void CalculateStartLocation()
        {
            Component compStart = PipeLineSystem.TempPipeline.CompStart;
            if (compStart is Spliter)
            {
                Spliter sp = (Spliter)compStart;
                int count = 0;
                foreach(var p in Network.GetListOfPipeline())
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
        /// <summary>
        /// Caculate the end location of the temp pipeline in term of the endcomp is merger
        /// </summary>
        private static void CalculateEndLocation()
        {
            Component compEnd = PipeLineSystem.TempPipeline.CompEnd;
            if (compEnd is Merger)
            {
                Merger mg = (Merger)compEnd; 
                int count = 0;               
                foreach(var p in Network.GetListOfPipeline())
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
        public static void RemoveSelectedComponent(int eX, int eY)
        {
            List<Component> tempCompList = PipeLineSystem.Network.GetListOfComponents();
            Component removeComponent = null;
            foreach (Component c in tempCompList)
            {
                if (c.ContainsPoint(eX, eX))
                {
                    removeComponent = c;
                }
            }
            tempCompList.Remove(removeComponent);
        }
        /// <summary>
        /// Save as a drawing network
        /// </summary>
        /// <param name="saveFileDialog1"></param>
        /// <returns></returns>
        public static bool SaveAsDrawing(SaveFileDialog saveFileDialog1)
        {
            bool result = false;
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.Title = "Save an text File";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileHandler temp = new FileHandler(saveFileDialog1.FileName);
                PipeLineSystem.FileHandler = temp;
                if (PipeLineSystem.FileHandler.WriteToFile(PipeLineSystem.Network))
                {

                    PipeLineSystem.SavedAs = true;
                    PipeLineSystem.Saved = true;
                    result = true;
                }
            }
            else
            {
                MessageBox.Show("You choose cancel");
            }
            return result;
        }
        /// <summary>
        /// Save network drawing
        /// </summary>
        /// <returns></returns>
        public static bool SaveDrawing()
        {
            bool result = false;
            if (PipeLineSystem.Saved == false)
            {
                if (PipeLineSystem.FileHandler.WriteToFile(PipeLineSystem.Network))
                {
                    PipeLineSystem.Saved = true;
                    result = true;
                }
            }
            return result;
        }

        public static bool OpenNetwork(OpenFileDialog openFileDialog1, Button btnLine)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            FileHandler temp = new FileHandler(openFileDialog1.FileName);
            PipeLineSystem.FileHandler = temp;
            PipeLineSystem.Network = PipeLineSystem.FileHandler.ReadFromFile();      
            if (dr == DialogResult.OK)
            {
                if (PipeLineSystem.Network != null)
                {
                    PipeLineSystem.Saved = true;
                    PipeLineSystem.checkForEnableDrawingPipeline(btnLine);

                    return true;
                }
            }
            else
            {
                MessageBox.Show("You choose cancel");
            }
           

            return false;
        }

        /// <summary>
        /// Add new network
        /// </summary>
        /// <param name="saveFileDialog1"></param>
        /// <param name="btnSave"></param>
        /// <param name="btnSaveAs"></param>
        public static void AddNewNetwork(SaveFileDialog saveFileDialog1, Button btnSave, Button btnSaveAs)
        {
            if (PipeLineSystem.Network.GetListOfComponents().Count != 0 && PipeLineSystem.Saved == false)
            {
                DialogResult dialogResult = MessageBox.Show("The current drawing has not saved yet? Would you like to save it  ", "Save your network?", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (PipeLineSystem.SavedAs == false)
                    {
                        if (PipeLineSystem.SaveAsDrawing(saveFileDialog1))
                        {
                            btnSaveAs.Enabled = false;
                            MessageBox.Show("Your drawing is saved successfully");
                        }
                    }
                    else
                    {
                        if (PipeLineSystem.SaveDrawing())
                        {
                            btnSave.Enabled = false;
                            btnSaveAs.Enabled = false;
                            MessageBox.Show("Your drawing is saved successfully");
                        }
                    }
                }
                if (dialogResult == DialogResult.No)
                {
                    PipeLineSystem.Network.RemoveAll();
                    btnSaveAs.Enabled = true;
                    PipeLineSystem.SavedAs = false;
                    btnSave.Enabled = false;
                }
            }
            else
            {
                PipeLineSystem.Network.RemoveAll();
                btnSaveAs.Enabled = true;
                PipeLineSystem.SavedAs = false;
                btnSave.Enabled = false;
            }
        }

        /// <summary>
        /// Precondition for allowing to draw pipeline
        /// </summary>
        public static void checkForEnableDrawingPipeline(Button btnLine)
        {
            if (PipeLineSystem.Network.GetListOfComponents().Count >= 0)
            {
                btnLine.Enabled = true;
            }
            else
            {
                btnLine.Enabled = false;
            }
        }

        public static void UpdateComponentSelected(int eX, int eY, NumericUpDown numericUpDown1, NumericUpDown numericUpDown2)
        {
            if (PipeLineSystem.Updated == 0)
            {
                foreach (var c in PipeLineSystem.Network.GetListOfComponents())
                {
                    if (c.ContainsPoint(eX, eY))
                    {
                        if (c is Pump)
                        {
                            DialogResult dialogResult = MessageBox.Show("You want to change your current flow? Put the new input and double click on this pump again to update it ", "Update your pump's current flow?", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                numericUpDown2.Enabled = true;
                                numericUpDown1.Enabled = false;
                                PipeLineSystem.UpdatePump = (Pump)c;
                                numericUpDown1.Value = (decimal)PipeLineSystem.UpdatePump.GetCapacity();
                            }
                            else
                            {
                                PipeLineSystem.Updated = 0;
                            }
                        }
                        if (c is AdjustableSpliter)
                        {
                            DialogResult dialogResult = MessageBox.Show("You want to change your splitter setting? Put the new input and click on this spliter again to update it ", "Update your adjustable spliter?", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                PipeLineSystem.UpdateSpliter = (AdjustableSpliter)c;
                            }
                            else
                            {
                                PipeLineSystem.Updated = 0;
                            }
                        }
                    }

                }
            }
        }
        public static void UpdateComponent(NumericUpDown numericUpDown1, double pumpFlow, double UpperPercent)
        {
            if (PipeLineSystem.UpdatePump != null && PipeLineSystem.Updated > 1)
            {
               
                numericUpDown1.Value = (decimal)PipeLineSystem.UpdatePump.GetCapacity();
                if (pumpFlow > PipeLineSystem.UpdatePump.GetCapacity())
                {
                    MessageBox.Show("Current flow cannot exceed maximum flow.");
                }
                else
                {
                    PipeLineSystem.UpdatePump.SetFlow(pumpFlow);
                    PipeLineSystem.Network.UpdateComponent(PipeLineSystem.UpdatePump);
                    PipeLineSystem.UpdatePump = null;
                    PipeLineSystem.Updated = 0;
                    numericUpDown1.Enabled = true;
                }
            }
            if (PipeLineSystem.UpdateSpliter != null && PipeLineSystem.Updated > 0)
            {
                PipeLineSystem.UpdateSpliter.SetUpperPercent(UpperPercent);
                PipeLineSystem.Network.UpdateComponent(PipeLineSystem.UpdateSpliter);
                PipeLineSystem.UpdateSpliter = null;
                PipeLineSystem.Updated = 0;
            }
        }
       
    }
}
