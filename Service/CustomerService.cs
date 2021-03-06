﻿using Data.Models;
using MyFinance.Data.Infrastructure;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomerService : Service<customer>
    {
        public static IDatabaseFactory db = new DatabaseFactory();
        public static IUnitOfWork u = new UnitOfWork(db);

        public CustomerService() : base(u)
        { }
    

    }
}
