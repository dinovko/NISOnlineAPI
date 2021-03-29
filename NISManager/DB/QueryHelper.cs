using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NISManager.DB
{
    public static class QueryHelper
    {
        public static long ExecInsert(this IDbConnection con, string sTableName, dynamic param, IDbTransaction tran = null)
        {
            string sql = DynamicQuery.GetInsertQuery(sTableName, param, false);
            return con.Query<int>(sql, (object)param, tran).FirstOrDefault();
        }
        public static long ExecInsertWithID(this IDbConnection con, string sTableName, dynamic param, IDbTransaction tran = null)
        {
            string sql = DynamicQuery.GetInsertQueryWithID(sTableName, param);
            return con.Execute(sql, (object)param, tran);
        }
        public static void ExecUpdate(this IDbConnection con, string sTableName, dynamic param, IDbTransaction tran = null)
        {
            string sql = DynamicQuery.GetUpdateQuery(sTableName, param);
            con.Execute(sql, (object)param, tran);
        }

        public static void ExecDelete(this IDbConnection con, string sTableName, long ID, IDbTransaction tran = null)
        {
            string sql = DynamicQuery.GetDeleteQuery(sTableName);
            con.Execute(sql, new { ID }, tran);
        }

        public static T SelectOneRow<T>(this IDbConnection con, string sTableName, long ID, IDbTransaction tran = null)
        {
            string sql = string.Format("select * from {0} where ID = {1}", sTableName, ID);
            return con.Query<T>(sql, transaction: tran).FirstOrDefault();
        }
    }
}
