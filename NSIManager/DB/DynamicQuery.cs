using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NISManager.DB
{
    public class DynamicQuery
    {
        public static string GetInsertQuery(string tableName, dynamic item, bool executeOnly = false)
        {
            PropertyInfo[] props = item.GetType().GetProperties();
            string[] columns = props.Select(p => p.Name).Where(s => s != "ID").ToArray();

            if (executeOnly)
            {
                return string.Format("INSERT INTO {0} ({1}) VALUES (@{2})",
                    tableName, string.Join(",", columns), string.Join(",@", columns));
            }
            else
            {
                return string.Format("INSERT INTO {0} ({1}) VALUES (@{2}); SELECT CAST(SCOPE_IDENTITY() AS INT)",
                    tableName, string.Join(",", columns), string.Join(",@", columns));
            }
        }

        public static string GetInsertQueryWithID(string tableName, dynamic item, bool executeOnly = false)
        {
            PropertyInfo[] props = item.GetType().GetProperties();
            string[] columns = props.Select(p => p.Name).ToArray();
            if (executeOnly)
            {
                return string.Format("INSERT INTO {0} ({1}) VALUES (@{2})",
                    tableName, string.Join(",", columns), string.Join(",@", columns));
            }
            else
            {
                return string.Format("INSERT INTO {0} ({1}) VALUES (@{2}) select ident_current('{0}')",
                    tableName, string.Join(",", columns), string.Join(",@", columns));
            }

        }
        public static string GetUpdateQuery(string tableName, dynamic item)
        {
            PropertyInfo[] props = item.GetType().GetProperties();
            string[] columns = props.Select(p => p.Name).Where(s => s != "ID").ToArray();

            var parameters = columns.Select(name => name + "=@" + name);

            return string.Format("UPDATE {0} WITH(ROWLOCK) SET {1} WHERE ID=@ID", tableName, string.Join(",", parameters));
        }

        public static string GetDeleteQuery(string tableName)
        {
            return string.Format("DELETE FROM {0} WHERE ID=@ID", tableName);
        }
    }
}
