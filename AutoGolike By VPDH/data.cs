using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGolike_By_VPDH
{
    public class data
    {
        public class DataJson
        {
            public DataFill fills { get; set; }
        }

        public class DataFill
        {
            public bool HDBrowser { get; set; }
            public string NumThread { get; set; }
            public string textbox2 { get; set; }
        }
    }
}
