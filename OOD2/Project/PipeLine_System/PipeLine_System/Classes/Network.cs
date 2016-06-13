using PipeLine_System;
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

        public Network()
        {
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
        public bool Addcomponent(Component c)
        {
            foreach (var item in components)
            {
                components.Add(item);
                return true;
            }
            return false;
        }

        public bool RemoveComponent(Component c)
        {
            foreach (var item in components)
            {
                if (c.GetComponentId() == item.GetComponentId())
                {
                    GetListOfComponents().Remove(item);
                    return true;
                }
            }
            return false;
        }

        public bool CheckOverLap(Component c)
        {
            foreach (var item in components)
            {
                if (c.GetLocation() == item.GetLocation())
                {
                    return true;
                }
            }
            return false;
        }

        public bool RemovePipeline(PipeLine P)
        {
            foreach (var item in pipelines)
            {
                if (P.getId() == item.getId())
                {
                    GetExceedPipeline().Remove(item);
                    return true;
                }
            }
            return false;
        }

        public List<PipeLine> GetExceedPipeline() 
        {
            return null;
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
            foreach (Component c in components)
            {
                if (c.GetType().ToString() == "Pump")
                {
                    gr.DrawImage(il.Images[0], c.GetLocation());//assuming the first image in the imageList 
                    //is of the Pump 
                }
                else if (c.GetType().ToString() == "Sink")
                {
                    gr.DrawImage(il.Images[1], c.GetLocation());//assuming the second image in the imageList 
                    //is of the Sink 
                }
                else if (c.GetType().ToString() == "Merger")
                {
                    gr.DrawImage(il.Images[2], c.GetLocation());//assuming the third image in the imageList 
                    //is of the Merger 
                }
                else if (c.GetType().ToString() == "Spliter")
                {
                    gr.DrawImage(il.Images[3], c.GetLocation());//assuming the fourth image in the imageList 
                    //is of the Splitter 
                }
                else if (c.GetType().ToString() == "AdjustableSpliter")
                {
                    gr.DrawImage(il.Images[3], c.GetLocation());//assuming the fourth image in the imageList 
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
        
    }
}
