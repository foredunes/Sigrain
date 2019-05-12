using ExcelDataReader;
using Sisgrain.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sisgrain.Classes
{
    class Imports
    {
        public List<Sample> fromMdbFile(string FileName)
        {
            List<Sample> listaDados = new List<Sample>();
            //Carrega dados da tabela Dados
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName;
            string strSQL = "SELECT * FROM Dados";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sample dados = new Sample();
                            dados.Amostra = reader["Amostra"].ToString();
                            dados.Categoria = reader["Tipo"].ToString();
                            dados.Descricao = reader["Leg"].ToString();
                            dados.Data = reader["Data"].ToString();

                            if (reader["Carbonatos"].ToString() != "")
                            {
                                dados.Carbonatos = Convert.ToDecimal(reader["Carbonatos"].ToString().Replace(".", ","));
                            }

                            if (reader["Latitude"].ToString() != "")
                            {
                                dados.Latitude = Convert.ToDecimal(reader["Latitude"].ToString().Replace(".", ","));
                            }

                            if (reader["Longitude"].ToString() != "")
                            {
                                dados.Longitude = Convert.ToDecimal(reader["Longitude"].ToString().Replace(".", ","));
                            }

                            listaDados.Add(dados);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //Carrega dados da tabela Pesos
            strSQL = "SELECT * FROM Pesos";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                try
                {
                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["Amostra"].ToString() + reader["Indice"].ToString() + reader["Peso"].ToString());
                            int i = 0;
                            foreach (var dados in listaDados)
                            {
                                if (listaDados[i].Amostra == reader["Amostra"].ToString())
                                {
                                    if (reader["Indice"].ToString() == "1")
                                    {
                                        listaDados[i].Peso0 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "2")
                                    {
                                        listaDados[i].Peso1 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "3")
                                    {
                                        listaDados[i].Peso2 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "4")
                                    {
                                        listaDados[i].Peso3 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "5")
                                    {
                                        listaDados[i].Peso4 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "6")
                                    {
                                        listaDados[i].Peso5 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "7")
                                    {
                                        listaDados[i].Peso6 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "8")
                                    {
                                        listaDados[i].Peso7 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "9")
                                    {
                                        listaDados[i].Peso8 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "10")
                                    {
                                        listaDados[i].Peso9 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "11")
                                    {
                                        listaDados[i].Peso10 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "12")
                                    {
                                        listaDados[i].Peso11 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "13")
                                    {
                                        listaDados[i].Peso12 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "14")
                                    {
                                        listaDados[i].Peso13 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "15")
                                    {
                                        listaDados[i].Peso14 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "16")
                                    {
                                        listaDados[i].Peso15 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "17")
                                    {
                                        listaDados[i].Peso16 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "18")
                                    {
                                        listaDados[i].Peso17 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "19")
                                    {
                                        listaDados[i].Peso18 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "20")
                                    {
                                        listaDados[i].Peso19 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "21")
                                    {
                                        listaDados[i].Peso20 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "22")
                                    {
                                        listaDados[i].Peso21 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "23")
                                    {
                                        listaDados[i].Peso22 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "24")
                                    {
                                        listaDados[i].Peso23 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "25")
                                    {
                                        listaDados[i].Peso24 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "26")
                                    {
                                        listaDados[i].Peso25 = Convert.ToDecimal(reader["Peso"].ToString().Replace(".", ","));
                                    }
                                }




                                i = i + 1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return listaDados;
        }

        public List<Sample> fromXlsFile(string FileName)
        {
            int peso0, peso1, peso2, peso3, peso4, peso5, peso6, peso7, peso8, peso9, peso10, peso11, peso12, peso13, peso14, peso15, peso16, peso17, peso18, peso19, peso20, peso21, peso22, peso23, peso24, peso25;
            peso0 = peso1 = peso2 = peso3 = peso4 = peso5 = peso6 = peso7 = peso8 = peso9 = peso10 = peso11 = peso12 = peso13 = peso14 = peso15 = peso16 = peso17 = peso18 = peso19 = peso20 = peso21 = peso22 = peso23 = peso24 = peso25 = 0;
            List<Sample> listaDados = new List<Sample>();

            using (var stream = File.Open(FileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            if (i == 0)
                            {
                                int v = 1;
                                while (v < 30)
                                {
                                    try
                                    {
                                        if (reader.GetDouble(v) == -4.0)
                                        {
                                            peso0 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -3.5)
                                        {
                                            peso1 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -3.0)
                                        {
                                            peso2 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -2.5)
                                        {
                                            peso3 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -2.0)
                                        {
                                            peso4 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -1.5)
                                        {
                                            peso5 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -1.0)
                                        {
                                            peso6 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -0.5)
                                        {
                                            peso7 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 0.0)
                                        {
                                            peso8 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 0.5)
                                        {
                                            peso9 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 1.0)
                                        {
                                            peso10 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 1.5)
                                        {
                                            peso11 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 2.0)
                                        {
                                            peso12 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 2.5)
                                        {
                                            peso13 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 3.0)
                                        {
                                            peso14 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 3.5)
                                        {
                                            peso15 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 4.0)
                                        {
                                            peso16 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 4.5)
                                        {
                                            peso17 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 5.0)
                                        {
                                            peso18 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 6.0)
                                        {
                                            peso19 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 7.0)
                                        {
                                            peso20 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 8.0)
                                        {
                                            peso21 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 9.0)
                                        {
                                            peso22 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 10.0)
                                        {
                                            peso23 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 11.0)
                                        {
                                            peso24 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 12.0)
                                        {
                                            peso25 = v;
                                        }
                                    }
                                    catch { }


                                    v = v + 1;
                                }
                            }

                            if (i > 0 && reader.GetString(0) != null)
                            {
                                if (reader.GetString(0).Length > 0)
                                {
                                    Sample sample = new Sample();
                                    sample.Amostra = reader.GetString(0);
                                    sample.Data = DateTime.Now.ToString("dd/MM/yyyy");
                                    try
                                    {
                                        sample.Peso0 = Convert.ToDecimal(reader.GetDouble(peso0));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso1 = Convert.ToDecimal(reader.GetDouble(peso1));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso2 = Convert.ToDecimal(reader.GetDouble(peso2));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso3 = Convert.ToDecimal(reader.GetDouble(peso3));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso4 = Convert.ToDecimal(reader.GetDouble(peso4));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso5 = Convert.ToDecimal(reader.GetDouble(peso5));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso6 = Convert.ToDecimal(reader.GetDouble(peso6));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso7 = Convert.ToDecimal(reader.GetDouble(peso7));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso8 = Convert.ToDecimal(reader.GetDouble(peso8));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso9 = Convert.ToDecimal(reader.GetDouble(peso9));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso10 = Convert.ToDecimal(reader.GetDouble(peso10));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso11 = Convert.ToDecimal(reader.GetDouble(peso11));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso12 = Convert.ToDecimal(reader.GetDouble(peso12));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso13 = Convert.ToDecimal(reader.GetDouble(peso13));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso14 = Convert.ToDecimal(reader.GetDouble(peso14));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso15 = Convert.ToDecimal(reader.GetDouble(peso15));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso16 = Convert.ToDecimal(reader.GetDouble(peso16));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso17 = Convert.ToDecimal(reader.GetDouble(peso17));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso18 = Convert.ToDecimal(reader.GetDouble(peso18));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso19 = Convert.ToDecimal(reader.GetDouble(peso19));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso20 = Convert.ToDecimal(reader.GetDouble(peso20));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso21 = Convert.ToDecimal(reader.GetDouble(peso21));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso22 = Convert.ToDecimal(reader.GetDouble(peso22));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso23 = Convert.ToDecimal(reader.GetDouble(peso23));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso24 = Convert.ToDecimal(reader.GetDouble(peso24));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Peso25 = Convert.ToDecimal(reader.GetDouble(peso25));
                                    }
                                    catch { }


                                    listaDados.Add(sample);
                                }

                            }
                            i = i + 1;
                        }
                    } while (reader.NextResult());
                }
            }

            return listaDados;
        }

        public List<Sample> fromDbFile(string FileName)
        {
            List<Sample> listaDados = new List<Sample>();

            SampleTools sampleTools = new SampleTools();
            List<decimal> phi = sampleTools.getPhiKeys();
            List<decimal> dmm = sampleTools.getDmmKeys();

            DatabaseConnect database = new DatabaseConnect(FileName);
            string sql = "SELECT * FROM Amostras";
            Console.WriteLine(sql);
            SQLiteConnection conn = new SQLiteConnection(database.Connection);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            Sample sample = new Sample();
            while (dr.Read())
            {
                sample.Amostra = dr["Amostra"].ToString();
                sample.Categoria = dr["Categoria"].ToString();
                sample.Data = dr["Data"].ToString();
                sample.Descricao = dr["Descricao"].ToString();
                sample.Latitude = Convert.ToDecimal(dr["Latitude"]);
                sample.Longitude = Convert.ToDecimal(dr["Longitude"]);
                sample.Carbonatos = Convert.ToDecimal(dr["Carbonatos"]);

                for (int i = 0; i < phi.Count; i++)
                {
                    PropertyInfo pinfo = typeof(Sample).GetProperty("Peso" + i);
                    pinfo.SetValue(sample, Convert.ToDecimal(dr["Peso" + i.ToString()]));
                }

                listaDados.Add(sample);

            }
            conn.Close();

            return listaDados;
        }
    }
}
