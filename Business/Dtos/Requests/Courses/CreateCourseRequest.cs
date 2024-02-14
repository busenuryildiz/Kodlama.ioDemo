using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.Courses
{
    public class CreateCourseRequest
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public string Description { get; set; }
        public string? ImgPath { get; set; }
    }
}
