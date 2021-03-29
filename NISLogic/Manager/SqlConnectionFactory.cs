using NISLogic.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace NISLogic.Manager
{
	public class SqlConnectionFactory : IConnectionFactory
	{
		public SqlConnectionFactory(string configuration)
		{
			Configuration = configuration;
		}

		public string Configuration { get; }

		private IDbConnection CreateConnection(string conf, bool WithLog = true)
		{
			var connectionString = Configuration;
			var dbConnection = new SqlConnection(connectionString);

			dbConnection.Open();

			//if (WithLog)
			//	UpdateUserDBSession(dbConnection);

			return dbConnection;
		}

		public IDbConnection Create()
		{
			return CreateConnection("DefaultConnection");
		}
	}
}
