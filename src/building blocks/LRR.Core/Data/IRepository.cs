using System;
using System.Collections.Generic;
using System.Text;
using LRR.Core.DomainObjects;

namespace LRR.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {

    }
}
