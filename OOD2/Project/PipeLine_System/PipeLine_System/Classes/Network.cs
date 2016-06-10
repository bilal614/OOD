using PipeLine_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    class Network
    {
        private List<Component> components;
        private List<PipeLine> pipelines;

        public Network()
        {
            components = new List<Component>();
            pipelines = new List<PipeLine>();
        }
        public bool Addcomponent(Component c)    { return false; }
        public bool RemoveComponent(Component c) { return false; }
        public bool CheckOverLap(Component c)    { return false; }
        public bool RemovePipeline(PipeLine P)    { return false; }
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
        
    }
}
