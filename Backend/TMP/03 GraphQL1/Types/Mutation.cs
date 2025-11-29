namespace Types
{
    [MutationType]
    public class Mutation
    {
        private readonly List<CourseType> _courses;

        public Mutation()
        {
            _courses = new List<CourseType>();
        }

        public bool CreateCourse(string name, Guid instructorId)
        {
            var courseType = new CourseType()
            {
                Id = Guid.NewGuid(),
                Name = name,
                Instructor = new InstructorType()
                {
                    Id = instructorId
                }
            };

            _courses.Add(courseType);

            return true;
        }

    }
}

// see `GraphQLException`