using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Data
{
  public class Data
  {
    public enum DataBaseType { SqlServer, Oracle, Access }

    public IDbConnection CreateConnection(string connectionString, DataBaseType dbType)
    {
      IDbConnection returnValue;
      if (!String.IsNullOrEmpty(connectionString))
      {
        switch (dbType)
        {
          case DataBaseType.SqlServer:
            IDbConnection = new SqlConnection();
              break;
          case DataBaseType.Oracle:

            break;
          case DataBaseType.Access:

            break;
        }
      }
      else
      {
        throw new NullReferenceException("Invalid connection string");
      }
    }
    public IDbCommand CreateCommand()
    {

    }
    public IDbDataAdapter CreateAdapter()
    {

    }
    public IDbDataParameter CreateParameter()
    {

    }
  }
}
