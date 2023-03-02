using ContactAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactAPI.Infrastructure
{
    public interface IContactService
    {
        public ContactDTO GetContactById(int id);
    }
}
