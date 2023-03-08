using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

ConnectionFactory factory = new();
factory.Uri = new("");

using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();



Console.Read();