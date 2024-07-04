using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IA
{
    public class Inhouse : Part
    {
        private int machineID;

        public int MachineID
        {
            get { return machineID; }
            set { machineID = value; }
        }


        public Inhouse()
        {

        }

        public Inhouse(int partID, string name, decimal price, int Stock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = Stock;
            Min = min;
            Max = max;

        }

        public Inhouse(int partID, string name, decimal price, int Stock, int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = Stock;
            Min = min;
            Max = max;
            MachineID = machineID;

        }

    }
}
