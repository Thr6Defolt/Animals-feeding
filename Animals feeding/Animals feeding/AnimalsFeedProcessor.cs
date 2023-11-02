using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Animals_feeding.AnimalPlace;

namespace Animals_feeding
{
    internal class AnimalsFeedProcessor : IDisposable
    {
        private List<AnimalPlace> animalPlaces = new List<AnimalPlace>();
        public void AddNewAnimalPlace(AnimalPlace animalPlace)
        {
            animalPlace.FoodFinished += HandleFoodFinished;
            animalPlaces.Add(animalPlace);
        }
        public void FeedAll()
        {
            foreach (var animalPlace in animalPlaces)
            {
                animalPlace.Feed(10);
            }
        }
        private void HandleFoodFinished(string feedName, AnimalPlace animalPlace)
        {
            Console.WriteLine($"All g00d.");
        }
        public void Dispose()
        {
            foreach (var animalPlace in animalPlaces)
            {
                animalPlace.FoodFinished -= HandleFoodFinished;
            }
        }
    }
}
