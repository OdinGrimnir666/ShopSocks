using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.Models;
using Microsoft.EntityFrameworkCore;

namespace Evaluation_of_the_Film1.Data.Repository
{
    public class SocksRepositary : IAllSocks
    {
        private readonly AppDbContent appDbContent;

        public SocksRepositary(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Socks> AllSocks => appDbContent.Socks.Include(c=> c.SocksCategory);

        public Socks getobjectcat(int carid) => appDbContent.Socks.FirstOrDefault( p=> p.Id==carid);

    }
}
