using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackUp
{
    public class GreenSQLite
    {
        public static string Execute(string sql, SQLiteConnection connection)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "Begin Transaction";
            try
            {
                command.ExecuteNonQuery();
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                command.CommandText = "Rollback Transaction";
                command.ExecuteNonQuery();
                return "Error have happent with this code: " + ex.Message;
            }
            finally
            {
                if (command.CommandText != "Rollback Transaction")
                {
                    command.CommandText = "Commit Transaction;";
                    command.ExecuteNonQuery();
                }
            }
            return "Code have been runned: " + sql;
        }
        public static int ExecuteScaler(string sql, SQLiteConnection connection)
        {
            SQLiteCommand command = new SQLiteCommand(connection);
            command.CommandText = "Begin Transaction";
            int returnValue = 0;
            try
            {
                command.ExecuteNonQuery();
                command.CommandText = sql;
                command.ExecuteNonQuery();
            }
            catch 
            {
                command.CommandText = "Rollback Transaction";
                command.ExecuteNonQuery();
                return returnValue;
            }
            finally
            {
                if (command.CommandText != "Rollback Transaction")
                {
                    command.CommandText = "Commit Transaction;";
                    command.ExecuteNonQuery();
                    command.CommandText = "Select last_insert_rowid()";
                    SQLiteDataReader reader;
                    reader = command.ExecuteReader();
                    if (reader.Read())
                        returnValue = int.Parse(reader[0].ToString());
                }
            }
            return returnValue;
        }
        public static SQLiteDataReader ExecuteReader(string sql, SQLiteConnection connection, out bool error, out string message)
        {
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                error = true;
                message = "Error have happent with this code: " + ex.Message;
                return null;
            }
            error = false;
            message = "Code have been runned: " + sql;
            return reader;
        }
        public static DataTable GetTable(string sql, SQLiteConnection connection)
        {
            bool error = false;
            string msg = "";
            DataTable table = new DataTable();
            SQLiteDataReader read = ExecuteReader(sql, connection, out error, out msg);
            if (error == false)
            {
                for (int colnr = 0; colnr < read.FieldCount; colnr++)
                {
                    table.Columns.Add(read.GetName(colnr));
                }
                while (read.Read())
                {
                    string[] cells = new string[read.FieldCount];
                    for (int colnr = 0; colnr < read.FieldCount; colnr++)
                    {
                        cells[colnr] = read[colnr].ToString();

                    }
                    table.Rows.Add(cells);
                }
                return table;
            }
            return null;
        }

    }
}
