using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        crowdContext DataContext { get; }
    }

}
