using System;
using System.Linq;
using RefactoringDemo.Domain;

namespace RefactoringDemo.Logic
{
    public class PrintingLogic
    {
        public void PrintOrder(Order order)
        {
            Action<Order> defaultPrint = delegate(Order o)
            {
                Console.WriteLine("Printing order {0} with default behavior...", o.OrderId);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Printed Order {0}", o.OrderId);
            };

            Action<Order> indiciumAndPrint = delegate(Order o)
            {
                Console.WriteLine("Printing order {0} with Generate Indicium behavior...", o.OrderId);
                Console.WriteLine("Generate some Indiciums for order {0}...", o.OrderId);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Indiciums Generated for order {0}", o.OrderId);
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("Printed Order {0}", o.OrderId);
            };

            if (order.Indiciums != null && order.Indiciums.Any())
            {
                order.Print(defaultPrint);                
            }
            else
            {
                order.Print(indiciumAndPrint);
            }
        }
    }
}