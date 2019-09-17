using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoors.Entities
{
    public class Product
    {
        private string _productCategory;

        public string ProductCategory { get => _productCategory; set => _productCategory = value; }

        private int _productID;

        public int ProductID { get => _productID; set => _productID = value; }

        private string _productDescription;

        public string ProductDescription { get => _productDescription; set => _productDescription = value; }

        private int _productQuantity;

        public int ProductQuantity { get => _productQuantity; set => _productQuantity = value; }

        private double _productPrice;

        public double ProductPrice { get => _productPrice; set => _productPrice = value; }

        public Product()
        {
            ProductCategory = "Camping Equipment";
            ProductID = 0000;
            ProductDescription = "The product has proved to be pretty useful when out for camping because of the robust material used in its manufacture.";
            ProductPrice = 0.0;
            ProductQuantity = 0;
        }
               
    }
}
