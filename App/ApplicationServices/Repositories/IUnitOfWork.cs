using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shunshine.App.ApplicationServices.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
