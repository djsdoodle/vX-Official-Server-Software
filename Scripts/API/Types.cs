using System.Collections.Generic;
using System.Linq;

namespace vX.API.Types{
    public class Portfolio{
        public int PortfolioID { get; set; }
        public List<Order> Orders { get; set; }
        public float Money { get; set; }
    }

    public class Order{
        public int PortfolioID { get; set; }
        public float Price { get; set; }
        public Stock stock { get; set; }
    }

    public class Stock{
        public string Name { get; set; }
        public string Description { get; set; }
        public float Ask;
        public float Bid;
        public List<Order> SellList = new List<Order>{};
        public List<Order> BuyList = new List<Order>{};
        public string Symbol { get; set; }
        public void Sort(){
            SellList = SellList.OrderBy(o => o.Price).ToList();
            BuyList = BuyList.OrderByDescending(o => o.Price).ToList();
        }
    }
}