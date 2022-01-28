using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Commands.UpdateCategorySub
{
    public class UpdateCategorySubRequest
    {
        public string CategorySubName { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}

