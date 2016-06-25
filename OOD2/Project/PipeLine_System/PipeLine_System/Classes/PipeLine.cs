using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    public class PipeLine
    {
        /*The PipeLine is a special class, even though it is in many ways similar to the Component class and shares a few attributes with 
         * the Component class. The PipeLine class represents the pipe-lines that connect the various components in the pipe-line network.
         * The reason we distinguish the PipeLine class from the conventional Component class is because it includes a List which presents
         * the various locations that the pipe-line touches on the drawing screen. 
         */

        /*PROPERTIES:
         * The PipeLine class has several properties including a few in common with the Component class such as the currentFlow, and the id.
         * The other properties include a List of locations that the user wants the pipe-line to pass through on the drawing screen. 
         */

        //Instance variables
        private int id;
        private Point startLocation;
        private Point endLocation;
        private double currentFlow;
       
        public double CurrentFlow
        {
            get { return currentFlow; }
            set { currentFlow = value; }
        }
        private double safeLimit;
        public double SafeLimit
        {
            get { return safeLimit; }
            set { safeLimit = value; }
        }
        private List<Point> clickLocation;
   
        private Component compStart;
     
        public Component CompStart
        {
            get { return compStart; }
            set { compStart = value; }
        }
        private Component compEnd;
       
        public Component CompEnd
        {
            get { return compEnd; }
            set { compEnd = value; }
        }
        private bool danger;
        //Constructors
        public PipeLine(int id, double safeLimit)
        {
            this.id = id;
            this.safeLimit = safeLimit;
            this.startLocation.X = 0;
            this.endLocation.X = 0;
            this.startLocation.Y = 0;
            this.endLocation.Y = 0;
        }
       /// <summary>
       /// Contructor to allow create infor for all
       /// </summary>
       /// <param name="id"></param>
       /// <param name="StartLoca"></param>
       /// <param name="EndLoca"></param>
       /// <param name="currentFlow"></param>
       /// <param name="safeLimit"></param>
       /// <param name="clickLocations"></param>
       /// <param name="compEnd"></param>
       /// <param name="compStart"></param>
        public PipeLine(int id, Point StartLoca, Point EndLoca, double currentFlow,  double safeLimit, List<Point> clickLocations,  Component compEnd, Component compStart)
        {
            this.id = id;
            this.startLocation = StartLoca;
            this.endLocation = EndLoca;
            this.currentFlow = currentFlow;
            this.safeLimit = safeLimit;
            this.clickLocation = clickLocations;
            this.compEnd = compEnd;
            this.compStart = compStart;
        }
         /// <summary>
        /// Alternative constructor which allows to create a pipeline with CompStart and CompEnd
        /// </summary>
        /// <param name="id"></param>
        /// <param name="safeLimit"></param>
        /// <param name="compEnd"></param>
        /// <param name="compStart"></param>
        public PipeLine(int id, double safeLimit, Component compEnd, Component compStart)
        {
            this.id = id;
            this.safeLimit = safeLimit;
            this.startLocation.X = 0;
            this.endLocation.X = 0;
            this.startLocation.Y = 0;
            this.endLocation.Y = 0;
            this.compEnd = compEnd;
            this.compStart = compStart;
            clickLocation = new List<Point>();
        }

        private bool withinRange(int nmbr, int bound1, int bound2)
        {
            bool inRange = false;
            if ((nmbr > bound1 && nmbr < bound2) || (nmbr < bound1 && nmbr > bound2))
            {
                inRange = true;
            }
            return inRange;
        }

        private bool checkSlope(int x, int y, int startX, int startY, int endX, int endY)
        {
            bool onSlope = false;
            if (((y - startY) / (x - startX)) == ((endY - startY) / (endX - startX)))
            {
                onSlope = true;
            }
            return onSlope;
        }

        public bool ContainPoints(int x, int y)
        {
            if (clickLocation.Count > 0)
            {
                for (int i = 0; i < clickLocation.Count; i++)
                {
                    if (i == 0)
                    {
                        if (withinRange(x, startLocation.X, clickLocation[i].X) && withinRange(y, startLocation.Y, clickLocation[i].Y))
                        {
                            if(checkSlope(x,y,startLocation.X,startLocation.Y,clickLocation[i].X,clickLocation[i].Y))
                            { return true; }
                        }
                    }
                    if (i > 0 && i < clickLocation.Count - 1)
                    {
                        if (withinRange(x, clickLocation[i - 1].X, clickLocation[i].X) && withinRange(y, clickLocation[i-1].Y, clickLocation[i].Y))
                        {
                            if(checkSlope(x,y,clickLocation[i-1].X,clickLocation[i-1].Y,clickLocation[i].X,clickLocation[i].Y))
                            { return true; }
                        }
                    }
                    if (i == (clickLocation.Count - 1))
                    {
                        if (withinRange(x, clickLocation[i].X, endLocation.X) && withinRange(y, clickLocation[i].Y, endLocation.Y))
                        {
                            if (checkSlope(x, y, clickLocation[i].X, clickLocation[i].Y, endLocation.X, endLocation.Y))
                            { return true; }
                        }
                        
                    }
                }
            }
            /*if (((x - startLocation.X) / (endLocation.X - startLocation.X)) == ((y - startLocation.Y) / (endLocation.Y - startLocation.Y)))
            { return true; }
            else { return false; }*/
            return false;
        }
        /// <summary>
        /// set the start location from the screen.
        /// The overlaped need to be checked before this method is call
        /// </summary>
        /// <param name="location"></param>
        public void setStartLocation(Point location)
        {
            this.startLocation.X = location.X + 28;
            this.startLocation.Y = location.Y + 18;
        }

        public Point getStartLocation()
        {
            Point p = this.startLocation;
            return p;
        }

        /// <summary>
        /// Set the end location
        /// </summary>
        /// <param name="location"></param>
        public void setEndLocation(Point location)
        {
            this.endLocation.X = location.X;
            this.endLocation.Y = location.Y + 18;
        }

        public Point getEndLocation()
        {
            Point p = this.endLocation;
            return p;
        }

        /// <summary>
        /// Added the clicked point in the middle of the line
        /// </summary>
        /// <param name="points"></param>
        public void setMiddleLocation(Point point)
        {
            clickLocation.Add(point);
        }

        public List<Point> getMiddleLocation()
        {
            return clickLocation;
        }
        /// <summary>
        /// get the id of the pipeline for reference in the files
        /// </summary>
        /// <returns></returns>
        public int getId()
        {
            return this.id;
        }

        public override string ToString()
        {
            //ID_STARTLOCA(X,Y)_ENDLOCA(X,Y)_CURRENTFLOW_SAFELIMIT_COMPSTART_COMPEND_DANGER_LIST_CLICKEDLOCATION
            String resultSt = null;
            //Working on checking for null comps
            resultSt += String.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}",
            id.ToString(), startLocation.X.ToString(), startLocation.Y.ToString(), endLocation.X.ToString(), endLocation.Y.ToString(),
            currentFlow.ToString(), safeLimit.ToString(),this.compStart.GetComponentId().ToString(), this.compEnd.GetComponentId().ToString(), danger.ToString());//Need the methods get comps

            if (clickLocation != null)
            {
                foreach (var p in clickLocation)
                {
                    resultSt += String.Format("_{0}_{1}", p.X.ToString(), p.Y.ToString());
                }
              
            }
            else
            {
                //-1 if the list is NULL
                resultSt += "_-1";
            }
            return resultSt;
        }

        /// <summary>
        /// Create an object of type Pipeline from string infors
        /// </summary>
        /// <param name="SinkInfors"></param>
        /// <returns></returns>
        public static PipeLine createPipeLineFromStringArray(string[] PipelineInfors)
        {
            PipeLine p = null;
            int id = Convert.ToInt16(PipelineInfors[0]);
            int Start_Loc_X = Convert.ToInt32(PipelineInfors[1]);
            int Start_Loc_Y = Convert.ToInt32(PipelineInfors[2]);
            Point StartLocation = new Point(Start_Loc_X, Start_Loc_Y);
            int End_Loc_X = Convert.ToInt32(PipelineInfors[3]);
            int End_Loc_Y = Convert.ToInt32(PipelineInfors[4]);
            Point EndLocation = new Point(End_Loc_X, End_Loc_Y);
            double CurrentFlow = Convert.ToDouble(PipelineInfors[5]);
            double SafeLimit = Convert.ToDouble(PipelineInfors[6]);
            Component compStart = new Component(Convert.ToInt32(PipelineInfors[7]));
            Component compEnd = new Component(Convert.ToInt32(PipelineInfors[8]));
            bool danger = Convert.ToBoolean(PipelineInfors[9]);
            int nrOfMiddlePoints = PipelineInfors.Length - 9;
            List<Point> middlePoints = new List<Point>();
            for (int i = 0; i < nrOfMiddlePoints/2; i++)
            {
                int tempX = Convert.ToInt32(PipelineInfors[10 + i]);
                int tempY = Convert.ToInt32(PipelineInfors[10 + i + 1]);
                Point tempPoint = new Point(tempX, tempY);
                middlePoints.Add(tempPoint);
            }

            p = new PipeLine(id, StartLocation, EndLocation, CurrentFlow, SafeLimit, middlePoints, compEnd, compStart);
           
            return p;
        }

        /// <summary>
        /// Draw a pipeline
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="p"></param>
        /// <param name="pen"></param>
        public static void DrawPipeline(Graphics gr, PipeLine p, Pen pen)
        {
            List<Point> points = p.getMiddleLocation();
            Font f = new Font("Arial", 8, FontStyle.Bold);
            int YText = 0;
            int XText = 0;
            XText = (p.startLocation.X + p.endLocation.X) / 2;
            YText = (p.startLocation.Y + p.endLocation.Y) / 2;
          
            gr.DrawString(p.CurrentFlow.ToString() + "/" + p.SafeLimit.ToString(), f, Brushes.Black, new Point(XText,YText));
            if (points.Count > 0)
            {
                gr.DrawLine(pen, p.getStartLocation(), points[0]);
                for (int i = 0; i < points.Count - 1; i++)
                {
                    gr.DrawLine(pen, points[i], points[i + 1]);
                }
                gr.DrawLine(pen, points[points.Count - 1], p.getEndLocation());
            }
            else
            {
                gr.DrawLine(pen, p.getStartLocation(), p.getEndLocation());
            }
        }
    }
}
