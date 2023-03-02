using ContactAPI.Infrastructure;
using ContactAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactAPI.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO()
            {
                Id = id,
                FirstName = "Dilek",
                LastName = "Karakaya"
            };
        }
    }
}
