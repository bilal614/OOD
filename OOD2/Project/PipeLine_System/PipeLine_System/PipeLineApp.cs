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
        //Global variables

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                FileHandler temp = new FileHandler(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("You choose cancel"," Pipe Line");
            }
        }

        private void panelDrawing_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelDrawing_DragDrop(object sender, DragEventArgs e)
        {
            int xPos = e.X;
            int yPos = e.Y;

            //PictureBox pic = new PictureBox();
            //pic.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            //Point clientPoint = panelDrawing.PointToClient(new Point(e.X, e.Y));
            //gr.DrawImage(pic.Image, clientPoint.X, clientPoint.Y);

        }

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
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            tempComponent = new Merger(network.SetId(), p, 0);
            deleteSelected = false;
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
                        if (tempPipeLine.CompStart == null)
                        {
                            foreach (Component c in network.GetListOfComponents())
                            {
                                if (c.ContainsPoint(e.X, e.Y))
                                {
                                    tempPipeLine.CompStart = c;
                                }
                            }
                        }
                        else if (tempPipeLine.CompStart != null && tempPipeLine.CompEnd == null)
                        {

                            foreach (Component c in network.GetListOfComponents())
                            {
                                if (c.ContainsPoint(e.X, e.Y) && c != tempPipeLine.CompStart)
                                {
                                    tempPipeLine.CompEnd = c;
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
        }

        private void btnAdjustSpliter_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            tempComponent = new AdjustableSpliter(network.SetId(), p, 0, Convert.ToInt32(this.ASpiter_UpValue.Value));
            deleteSelected = false;
        }

        private void btnSink_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            tempComponent = new Sink(network.SetId(), p, 0);
            deleteSelected = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteSelected = true;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            tempPipeLine = new PipeLine(network.SetPipeLineId(), Convert.ToDouble(this.numericUpDown4.Value), null, null);
        }

    }
}
