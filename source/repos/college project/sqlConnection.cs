using System;
using System.Data;
using System.Data.SqlClient;

namespace college_project
{
    internal class sqlConnection
    {
        private string strcon;

        public sqlConnection(string strcon)
        {
            this.strcon = strcon;
        }

        public ConnectionState State { get; internal set; }

        public static implicit operator SqlConnection(sqlConnection v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator sqlConnection(SqlCommand v)
        {
            throw new NotImplementedException();
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}