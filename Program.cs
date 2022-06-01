using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предлагаем скидку в зависимости от размера покупки. 
            Console.WriteLine("What is the purchase amount of your check in our store?");
            Console.WriteLine("Enter amount (integer) : ");
            int totalCost = Convert.ToInt32(Console.ReadLine());
            // Если покупка меньше 10
            if (totalCost < 10)
            {
                Console.WriteLine("Unfortunately next time there will be no discount.");
            }
            // Если покупка больше или равна 10 И меньше или равна 20
            else if (totalCost >= 10 && totalCost <= 20)
            {
                Console.WriteLine("Your discount on your next purchase in our store will be 1 euro");
            }
            // Если покупка больше 20 И меньше или равна 50
            else if (totalCost > 20 && totalCost <= 50)
            {
                Console.WriteLine("Your discount on your next purchase in our store will be 5 euro");
            }
            // Если покупка больше 50 И меньше или равна 100
            else if (totalCost > 50 && totalCost <= 100)
            {
                Console.WriteLine("Your discount on your next purchase in our store will be 10 euro");
            }
            // Любой другой случай
            else
            {
                Console.WriteLine("Your discount on your next purchase in our store will be 15 euro");
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}