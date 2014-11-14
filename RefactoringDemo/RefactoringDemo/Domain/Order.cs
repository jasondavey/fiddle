using System;

namespace RefactoringDemo.Domain
{
    public class Order
    {
        public long OrderId { get; set; }

        public string[] Indiciums { get; set; }

        public void Print(Action<Order> strategy)
        {
            strategy(this);
        }
    }
}