using Evaluation_of_the_Film1.Models;

namespace Evaluation_of_the_Film1.Data.Models
{
    public class OrderDeteil
    {
        public int id { get; set; }

        public int orderID { get; set; }

        public int SocksID { get; set; }

        public uint price { get; set; }

        public virtual Socks socks { get; set; }

        public virtual Order order { get; set; }       
    }
}
