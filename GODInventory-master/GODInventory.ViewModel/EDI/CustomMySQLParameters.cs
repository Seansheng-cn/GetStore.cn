using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GODInventory.ViewModel.EDI
{
    public class CustomMySqlParameters
    {
        MySqlParameter[] parameters;
        string sql;

        public CustomMySqlParameters(MySqlParameter[] parameters, string sql ) {
            this.parameters = parameters;
            this.sql = sql;
        }

        public MySqlParameter[] Parameters {
            get { return parameters; }
        }

        public string SqlString {
            get { return sql;  }
        }

    }
}
