using PineLineProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLineProject.Classes
{
    class Network : Component
    {
        private List<Component> components;
        private List<PineLine> pipelines;

        public Network()
        {
            components = new List<Component>();
            pipelines = new List<PineLine>();
        }
        public bool Addcomponent(Component c)    { return false; }
        public bool RemoveComponent(Component c) { return false; }
        public bool CheckOverLap(Component c)    { return false; }
        public bool RemovePipeline(PineLine P)    { return false; }
        public List<PipeLine> GetExceedPipeline() { return null; }
        public List<Component> GetListOfComponents() { return null; }
        public List<PipeLine> GetListOfPipeline() { return null; }
        
    }
}
