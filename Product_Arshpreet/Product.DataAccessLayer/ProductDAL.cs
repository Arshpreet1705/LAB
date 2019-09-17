using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using GreatOutdoors.Entities;
using GreatOutdoors.Exceptions;

namespace GreatOutdoors.DataAccessLayer
{
    public class ProductDAL
    {
        //a static list to store a list of Products
        public static List<Product> productList = new List<Product>();

        //Function to return a list fo all products
        public List<Product> GetAllProductsDAL()
        {
            return productList;
        }

        //Function to return a product with Product_ID as an argument 
        public Product GetProductByProductIDDAL(int p_id)
        {
            Product getProduct = null;
            try
            {
                foreach(Product item in productList)
                {
                    if (item.ProductID == p_id)
                        getProduct = item;
                }
            }
            catch(SystemException ex)
            {
                throw new GreatOutdoorsException(ex.Message);
            }
            return getProduct;
        }

        //Function to let user overwrite product description
        public bool UpdateProductDescriptionDAL(int p_id, string desc)
        {
            bool isupdated = false;
            try
            {
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].ProductID == p_id)
                    {
                        productList[i].ProductDescription = desc;
                        isupdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new GreatOutdoorsException(ex.Message);
            }
            return isupdated;
        }
        //Function to add a product
        public bool AddProductDAL(Product product)
        {
            bool productAdded = false;
            try
            {
                productList.Add(product);
                productAdded = true;
            }
            catch(SystemException ex)
            {
                throw new GreatOutdoorsException(ex.Message);
            }

            return productAdded;
        }

        //Function to delete a product
        public bool DeleteProductDAL(int productID)
        {
            bool productDeleted = false;
            try
            {
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].ProductID == productID)
                    {
                        productList.Remove(productList[i]);
                        productDeleted = true;
                    }
                }
            }
            catch(DbException ex)
            {
                throw new GreatOutdoorsException(ex.Message);
            }

            return productDeleted;
        }

        //Function to Update Price
        public bool UpdateProductPriceDAL(int productID,double price)
        {
            bool priceUpdated = false;
            try
            {
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].ProductID == productID)
                    {
                        productList[i].ProductPrice=price;
                        priceUpdated = true;
                    }
                }
            }
            catch(SystemException ex)
            {
                throw new GreatOutdoorsException(ex.Message);
            }
            return priceUpdated;

        }

    }
        

}




