namespace Evaluation_of_the_Film1.Models
{
    public class Socks
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public int floorid { set; get; }

        public virtual Floor floor { set; get; }    

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        public int sockscategoryid { set; get; }

        public virtual SocksCategory SocksCategory { set; get;}


        


    }
}
