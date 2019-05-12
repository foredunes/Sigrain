using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisgrain.Classes
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
                CreateTableAmostras(conn);
                conn.Close();
            }

        }
        
        private void CreateTableAmostras(SQLiteConnection conn)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("CREATE TABLE IF NOT EXISTS Amostras (Id INTEGER PRIMARY KEY AUTOINCREMENT,");
            sql.AppendLine("Amostra VARCHAR,");
            sql.AppendLine("Categoria VARCHAR,");
            sql.AppendLine("Descricao VARCHAR,");
            sql.AppendLine("Data VARCHAR,");
            sql.AppendLine("Carbonatos VARCHAR,");
            sql.AppendLine("Latitude VARCHAR,");
            sql.AppendLine("Longitude VARCHAR,");
            sql.AppendLine("Peso0 VARCHAR,");
            sql.AppendLine("Peso1 VARCHAR,");
            sql.AppendLine("Peso2 VARCHAR,");
            sql.AppendLine("Peso3 VARCHAR,");
            sql.AppendLine("Peso4 VARCHAR,");
            sql.AppendLine("Peso5 VARCHAR,");
            sql.AppendLine("Peso6 VARCHAR,");
            sql.AppendLine("Peso7 VARCHAR,");
            sql.AppendLine("Peso8 VARCHAR,");
            sql.AppendLine("Peso9 VARCHAR,");
            sql.AppendLine("Peso10 VARCHAR,");
            sql.AppendLine("Peso11 VARCHAR,");
            sql.AppendLine("Peso12 VARCHAR,");
            sql.AppendLine("Peso13 VARCHAR,");
            sql.AppendLine("Peso14 VARCHAR,");
            sql.AppendLine("Peso15 VARCHAR,");
            sql.AppendLine("Peso16 VARCHAR,");
            sql.AppendLine("Peso17 VARCHAR,");
            sql.AppendLine("Peso18 VARCHAR,");
            sql.AppendLine("Peso19 VARCHAR,");
            sql.AppendLine("Peso20 VARCHAR,");
            sql.AppendLine("Peso21 VARCHAR,");
            sql.AppendLine("Peso22 VARCHAR,");
            sql.AppendLine("Peso23 VARCHAR,");
            sql.AppendLine("Peso24 VARCHAR,");
            sql.AppendLine("Peso25 VARCHAR");
            sql.AppendLine(")");
            SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine("Tabela Amostras com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar tabela Amostras." + ex);
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
