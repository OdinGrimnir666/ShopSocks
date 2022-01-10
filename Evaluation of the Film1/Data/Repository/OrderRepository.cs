using Evaluation_of_the_Film1.Data.interaces;
using Evaluation_of_the_Film1.Data.Models;

namespace Evaluation_of_the_Film1.Data.Repository
{
    public class OrderRepository : IALlordercs
    {
        private readonly AppDbContent appDBcontext;
        private readonly ShopSocks shopsocks;

        public OrderRepository(AppDbContent appDbcontext,ShopSocks shopsocks)
        {
            this.appDBcontext=appDbcontext;
            this.shopsocks = shopsocks;
        }



        public void createOder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBcontext.Order.Add(order);
            var items = shopsocks.listsocksitem;

            foreach (var item in items)
            {
                var orderdeteil = new OrderDeteil()
                {
                    SocksID = item.socks.Id,
                    orderID = order.id,
                    price = item.socks.price
                };
                appDBcontext.OrderDeteil.Add(orderdeteil);
            }
            appDBcontext.SaveChanges();
        }
    }
}
