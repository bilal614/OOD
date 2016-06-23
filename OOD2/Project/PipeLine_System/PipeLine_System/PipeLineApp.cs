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
        //Component tempComponent = null;
        //PipeLine tempPipeLine = null;
        //private Network network = new Network();
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
                if (PipeLineSystem.FileHander.WriteToFile(PipeLineSystem.Network))
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
            PipeLineSystem.TempComponent = new Spliter(PipeLineSystem.Network.SetId(), p, 0);
            deleteSelected = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            PipeLineSystem.TempComponent = new Merger(PipeLineSystem.Network.SetId(), p, 0);
            deleteSelected = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (deleteSelected == false)
                {
                    if (PipeLineSystem.TempComponent != null)
                    {
                        PipeLineSystem.TempComponent.SetLocation(e.X, e.Y);
                        if (PipeLineSystem.TempComponent is Pump)
                        {
                            PipeLineSystem.TempComponent.SetFlow(Convert.ToDouble(this.numericUpDown2.Value));
                            PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                            PipeLineSystem.TempComponent = null;
                        }
                        else if (PipeLineSystem.TempComponent is Merger)
                        {
                            //tempComponent.SetFlow(Convert.ToDouble(this.numericUpDown2.Value));
                            PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                            PipeLineSystem.TempComponent = null;
                        }
                        else if (PipeLineSystem.TempComponent is Spliter)
                        {
                            PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                            PipeLineSystem.TempComponent = null;
                        }
                        else if (PipeLineSystem.TempComponent is AdjustableSpliter)
                        {
                            PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                            PipeLineSystem.TempComponent = null;
                        }
                        else if (PipeLineSystem.TempComponent is Sink)
                        {
                            PipeLineSystem.Network.Addcomponent(PipeLineSystem.TempComponent);
                            PipeLineSystem.TempComponent = null;
                        }
                    }

                    if (PipeLineSystem.TempPipeline != null)
                    {
                        if (PipeLineSystem.TempPipeline.CompStart == null)
                        {
                            foreach (Component c in PipeLineSystem.Network.GetListOfComponents())
                            {
                                if (c.ContainsPoint(e.X, e.Y))
                                {
                                    PipeLineSystem.TempPipeline.CompStart = c;
                                    break;
                                }
                            }
                        }
                        else if (PipeLineSystem.TempPipeline.CompStart != null && PipeLineSystem.TempPipeline.CompEnd == null)
                        {
                            Component temporaryComponent = null;

                            foreach (Component c in PipeLineSystem.Network.GetListOfComponents())
                            {
                                if (c.ContainsPoint(e.X, e.Y) && c != PipeLineSystem.TempPipeline.CompStart)
                                {
                                    temporaryComponent = c;
                                    break;
                                }
                            }
                            if (temporaryComponent != null)
                            {
                                PipeLineSystem.TempPipeline.CompEnd = temporaryComponent;
                                if (PipeLineSystem.Network.AddPipeLine(PipeLineSystem.TempPipeline))
                                {
                                }
                                else
                                {
                                    MessageBox.Show("Number of pipelines connected to components exceeded.");
                                }
                                PipeLineSystem.TempPipeline = null;
                            }
                            else
                            {
                                Point pnt = new Point(e.X, e.Y);
                                PipeLineSystem.TempPipeline.setMiddleLocation(pnt);
                            }

                        }
                    }
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
            PipeLineSystem.Network.DrawAllComponents(gr, imageList1);
            PipeLineSystem.Network.DrawAllPipeLines(gr);
        }

        private void btnPump_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            PipeLineSystem.TempComponent = new Pump(PipeLineSystem.Network.SetId(), p, 0);
            deleteSelected = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void btnAdjustSpliter_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            PipeLineSystem.TempComponent = new AdjustableSpliter(PipeLineSystem.Network.SetId(), p, 0, Convert.ToInt32(this.ASpiter_UpValue.Value));
            deleteSelected = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void btnSink_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            PipeLineSystem.TempComponent = new Sink(PipeLineSystem.Network.SetId(), p, 0);
            deleteSelected = false;
            PipeLineSystem.TempPipeline = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteSelected = true;
            PipeLineSystem.TempComponent = null;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            PipeLineSystem.TempPipeline = new PipeLine(PipeLineSystem.Network.SetPipeLineId(), Convert.ToDouble(this.numericUpDown4.Value), null, null);
            deleteSelected = false;
            PipeLineSystem.TempComponent = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

    }
}
