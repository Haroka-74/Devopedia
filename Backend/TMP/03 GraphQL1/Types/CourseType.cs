namespace Types
{
    public enum Subject
    {
        Math,
        Science,
        History
    }

    public class CourseType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public InstructorType? Instructor { get; set; }
        public IEnumerable<StudentType>? Students { get; set; }
    }
}