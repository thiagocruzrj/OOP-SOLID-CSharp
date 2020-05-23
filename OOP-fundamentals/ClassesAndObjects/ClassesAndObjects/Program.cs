namespace ClassesAndObjects
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Jessica";
            person1.Age = 21;
            person1.Gender = "woman";
            person1.Characteristics();
        }
    }
}
