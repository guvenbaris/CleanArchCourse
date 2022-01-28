using System;

namespace CleanArchCourse.Application.Exceptions
{
    public class NotFoundExceptions : Exception
    {
        public NotFoundExceptions(string name, object key) :base($"Entity '{name}' ({key}) was not found")
        {
            
        }
    }
}
