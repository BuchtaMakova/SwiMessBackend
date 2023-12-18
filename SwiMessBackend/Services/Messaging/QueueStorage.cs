using SwiMessBackend.Models.Messaging;

namespace SwiMessBackend.Services.Messaging
{
    public class QueueStorage
    {
        public List<MessageStorage> Queues { get; set; }

        public QueueStorage()
        {
            this.Queues = new List<MessageStorage>();
        }
    }
}
