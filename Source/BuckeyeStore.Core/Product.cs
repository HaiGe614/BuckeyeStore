using System;

namespace BuckeyeStore.Core
{
    public class Product
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public string Brand {get; set;}
        public Review Review {get; set;}
        public AggregateRating AggregateRating {get; set;}
        public List<Offer> Offers {get; set;}
        public String Sku {get; set;}

        public void AddReview(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
