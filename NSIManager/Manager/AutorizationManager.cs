using NISManager.BusinessObjects;
using NISManager.DB;
using NISManager.Manager;
using NSIManager.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;


namespace NSIManager.Manager
{
    public class AutorizationManager: ManagerBase
    {
        public long SaveRegistrationPerson(Person per, string conn)
        {
            using (IDbConnection con = new SqlConnectionFactory(conn).Create())
            {
                con.ExecInsert("[dbo].[Person]", new
                {
                   LastName = "asdasdasdasd"
                });


                return per.ID;
            }
        }
    }
}
