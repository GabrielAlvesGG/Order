using System;
using Pedido.Entities;
using Pedido.Entities.Enuns;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do Usuario: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o e-mail :");
            string email = Console.ReadLine();
            Console.WriteLine("Digite a data de Nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            
            Client client = new Client(name,email, dataNascimento);
            
            Console.WriteLine("Diga o status do pedido");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime date = DateTime.Now;
            Order order = new Order(date,status, client);
            Console.WriteLine("Digite quantas ordens de pedidos será efetuada: ");
            int ordens = int.Parse(Console.ReadLine());

            for (int i = 1; i <= ordens; i++)
            {
                Console.WriteLine("Ordem de Pedido #" + i );
                Console.WriteLine("Nome do produto");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine("Quato custa o produto: ");
                double preco = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantidade de produtos: ");
                int quantidade = int.Parse(Console.ReadLine());

                Product produto = new Product(nomeProduto, preco);

                OrderItem orderitem = new OrderItem(quantidade, preco, produto);

                order.AddItem(orderitem);
            }
            
            Console.WriteLine(order);
            Console.WriteLine("Fim do programa!");
        }
    }
}
