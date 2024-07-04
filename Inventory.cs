using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IA
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static int prtIndex;


        
        public static void PopulateLists()
        {
        }

        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool RemoveProduct(int id)
        {
            bool removed = false;

            foreach (Product product in Products)
            {
                if (id == product.ID)
                {
                    Products.Remove(product);
                    return removed = true;
                }
                else
                {
                    MessageBox.Show("Error!");
                    return false;
                }
            }
            return removed;
        }

        public static Product LookupProduct(int id)
        {
            foreach (Product product in Products)
            {
                if (product.ID == id)
                {
                    return product;
                }
            }
            Product voidProd = new Product();
            return voidProd;
        }

        public static void UpdateProduct(int id, Product updatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ID == id)
                {
                    currentProduct.name = updatedProduct.name;
                    currentProduct.price = updatedProduct.price;
                    currentProduct.Quantity = updatedProduct.Quantity;
                    currentProduct.min = updatedProduct.min;
                    currentProduct.max = updatedProduct.max;
                    currentProduct.AssociatedParts = updatedProduct.AssociatedParts;
                    return;

                }
            }
        }

        public static void AddPart(int index, Part part)
        {
            AllParts.Insert(index - 1, part);
        }

        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        public static bool DeletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int id)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == id)
                {
                    return part;
                }
            }
            Part EmptyPart = null;
            return EmptyPart;
        }

        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }

        public static void UpdatePart(int partID, Part part)
        {
            DeletePart(partID);
            AllParts.Add(part);
        }
    }


}
