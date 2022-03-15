using System;

namespace _15032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(44,18);
            string priceStr;
            //do
            //{
            //    Console.WriteLine("Qiymeti daxil edin");
            //    priceStr = Console.ReadLine();

            //} while (!double.TryParse(priceStr,out product.Price) || product.Price<0);


            //product.Price = -45;
            //product.PriceSetter(45);
            product.Price = 50;
            product.Name = "     ";
            product.Age = 133;
            product.DiscountPercent = 40;

            Console.WriteLine(product.Price);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Age);
            Console.WriteLine(product.DiscountedPrice);
            Console.WriteLine(product.Tax);

            Human human = new Human();
            human.Name = "Ali";
            Console.WriteLine(human.Name);
           Student student = new Student("Hikmet", "Abbasov");
            student.Name = "Ali";
            Console.WriteLine(student.Name);



        }
    }
}
