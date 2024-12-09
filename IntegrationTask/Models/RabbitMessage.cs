namespace IntegrationTask.Models
{
    public class RabbitMessage
    {

        public required string RoutingKey { get; set; }

        public required string Message { get; set; }
    }
}
