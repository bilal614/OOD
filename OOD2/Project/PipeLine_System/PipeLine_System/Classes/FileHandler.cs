using System;
using System.Collections.Generic;
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
                fs = new FileStream(this.path, FileMode.Append, FileAccess.Write);
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
                MessageBox.Show("Something went wrong, IOException was thrown");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
            return false;
        }
        public Network ReadFromFile()
        {
            Network nw = new Network();
            return nw;
        }
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
    }
}
