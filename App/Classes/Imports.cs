using ExcelDataReader;
using Sigrain.Classes;
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

namespace Sigrain.Classes
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
                            dados.Name = reader["Amostra"].ToString();
                            dados.Category = reader["Tipo"].ToString();
                            dados.Description = reader["Leg"].ToString();
                            dados.Date = reader["Data"].ToString();

                            if (reader["Carbonatos"].ToString() != "")
                            {
                                dados.Carbonates = Convert.ToDecimal(reader["Carbonatos"].ToString().Replace(".", ","));
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

            //Carrega dados da tabela Weights
            strSQL = "SELECT * FROM Weights";
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
                            Console.WriteLine(reader["Amostra"].ToString() + reader["Indice"].ToString() + reader["Weight"].ToString());
                            int i = 0;
                            foreach (var dados in listaDados)
                            {
                                if (listaDados[i].Name == reader["Amostra"].ToString())
                                {
                                    if (reader["Indice"].ToString() == "1")
                                    {
                                        listaDados[i].Weight0 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "2")
                                    {
                                        listaDados[i].Weight1 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "3")
                                    {
                                        listaDados[i].Weight2 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "4")
                                    {
                                        listaDados[i].Weight3 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "5")
                                    {
                                        listaDados[i].Weight4 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "6")
                                    {
                                        listaDados[i].Weight5 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "7")
                                    {
                                        listaDados[i].Weight6 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "8")
                                    {
                                        listaDados[i].Weight7 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "9")
                                    {
                                        listaDados[i].Weight8 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "10")
                                    {
                                        listaDados[i].Weight9 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "11")
                                    {
                                        listaDados[i].Weight10 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "12")
                                    {
                                        listaDados[i].Weight11 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "13")
                                    {
                                        listaDados[i].Weight12 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "14")
                                    {
                                        listaDados[i].Weight13 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "15")
                                    {
                                        listaDados[i].Weight14 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "16")
                                    {
                                        listaDados[i].Weight15 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "17")
                                    {
                                        listaDados[i].Weight16 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "18")
                                    {
                                        listaDados[i].Weight17 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "19")
                                    {
                                        listaDados[i].Weight18 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "20")
                                    {
                                        listaDados[i].Weight19 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "21")
                                    {
                                        listaDados[i].Weight20 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "22")
                                    {
                                        listaDados[i].Weight21 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "23")
                                    {
                                        listaDados[i].Weight22 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "24")
                                    {
                                        listaDados[i].Weight23 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "25")
                                    {
                                        listaDados[i].Weight24 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
                                    }

                                    if (reader["Indice"].ToString() == "26")
                                    {
                                        listaDados[i].Weight25 = Convert.ToDecimal(reader["Weight"].ToString().Replace(".", ","));
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
            int Weight0, Weight1, Weight2, Weight3, Weight4, Weight5, Weight6, Weight7, Weight8, Weight9, Weight10, Weight11, Weight12, Weight13, Weight14, Weight15, Weight16, Weight17, Weight18, Weight19, Weight20, Weight21, Weight22, Weight23, Weight24, Weight25;
            Weight0 = Weight1 = Weight2 = Weight3 = Weight4 = Weight5 = Weight6 = Weight7 = Weight8 = Weight9 = Weight10 = Weight11 = Weight12 = Weight13 = Weight14 = Weight15 = Weight16 = Weight17 = Weight18 = Weight19 = Weight20 = Weight21 = Weight22 = Weight23 = Weight24 = Weight25 = 0;
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
                                            Weight0 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -3.5)
                                        {
                                            Weight1 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -3.0)
                                        {
                                            Weight2 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -2.5)
                                        {
                                            Weight3 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -2.0)
                                        {
                                            Weight4 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -1.5)
                                        {
                                            Weight5 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -1.0)
                                        {
                                            Weight6 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == -0.5)
                                        {
                                            Weight7 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 0.0)
                                        {
                                            Weight8 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 0.5)
                                        {
                                            Weight9 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 1.0)
                                        {
                                            Weight10 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 1.5)
                                        {
                                            Weight11 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 2.0)
                                        {
                                            Weight12 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 2.5)
                                        {
                                            Weight13 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 3.0)
                                        {
                                            Weight14 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 3.5)
                                        {
                                            Weight15 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 4.0)
                                        {
                                            Weight16 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 4.5)
                                        {
                                            Weight17 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 5.0)
                                        {
                                            Weight18 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 6.0)
                                        {
                                            Weight19 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 7.0)
                                        {
                                            Weight20 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 8.0)
                                        {
                                            Weight21 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 9.0)
                                        {
                                            Weight22 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 10.0)
                                        {
                                            Weight23 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 11.0)
                                        {
                                            Weight24 = v;
                                        }
                                    }
                                    catch { }
                                    try
                                    {
                                        if (reader.GetDouble(v) == 12.0)
                                        {
                                            Weight25 = v;
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
                                    sample.Name = reader.GetString(0);
                                    sample.Date = DateTime.Now.ToString("dd/MM/yyyy");
                                    try
                                    {
                                        sample.Weight0 = Convert.ToDecimal(reader.GetDouble(Weight0));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight1 = Convert.ToDecimal(reader.GetDouble(Weight1));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight2 = Convert.ToDecimal(reader.GetDouble(Weight2));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight3 = Convert.ToDecimal(reader.GetDouble(Weight3));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight4 = Convert.ToDecimal(reader.GetDouble(Weight4));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight5 = Convert.ToDecimal(reader.GetDouble(Weight5));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight6 = Convert.ToDecimal(reader.GetDouble(Weight6));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight7 = Convert.ToDecimal(reader.GetDouble(Weight7));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight8 = Convert.ToDecimal(reader.GetDouble(Weight8));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight9 = Convert.ToDecimal(reader.GetDouble(Weight9));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight10 = Convert.ToDecimal(reader.GetDouble(Weight10));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight11 = Convert.ToDecimal(reader.GetDouble(Weight11));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight12 = Convert.ToDecimal(reader.GetDouble(Weight12));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight13 = Convert.ToDecimal(reader.GetDouble(Weight13));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight14 = Convert.ToDecimal(reader.GetDouble(Weight14));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight15 = Convert.ToDecimal(reader.GetDouble(Weight15));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight16 = Convert.ToDecimal(reader.GetDouble(Weight16));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight17 = Convert.ToDecimal(reader.GetDouble(Weight17));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight18 = Convert.ToDecimal(reader.GetDouble(Weight18));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight19 = Convert.ToDecimal(reader.GetDouble(Weight19));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight20 = Convert.ToDecimal(reader.GetDouble(Weight20));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight21 = Convert.ToDecimal(reader.GetDouble(Weight21));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight22 = Convert.ToDecimal(reader.GetDouble(Weight22));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight23 = Convert.ToDecimal(reader.GetDouble(Weight23));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight24 = Convert.ToDecimal(reader.GetDouble(Weight24));
                                    }
                                    catch { }
                                    try
                                    {
                                        sample.Weight25 = Convert.ToDecimal(reader.GetDouble(Weight25));
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
            string sql = "SELECT * FROM Samples";
            Console.WriteLine(sql);
            SQLiteConnection conn = new SQLiteConnection(database.Connection);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            Sample sample = new Sample();
            while (dr.Read())
            {
                sample.Name = dr["Name"].ToString();
                sample.Category = dr["Category"].ToString();
                sample.Date = dr["Date"].ToString();
                sample.Description = dr["Description"].ToString();
                sample.Latitude = Convert.ToDecimal(dr["Latitude"]);
                sample.Longitude = Convert.ToDecimal(dr["Longitude"]);
                sample.Carbonates = Convert.ToDecimal(dr["Carbonates"]);

                for (int i = 0; i < phi.Count; i++)
                {
                    PropertyInfo pinfo = typeof(Sample).GetProperty("Weight" + i);
                    pinfo.SetValue(sample, Convert.ToDecimal(dr["Weight" + i.ToString()]));
                }

                listaDados.Add(sample);

            }
            conn.Close();

            return listaDados;
        }
    }
}
