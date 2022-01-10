using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.Models;
using System.Linq;

namespace Evaluation_of_the_Film1.mocks
{
    public class MockIallSocks : IAllSocks
    {
        private readonly ISocksCategory _sockscategory = new MockSocksCategorycs();
        private readonly ISocksfloor _sockfloor = new MockSocksFloor();
        public IEnumerable<Socks> AllSocks
        {
            get
            {
                return new List<Socks>
                {
                    new Socks {Name="The Pair of Socks Night Star",floor=_sockfloor.GetFloor.Last(),
                    longDesc="1 пара в упаковке. Изготовлены из гребеночного хлопка высокого качества, комфортны и мягки на ощупь",shortDesc="Темно-синие носки The Pair of Socks",img="/img/1.jpg",
                    price=50, SocksCategory=_sockscategory.AllCategory.Last()},

                   createsock("The Pair of Socks Senator",_sockfloor.GetFloor.Last(),"Изготовлены из гребеночного хлопка высокого качества, комфортны и мягки на ощупь.","Темно-синие носки","/img/2.jpg",45,_sockscategory.AllCategory.First()),
                   
                   createsock("Лео Kanada",_sockfloor.GetFloor.First(),"Хорошо впитывают влагу, давая ощущение сухости ногам","Зимнее теплые темоноски","/img/3.jpg",70,_sockscategory.AllCategory.First()),

                   createsock("Punto Blanco ",_sockfloor.GetFloor.First(),"Мужские носки Punto Blanco сочетают модный дизайн и многолетний успешный опыт производства носков.","Низкие мужские носки","/img/4.jpg",78,_sockscategory.AllCategory.Last())


                     };
            }
        }

        public Socks createsock(string name ,Floor floor,string longDesc,string shortDesc,string img,ushort price,SocksCategory sockscategory)
        {
            return new Socks { Name = name, floor = floor,longDesc=longDesc,shortDesc=shortDesc,img=img,price=price, SocksCategory = sockscategory };
        }

                
            


        public Socks getobjectcat(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
