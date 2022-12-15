using Help_Desk_Solution.Core.DTO;
using Help_Desk_Solution.Core.Service;
using Help_Desk_Solution.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Help_Desk_Solution.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly MongoDBService _mongoDBService;

        public TicketController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        [HttpPost]
        [Route("Open-ticket")]

        public async Task<IActionResult> AddTicket([FromBody]OpenTicketDTO openTicketDTO)
        {
            var result = await _mongoDBService.AddTicketAsync(openTicketDTO);
            return Ok(result);
        
        }

        [HttpPatch]
        [Route("update-ticket")]
        public async Task<IActionResult> UpdateTicket(OpenTicketDTO model)
        {
            return Ok(model);
        }
       
        /*
        [HttpPatch]
        [Route("close-ticket")]
        public async Task<IActionResult> CloseTicket(CloseTicketDTO model)
        {
            return Ok(model);
        }

        [HttpPatch]
        [Route("escalate-ticket")]
        public async Task<IActionResult> UpdateTicket(bool isEscalated)
        {
            return Ok(isEscalated);
        }

        [HttpPatch]
        [Route("assign-ticket")]
        public async Task<IActionResult> AssignTicket(string userId)
        {
            return Ok(userId);
        }

        [HttpPatch]
        [Route("escalate-to-ticket")]
        public async Task<IActionResult> UpdateTicket(string userId)
        {
            return Ok(userId);
        }

        [HttpPost]
        [Route("create-comment")]
        public async Task<IActionResult> CreateComment(CreateCommentDTO model)
        {
            return Ok(model);
        }
        [HttpPatch]
        [Route("update-comment")]
        public async Task<IActionResult> UpdateComment(CreateCommentDTO model)
        {
            return Ok(model);
        }
        [HttpDelete]
        [Route("delete-comment")]
        public async Task<IActionResult> DeleteComment(string commentId)
        {
            return Ok(commentId);
        }
        [HttpGet]
        [Route("Get-all-ticket")]
        public async Task<IActionResult> GetTicketById(string ticketId)
        {
            return Ok(ticketId);
        }
        [HttpGet]
        [Route("get-all-ticket")]
        public async Task<IActionResult> GetAllTicket()
        {
            return null;
        }
        [HttpGet]
        [Route("get-all-ticket-assigned-to-a-user")]
        public async Task<IActionResult> GetAllTicketByUserId(string ticketId)
        {
            return Ok(ticketId);
        }
        [HttpGet]
        [Route("get-ticket-by-user-and-category-reference")]
        public async Task<IActionResult> GetAllTicketByUserIdAndCategoryId(string ticketId, string categoryId)
        {
            return Ok(ticketId);
        }*/
        /*[HttpGet]
        [Route("get-all-ticket-assigned-to-a-user-by-category-reference")]
        public async Task<IActionResult> GetUserTicketByCategory(string CategoryId)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-ticket-by-user-and-status")]
        public Task<IActionResult> GetAllTicketByUserAndStatus(string UserId, string status)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-ticket-assigned-to-a-user-by-status")]
        public Task<IActionResult> GetAllAssignedTicetByStatus(string status)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-by-user-category-reference-and-status")]
        public Task<IActionResult> GetAllTicket(string ticketId, string categoryId, string status)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-ticket-assigned-to-a-user-by-category-rference-and-status")]
        public Task<IActionResult> GetAllAssignedTicketByUserIdCategoryIdStatus(string ticketId, string categoryId, string status)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-tickets-by-user-Id")]
        public Task<IActionResult> GetAllTicketByUserId(string ticketId, string userId)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-tickets-assigned-by-user-Id")]
        public Task<IActionResult> GetAllTicketAssignedByUserId(string ticketId, string userId)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-tickets-by-user-Id-and-status")]
        public Task<IActionResult> GetAllTickeByUserIdAndStatus(string ticketId, string status)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-tickets-assigned-by-user-Id-and-status")]
        public Task<IActionResult> GetAllTicketAssignedByUserIdAndStatus(string ticketId, string userId)
        {
            return reference;
        }
        [HttpPost]
        [Route("service-ticket")]
        public Task<IActionResult> ServiceTicket(string message, DateTime completionTime)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-ticket-summary")]
        public Task<IActionResult> GetTicketSummary()
        {
            return reference;
        }
        [HttpGet]
        [Route("get-escalated-ticket-by-user-Id")]
        public Task<IActionResult> GetEscalatedTicketByUserId(string userId)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-escalated-tickets-assigned-by-user-Id")]
        public Task<IActionResult> GetAllEscalatedTicketAssignedByUserId(string userId)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-all-tickets-assigned-by-user-Id")]
        public Task<IActionResult> GetAllTicketAssignedByUserId(string userId)
        {
            return reference;
        }
        [HttpGet]
        [Route("get-most-recent-ticket")]
        public Task<IActionResult> GetMostRecentTicket()
        {
            return reference;
        }
        [HttpGet]
        [Route("get-escalted-tickets-assigned-to-user")]
        public Task<IActionResult> GetAllTicketAssignedToUser(string userId)
        {
            return reference;
        }*/
    }  
}

