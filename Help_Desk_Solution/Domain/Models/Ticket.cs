

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Help_Desk_Solution.Domain.Models
{
    public class Ticket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string CategoryId { get; set; }
        public string Message { get; set; }
        public List<ImageDTO> Image { get; set; } = null;
        public List<CommentDTO> Comment { get; set; }
        public List<ActivityDTO> Activity { get; set; }
        public string TicketStatus { get; set; }
        
        public DateTime TimeStamp
        {
            get; set;


        }
        public class ImageDTO
        {
            public string ImageURL { get; set; }
        }
        public class CommentDTO
        {
            public string message { get; set; }
            public DateTime TimeStamp { get; set; }
        }
        public class ActivityDTO
        {
            public string Message { get; set; }
            public DateTime CompletionTime { get; set; }
            public string Status
            {
                get { return Status; }
                set
                {
                    if (value == "INPROGRESS" || value == "COMPLETED")
                    {
                        Status = value;
                    }
                    else
                    {
                        Status = "UNKNOWN";
                    }
                }
            }
        }
            public enum roles
            {
                Admin,
                User
            }
    }
}

