using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigrain.Classes
{
    class DatabaseConnect
    {
        public String Connection;
        public String DatabaseName;

        public DatabaseConnect(string DatabaseFile)
        {
            DatabaseName = DatabaseFile;
            Connection = "Data Source=" + DatabaseFile;
            CreateDatabase();
        }

        public void CreateDatabase()
        {
            if (!File.Exists(DatabaseName) && DatabaseName != null)
            {
                SQLiteConnection.CreateFile(DatabaseName);
                SQLiteConnection conn = new SQLiteConnection(Connection);
                conn.Open();
                conn.Close();
                Console.WriteLine("Banco de dados criado com sucesso!");
            }
            else if (DatabaseName != null)
            {
                SQLiteConnection conn = new SQLiteConnection(Connection);
                conn.Open();
                CreateTableSamples(conn);
                conn.Close();
            }

        }
        
        private void CreateTableSamples(SQLiteConnection conn)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Samples (Id INTEGER PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("Name VARCHAR,");
            sql.AppendLine("Category VARCHAR,");
            sql.AppendLine("Description VARCHAR,");
            sql.AppendLine("Date VARCHAR,");
            sql.AppendLine("Carbonates VARCHAR,");
            sql.AppendLine("Latitude VARCHAR,");
            sql.AppendLine("Longitude VARCHAR,");
            sql.AppendLine("Weight0 VARCHAR,");
            sql.AppendLine("Weight1 VARCHAR,");
            sql.AppendLine("Weight2 VARCHAR,");
            sql.AppendLine("Weight3 VARCHAR,");
            sql.AppendLine("Weight4 VARCHAR,");
            sql.AppendLine("Weight5 VARCHAR,");
            sql.AppendLine("Weight6 VARCHAR,");
            sql.AppendLine("Weight7 VARCHAR,");
            sql.AppendLine("Weight8 VARCHAR,");
            sql.AppendLine("Weight9 VARCHAR,");
            sql.AppendLine("Weight10 VARCHAR,");
            sql.AppendLine("Weight11 VARCHAR,");
            sql.AppendLine("Weight12 VARCHAR,");
            sql.AppendLine("Weight13 VARCHAR,");
            sql.AppendLine("Weight14 VARCHAR,");
            sql.AppendLine("Weight15 VARCHAR,");
            sql.AppendLine("Weight16 VARCHAR,");
            sql.AppendLine("Weight17 VARCHAR,");
            sql.AppendLine("Weight18 VARCHAR,");
            sql.AppendLine("Weight19 VARCHAR,");
            sql.AppendLine("Weight20 VARCHAR,");
            sql.AppendLine("Weight21 VARCHAR,");
            sql.AppendLine("Weight22 VARCHAR,");
            sql.AppendLine("Weight23 VARCHAR,");
            sql.AppendLine("Weight24 VARCHAR,");
            sql.AppendLine("Weight25 VARCHAR");
            sql.AppendLine(")");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Tabela Samples com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar tabela Samples." + ex);
                conn.Close();
            }
        }


        public bool Insert(object obj, string table, bool showMessage = true)
        {
            string sql = "";
            if (obj == null)
            {
                Console.WriteLine("Object is null");
                return false;
            }
            else
            {
                var props = GetProperties(obj);
                sql = sql + "INSERT INTO " + table + " (";
                foreach (var prop in props)
                {
                    if (!prop.Key.Contains("Id"))
                    {
                        sql = sql + prop.Key + ", ";
                    }
                }

                sql = sql + ") VALUES (";
                foreach (var prop in props)
                {
                    if (!prop.Key.Contains("Id"))
                    {
                        sql = sql + "'" + prop.Value + "', ";
                    }
                }

                sql = sql + ")";

                sql = sql.Replace(", )", ")");

                SQLiteConnection conn = new SQLiteConnection(Connection);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                try
                {
                    Console.WriteLine(sql);
                    cmd.ExecuteNonQuery();
                    if(showMessage == true)
                    {
                        MessageBox.Show("Registro salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    if (showMessage == true)
                    {
                        MessageBox.Show("Erro ao salvar registro" + ex.Message);
                    }
                    conn.Close();
                    return false;
                }
            }

        }

        public bool EditRow(object obj, string table, string id)
        {
            SQLiteConnection conn = new SQLiteConnection(Connection);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            string sql = "";
            if (obj == null)
            {
                Console.WriteLine("Object is null");
                conn.Close();
                return false;
            }
            else
            {
                var props = GetProperties(obj);
                sql = sql + "UPDATE " + table + " SET ";
                foreach (var prop in props)
                {
                    if (!prop.Key.Contains("Id"))
                    {
                        sql = sql + prop.Key + "=" + "'" + prop.Value + "'" + ", ";
                    }
                }

                sql = sql + " WHERE Id = " + id;

                sql = sql.Replace(",  ", " ");

                Console.WriteLine(sql);

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Registro atualizado.");
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao atualizar registro." + ex.Message);
                    conn.Close();
                    return false;
                }
            }
        }

        public SQLiteDataReader GetTableData(string table)
        {
            string sql = "SELECT * FROM " + table;

            SQLiteConnection conn = new SQLiteConnection(Connection);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            return dr;

        }

        public SQLiteDataReader GetTableDataById(string table, string Id)
        {
            string sql = "SELECT * FROM " + table + " WHERE Id=" + Id;

            SQLiteConnection conn = new SQLiteConnection(Connection);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            return dr;
        }



        private static Dictionary<string, string> GetProperties(object obj)
        {
            var props = new Dictionary<string, string>();
            if (obj == null)
                return props;

            var type = obj.GetType();
            foreach (var prop in type.GetProperties())
            {
                var val = prop.GetValue(obj, new object[] { });
                var valStr = val == null ? "" : val.ToString();
                props.Add(prop.Name, valStr);
            }

            return props;
        }
    }
}
