namespace ClassesAndObjects
{
    class Car
    {
        public string Color;
        public int YearManufacture;
        public string Brand;

        public Car()
        {

        }

        public Car(string color)
        {
            Color = color;
        }

        public Car(string color, int yearManufacture, string brand)
        {
            Color = color;
            YearManufacture = yearManufacture;
            Brand = brand;
        }

        public void Characteristics()
        {
            System.Console.WriteLine($"My car is {Color}, from year {YearManufacture} by {Brand}");
        }
    }
}
