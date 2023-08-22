using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ShopStore.Controller;

namespace ShopStore
{
    public static class Program
    {
        public static void MainMneu()
        {
            Console.WriteLine("Please Choose One Option");
            Console.WriteLine("1: Product");
            Console.WriteLine("2: Group Of Product");
            Console.WriteLine("3: Increase The Product Entity ");
            Console.WriteLine("4: Decrease The Product Entity");
            Console.WriteLine("5: Report Of Product");
            Console.WriteLine("6: Exit");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.Clear();
                    Product.product();
                    break;
                case 2:
                    Console.Clear();
                    ProductsGroup.productGroup();
                    break;
                case 3:
                    Console.Clear();
                    IncreaseTheProductEntity.increaseTheProductEntity();
                    break;
                case 4:
                    Console.Clear();
                    DecreaseTheEntityOfProduct.decreaseTheEntityOfProduct();
                    break;
                case 5:
                    Console.Clear();
                    ReportOfProduct.reportOfProduct();
                    break;
                case 6:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
        public static void Main(string[] args)
        {
            MainMneu();

        }
    }
}

