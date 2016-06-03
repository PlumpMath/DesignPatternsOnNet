namespace DesignPatterns._01_PatternsOfBehavior_Chapter1.Strategy.InterfaceVsDelegate
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }
}
