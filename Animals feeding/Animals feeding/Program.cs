namespace Animals_feeding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new AnimalsFeedProcessor();
            var lionCage = new AnimalPlace("Lion", "Meat");
            var tigerCage = new AnimalPlace("Tiger", "Fish");

            processor.AddNewAnimalPlace(lionCage);
            processor.AddNewAnimalPlace(tigerCage);

            lionCage.Feed(5);
            tigerCage.Feed(0);

            processor.FeedAll();

            processor.Dispose();
        }
    }
}