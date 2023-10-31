using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CaseStudy.CustomException.MyException;

namespace CaseStudy
{
    internal class Product
    {

        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public static void AddProduct(DigitalProduct product)
        {
            if (product.ProductId <= 0)
            {
                throw new UserException(MyException.Errors[1]);
            }
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new UserException(MyException.Errors[4]);
            }
            if (product.Price <= 0)
            {
                throw new UserException(MyException.Errors[3]);
            }
            if (product.StockQuantity <= 0)
            {
                throw new UserException(MyException.Errors[2]);
            }

        }
        public static void AddProducts(PhysicalProduct product)
        {
            if (product.ProductId <= 0)
            {
                throw new UserException(MyException.Errors[1]);
            }
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new UserException(MyException.Errors[4]);
            }
            if (product.Price <= 0)
            {
                throw new UserException(MyException.Errors[5]);
            }
            if (product.Weight <= 0)
            {
                throw new UserException(MyException.Errors[6]);
            }


        }

    }
}
