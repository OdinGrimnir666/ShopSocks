using Evaluation_of_the_Film1.Models;

namespace Evaluation_of_the_Film1.interaces
{
    public interface IAllSocks
    {
        public IEnumerable<Socks> AllSocks { get;}

        Socks getobjectcat(int carid);
    }
}
