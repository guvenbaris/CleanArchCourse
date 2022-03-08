using System;
using TestConsole.MediatorPatternDeneme;

using TestConsole.CreateCategorySub;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConreteMediator conreteMediator = new ConreteMediator();

            CreateCategorySubRequest request = new CreateCategorySubRequest
            {
                CategoryId = 1,
                CategorySubName = "Merhaba",
            };

            Console.WriteLine(conreteMediator.Send(request));
        }
    }
}
