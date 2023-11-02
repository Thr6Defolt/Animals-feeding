using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Animals_feeding
{
    public class AnimalPlace
    {
        public string Name {  get; set; }
        public string FeedName { get; set; }
        public event Action<string, AnimalPlace> FoodFinished;

        public AnimalPlace(string name, string feedName)
        {
            Name = name;
            FeedName = feedName;
        }
        public void Feed(int feedInt)
        {
            if (feedInt <= 0)
            {
                Console.WriteLine($"Feed out.");
                FoodFinished?.Invoke(FeedName, this);
            }
            else
            {
                Console.WriteLine($"All good.");
            }
        }
    }
}
