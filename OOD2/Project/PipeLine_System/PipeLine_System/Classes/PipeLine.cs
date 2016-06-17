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
        public Point startLocation;
        public Point endLocation;
        private double currentFlow;
        public double CurrentFlow { get; set; }
        private double safeLimit;
        public double SafeLimit { get; set; }
        private List<Point> clickLocation;
        private Component compStart;
        public Component CompStart{get;set;}
        private Component compEnd;
        public Component CompEnd { get; set; }
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
        }
        /// <summary>
        /// set the start location from the screen.
        /// The overlaped need to be checked before this method is call
        /// </summary>
        /// <param name="location"></param>
        public void setStartLocation(Point location)
        {
            this.startLocation.X = location.X;
            this.startLocation.Y = location.Y;
        }

        /// <summary>
        /// Set the end location
        /// </summary>
        /// <param name="location"></param>
        public void setEndLocation(Point location)
        {
            this.endLocation.X = location.X;
            this.startLocation.Y = location.Y;
        }

        /// <summary>
        /// Added the clicked point in the middle of the line
        /// </summary>
        /// <param name="points"></param>
        public void setMiddleLocations(List<Point> points)
        {
            foreach (var p in points)
            {
                clickLocation.Add(p);
            }
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
            id.ToString(), startLocation.X.ToString(), startLocation.Y.ToString(), endLocation.X.ToString(), endLocation.X.ToString(),
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
    }
}
