namespace Evaluation_of_the_Film1.Models
{
    public class SocksCategory
    {
        public int Id { get; set; }  

        public string namecategory { get; set; }

        public string desk { get; set; }

        public List<Socks> socks { set; get; } 
    }
}
