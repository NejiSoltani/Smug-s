using Data.Models;
using MyFinance.Data.Infrastructure;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service
{
    public class ContactService : Service<contact>
    {
        public static IDatabaseFactory db = new DatabaseFactory();
        public static IUnitOfWork u = new UnitOfWork(db);

        public ContactService() : base(u)
        {
        }


     /*   public IEnumerable<comment> getTestById(int id)
        {

            return u.getRepository<comment>()
                .GetMany(x => x.idComment == id);
        }

        public IEnumerable<comment> getAll()
        {

            return u.getRepository<comment>()
                .GetMany();
        }*/

    }
}