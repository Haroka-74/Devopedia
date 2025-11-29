namespace _03_Aggregation.Models
{
    public class University
    {
        private readonly IList<Student> _students = [];
        public IReadOnlyList<Student> Students => _students.AsReadOnly();
        public void AddStudent(Student student) => _students.Add(student);
    }
}