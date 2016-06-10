using PipeLine_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        
    }
}
