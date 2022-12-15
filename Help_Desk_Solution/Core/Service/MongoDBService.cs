using Help_Desk_Solution.Core.DTO;
using Help_Desk_Solution.Core.ResponseDTO;
using Help_Desk_Solution.Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Net;
using static Help_Desk_Solution.Domain.Models.Ticket;

namespace Help_Desk_Solution.Core.Service
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Ticket> _ticketCollection;

        public MongoDBService(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            _ticketCollection = database.GetCollection<Ticket>(mongoDBSettings.Value.CollectionName);
        }

        public async Task<ResponseDTO<OpenTicketResponseDTO>> AddTicketAsync(OpenTicketDTO openTicketDTO)
        {
             List<ImageDTO> imageList = new List<ImageDTO>()
            {
                new ImageDTO()
                {
                     ImageURL = openTicketDTO.image.ImageURL
                },
            };
            var ticket = new Ticket
            {
                Title = openTicketDTO.title,
                Message = openTicketDTO.message,
                CategoryId = openTicketDTO.CategoryId,
                Image= imageList,
                TicketStatus = "OPEN"
            };
            await _ticketCollection.InsertOneAsync(ticket);            
            if (ticket == null)
            {
               var res =ResponseDTO<OpenTicketResponseDTO>.Fail("could not create ticket", (int)HttpStatusCode.InternalServerError);
                return res;
                
            }

            var response = ResponseDTO<OpenTicketResponseDTO>.Success("ticket successfullly created", new OpenTicketResponseDTO { Id = ticket.Id }, (int)HttpStatusCode.OK);
            return response;
        }
        public async Task UpdateTicket ()
        {

        }
    }
    
}

