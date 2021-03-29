using NISLogic.BusinessObjects;
using NISLogic.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NISLogic.Manager
{
    public class AutorizationManager : ManagerBase
    {
        public long SaveRegistrationPerson(Person per, string conn)
        {
            using (IDbConnection con = new SqlConnectionFactory(conn).Create())
            {
                per.ID = con.ExecInsert("[dbo].[Person]", new
                {
                    per.LastName,
                    per.FirstName,
                    per.SecondName,
                    per.IIN,
                    per.Email
                });

                per.UsersObj.ID = con.ExecInsert("[dbo].[Users]", new
                {
                    per.UsersObj.Password,
                    PersonID = per.ID,
                    per.UsersObj.UserTypeID
                });

                if (per.UsersObj.IsSchoolboy)
                {
                    con.ExecInsert("[dbo].[SchoolboyUsers]", new
                    {
                        UserID = per.UsersObj.ID,
                        per.UsersObj.SchoolboyUsersObj.SchoolID,
                        per.UsersObj.SchoolboyUsersObj.ClassID,
                        per.UsersObj.SchoolboyUsersObj.LanguageLearningID
                    });
                }

                return per.ID;
            }
        }
    }
}
