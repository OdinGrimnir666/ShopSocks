using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.Models;

namespace Evaluation_of_the_Film1.Data.Repository
{
    public class FlorrREpositary:ISocksfloor
    {
        private readonly AppDbContent appDbContent;

        public FlorrREpositary(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Floor> GetFloor => appDbContent.Floor;
    }
}
