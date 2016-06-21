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
      //private ImageList imageList = new ImageList();
        Component tempComponent = null;
        PipeLine tempPipeLine = null;
        private Network network = new Network();
        public bool deleteSelected = false;
        public PipeLineApp()
        {
            InitializeComponent();

        }
        #region Save/SaveAs/Opem
        //Global variables
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.Title = "Save an text File";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileHandler temp = new FileHandler(saveFileDialog1.FileName);
                PipeLineSystem.FileHander = temp;
                //PipeLineSystem.FileHander.WriteToFile(PipeLineSystem.Network);
                //Need to be edited after discuss with Bilal
                if (PipeLineSystem.FileHander.WriteToFile(network))
                {
                    btnSave.Enabled = true;
                    btnSaveAs.Enabled = false;
                    PipeLineSystem.Saved = true;
                    MessageBox.Show("Your drawing is saved successfully");
                }

            }
            else
            {
                MessageBox.Show("You choose cancel", " Pipe Line");
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileHandler temp = new FileHandler(openFileDialog1.FileName);
                PipeLineSystem.FileHander = temp;
                PipeLineSystem.Network = PipeLineSystem.FileHander.ReadFromFile();

                if (PipeLineSystem.Network != null)
                {
                   PipeLineSystem.Saved = true;
                    //Draw all components methods
                   PipeLineSystem.Network.DrawAllComponents(gr, imageList1);
                   MessageBox.Show("Your drawing is loaded");
                }

            }
            else
            {
                MessageBox.Show("You choose cancel", " Pipe Line");
            }
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
            Point p = new Point();
            tempComponent = new Spliter(network.SetId(), p, 0);
            deleteSelected = false;
            tempPipeLine = null;
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            tempComponent = new Merger(network.SetId(), p, 0);
            deleteSelected = false;
            tempPipeLine = null;
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (deleteSelected == false)
                {
                    if (tempComponent != null)
                    {
                        tempComponent.SetLocation(e.X, e.Y);
                        if (tempComponent is Pump)
                        {
                            tempComponent.SetFlow(Convert.ToDouble(this.numericUpDown2.Value));
                            network.Addcomponent(tempComponent);
                            tempComponent = null;
                        }
                        else if (tempComponent is Merger)
                        {
                            //tempComponent.SetFlow(Convert.ToDouble(this.numericUpDown2.Value));
                            network.Addcomponent(tempComponent);
                            tempComponent = null;
                        }
                        else if (tempComponent is Spliter)
                        {
                            network.Addcomponent(tempComponent);
                            tempComponent = null;
                        }
                        else if (tempComponent is AdjustableSpliter)
                        {
                            network.Addcomponent(tempComponent);
                            tempComponent = null;
                        }
                        else if (tempComponent is Sink)
                        {
                            network.Addcomponent(tempComponent);
                            tempComponent = null;
                        }
                    }

                    if (tempPipeLine != null)
                    {
                        /*if (tempPipeLine == null && btnDelete.Focused)
                        {
                            tempPipeLine = new PipeLine(network.SetPipeLineId(), Convert.ToDouble(this.numericUpDown4.Value), null, null);
                            deleteSelected = false;
                            tempComponent = null;
                        }*/
                        if (tempPipeLine.CompStart == null)
                        {
                            foreach (Component c in network.GetListOfComponents())
                            {
                                if (c.ContainsPoint(e.X, e.Y))
                                {
                                    tempPipeLine.CompStart = c;
                                    break;
                                }
                            }
                        }
                        else if (tempPipeLine.CompStart != null && tempPipeLine.CompEnd == null)
                        {
                            Component temporaryComponent = null;

                            foreach (Component c in network.GetListOfComponents())
                            {
                                if (c.ContainsPoint(e.X, e.Y) && c != tempPipeLine.CompStart)
                                {
                                    temporaryComponent = c;
                                }
                            }
                            if (temporaryComponent != null)
                            {
                                tempPipeLine.CompEnd = temporaryComponent;
                                network.AddPipeLine(tempPipeLine);
                                tempPipeLine = null;
                            }
                            else
                            {
                                Point pnt = new Point(e.X, e.Y);
                                tempPipeLine.setMiddleLocation(pnt);
                            }

                        }
                    }
                }
                else
                {
                    List<Component> tempCompList = network.GetListOfComponents();
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
                //network.DrawAllComponents(gr, imageList1);
                this.Refresh();
            }
            catch
            {
                MessageBox.Show("Please select a component or pipeline to draw.");
            }
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            gr = e.Graphics;
            network.DrawAllComponents(gr, imageList1);
            network.DrawAllPipeLines(gr);
        }

        private void btnPump_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            tempComponent = new Pump(network.SetId(), p, 0);
            deleteSelected = false;
            tempPipeLine = null;
        }

        private void btnAdjustSpliter_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            tempComponent = new AdjustableSpliter(network.SetId(), p, 0, Convert.ToInt32(this.ASpiter_UpValue.Value));
            deleteSelected = false;
            tempPipeLine = null;
        }

        private void btnSink_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            tempComponent = new Sink(network.SetId(), p, 0);
            deleteSelected = false;
            tempPipeLine = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteSelected = true;
            tempComponent = null;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            tempPipeLine = new PipeLine(network.SetPipeLineId(), Convert.ToDouble(this.numericUpDown4.Value), null, null);
            deleteSelected = false;
            tempComponent = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

    }
}
