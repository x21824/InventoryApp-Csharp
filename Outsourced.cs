using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IA
{
    public class Outsourced : Part
    {
        private string companyname;

        public string Companyname
        {
            get { return companyname; }
            set { companyname = value; }
        }



        public Outsourced()
        { }
        public Outsourced(int partID, string name, decimal price, int Stock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = Stock;
            Min = min;
            Max = max;

        }
        public Outsourced(int partID, string name, decimal price, int Stock, int min, int max, string companyname)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = Stock;
            Min = min;
            Max = max;
            Companyname = companyname;

        }
    }

}
