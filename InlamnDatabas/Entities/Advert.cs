using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlamnDatabas.Entities
{
    public class Advert
    {
        public int AdvertId { get; set; }
        public string AdvertTitle { get; set; }
        public string AdvertDescription { get; set; }
        public double AdvertPrice { get; set; }
        public DateTime AdvertDate { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }

        public Advert(int advertId, string advertTitle, string advertDescription, double advertPrice, DateTime advertDate, User user, Category category)
        {
            AdvertId = advertId;
            AdvertTitle = advertTitle;
            AdvertDescription = advertDescription;
            AdvertPrice = advertPrice;
            AdvertDate = advertDate;
            User = user;
            Category = category;
        }
    }
}
