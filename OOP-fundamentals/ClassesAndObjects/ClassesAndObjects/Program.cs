namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car person1 = new Car("Blue", 2020, "Toyota");
            person1.Characteristics();

            Car person2 = new Car();
            person2.Color = "red";
            person2.YearManufacture = 2019;
            person2.Brand = "Honda";
            person2.Characteristics();

            Car person3 = new Car("black");
            person3.YearManufacture = 2017;
            person3.Brand = "Wolks";
            person3.Characteristics();
        }
    }
}