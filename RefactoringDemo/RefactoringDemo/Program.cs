using System;
using RefactoringDemo.Domain;
using RefactoringDemo.Logic;

namespace RefactoringDemo
{
    public class Program
    {
        private static void Main()
        {
            /* To solve this, simply use the strategy pattern by encapsulating each print behavior into its own class
             * then pass in that strategy into the printing method */

            var printingLogic = new PrintingLogic();

            var orderWithIndiciums = new Order
            {
                OrderId = 123456789,
                Indiciums = new[] {"dfdd","dds","zaa"}
            };

            var orderWithoutIndiciums = new Order{OrderId = 987654321};

            
            printingLogic.PrintOrder(orderWithIndiciums);
            printingLogic.PrintOrder(orderWithoutIndiciums);

            Console.WriteLine("Refactoring Demo Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}