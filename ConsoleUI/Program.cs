using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetAllByPrice(0,200)) // 0 ile 200 Fiyat Aralığındaki Ürünler
            {
                Console.WriteLine("Product Name : " + item.ProductName +" / " + "Available in Stock : " + item.UnitsInStock);
            }
        }
    }
}
