using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchCourse.Application.Dtos
{
    public class CategorySubDetailDto
    {
        public string CategorySubName { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
