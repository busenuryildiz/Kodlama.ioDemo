using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Instructors
{
    public class GetListInstructorResponse
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
