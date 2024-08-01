using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Project.classes
{
    public abstract class Part
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Part(int partId, string name, int inStock, decimal price, int min, int max)
        {
            PartId = partId;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        //abstract method for InHouse
        //Abstract method in PartSelection.CS
        public abstract int MachineId();

        //abstract method for Outsourced
        //Abstract method in PartSelection.CS
        public abstract string CompanyName();


    }
}
