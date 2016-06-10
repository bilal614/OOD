using PipeLine_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PipeLine_System
{
    class Network
    {
        private List<Component> components;
        private List<PipeLine> pipelines;
        private static int count = 0;
        public Network()
        {
            components = new List<Component>();
            pipelines = new List<PipeLine>();
        }
        public bool Addcomponent(Component c)
        {
            count = components.Count +1;
            return false;
        }
        public bool RemoveComponent(Component c) { return false; }
        public bool CheckOverLap(Component c)
        {
            //foreach (var item in components)
            //{
            //    if (item.ContainsPoint(c))
            //    {
            //        return false;
            //    } 
            //}
            return true;
        }
        public bool RemovePipeline(PipeLine P)
        {
           
            return false; }
        public List<PipeLine> GetExceedPipeline() { return null; }
        public List<Component> GetListOfComponents() { return null; }
        public List<PipeLine> GetListOfPipeline() { return null; }
        public Component FindComponents(Point p) { return null; }
        public bool AddPipeLine(Point p) { return false; }
    }
}
