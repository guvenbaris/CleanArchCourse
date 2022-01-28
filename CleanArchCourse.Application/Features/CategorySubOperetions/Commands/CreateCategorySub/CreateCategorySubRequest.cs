using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CleanArchCourse.Application.Features.CategorySubOperetions.Commands.CreateCategorySub
{
    public class CreateCategorySubRequest
    {
        public int CategoryId { get; set; } 
        public string CategorySubName { get; set; }
    }
}
