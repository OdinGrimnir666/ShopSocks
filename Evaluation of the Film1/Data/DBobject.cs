using Evaluation_of_the_Film1.Models;

namespace Evaluation_of_the_Film1.Data
{
    public class DBobject
    {
        public static void initial(AppDbContent content)
        {
            if(!content.SocksCategories.Any())
            {
                content.SocksCategories.AddRange(Categories.Select(c=>c.Value ));
            }


            if (!content.Floor.Any())
            {
                content.Floor.AddRange(Floor.Select(c => c.Value));
            }

            if(!content.Socks.Any())
            {
                content.AddRange(
                    new Socks
                    {
                        Name = "The Pair of Socks Night Star",
                        floor = Floor["Мужские"],
                        longDesc = "1 пара в упаковке. Изготовлены из гребеночного хлопка высокого качества, комфортны и мягки на ощупь",
                        shortDesc = "Темно-синие носки The Pair of Socks",
                        img = "/img/1.jpg",
                        price = 50,
                        SocksCategory = Categories["everyday"]
                    },

                   createsock("The Pair of Socks Senator", Floor["Женские"], "Изготовлены из гребеночного хлопка высокого качества, комфортны и мягки на ощупь.", "Темно-синие носки", "/img/2.jpg", 45, Categories["everyday"]),

                    createsock("Лео Kanada", Floor["Женские"], "Хорошо впитывают влагу, давая ощущение сухости ногам", "Зимнее теплые темоноски", "/img/3.jpg", 70, Categories["everyday"]),

                   createsock("Punto Blanco ", Floor["Мужские"], "Мужские носки Punto Blanco сочетают модный дизайн и многолетний успешный опыт производства носков.", "Низкие мужские носки", "/img/4.jpg", 78, Categories["everyday"])
                );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Floor> floor;
        public static Dictionary<string, Floor> Floor
        {
            get
            {
                if (floor== null)
                {
                    var list = new Floor[]
                    {
                           new Floor{name="Мужские"},
                           new Floor{name="Женские"}
                    };
                    floor= new Dictionary<string, Floor>();
                    foreach (var el in list)
                    {
                        floor.Add(el.name, el);
                    }
                }
                return floor;
            }
        }

        private static Dictionary<string, SocksCategory> category;
        public static Dictionary<string,SocksCategory> Categories
        {
            get
            {
                if(category==null)
                {
                    var list = new SocksCategory[]
                    {
                    new SocksCategory{namecategory="sport",desk="носки для спорта"},
                    new SocksCategory{namecategory="everyday", desk="павседневные"}
                    };
                    category = new Dictionary<string, SocksCategory>();
                    foreach ( var el in list)
                    {
                        category.Add(el.namecategory, el);
                    }
                }
                return category;
            }
        }
        public static Socks createsock(string name, Floor floor, string longDesc, string shortDesc, string img, ushort price, SocksCategory sockscategory)
        {
            return new Socks { Name = name, floor = floor, longDesc = longDesc, shortDesc = shortDesc, img = img, price = price, SocksCategory = sockscategory };
        } 
    }
}
