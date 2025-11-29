using Bogus;

namespace Types
{
    [QueryType]
    public class Query
    {
        // Global Faker instances
        private static readonly Faker<StudentType> _studentFaker = new Faker<StudentType>()
            .RuleFor(s => s.Id, f => Guid.NewGuid())
            .RuleFor(s => s.FirstName, f => f.Name.FirstName())
            .RuleFor(s => s.LastName, f => f.Name.LastName())
            .RuleFor(s => s.GPA, f => f.Random.Decimal(2.0m, 4.0m));

        private static readonly Faker<InstructorType> _instructorFaker = new Faker<InstructorType>()
            .RuleFor(i => i.Id, f => Guid.NewGuid())
            .RuleFor(i => i.FirstName, f => f.Name.FirstName())
            .RuleFor(i => i.LastName, f => f.Name.LastName())
            .RuleFor(i => i.Salary, f => f.Random.Decimal(40000m, 120000m));

        private static readonly Faker<CourseType> _courseFaker = new Faker<CourseType>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.Name, f => f.PickRandom(
                "Introduction to Computer Science",
                "Advanced Mathematics",
                "World History",
                "Chemistry Fundamentals",
                "Physics 101",
                "Calculus I",
                "Biology Basics",
                "Ancient Civilizations",
                "Algebra II",
                "Environmental Science"
            ))
            .RuleFor(c => c.Instructor, f => _instructorFaker.Generate())
            .RuleFor(c => c.Students, f => _studentFaker.Generate(f.Random.Int(5, 15)));

        // In-memory storage for generated courses
        private static readonly List<CourseType> _courses = _courseFaker.Generate(10);

        public IEnumerable<CourseType> GetCourses()
        {
            return _courses;
        }

        public CourseType? GetCourse(Guid id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}