using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.Models;

namespace Evaluation_of_the_Film1.mocks
{
    public class MockSocksFloor : ISocksfloor
    {
        public IEnumerable<Floor> GetFloor
        {
            get {
                return new List<Floor>
            {
                new Floor{name="Мужские"},
                new Floor{name="Женские"}
            };
           }   
        }
    }
}
