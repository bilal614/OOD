﻿using PipeLine_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PipeLine_System
{
    public class Network
    {
        private List<Component> components;
        private List<PipeLine> pipelines;
        private List<PipeLine> Neigbor_pipelines;
        private List<PipeLine> exceeding_pipeline;
        PipeLineSystem sys; 

        public Network()
        {
            sys = new PipeLineSystem();
            components = new List<Component>();
            pipelines = new List<PipeLine>();
        }
        public Component FindComponent(Point p)
        {
            foreach (var item in components)
            {
                if (item.ContainsPoint(p.X,p.Y))
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// This function first checks to see if the Component c has any overlap with the locations of the 
        /// other Components in the list of Components. If not it adds the Component c to the list of 
        /// Components and returns true. Otherwise it returns a false.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool Addcomponent(Component c)
        {
            if (CheckOverLap(c))
            {
                return false;
            }
            else
            {
                components.Add(c);
                return true;
            }
        }

        /// <summary>
        /// This function checks if the Component c given in the argument has any overlap with any of the 
        /// Component location in the List of Components.
        /// </summary>
        /// <param name="c">Component c to check for overlap</param>
        /// <returns>Returns true if there is an overlap and false if there is no overlap.</returns>
        public bool CheckOverLap(Component c)
        {
            bool returnValue1 = false, returnValue2 = false;
            foreach (var item in components)
            {
                /*In this condition we check that the point location of component c is not contained in Component
                 * item's area by 30+x from item's location.X and by y-30 from item's location.Y. 
                 */
                if (item.GetLocation().X <= c.GetLocation().X && c.GetLocation().X <= (item.GetLocation().X + 30) &&
                    item.GetLocation().Y - 30 <= c.GetLocation().Y && c.GetLocation().Y <= item.GetLocation().Y)
                {
                    returnValue1 = true;
                }

                /*This condition we check the reverse that the point location of component item is not contained in 
                 * Component c's area by 30+x from c's location.X and by y-30 from c's location.Y. 
                 */
                if (c.GetLocation().X <= item.GetLocation().X && item.GetLocation().X <= (c.GetLocation().X + 30) &&
                    c.GetLocation().Y - 30 <= item.GetLocation().Y && item.GetLocation().Y <= c.GetLocation().Y)
                {
                    returnValue2 = true;
                }

                if (returnValue1 == true && returnValue2 == true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RemovePipeline(PipeLine P)
        {
            
            foreach (PipeLine pipe in pipelines)
            {
                if (pipe == P)
                {
                    pipelines.Remove(pipe);
                  //  P.CompEnd.updateCurrentFlow_Neighbors();

                    sys.refreshDrawing();
                    return true;
                }
            }
            return false;
        }

        public bool RemoveComponent(Component comp)
        { 
            foreach (Component c in components)
            {
                if (comp == c)
                {
                    foreach (PipeLine pipefromlist in GetPipelineOfComponent(c))
                    {
                        RemovePipeline(pipefromlist);

                    }

              
                    components.Remove(c);
                    sys.refreshDrawing();
                    return true;
                }
            }

            return false;
        }

        public List<PipeLine> GetExceedPipeline() 
        {
            exceeding_pipeline = new List<PipeLine>();
            foreach (PipeLine pipe in pipelines)
            {
                if (pipe.CurrentFlow >= pipe.SafeLimit)
                {
                    exceeding_pipeline.Add(pipe);

                }
            }
            return exceeding_pipeline; 
        }
        public List<PipeLine> GetPipelineOfComponent(Component cop)
        {
           Neigbor_pipelines = new List<PipeLine>();
           foreach (PipeLine np in pipelines)
           {
               if (np.CompEnd == cop || np.CompStart == cop)
               {
                   Neigbor_pipelines.Add(np);
               }
           }
           return Neigbor_pipelines;
        }
        public List<Component> GetListOfComponents() 
        {
            return components; 
        }
        public List<PipeLine> GetListOfPipeline()
        {
            return pipelines; 
        }
        public bool AddPipeLine(PipeLine p)
        {

            //foreach (var item in pipelines)
            //{
                //item.startLocation =  
                //item.endLocation = 
                pipelines.Add(p);
                return true;
            //}
            //return false;
        }

        /// <summary>
        /// All Components are drawn on the graphics gr, using the images in the Imagelist il
        /// (il.Images[0] for the Pump; il.Images[1] for the Sink, etc.)
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="il"></param>
        public bool DrawAllComponents(Graphics gr, ImageList il)
        {
            Point p;
            try
            {
                foreach (Component c in components)
                {
                    if (c is Pump)
                    {
                        gr.DrawImage(il.Images[0], c.GetLocation());//assuming the first image in the imageList                   
                        //is of the Pump 
                    }
                    else if (c is Sink)
                    {
                        gr.DrawImage(il.Images[1], c.GetLocation());//assuming the second image in the imageList 
                        //is of the Sink 
                    }
                    else if (c is Merger)
                    {
                        gr.DrawImage(il.Images[2], c.GetLocation());//assuming the third image in the imageList 
                        //is of the Merger 
                    }
                    else if (c is Spliter)
                    {
                        gr.DrawImage(il.Images[3], c.GetLocation());//assuming the fourth image in the imageList 
                        //is of the Splitter 
                    }
                    else if (c is AdjustableSpliter)
                    {
                        gr.DrawImage(il.Images[4], c.GetLocation());//assuming the fourth image in the imageList 
                        //is of the Adjustable Splitter. Splitter and Adjustable Splitter have the same image 
                    }
                    else
                    {
                        return false; //in case that not all Components were drawn on the drawing screen
                        //the function should return a false, also each component in the list of components
                        //must be a specific component type: pump, sink, merger, splitter or adjustable splitter 
                    }
                }
                return true;
            }
            catch (ArgumentNullException e) 
            {
                //message box is only for our own feedback when error occurs
                MessageBox.Show("One of your components location Point is null or un-initialized.");
            }
            return false;
        }
        public bool DrawAllPipeLines(Graphics gr)
        {
            try
            {
                foreach (PipeLine p in pipelines)
                {
                    List<Point> points = p.getMiddleLocation();
                    gr.DrawLine(Pens.Black, p.CompStart.GetLocation(), points[0]);
                    for (int i = 0; i < points.Count - 1; i++)
                    {
                        gr.DrawLine(Pens.Black, points[i], points[i + 1]);
                    }
                    gr.DrawLine(Pens.Black, points[points.Count - 1], p.CompEnd.GetLocation());
                }
            }
            catch
            {
                MessageBox.Show("Some of the pipelines are not connected to a component.");
            }
            return true;
        }

        public int SetId()
        {
            int count = components.Count()+1; 
            return count;
        }

        public int SetPipeLineId()
        {
            int count = pipelines.Count() + 1;
            return count;
        } 
    }
}
