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
        //Global variables
        Graphics gr;
        private Network network;  

        public PipeLineApp()
        {
            InitializeComponent();
            network = new Network();
        }    
  
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

        private void btnPump_MouseDown(object sender, MouseEventArgs e)
        {           
              
        }

        private void panelDrawing_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void panelDrawing_DragDrop(object sender, DragEventArgs e)
        {
            int xPos = e.X;
            int yPos = e.Y;
        }

        private void btnMerger_MouseDown(object sender, MouseEventArgs e)
        {
          //  btnMerger.DoDragDrop(btnMerger.Image, DragDropEffects.Move);
        }

        private void btnSpliter_MouseDown(object sender, MouseEventArgs e)
        {
            // btnSpliter.DoDragDrop(btnSpliter.Image, DragDropEffects.Move);
        }

        private void btnAdjustSpliter_MouseDown(object sender, MouseEventArgs e)
        {
            //btnAdjustSpliter.DoDragDrop(btnAdjustSpliter.Image, DragDropEffects.Move);
        }

        private void btnSink_MouseDown(object sender, MouseEventArgs e)
        {
           // btnSink.DoDragDrop(btnSink.Image, DragDropEffects.Move);
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
           // network.DrawAllComponents(gr,null);
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {

        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btnPump_MouseUp(object sender, MouseEventArgs e)
        {
            network.Addcomponent(new Pump(1,e.Location,20)); // Values are only for testin!
            this.Refresh();           
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
            gr = e.Graphics;
            network.DrawAllComponents(gr, imageList1);
        }

        private void btnPump_Click(object sender, EventArgs e)
        {

        }
        
        private void btnMerger_MouseUp(object sender, MouseEventArgs e)
        {
            network.Addcomponent(new Merger(1, e.Location, 20));
            this.Refresh();
        }
    }
}
