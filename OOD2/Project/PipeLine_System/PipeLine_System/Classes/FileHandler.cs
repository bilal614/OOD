using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeLine_System
{
    class FileHandler
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
                sw.WriteLine("Component");
                foreach (var c in nw.GetListOfComponents())
                {
                    
                }

            }
            catch (IOException)
            {
                listBox1.Items.Add("Something went wrong, IOException was thrown");
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
            string returnResult;
            if(component is Pump)
            {
                Sink sk = (Sink)component;

            }
        }
    }
}
