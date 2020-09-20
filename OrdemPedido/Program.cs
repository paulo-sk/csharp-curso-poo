using OrdemPedido.Entities;
using OrdemPedido.Entities.Enums;
using System;

namespace OrdemPedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //converter enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //converter string para enum
            //o valor à ser convertido para enum, deve ser exatamente igual a um dos valores suportados na classe enum que vc definiu
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}
