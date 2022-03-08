using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.CreateCategorySub
{
    public class CreateCategorySubResponse :IResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; } = true;
    }
}
