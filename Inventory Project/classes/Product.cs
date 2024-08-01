using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Project.classes
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public Product(int productID, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        //addAssociated Part Method
        public void AddAssociatedPart (Part part)
        {
            AssociatedParts.Add(part);
        }

        //removeAssociated Part Method
        public bool RemoveAssociatedPart (int partId)
        {
            bool deleted = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.PartId == partId)
                {
                    return deleted = true;
                }
            }
            return deleted;
        }

        //Lookup Associated Part Method
        public Part LookUpAssociatedPart(int partid)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartId == partid)
                {
                    return part;
                }
            }
            return null;
        }


    }




}
