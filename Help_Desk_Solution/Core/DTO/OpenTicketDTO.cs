using Help_Desk_Solution.Domain.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using static Help_Desk_Solution.Domain.Models.Ticket;

namespace Help_Desk_Solution.Core.DTO
{
    public class OpenTicketDTO
    {
        public string title { get; set; }
        public string message { get; set; }
        public ImageDTO image { get; set; }

        public string CategoryId { get; set; }

    }
}
