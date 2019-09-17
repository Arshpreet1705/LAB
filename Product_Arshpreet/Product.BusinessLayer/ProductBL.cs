using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoors.Entities;
using GreatOutdoors.Exceptions;
using GreatOutdoors.DataAccessLayer;

namespace GreatOutdoors.BusinessLayer
{
    public class ProductBL
    {
        private bool ValidateProductBL(Product product)
        {
            StringBuilder sb = new StringBuilder();
            bool validProduct = true;
            string s = Convert.ToString(product.ProductID);

            if (s.Length != 4)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Invalid ");
            }
            if (product.ProductDescription == string.Empty)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Description Required");
            }            
            if (product.ProductQuantity< 0)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Quantity in cart can't be negative");
            }           
            if (product.ProductPrice < 0.0)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Product price can't be negative");
            }
            if (product.ProductCategory != "Camping Equipment" || product.ProductCategory != "Golf Equipment" || product.ProductCategory != "Mountaineering Equipment" || product.ProductCategory != "Outdoor Protection" || product.ProductCategory != "Personal Accessories")
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Invalid product category");
            }
            if (validProduct == false)
            {
                throw new GreatOutdoorsException(sb.ToString());
            }

            return validProduct;

        }
        public List<Product> GetAllProductsBL()
        {
            List<Product> productList = null;
            List<Product> tempList = null;
            bool isvalid = true;
            try
            {
                ProductDAL productDAL = new ProductDAL();
                tempList = productDAL.GetAllProductsDAL();
                for (int i = 0; i < tempList.Count; i++)
                {
                    if (ValidateProductBL(tempList[i]) != true)
                    {
                        isvalid = false;
                        break;

                    }
                }
                if (isvalid == true)
                {
                    productList = tempList;
                }
            }
            catch (GreatOutdoorsException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productList;
        }

        public Product GetProductByProductIDBL(int p_id)
        {
            Product getProduct = null;
            Product tempProduct = null;
            bool isValid;
            try
            {
                ProductDAL productDAL = new ProductDAL();
                tempProduct = productDAL.GetProductByProductIDDAL(p_id);
                isValid = ValidateProductBL(tempProduct);
                if (isValid == true)
                {
                    getProduct = tempProduct;
                }
            }
            catch (GreatOutdoorsException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return getProduct;
        }
        public bool UpdateProductDescriptionBL(int p_id, string desc)
        {
            bool productUpdated = false;
            bool tempUpdated = false;
            try
            {
                ProductDAL product = new ProductDAL();
                tempUpdated = product.UpdateProductDescriptionDAL(p_id, desc);

                if (desc != null)
                {
                    productUpdated = tempUpdated;
                }

            }
            catch (GreatOutdoorsException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productUpdated;

        }
        public bool AddProductBL(Product newProduct)
        {
            bool productAdded = false;

            try
            {
                if (ValidateProductBL(newProduct))
                {
                    ProductDAL productDAL = new ProductDAL();
                    productAdded = productDAL.AddProductDAL(newProduct);
                }
            }
            catch (GreatOutdoorsException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productAdded;
        }
        public bool DeleteProductBL(int productID)
        {
            bool productDeleted = false;
            try
            {
                if (productID > 0)
                {
                    ProductDAL productDAL = new ProductDAL();
                    productDeleted = productDAL.DeleteProductDAL(productID);
                }
                else
                {
                    throw new GreatOutdoorsException("Invalid ID");
                }

            }
            catch (GreatOutdoorsException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productDeleted;
        }
        public bool UpdateProductPriceBL(int product_id, double price)
        {
            bool priceUpdated = false;

            try
            {
                ProductDAL product = new ProductDAL();
                string s = Convert.ToString(product_id);
                if(s.Length==4 && price>=0.0)
                {
                    priceUpdated = product.UpdateProductPriceDAL(product_id,price);
                }
                else
                {
                    throw new GreatOutdoorsException("Invalid type or invalid price!");
                }

            }
            catch(GreatOutdoorsException)
            {
                throw;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return priceUpdated;

        }

    }



}
