using Evaluation_of_the_Film1.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluation_of_the_Film1.Data.Models
{
    public class ShopSocks
    {
        private readonly AppDbContent appDbContent;

        public ShopSocks(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public string shopSocksid { get; set; }
         
        public List<SocksITem> listsocksitem { get; set; }

        public static ShopSocks Getsocks(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDbContent>();

            string shopsocksid = session.GetString("socksid") ?? Guid.NewGuid().ToString();
            session.SetString("socksid", shopsocksid);

            return new ShopSocks(context)
            {
                shopSocksid = shopsocksid
            };
        }

        public void AddtoSocks(Socks socks)
        {
            appDbContent.SocksITem.Add(new SocksITem
            {
                 shopSocksid=shopSocksid, 
                 socks=socks,
                 price=socks.price
            });

            appDbContent.SaveChanges();
        }

        public List<SocksITem> Getshopitems()
        {
            return appDbContent.SocksITem.Where(c => c.shopSocksid == shopSocksid).Include(s => s.socks).ToList();
        }
    }
}
