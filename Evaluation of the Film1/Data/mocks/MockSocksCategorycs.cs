using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.Models;

namespace Evaluation_of_the_Film1.mocks
{
    public class MockSocksCategorycs : ISocksCategory
    {
        public IEnumerable<SocksCategory> AllCategory
        {
            get
            {
                return new List<SocksCategory>
                {
                    new SocksCategory{namecategory="sport",desk="носки для спорта"},
                    new SocksCategory{namecategory="everyday", desk="павседневные"}
                };  
            }
        }
    }
}
