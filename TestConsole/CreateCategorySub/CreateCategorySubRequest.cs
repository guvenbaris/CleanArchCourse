using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TestConsole.CreateCategorySub
{
    public class CreateCategorySubRequest : IRequest<CreateCategorySubResponse>
    {
        public int CategoryId { get; set; } 
        public string CategorySubName { get; set; }
    }
}
