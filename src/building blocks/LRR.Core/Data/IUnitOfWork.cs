﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LRR.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
