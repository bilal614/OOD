using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeLine_System
{
    public partial class PipeLineApp : Form
    {
        
        Graphics gr;
       
        public PipeLineApp()
        {
            InitializeComponent();
           
        }
        #region Save/SaveAs/Open
        //Global variables
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (PipeLineSystem.SaveAsDrawing(saveFileDialog1))
            {
                btnSaveAs.Enabled = false;
                MessageBox.Show("Your drawing is saved successfully");
            }


        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            PipeLineSystem.AddNewNetwork(saveFileDialog1, btnSave, btnSaveAs);
            if (PipeLineSystem.OpenNetwork(openFileDialog1, btnLine))
            {
                PipeLineSystem.Saved = true;
                this.btnSaveAs.Enabled = false;
                this.btnSave.Enabled = false;
                //Draw all components methods
                MessageBox.Show("Your drawing is loaded");
                this.Refresh();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           if(PipeLineSystem.SaveDrawing())
           {
               btnSave.Enabled = false;
               btnSaveAs.Enabled = false;
               MessageBox.Show("Your drawing is saved successfully");
           }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            PipeLineSystem.AddNewNetwork(saveFileDialog1, btnSave, btnSaveAs);
            this.Refresh();
        }
        #endregion
        private void ASpiter_UpValue_ValueChanged(object sender, EventArgs e)
        {
            decimal down = 100;
            tb_DownValue.Text = down + "";
            decimal counter = ASpiter_UpValue.Value;
            if (ASpiter_UpValue.Value <= down)
            {
                down = down - counter;
                tb_DownValue.Text = down.ToString();
            }
        }

        private void btnSpliter_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            Point p = new Point();
            PipeLineSystem.TempComponent = new Spliter(PipeLineSystem.Network.SetId(), p, 0);
            PipeLineSystem.DeleteSelected = false;
            PipeLineSystem.Added = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            Point p = new Point();
            PipeLineSystem.TempComponent = new Merger(PipeLineSystem.Network.SetId(), p, 0);
            PipeLineSystem.DeleteSelected = false;
            PipeLineSystem.Added = false;
            PipeLineSystem.TempPipeline = null;
        }
        //
        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
               
                if (PipeLineSystem.DeleteClicked == 1)
                {
                    int X = e.X;
                    int Y = e.Y;
                    PipeLineSystem.CompToBeDeleted = PipeLineSystem.Network.FindComponent(new Point(X, Y));
                    PipeLineSystem.PipeLineToBeDeleted = PipeLineSystem.Network.FindPipeLine(new Point(X, Y));
                    if (PipeLineSystem.PipeLineToBeDeleted != null)
                    { PipeLineSystem.Network.RemovePipeline(PipeLineSystem.PipeLineToBeDeleted); }
                    if (PipeLineSystem.CompToBeDeleted != null)
                    { PipeLineSystem.Network.RemoveComponent(PipeLineSystem.CompToBeDeleted); }
                    PipeLineSystem.DeleteClicked = 0;
                    panelDrawing.Refresh();
                }
                //Need to check this again
                if (PipeLineSystem.Added == false)
                {
                    double pumpFlow = Convert.ToDouble(numericUpDown2.Value);
                    double pumpMaxFlow = Convert.ToDouble(numericUpDown1.Value);
                    double safeLimit = Convert.ToDouble(this.numericUpDown4.Value);
                    double upperPercent = Convert.ToDouble(this.ASpiter_UpValue.Value);
                    if (pumpFlow > pumpMaxFlow)
                    {

                        throw new Classes.CustomExceptions("Current flow cannot exceed maximum flow.");
                    }
                    PipeLineSystem.AddTempComponent(e.X, e.Y, pumpFlow, upperPercent, pumpMaxFlow);
                    PipeLineSystem.AddTempPipeline(e.X, e.Y, safeLimit);
                }
                else
                {
                    //Raima, I moved the code of remove in to system class in following function 
                    //, you can extend it here
                    //PipeLineSystem.RemoveSelectedComponent(e.X, e.Y);
                }
                //enable the save button
                if(PipeLineSystem.Saved == false && PipeLineSystem.SavedAs == true)
                {
                    btnSave.Enabled = true;
                }
                PipeLineSystem.checkForEnableDrawingPipeline(btnLine);

                
                this.Refresh();
            }   
            catch(Classes.CustomExceptions ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Please select a component or pipeline to draw.");
            }
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            if(PipeLineSystem.Network != null)
            {
                PipeLineSystem.Network.UpdateCurrentFlowOfNetwork();
                gr = e.Graphics;
                PipeLineSystem.Network.DrawAllComponents(gr, imageList1);
                PipeLineSystem.Network.DrawAllPipeLines(gr);
            }
        }

        private void btnPump_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Enabled = true;
            this.numericUpDown2.Enabled = true;
          
            if(PipeLineSystem.FirstPumpAdded == false)
            {
                MessageBox.Show("Please fill in the capacity and current flow of the pump in the pump setting box");
                PipeLineSystem.FirstPumpAdded = true;
            }
           
            Point p = new Point();
            PipeLineSystem.TempComponent = new Pump(PipeLineSystem.Network.SetId(), p, 0);
            PipeLineSystem.DeleteSelected = false;
            PipeLineSystem.Added = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void btnAdjustSpliter_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            if(PipeLineSystem.FirstAdjustSplitterAdded == false)
            {
                MessageBox.Show("Please fill in the percentage of the spliter in the spliter setting box");
                PipeLineSystem.FirstAdjustSplitterAdded = true;
            }
          
            Point p = new Point();
            PipeLineSystem.TempComponent = new AdjustableSpliter(PipeLineSystem.Network.SetId(), p, 0, Convert.ToInt32(this.ASpiter_UpValue.Value));
            PipeLineSystem.DeleteSelected = false;
            PipeLineSystem.Added = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void btnSink_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            Point p = new Point();
            PipeLineSystem.TempComponent = new Sink(PipeLineSystem.Network.SetId(), p, 0);
            PipeLineSystem.DeleteSelected = false;
            PipeLineSystem.Added = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.numericUpDown1.Enabled = false;
            //this.numericUpDown2.Enabled = false;
            PipeLineSystem.DeleteClicked = 1;
          //  deleteSelected = true;
            PipeLineSystem.TempComponent = null;
          
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown4.Enabled = true;
            if (PipeLineSystem.FirstPipeLineAdded == false)
            {
                MessageBox.Show("Please fill in the capacity of the pipeline in the setting box");
                PipeLineSystem.FirstPipeLineAdded = true;
            }
            PipeLineSystem.TempPipeline = new PipeLine(PipeLineSystem.Network.SetPipeLineId(), Convert.ToDouble(this.numericUpDown4.Value), null, null);
            PipeLineSystem.DeleteSelected = false;
            PipeLineSystem.Added = false;
            PipeLineSystem.TempComponent = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PipeLineApp_Load(object sender, EventArgs e)
        {
            btnLine.Enabled = false;
            numericUpDown4.Enabled = false;
        }
        
        private void panelDrawing_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (PipeLineSystem.Updated == 0)
            {
                foreach (var c in PipeLineSystem.Network.GetListOfComponents())
                {
                    if (c.ContainsPoint(e.X, e.Y))
                    {
                        if (c is Pump)
                        {
                            DialogResult dialogResult = MessageBox.Show("You want to change your current flow? Put the new input and click on this pump again to update it ", "Update your pump's current flow?", MessageBoxButtons.YesNo);
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
            PipeLineSystem.Updated++;
            if (PipeLineSystem.UpdatePump != null && PipeLineSystem.Updated > 1)
            {
                double pumpFlow = Convert.ToDouble(numericUpDown2.Value);
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
                    this.numericUpDown1.Enabled = true;
                }
            }
            if (PipeLineSystem.UpdateSpliter != null && PipeLineSystem.Updated > 0)
            {
                double upperPercent = Convert.ToDouble(this.ASpiter_UpValue.Value);
                PipeLineSystem.UpdateSpliter.SetUpperPercent(upperPercent);
                PipeLineSystem.Network.UpdateComponent(PipeLineSystem.UpdateSpliter);
                PipeLineSystem.UpdateSpliter = null;
                PipeLineSystem.Updated = 0;
            }
            this.Refresh();
        }

      
       
      

       

     

    }
}
