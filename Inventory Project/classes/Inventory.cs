using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Project.classes
{
    public class Inventory
    {
        public static BindingList<Part> allParts = new BindingList<Part>();
        public static BindingList<Product> allProducts = new BindingList<Product>();

//Part Methods
        
        //adding parts to BindingList method
        public static void PartAdd(Part part)
        {
            allParts.Add(part);
        }

        //Updating Parts in BindingList Method
        public static void UpdatePart(int partId, Part part)
        {
            //iterate through allParts List
            for (int i = 0; i < allParts.Count; i++)
            {
                //Find the index
                if (allParts[i].PartId == partId)
                {

                    //Check if argument received is an OutSource/InHouse List
                    //Changes the allParts List to InHouse or OutSource and populates list
                    if (part is OutSource changeOutSourcePart)
                    {
                        if (allParts[i] is InHouse currentInHousePart)
                        {
                            OutSource modifyOutSource = new OutSource(
                                currentInHousePart.PartId,
                                changeOutSourcePart.Name,
                                changeOutSourcePart.InStock,
                                changeOutSourcePart.Price,
                                changeOutSourcePart.Min,
                                changeOutSourcePart.Max,
                                changeOutSourcePart.OutSourceCompanyName
                                );
                            allParts[i] = modifyOutSource;
                        }
                        else if (allParts[i] is OutSource currentOutSourcePart)
                        {
                            currentOutSourcePart.Name = changeOutSourcePart.Name;
                            currentOutSourcePart.InStock = changeOutSourcePart.InStock;
                            currentOutSourcePart.Price = changeOutSourcePart.Price;
                            currentOutSourcePart.Min = changeOutSourcePart.Min;
                            currentOutSourcePart.Max = changeOutSourcePart.Max;
                            currentOutSourcePart.OutSourceCompanyName = changeOutSourcePart.OutSourceCompanyName;
                        }
                    }
                    else if (part is InHouse changeInHousePart)
                    {
                        if (allParts[i] is InHouse current1InHousePart)
                        {
                            current1InHousePart.Name = changeInHousePart.Name;
                            current1InHousePart.InStock = changeInHousePart.InStock;
                            current1InHousePart.Price = changeInHousePart.Price;
                            current1InHousePart.Min = changeInHousePart.Min;
                            current1InHousePart.Max = changeInHousePart.Max;
                            current1InHousePart.InHouseMachineId = changeInHousePart.InHouseMachineId;
                        }
                        else if (allParts[i] is OutSource current1OutSourcePart)
                        {
                            InHouse modifyInHouse = new InHouse(
                                current1OutSourcePart.PartId,
                                changeInHousePart.Name,
                                changeInHousePart.InStock,
                                changeInHousePart.Price,
                                changeInHousePart.Min,
                                changeInHousePart.Max,
                                changeInHousePart.InHouseMachineId
                                );
                            allParts[i] = modifyInHouse;
                        }
                    }

                }

            }
        }
        //LookUp Part in BindingList
        public static Part LookUpPart(int partid)
        {
            foreach (Part part in allParts)
            {
                if(part.PartId == partid)
                {
                    return part;
                }
            }
            return null;
            
        }
        

        
        //Delete Part in BindingList
        public static bool DeletePart(Part part)
        {
            return allParts.Remove(part);
        }
        
        
//Product Methods

        //Add Product to BindingList Method
        public static void AddProduct(Product product)
        {
            allProducts.Add(product);
        }

        //LookUp Product Method
        public static Product LookUpProduct(int productid)
        {
            foreach (Product product in allProducts)
            {
                if(product.ProductID == productid)
                {
                    return product;
                }
            }
            return null;
        }

        //Update Product Method
        public static void UpdateProduct(int productid, Product product)
        {
            foreach (Product toBeModifiedProduct in allProducts)
            {
                if (toBeModifiedProduct.ProductID == productid)
                {
                    toBeModifiedProduct.ProductID = product.ProductID;
                    toBeModifiedProduct.Name = product.Name;
                    toBeModifiedProduct.InStock = product.InStock;
                    toBeModifiedProduct.Price = product.Price;
                    toBeModifiedProduct.Min = product.Min;
                    toBeModifiedProduct.Max = product.Max;
                    toBeModifiedProduct.AssociatedParts = product.AssociatedParts;
                    return;
                }
            }
        }

        //Remove Product Method
        public static bool RemoveProduct(int productid)
        {
            bool boolDeleted = false;
            foreach (Product product in allProducts)
            {
                if (product.ProductID == productid)
                {
                    return boolDeleted = true;
                }
            }
            return boolDeleted;
        }
        
        //Items to populate grid
        public static void PopulateGrid()
        {
            var exampleInHousePart = new InHouse(1, "Part 1", 5, 10.00m, 1, 10, 101);
            var exampleOutSourcePart = new OutSource(2, "Part 2", 3, 5.00m, 1, 5, "Corp");

            var exampleProduct = new Product(1, "Product 1", 3, 20.00m, 1, 10);
            var exampleProduct2 = new Product(2, "Product 2", 8, 10.00m, 5, 20);

            PartAdd(exampleInHousePart);
            PartAdd(exampleOutSourcePart);

            AddProduct(exampleProduct);
            AddProduct(exampleProduct2);
        }
    }
}
