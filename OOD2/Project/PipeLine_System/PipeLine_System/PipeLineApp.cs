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
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileHandler temp = new FileHandler(openFileDialog1.FileName);
                PipeLineSystem.FileHandler = temp;
                PipeLineSystem.Network = PipeLineSystem.FileHandler.ReadFromFile();

                if (PipeLineSystem.Network != null)
                {
                   PipeLineSystem.Saved = true;
                   this.btnSaveAs.Enabled = false;
                   this.btnSave.Enabled = false;
                    //Draw all components methods
                   this.Refresh();
                   MessageBox.Show("Your drawing is loaded");
                }

            }
            else
            {
                MessageBox.Show("You choose cancel");
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
            if(PipeLineSystem.Network.GetListOfComponents().Count != 0 && PipeLineSystem.Saved == false)
            {
                DialogResult dialogResult = MessageBox.Show("The current drawing has not saved yet? Would you like to save it  ", "Save your network?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if(PipeLineSystem.SavedAs == false)
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
            }
            PipeLineSystem.Network.RemoveAll();
            this.Refresh();
            btnSaveAs.Enabled = true;
            PipeLineSystem.SavedAs = false;
            btnSave.Enabled = false;
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
            PipeLineSystem.TempPipeline = null;
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            Point p = new Point();
            PipeLineSystem.TempComponent = new Merger(PipeLineSystem.Network.SetId(), p, 0);
            PipeLineSystem.DeleteSelected = false;
            PipeLineSystem.TempPipeline = null;
        }

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
                if (PipeLineSystem.DeleteSelected == false)
                {
                    double pumpFlow = Convert.ToDouble(numericUpDown2.Value);
                    double upperPercent = Convert.ToDouble(this.ASpiter_UpValue.Value);
                    PipeLineSystem.AddTempComponent(e.X, e.Y, pumpFlow, upperPercent);
                    PipeLineSystem.AddTempPipeline(e.X, e.Y);
                }
                else
                {
                    List<Component> tempCompList = PipeLineSystem.Network.GetListOfComponents();
                    Component removeComponent = null;
                    foreach (Component c in tempCompList)
                    {
                        if (c.ContainsPoint(e.X, e.Y))
                        {
                            removeComponent = c;
                        }
                    }
                    tempCompList.Remove(removeComponent);
                }
                
                //enable the save button
                if(PipeLineSystem.Saved == false && PipeLineSystem.SavedAs == true)
                {
                    btnSave.Enabled = true;
                }
                this.Refresh();
                
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
            PipeLineSystem.TempPipeline = null;
        }

        private void btnSink_Click(object sender, EventArgs e)
        {
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            Point p = new Point();
            PipeLineSystem.TempComponent = new Sink(PipeLineSystem.Network.SetId(), p, 0);
            PipeLineSystem.DeleteSelected = false;
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
            PipeLineSystem.TempComponent = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

       

     

    }
}
