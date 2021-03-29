using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NISManager.DB
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}
