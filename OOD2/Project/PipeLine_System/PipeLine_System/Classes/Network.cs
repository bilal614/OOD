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
                MessageBox.Show("Cannot draw component over another component.");
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
            if (GetListOfComponents().Count > 0)
            {
                foreach (Component com in components)
                {
                    /*In this condition we check that the point location of component c is not contained in Component
                     * item's area by 30+x from item's location.X and by y-30 from item's location.Y. 
                     */
                    Point ofCom = com.GetLocation();
                    Point ofC = c.GetLocation();
                    if (ofCom.X <= ofC.X && ofC.X <= (ofCom.X + 30) &&
                        ofCom.Y <= ofC.Y && ofC.Y <= (ofCom.Y + 30))
                    {
                        returnValue1 = true;
                    }

                    /*This condition we check the reverse that the point location of component item is not contained in 
                     * Component c's area by 30+x from c's location.X and by y-30 from c's location.Y. 
                     */
                    if (ofC.X <= ofCom.X && ofCom.X <= (ofC.X + 30) &&
                        ofC.Y <= ofCom.Y && ofCom.Y <= ofC.Y + 30)
                    {
                        returnValue2 = true;
                    }

                    if (returnValue1 == true || returnValue2 == true)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool RemovePipeline(PipeLine P)
        {
            
            foreach (PipeLine pipe in pipelines)
            {
                if (pipe == P)
                {
                    pipe.CurrentFlow = 0;
                    UpdateCurrentFlowOfNetwork();
                    pipelines.Remove(pipe);
                    // below will inform component that its pipeline has gone now.
                    foreach (var c in components)
                    {
                        UpdatePipelinesOfComps(c);
                    }
                    
               
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
            bool toAddOrNot = true;
            int count1 = 0, count2 = 0;
            foreach (PipeLine pl in this.GetListOfPipeline())
            {
                if (pl.CompStart is Pump)//to avoid multiple connections from pump
                {
                    if (p.CompStart == pl.CompStart)
                    {
                        toAddOrNot = false;
                        break;
                    }
                }

                if (pl.CompEnd is Sink)
                {
                    if (p.CompEnd == pl.CompEnd)
                    {
                        toAddOrNot = false;
                        break;
                    }
                }

                if (pl.CompStart is Merger)
                {
                    if (p.CompStart == pl.CompStart)
                    {
                        toAddOrNot = false;
                        break;
                    }
                }
                if (pl.CompEnd is Merger)
                {
                    if (p.CompEnd == pl.CompEnd)
                    {
                        count1++;
                    }
                }

                if (pl.CompStart is Spliter)
                {
                    if (p.CompStart == pl.CompStart)
                    {
                        count2++;
                    }
                }
                if (pl.CompEnd is Spliter)
                {
                    if (p.CompEnd == pl.CompEnd)
                    {
                        toAddOrNot = false;
                        break;
                    }
                }
            }

            if (count1 >= 2 || count2 >= 2)
            {
                toAddOrNot = false;
            }
            if (p.CompStart is Sink)
            {
                toAddOrNot = false;
            }
            if (p.CompEnd is Pump)
            {
                toAddOrNot = false;
            }
            if (toAddOrNot)
            {
                pipelines.Add(p);
            }
            return toAddOrNot;
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
                    Font f = new Font("Arial", 10);
                    gr.DrawString(c.GetFlow().ToString(), f, Brushes.Black, c.GetLocation().X, c.GetLocation().Y - 20);
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
                        AdjustableSpliter temp;
                        if (c is AdjustableSpliter)
                        {
                            temp = (AdjustableSpliter)c;
                            gr.DrawImage(il.Images[4], temp.GetLocation());//assuming the fourth image in the imageList 
                            //is of the Adjustable Splitter. Splitter and Adjustable Splitter have the same image 
                        }
                        else
                        {
                            gr.DrawImage(il.Images[3], c.GetLocation());//assuming the fourth image in the imageList 
                            //is of the Splitter 
                        }
                                           
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
                    if (points.Count > 0)
                    {
                        gr.DrawLine(Pens.Black, p.getStartLocation(), points[0]);
                        for (int i = 0; i < points.Count - 1; i++)
                        {
                            gr.DrawLine(Pens.Black, points[i], points[i + 1]);
                        }
                        gr.DrawLine(Pens.Black, points[points.Count - 1], p.getEndLocation());
                    }
                    else
                    {
                        gr.DrawLine(Pens.Black, p.getStartLocation(), p.getEndLocation());
                    }
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
      
        /// <summary>
        /// Find component basing on the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private Component GetComponent(int id)
        {
            Component returnComp = null;
            foreach(var c in components)
            {
                if(c.GetComponentId() == id)
                {
                    returnComp = c;
                }
            }
            return returnComp;
        }
        /// <summary>
        /// Find pipeline basing on the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private PipeLine GetPipeline(int id)
        {
            PipeLine returnPipeline = null;
            foreach(var p in pipelines)
            {
                if(p.getId() == id)
                {
                    returnPipeline = p;
                }
            }
            return returnPipeline;
        }


        /// <summary>
        /// Update Pipelines of Comps depending type of com
        /// </summary>
        /// <param name="c"></param>
        private void UpdatePipelinesOfComps(Component c)
        {
            if(c is Pump)
            {
               Pump p = (Pump)c;
               if (p.getOutPipeLine() != null)
               {
                   PipeLine outPipeLine = GetPipeline(p.getOutPipeLine().getId());
                   p.addOutPipeLine(outPipeLine);
               }
               else { p.addOutPipeLine(null); }

            }
            if(c is Spliter || c is AdjustableSpliter)
            {
                Spliter sp = null;
                sp = (Spliter)c;
                if (c is AdjustableSpliter)
                {
                    sp = (AdjustableSpliter)c;
                }
                if (sp.getInPipeLine() != null)
                {
                    PipeLine inPipeLine = GetPipeline(sp.getInPipeLine().getId());
                    sp.addInPipeLine(inPipeLine);
                }
                else { sp.addInPipeLine(null); }
                if (sp.getOutPipeLine1() != null)
                {
                PipeLine outPipeLine1 = GetPipeline(sp.getOutPipeLine1().getId());
                sp.addOutPipeLine1(outPipeLine1);
                }
                else { sp.addOutPipeLine1(null); }
                if (sp.getOutPipeLine2() != null)
                {
                PipeLine outPipeLine2 = GetPipeline(sp.getOutPipeLine2().getId());
                sp.addOutPipeLine2(outPipeLine2);
                }
                else { sp.addOutPipeLine2(null); }
            }
            if(c is Merger)
            {
                Merger mg = (Merger)c;
                if (mg.getOutPipeLine() != null)
                {
                    PipeLine outPipeline = GetPipeline(mg.getOutPipeLine().getId());
                    mg.addOutPipeLine(outPipeline);
                }
                else { mg.addOutPipeLine(null); }
                if (mg.getInPipeLine1() != null)
                {
                    PipeLine inPipeline1 = GetPipeline(mg.getInPipeLine1().getId());
                    mg.addInPipeLine1(inPipeline1);
                }
                else { mg.addInPipeLine1(null); }
                if (mg.getInPipeLine2() != null)
                {
                    PipeLine intPipeline2 = GetPipeline(mg.getInPipeLine2().getId());
                    mg.addInPipeLine2(intPipeline2);
                }
                else { mg.addInPipeLine2(null); }
            }
            if (c is Sink)
            {
                Sink sk = (Sink)c;
                if (sk.getInPipeLine() != null)
                {
                    PipeLine inPipeline = GetPipeline(sk.getInPipeLine().getId());
                    sk.addInPipeLine(inPipeline);
                }
                else { sk.addInPipeLine(null); }
            }
        }
        /// <summary>
        /// Update the full infors of comps and pipelines base on their id
        /// </summary>
        /// <param name="nw"></param>
        public void updateNetwork()
        {
            foreach(var c in components)
            {
                UpdatePipelinesOfComps(c);
            }
            foreach(var p in pipelines)
            {
                p.CompStart = GetComponent(p.CompStart.GetComponentId());
                p.CompEnd = GetComponent(p.CompEnd.GetComponentId());
            }
        }


        public void UpdateCurrentFlowOfNetwork()
        {
            try
            {
                foreach (PipeLine p in GetListOfPipeline())
                {
                    if (p.CompStart is Pump)
                    {
                        p.CompEnd.SetFlow(p.CompStart.GetFlow());
                    }
                }

                foreach (PipeLine p in GetListOfPipeline())
                {
                    if (p.CompStart is AdjustableSpliter)
                    {
                        double upperFlow = 0, lowerFlow = 0;
                        AdjustableSpliter temp = (AdjustableSpliter)p.CompStart;
                        PipeLine p1 = null, p2 = null;
                        foreach (PipeLine pi in GetListOfPipeline())
                        {
                            if (pi.CompStart == temp)
                            {
                                if (upperFlow == 0)
                                {
                                    p1 = pi;
                                    upperFlow = (100 - temp.GetUpperPercent()) * temp.GetFlow();
                                }

                                if (lowerFlow == 0)
                                {
                                    p2 = pi;
                                    lowerFlow = temp.GetUpperPercent() * temp.GetFlow();
                                }
                            }
                        }
                        p1.CompEnd.SetFlow(upperFlow);
                        p2.CompEnd.SetFlow(lowerFlow);
                    }
                    if (p.CompStart is Spliter)
                    {
                        p.CompEnd.SetFlow(p.CompStart.GetFlow() / 2);
                    }
                }
                foreach (PipeLine p in GetListOfPipeline())
                {
                    if (p.CompStart is Merger)
                    {
                        double mergerCurrentFlow = 0;
                        Merger temp = (Merger)p.CompStart;
                        foreach (PipeLine pi in GetListOfPipeline())
                        {
                            if (pi.CompEnd == temp)
                            {


                                mergerCurrentFlow += pi.CompEnd.GetFlow();
                            }
                        }
                        p.CompEnd.SetFlow(mergerCurrentFlow);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Current flow update error.");
            }

        }
    }
}
