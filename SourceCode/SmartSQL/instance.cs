using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSQL
{
    public class instance
    {
        public string nameInstance { get; set; }
        public string version { get; set; }
        public string sharedName { get; set; }
        public string Owner { get; set; }
        public bool autoCreated { get; set; }
        public string state { get; set; }
        public DateTime lastStartTime { get; set; }
        public string instancePipeName { get; set; }

        public override string ToString()
        {
            return nameInstance;
        }


        

    }
}
