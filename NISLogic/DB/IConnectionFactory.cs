using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NISLogic.DB
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}
