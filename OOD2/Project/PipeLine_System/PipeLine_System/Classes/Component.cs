using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    class Component
    {
        /*The Component class is the parent class for all the different child Component classes including Pump, Splitter, Merger, Sink and 
        the Pump class. The Component class serves as the blueprint for each of the different kind of components that are needed in the 
        the pipe-line network.
         */
        /*PROPERTIES:
         * Properties of the Component class include those properties which are common to all the Component child classes and include 
         * attributes including the location, an id and a current-flow for each component. Moreover all the properties for the Component
         * class have been kept private and can be accessed via various methods. Area is the length x width of the Component picture on the
         * drawing screen.
         */
        private int id;
        private Point location;
        private double currentFlow;
        public static const int Radius = 40; /*the radius of every Component (that is why it is static), because the relative size of the
        Components on the drawing screen is similar so we can use this value as Radius for all Components*/

        /*
         * CONSTRUCTOR
        */
        public Component(int ID, Point componentLocation, double CurrentFlow)
        {
            id = ID;
            location = componentLocation;
            currentFlow = CurrentFlow;
        }
         /*METHODS:
         * The Component class has the method updateCurrentFlow which takes no parameters and returns nothing. This method would be tied to 
         * an event which would be raised if the current-flow of the Component is changed. If so the current-flow of the neighbors are changed
         * by invoking their current-flow change event as well. 
         */
        bool updateCurrentFlow()
        {
            //needs to be implemented 
            return true;
        }

        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this Component.
        /// In other words: it checks if the distance between the center of this Component and the point (xmouse,ymouse)
        /// is less than or equal to the Radius of the Component.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns></returns>
        public virtual bool ContainsPoint(int xmouse, int ymouse)
        {
            return (this.location.X - xmouse) * (this.location.X - xmouse) + (this.location.Y - ymouse) * (this.location.Y - ymouse) <= Radius * Radius;
        }
    }
}
