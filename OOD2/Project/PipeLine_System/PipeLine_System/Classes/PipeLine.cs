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
        private double safeLimit;
        private List<Point> clickLocation;
        private Component compStart;
        private Component compEnd;
        private bool danger;
        //Constructors

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
            resultSt += String.Format("{0}_{1}_{2}_{3}_{4}_{5}_{6}_{7}_{8}_{9}",
            id.ToString(), startLocation.X.ToString(), startLocation.Y.ToString(), endLocation.X.ToString(), endLocation.X.ToString(),
            currentFlow.ToString(), safeLimit.ToString(),this.compStart.GetComponentId().ToString(), this.compEnd.GetComponentId().ToString(), danger.ToString());//Need the methods get comps

            foreach(var p in clickLocation)
            {
                resultSt += String.Format("_{0}_{1}", p.X.ToString(), p.Y.ToString());
            }
            return resultSt;      
        }
    }
}
