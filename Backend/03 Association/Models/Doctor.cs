namespace _02_Association.Models
{
    public class Doctor
    {
        public void Treat(Patient patient)
        {
            Console.WriteLine($"Doctor is treating {patient.Name}");
        }
    }
}