using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA
{
    public class Product
    {
        private int ProductID;
        private string Name;
        private decimal Price;
        private int InStock;
        private int Min;
        private int Max;

        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public Product()
        {

        }
        

        public int ID
        {
            get { return ProductID; }
            set { ProductID = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public decimal price
        {
            get { return Price; }
            set { Price = value; }

        }

        public int Quantity
        {
            get { return InStock; }
            set { InStock = value; }
        }

        public int min
        {
            get { return Min; }
            set { Min = value; }
        }

        public int max
        {
            get { return Max; }
            set { Max = value; }
        }
        public Product(int ID, string name, decimal price, int Stock, int min, int max)
        {
            ProductID = ID;
            Name = name;
            Price = price;
            InStock = Stock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
            bool partRemoved = false;

            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return partRemoved = true;
                }
                else
                    partRemoved = false;
            }
            return partRemoved;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                { return part; }
            }
            return null;
        }
    }
}
