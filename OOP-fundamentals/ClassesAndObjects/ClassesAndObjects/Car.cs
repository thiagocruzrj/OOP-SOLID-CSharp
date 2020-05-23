namespace ClassesAndObjects
{
    class Car
    {
        public string Color;
        public int YearManufacture;
        public string Brand;

        public Car()
        {
            Color = "Red";
            YearManufacture = 2019;
            Brand = "Ford";
        }

        public void Characteristics()
        {
            System.Console.WriteLine($"My car is {Color}, from year {YearManufacture} by {Brand}");
        }
    }
}
