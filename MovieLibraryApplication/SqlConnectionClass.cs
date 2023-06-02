using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibraryApplication
{
    internal class SqlConnectionClass
    {
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=MovieLibraryApplication;Integrated Security=True");
        }
    }
}
