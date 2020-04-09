namespace DEV_2._1
{
    public class Car : Vehicle
    {
        public Car(string brandName, string model, string seialNumber, double price)
        {
            this.BrandName = brandName;
            this.Model = model;
            this.SerialNumber = seialNumber;
            this.Price = price;            
        }

        public Car()
        {
        }
    }
}