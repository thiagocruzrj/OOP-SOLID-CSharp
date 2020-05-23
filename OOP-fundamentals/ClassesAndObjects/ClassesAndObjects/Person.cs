namespace ClassesAndObjects
{
    class Person
    {
        public string Name;
        public int Age;
        public string Gender;

        public void Characteristics()
        {
            System.Console.WriteLine($"My name is {Name}, i've {Age} years old and i'm a {Gender}");
        }
    }
}
