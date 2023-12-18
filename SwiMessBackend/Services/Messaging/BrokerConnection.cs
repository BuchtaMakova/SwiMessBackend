using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore.Metadata;
using RabbitMQ.Client;
using IModel = RabbitMQ.Client.IModel;

namespace SwiMessBackend.Services.Messaging
{
    public class BrokerConnection
    {
        public IModel? Channel { get; private set; }
        public string? Exchange;

        public BrokerConnection()
        {
            Exchange = "exchange";
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
                VirtualHost = "/"
            };
            var connection = factory.CreateConnection();
            Channel = connection.CreateModel();
            Channel.ExchangeDeclare(Exchange, ExchangeType.Direct);
        }
    }
}
