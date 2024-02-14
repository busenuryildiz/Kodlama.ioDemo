using Business.Dtos.Requests.Users;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Instructors
{
    public class CreateInstructorRequest
    {
         public CreateUserRequest User { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
