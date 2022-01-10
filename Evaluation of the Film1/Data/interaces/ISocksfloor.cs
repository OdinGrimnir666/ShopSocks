using Evaluation_of_the_Film1.Models;

namespace Evaluation_of_the_Film1.interaces
{
    public interface ISocksfloor
    {
        IEnumerable<Floor> GetFloor { get; }
    }
}
