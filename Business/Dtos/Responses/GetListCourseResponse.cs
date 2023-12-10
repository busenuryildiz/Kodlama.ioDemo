using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses
{
    public class GetListCourseResponse
    {
        public Guid Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ImgPath { get; set; }
        public decimal UnitPrice { get; set; } = 0;
    }
}
