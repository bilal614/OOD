using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipeLine_System
{
    public class FileHandler
    {
        private string path;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="path"></param>
        public FileHandler(string path)
        {
            this.path = path;
        }
        public bool WriteToFile(Network nw)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream(this.path, FileMode.Create, FileAccess.Write);
                //try for FileMode : Open, Create, Truncate, Append
                sw = new StreamWriter(fs);
                sw.WriteLine("Components");
                foreach (var c in nw.GetListOfComponents())
                {
                    sw.WriteLine(convertComponentToString(c));
                }
                sw.WriteLine("Pipelines");
                foreach (var p in nw.GetListOfPipeline())
                {
                    sw.WriteLine(p.ToString());
                }

            }
            catch (IOException)
            {
                MessageBox.Show("Something went wrong with file hanlder, IOException was thrown");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
            return false;
        }
        /// <summary>
        /// Read the list of network from the file
        /// </summary>
        /// <returns></returns>
        public Network ReadFromFile()
        {
            FileStream fs =  null;                  
            StreamReader sr = null;
            Network nw = new Network();
            try
            {
                fs = new FileStream(this.path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                String s = sr.ReadLine();
                if(s == "Components")
                {
                    while (s != "Pipelines")
                    {
                        s = sr.ReadLine();
                        Component p = ConvertFromStringToComp(s);
                        nw.Addcomponent(p);
                    }
                    s = sr.ReadLine();
                }
                while(s != null)
                {

                }
            }
            catch (IOException)
            {
                MessageBox.Show("something went wrong, IOException was thrown");
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
            return nw;
        }
        /// <summary>
        /// Convert a information of components into a string
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        private String convertComponentToString(Component component)
        {
            string result = null;
            if(component is Pump)
            {
                Pump pu = (Pump)component;
                result = pu.ToString();
            }
            if (component is Sink)
            {
                Sink sk = (Sink)component;
                result = sk.ToString();
            }
            if (component is Merger)
            {
                Merger mg = (Merger)component;
                result = mg.ToString();
            }
            if (component is Spliter)
            {
                Spliter spt = (Spliter)component;
                result = spt.ToString();
            }
            if (component is AdjustableSpliter)
            {
                AdjustableSpliter aspt = (AdjustableSpliter)component;
                result = aspt.ToString();
            }
            return result;
        }
        /// <summary>
        /// Convert from string to component
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private Component ConvertFromStringToComp(String s)
        {
            Component c = null;
            char[] separators = {'_'};
            string[] ComponentInfor = s.Split(separators);
            string type = ComponentInfor[0];
            if(type == "PU")
            {
                c = Pump.createPumpFromStringArray(ComponentInfor);
            }
            if(type == "SP")
            {
                c = Spliter.createSpliterFromStringArray(ComponentInfor);
            }
            if(type == "ASP")
            {
                c = AdjustableSpliter.createSpliterFromStringArray(ComponentInfor);
            }
            if(type == "MG")
            {
                c = Merger.createMergerFromStringArray(ComponentInfor);
            }
            if(type == "SK")
            {
                c = Sink.createSinkFromStringArray(ComponentInfor);
            }
            return c;
        }

    }
}
