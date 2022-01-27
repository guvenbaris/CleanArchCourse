namespace CleanArchCourse.Domain.Abstract.Entity
{
    public interface IBasePerson<TType> : IBasePerson
    {
        public TType Name { get; set; }
        public TType Surname { get; set; }
    }

    public interface IBasePerson
    {

    }
}
