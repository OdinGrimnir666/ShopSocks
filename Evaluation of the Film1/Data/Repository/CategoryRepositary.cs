using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.Models;

namespace Evaluation_of_the_Film1.Data.Repository
{
    public class CategoryRepositary : ISocksCategory
    {
        private readonly AppDbContent appDbContent;

        public CategoryRepositary(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<SocksCategory> AllCategory => appDbContent.SocksCategories;
    }
}
