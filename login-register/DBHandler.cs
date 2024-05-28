using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_register
{
    public static partial class DBHandler
    {
        public static NpgsqlConnection OpenConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(Globals.connectionString);
            connection.Open();
            return connection;
        }

        public static NpgsqlCommand GetCommand(NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            return command;
        }

        public static void CloseConnection(NpgsqlConnection connection, NpgsqlCommand command)
        {
            command.Dispose();
            connection.Close();
        }
    }
}
