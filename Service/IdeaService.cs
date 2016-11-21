using Data.Models;
using MyFinance.Data.Infrastructure;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class IdeaService : Service<idea>
    {
        public static IDatabaseFactory db = new DatabaseFactory();
        public static IUnitOfWork u = new UnitOfWork(db);

        public IdeaService() : base(u)
        { }

        public IEnumerable<idea> getTestById(int id)
        {

            return u.getRepository<idea>()
                .GetMany(x => x.idIdea == id);
        }




        public IEnumerable<idea> getReportedIdea()
        {

            return u.getRepository<idea>()
                .GetMany(x => x.isReported == true);
        }





        public customer getCustomers(int id)
        {           
            CustomerService customerserv = new CustomerService();
            return customerserv.GetById(id);         
        }






        public int getNbrofLikesById(int id)
        {
            int nb = 0;
            List<idea> a = new List<idea>();

            Like2Service like2service = new Like2Service();
            List<like2> listelike = like2service.GetMany().ToList();
            foreach(like2 l in listelike)
            {
                if(l.idea_idIdea==id)
                {
                    nb++;
                }
            }
            return nb;
            //return u.getRepository<idea>()
            //    .GetMany(x => x.idIdea == id);
        }










    }
}
