namespace _04_Composition.Models
{
    public class House
    {
        private readonly IEnumerable<Room> _rooms;

        public House()
        {
            _rooms = [new("Bedroom"), new("Kitchen"), new("Living Room")];
        }

        public override string ToString() => $"[{string.Join(", ", _rooms)}]";
    }
}