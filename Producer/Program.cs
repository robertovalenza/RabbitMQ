using System;
using RabbitMQ.Client;
using System.Text;


class Program
{
    public static void Main()
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            Console.WriteLine("Routing Key: ");
            var routingKey = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Messaggio");
                string message = Console.ReadLine();
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "", routingKey: routingKey, basicProperties: null, body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
        }
        Console.WriteLine(" Press [enter] to exit.");
        Console.ReadLine();

    }

}