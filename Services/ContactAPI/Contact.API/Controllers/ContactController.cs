using ContactAPI.Infrastructure;
using ContactAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService ContactService)
        {
            _contactService = ContactService;
        }

        [HttpGet("{Id}")]
        public ContactDTO Get(int Id)
        {
           return _contactService.GetContactById(Id);
        }
    }
}
