using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PineLineProject
{
    public partial class PineLine : Form
    {
        public PineLine()
        {
            InitializeComponent();
        }

        private void PineLine_Load(object sender, EventArgs e)
        {

        }

        private void btnPump_Click(object sender, EventArgs e)
        {

        }
        #region Drag and drop components implementation

        private void btnPump_MouseDown(object sender, MouseEventArgs e)
        {
            //Drag the image of the button
            btnPump.DoDragDrop(btnPump.Image, DragDropEffects.Move);
        }

        private void panelDrawing_DragEnter(object sender, DragEventArgs e)
        {
            //Allow every types of objects. Need to be improved. Only allow Bitmap object
            e.Effect = e.AllowedEffect;
        }

        private void panelDrawing_DragDrop(object sender, DragEventArgs e)
        {
            //Get the image from data and set it to picture box
            PictureBox pic = new PictureBox();
            pic.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            //Draw the image in the position of the cursor
            int xPos = e.X;
            int yPos = e.Y;

            Point clientPoint = panelDrawing.PointToClient(new Point(e.X, e.Y));

            Graphics gr = panelDrawing.CreateGraphics();
            gr.DrawImage(pic.Image, clientPoint.X, clientPoint.Y);
        }

        private void btnMerger_MouseDown(object sender, MouseEventArgs e)
        {
            btnMerger.DoDragDrop(btnMerger.Image, DragDropEffects.Move);
        }
        #endregion

        private void btnSpliter_MouseDown(object sender, MouseEventArgs e)
        {
            btnSpliter.DoDragDrop(btnSpliter.Image, DragDropEffects.Move);
        }

        private void btnAdjustSpliter_MouseDown(object sender, MouseEventArgs e)
        {
            btnAdjustSpliter.DoDragDrop(btnAdjustSpliter.Image, DragDropEffects.Move);
        }

        private void btnSink_MouseDown(object sender, MouseEventArgs e)
        {
            btnSink.DoDragDrop(btnSink.Image, DragDropEffects.Move);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Are you sure you want to close the program?",
            "PipeLine", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
                this.Close();
            else
                return;
        }
        private void btnSink_Click(object sender, EventArgs e)
        {

        }
    }
}
