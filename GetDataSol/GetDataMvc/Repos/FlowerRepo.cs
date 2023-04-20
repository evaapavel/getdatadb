using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GetDataMvc.ORM;
using GetDataMvc.BusinessObjects;

namespace GetDataMvc.Repos
{
    public class FlowerRepo
    {



        private MssqlDbContext context;



        public FlowerRepo()
        {
            this.context = new MssqlDbContext();
        }



        public List<Flower> GetList()
        {
            var query = from f in this.context.Flowers
                            //where true
                        select f
            ;

            var list = query.ToList<Flower>();

            return list;
        }



        public Flower Load(Flower flower)
        {
            return this.context.Flowers.Find(flower.ID);
        }




    }
}
