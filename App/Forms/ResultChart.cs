using Sigrain.Classes;
using Sigran.Classes;
using Sigran.PropertyGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sigran.Forms
{
    public partial class ResultChart : Form
    {
        SampleTools sampleTools = new SampleTools();
        Functions f = new Functions();

        public string Type = "";

        public List<string> TempLabels = new List<string>();

        public ResultChart()
        {
            InitializeComponent();
            
        }

        private void ResultChart_Load(object sender, EventArgs e)
        {
            if (Type == "histogram")
                editarLegendaToolStripMenuItem.Visible = false;

            splitContainer1.Panel1Collapsed = true;
            propertyGrid1.Dock = dataGridView1.Dock = DockStyle.Fill;

            chart1.ChartAreas[0].BackColor = Color.Transparent;

            if(Type == "histogram")
            {
                //Configurações da janela
                Text = Text + " - Histograma";

                chart1.Series[1].BorderWidth = 0;
                chart1.Series[1].MarkerBorderWidth = 0;
                chart1.Series[1]["PointWidth"] = "1";

                //Configurações do gráfico
                chart1.ChartAreas[0].AxisX.Title = "phi";
                chart1.ChartAreas[0].AxisY.Title = "Frequência (%)";
                chart1.ChartAreas[0].AxisY.Interval = 10;
                chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 100;
                chart1.ChartAreas[0].AxisX.IsMarginVisible = true;
                chart1.ChartAreas[0].AxisY.IsMarginVisible = true;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = 27;
                chart1.Legends.Remove(chart1.Legends[0]);
                //altera a cor do ponto de maior valor
                double maximumValue = 0;
                int idMaximumValue = 0;
                int c = 0;
                foreach (DataPoint dp in chart1.Series[1].Points)
                {
                    if(dp.YValues[0] > maximumValue)
                    {
                        maximumValue = dp.YValues[0];
                        idMaximumValue = c;
                    }
                    c++;
                }
                chart1.Series[1].Points[idMaximumValue].Color = Color.Red;
                //Titulo do gráfico
                Title title = chart1.Titles.Add("Histograma");
                title.Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.Black;
                //Linhas verticais
                System.Windows.Forms.DataVisualization.Charting.ChartArea CA = chart1.ChartAreas[0];
                double[] verbalClassDetaill = new double[] { 26.9f };
                for (int m = 0; m < verbalClassDetaill.Length; m++)
                {
                    VerticalLineAnnotation VA;
                    VA = new VerticalLineAnnotation();
                    VA.AxisX = CA.AxisX;
                    VA.AllowMoving = false;
                    VA.IsInfinitive = true;
                    VA.ClipToChartArea = CA.Name;
                    VA.Name = "myLineDetaill" + m.ToString();
                    VA.LineColor = Color.FromArgb(180, 180, 180);
                    VA.LineDashStyle = ChartDashStyle.Solid;
                    VA.LineWidth = 1;
                    VA.X = verbalClassDetaill[m];
                    chart1.Annotations.Add(VA);
                }
            }

            if (Type == "frequencyAcc")
            {
                //Configurações da janela
                Text = Text + " - Frequência acumulada";

                //Configurações do gráfico
                chart1.ChartAreas[0].AxisX.Title = "phi";
                chart1.ChartAreas[0].AxisY.Title = "Frequência acumulada (%)";
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Interval = 10;
                chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;
                chart1.ChartAreas[0].AxisX.Minimum = -4;
                chart1.ChartAreas[0].AxisX.Maximum = 12;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 100;
                //chart1.Legends["Legend1"].Enabled = false;
                chart1.Series[chart1.Series.Count-1].Enabled = false;
                //Titulo do gráfico
                Title title = chart1.Titles.Add("Frequência Acumulada");
                title.Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.Black;

                CreateDetailedGrid();

                for(int s = 0; s < chart1.Series.Count; s++)
                {
                    chart1.Series[s].BorderWidth = 2;
                    chart1.Series[s].MarkerStyle = MarkerStyle.Circle;
                    chart1.Series[s].MarkerSize = 5;
                    chart1.Series[s].MarkerColor = chart1.Series[s].BorderColor;
                }

                for(int t=0; t<chart1.ChartAreas.Count; t++)
                {
                    if(t>0)
                    {
                        chart1.ChartAreas[t].AxisX.LineColor =
                        chart1.ChartAreas[t].AxisX.InterlacedColor =
                        chart1.ChartAreas[t].AxisX.TitleForeColor =
                        chart1.ChartAreas[t].AxisX.MajorGrid.LineColor =
                        chart1.ChartAreas[t].AxisX.MinorGrid.LineColor =
                        chart1.ChartAreas[t].AxisX.LabelStyle.ForeColor =
                        Color.Transparent;

                        chart1.ChartAreas[t].AxisY.LineColor =
                        chart1.ChartAreas[t].AxisY.InterlacedColor =
                        chart1.ChartAreas[t].AxisY.TitleForeColor =
                        chart1.ChartAreas[t].AxisY.MajorGrid.LineColor =
                        chart1.ChartAreas[t].AxisY.MinorGrid.LineColor =
                        chart1.ChartAreas[t].AxisY.LabelStyle.ForeColor =
                        Color.Transparent;

                        chart1.ChartAreas[t].AxisY.LabelStyle.Enabled = false;
                        chart1.ChartAreas[t].AxisX.LabelStyle.Enabled = false;
                        chart1.ChartAreas[t].AxisY.Enabled =
                        chart1.ChartAreas[t].AxisX.Enabled = AxisEnabled.False;
                    }
                }

                chart1.Legends[0].Title = "Legenda";
            }

            if(Type == "histogram" || Type == "frequencyAcc")
            {
                //Eixos
                chart1.ChartAreas[0].AxisX.TitleFont =
                chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 12);
                chart1.ChartAreas[0].AxisX.LabelStyle.Font =
                chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 10);
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(180, 180, 180);
                chart1.ChartAreas[0].AxisX.LineWidth =
                chart1.ChartAreas[0].AxisY.LineWidth = 2;
                chart1.ChartAreas[0].AxisX.MajorTickMark.Size =
                chart1.ChartAreas[0].AxisY.MajorTickMark.Size = 1;
                chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled =
                chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = true;
                chart1.ChartAreas[0].AxisX.MinorTickMark.Size =
                chart1.ChartAreas[0].AxisY.MinorTickMark.Size = 0.7f;
                chart1.ChartAreas[0].AxisX.MinorGrid.Interval =
                chart1.ChartAreas[0].AxisY.MinorGrid.Interval = 1;
                //Serie
            }

            if (Type == "sherpard")
            {
                //Configurações da janela
                Text = Text + " - Diagrama de Sherpard";
                //Background imagem
                chart1.ChartAreas[0].BackImage = "Sherpard_bg";
            }

            if (Type == "pejrup")
            {
                //Configurações da janela
                Text = Text + " - Diagrama de Pejrup";
                //Background imagem
                chart1.ChartAreas[0].BackImage = "Pejrup_bg";
            }

            if (Type == "folk")
            {
                //Configurações da janela
                Text = Text + " - Diagrama de Folk";
                //Background imagem
                chart1.ChartAreas[0].BackImage = "Folk_bg";
            }

            if (Type == "folkThicks")
            {
                //Configurações da janela
                Text = Text + " - Diagrama de Folk";
                //Background imagem
                chart1.ChartAreas[0].BackImage = "Folk_coarse_bg";
            }

            if (Type == "sherpard" || Type == "pejrup" || Type == "folk" || Type == "folkThicks")
            {
                //Configurações do gráfico
                chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;
                chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
                chart1.ChartAreas[0].AxisY.IsMarginVisible = false;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = 150;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 120;
                chart1.Legends.Remove(chart1.Legends[0]);
                chart1.ChartAreas[0].AxisX.Interval = 10;
                chart1.ChartAreas[0].AxisY.Interval = 10;
                chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
                chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
                //Background imagem
                chart1.ChartAreas[0].BackImageWrapMode = ChartImageWrapMode.Scaled;
                //Labels pontos

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                {
                    chart1.Series[0].Points[i].LabelForeColor = Color.Red;
                    chart1.Series[0].Points[i].MarkerColor = Color.DodgerBlue;
                    chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Circle;
                }

                //Configurações de largura
                chart1.Dock = DockStyle.None;
                chart1.Width = Convert.ToInt32(splitContainer1.Height * 1.4);
                chart1.Height = splitContainer1.Height;

                /*//Legenda personalizada
                RectangleAnnotation RA = new RectangleAnnotation();
                RA.IsSizeAlwaysRelative = false;
                RA.Width = 25;
                RA.Height = 1;
                RA.Bottom = 0;
                RA.X = 65;
                RA.Y = 10;
                RA.Text = "Legenda\n1.Vida";
                RA.LineWidth = 0;
                RA.BackColor = Color.Transparent;
                RA.ForeColor = Color.Black;
                RA.Font = new System.Drawing.Font("Arial", 12f);
                RA.Alignment = ContentAlignment.MiddleLeft;
                RA.LineColor = Color.Black;
                RA.LineWidth = 1;
                chart1.Annotations.Add(RA);*/

            }

            if (Type == "bivariate")
            {
                //Configurações da janela
                Text = Text + " - Correlação";

                chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;

                chart1.Legends[0].Enabled = false;

                //Eixos
                chart1.ChartAreas[0].AxisX.IntervalAutoMode =
                chart1.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
                chart1.ChartAreas[0].AxisX.TitleFont =
                chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 12);
                chart1.ChartAreas[0].AxisX.LabelStyle.Font =
                chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 10);
                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.000";
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(180, 180, 180);
                chart1.ChartAreas[0].AxisX.LineWidth =
                chart1.ChartAreas[0].AxisY.LineWidth = 2;
                chart1.ChartAreas[0].AxisX.MajorTickMark.Size =
                chart1.ChartAreas[0].AxisY.MajorTickMark.Size = 1;
                chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled =
                chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = true;
                chart1.ChartAreas[0].AxisX.MinorTickMark.Size =
                chart1.ChartAreas[0].AxisY.MinorTickMark.Size = 0.7f;

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                {
                    chart1.Series[0].Points[i].LabelForeColor = Color.Red;
                    chart1.Series[0].Points[i].MarkerColor = Color.DodgerBlue;
                    chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Circle;
                }
            }
        }

        private void CreateDetailedGrid()
        {
            //Grade secundária
            System.Windows.Forms.DataVisualization.Charting.ChartArea CA = chart1.ChartAreas[0];
            double[] verbalClass = new double[] { 0, 4, 8 };
            for (int m = 0; m < verbalClass.Length; m++)
            {
                int rdn = new Random().Next(10);
                VerticalLineAnnotation VA;
                VA = new VerticalLineAnnotation();
                VA.AxisX = CA.AxisX;
                VA.AllowMoving = false;
                VA.IsInfinitive = true;
                VA.ClipToChartArea = CA.Name;
                VA.LineColor = Color.Red;
                VA.LineDashStyle = ChartDashStyle.Dash;
                VA.LineWidth = 1;
                VA.X = verbalClass[m];
                chart1.Annotations.Add(VA);
            }

            //Linhas de escala (Cascalho, Areia, Silte e Argila)
            double[] verbalClassDetaill = new double[] { -3.0,-2.5,-2.0,-1.5,-1.25,-1,-0.75,-0.25,-0.5,
                                                            1.0,1.5,2.0,2.5,2.75,3.0,3.25,3.5,3.75,
                                                            5.0,5.5,6.0,6.5,6.75,7.0,7.25,7.5,7.75,
                                                            9.0,9.5,10.0,10.5,10.75,11.0,11.25,11.5,11.75, 12 };
            for (int m = 0; m < verbalClassDetaill.Length; m++)
            {
                int rdn = new Random().Next(10);
                VerticalLineAnnotation VA;
                VA = new VerticalLineAnnotation();
                VA.AxisX = CA.AxisX;
                VA.AllowMoving = false;
                VA.IsInfinitive = true;
                VA.ClipToChartArea = CA.Name;
                VA.LineColor = Color.FromArgb(180, 180, 180);
                VA.LineDashStyle = ChartDashStyle.Solid;
                VA.LineWidth = 1;
                VA.X = verbalClassDetaill[m];
                chart1.Annotations.Add(VA);
            }

            // Labels de escala (Cascalho, Areia, Silte e Argila)
            double[] scaleNumbers = new double[] { -4, 0, 4, 8 };
            string[] scaleLabels = new string[] { "Cascalho", "Areia", "Silte", "Argila" };
            for (int m = 0; m < scaleNumbers.Length; m++)
            {
                RectangleAnnotation RA = new RectangleAnnotation();
                RA.AxisX = CA.AxisX;
                RA.IsSizeAlwaysRelative = false;
                RA.Width = 4;
                RA.Height = 1;
                RA.Bottom = 0;
                RA.AxisY = CA.AxisY;
                RA.Y = 10;
                RA.X = scaleNumbers[m];
                RA.Text = scaleLabels[m];
                RA.LineWidth = 0;
                RA.BackColor = Color.Transparent;
                RA.ForeColor = Color.Red;
                RA.Font = new System.Drawing.Font("Arial", 8f);
                chart1.Annotations.Add(RA);
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarGráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Salvando gráfico como...");
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "All files (*.*)|*.*|JPEG (*.jpg,*.jpeg,*.jpe)|*.jpg,*.jpeg,*.jpe|PNG (*.png)|*.png|Bitmap (*.bmp)|*.bmp|GIF (*.gif)|*.gif|TIFF (*.tiff)|*.tiff";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.Title = "Salvar gráfico...";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog1.FileName.Contains("jpeg") || saveFileDialog1.FileName.Contains("jpg") || saveFileDialog1.FileName.Contains("jpe"))
                    {
                        chart1.SaveImage(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    }
                    if (saveFileDialog1.FileName.Contains("png"))
                    {
                        chart1.SaveImage(saveFileDialog1.FileName, ImageFormat.Png);
                    }
                    if (saveFileDialog1.FileName.Contains("bmp"))
                    {
                        chart1.SaveImage(saveFileDialog1.FileName, ImageFormat.Bmp);
                    }
                    if (saveFileDialog1.FileName.Contains("gif"))
                    {
                        chart1.SaveImage(saveFileDialog1.FileName, ImageFormat.Gif);
                    }
                    if (saveFileDialog1.FileName.Contains("tiff"))
                    {
                        chart1.SaveImage(saveFileDialog1.FileName, ImageFormat.Tiff);
                    }
                    MessageBox.Show("Gráfico salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Erro ao salvar gráfico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void DadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                splitContainer1.Panel1Collapsed = false;
                dadosToolStripMenuItem.Font = new System.Drawing.Font(dadosToolStripMenuItem.Font.FontFamily, dadosToolStripMenuItem.Font.Size, FontStyle.Bold);
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
                dadosToolStripMenuItem.Font = new System.Drawing.Font(dadosToolStripMenuItem.Font.FontFamily, dadosToolStripMenuItem.Font.Size, FontStyle.Regular);
            }
            dataGridView1.Visible = true;
            propertyGrid1.Visible = false;

            editarToolStripMenuItem.Font = new System.Drawing.Font(editarToolStripMenuItem.Font.FontFamily, editarToolStripMenuItem.Font.Size, FontStyle.Regular);
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                splitContainer1.Panel1Collapsed = false;
                editarToolStripMenuItem.Font = new System.Drawing.Font(editarToolStripMenuItem.Font.FontFamily, editarToolStripMenuItem.Font.Size, FontStyle.Bold);
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
                editarToolStripMenuItem.Font = new System.Drawing.Font(editarToolStripMenuItem.Font.FontFamily, editarToolStripMenuItem.Font.Size, FontStyle.Regular);
            }
            dataGridView1.Visible = false;
            propertyGrid1.Visible = true;

            dadosToolStripMenuItem.Font = new System.Drawing.Font(dadosToolStripMenuItem.Font.FontFamily, dadosToolStripMenuItem.Font.Size, FontStyle.Regular);

            //CARREGA PROPRIEDADES NO PROPERTGRID1
            if (Type == "histogram")
            {
                HistogramPropertyGrid pg = new HistogramPropertyGrid();
                pg.Title = chart1.Titles[0].Text;
                pg.TitleFont = chart1.Titles[0].Font;
                pg.BackgroundColor = chart1.BackColor;
                if (chart1.BorderlineDashStyle == ChartDashStyle.NotSet)
                    pg.BorderStyle = "Nenhuma";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Solid)
                    pg.BorderStyle = "Solida";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Dash)
                    pg.BorderStyle = "Tracejada";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Dot)
                    pg.BorderStyle = "Pontilhada";
                pg.BorderDepth = chart1.BorderlineWidth;
                pg.BorderColor = chart1.BorderlineColor;

                pg.TitleAxisX = chart1.ChartAreas[0].AxisX.Title;
                pg.DepthAxisX = chart1.ChartAreas[0].AxisX.LineWidth;
                pg.IntervalAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.Interval;
                pg.SubdivisionsAxisX = chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled;
                pg.ColorAxisX = chart1.ChartAreas[0].AxisX.LineColor;
                pg.GridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.Enabled;
                pg.DepthGridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth;
                pg.ColorGridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.LineColor;
                pg.MinimumAxisX = chart1.ChartAreas[0].AxisX.Minimum;
                pg.MaximumAxisX = chart1.ChartAreas[0].AxisX.Maximum;

                pg.TitleAxisY = chart1.ChartAreas[0].AxisY.Title;
                pg.DepthAxisY = chart1.ChartAreas[0].AxisY.LineWidth;
                pg.IntervalAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.Interval;
                pg.SubdivisionsAxisY = chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled;
                pg.ColorAxisY = chart1.ChartAreas[0].AxisY.LineColor;
                pg.GridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.Enabled;
                pg.DepthGridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth;
                pg.ColorGridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.LineColor;
                pg.MinimumAxisY = chart1.ChartAreas[0].AxisY.Minimum;
                pg.MaximumAxisY = chart1.ChartAreas[0].AxisY.Maximum;

                int serie = 1;
                pg.ColorSerie = chart1.Series[serie].Color;
                pg.ColorBorderSerie = chart1.Series[serie].BorderColor;
                if (chart1.Series[serie].BorderDashStyle == ChartDashStyle.NotSet)
                    pg.BorderStyleSerie = "Nenhuma";
                if (chart1.Series[serie].BorderDashStyle == ChartDashStyle.Solid)
                    pg.BorderStyleSerie = "Solida";
                if (chart1.Series[serie].BorderDashStyle == ChartDashStyle.Dash)
                    pg.BorderStyleSerie = "Tracejada";
                if (chart1.Series[serie].BorderDashStyle == ChartDashStyle.Dot)
                    pg.BorderStyleSerie = "Pontilhada";
                pg.BorderDepthSerie = chart1.Series[1].BorderWidth;

                //obtem a cor do ponto de maior valor
                double maximumValue = 0;
                int idMaximumValue = 0;
                int c = 0;
                foreach (DataPoint dp in chart1.Series[1].Points)
                {
                    if (dp.YValues[0] > maximumValue)
                    {
                        maximumValue = dp.YValues[0];
                        idMaximumValue = c;
                    }
                    c++;
                }
                pg.ColorMaximumColumn = chart1.Series[1].Points[idMaximumValue].Color;

                propertyGrid1.SelectedObject = pg;
            }

            if (Type == "frequencyAcc")
            {
                FrequencyAccPropertyGrid pg = new FrequencyAccPropertyGrid();
                pg.Title = chart1.Titles[0].Text;
                pg.TitleFont = chart1.Titles[0].Font;
                pg.BackgroundColor = chart1.BackColor;
                if (chart1.BorderlineDashStyle == ChartDashStyle.NotSet)
                    pg.BorderStyle = "Nenhuma";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Solid)
                    pg.BorderStyle = "Solida";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Dash)
                    pg.BorderStyle = "Tracejada";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Dot)
                    pg.BorderStyle = "Pontilhada";
                pg.BorderDepth = chart1.BorderlineWidth;
                pg.BorderColor = chart1.BorderlineColor;

                pg.TitleAxisX = chart1.ChartAreas[0].AxisX.Title;
                pg.DepthAxisX = chart1.ChartAreas[0].AxisX.LineWidth;
                pg.IntervalAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.Interval;
                pg.SubdivisionsAxisX = chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled;
                pg.ColorAxisX = chart1.ChartAreas[0].AxisX.LineColor;
                pg.GridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.Enabled;
                pg.DepthGridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth;
                pg.ColorGridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.LineColor;
                pg.MinimumAxisX = chart1.ChartAreas[0].AxisX.Minimum;
                pg.MaximumAxisX = chart1.ChartAreas[0].AxisX.Maximum;

                pg.TitleAxisY = chart1.ChartAreas[0].AxisY.Title;
                pg.DepthAxisY = chart1.ChartAreas[0].AxisY.LineWidth;
                pg.IntervalAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.Interval;
                pg.SubdivisionsAxisY = chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled;
                pg.ColorAxisY = chart1.ChartAreas[0].AxisY.LineColor;
                pg.GridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.Enabled;
                pg.DepthGridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth;
                pg.ColorGridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.LineColor;
                pg.MinimumAxisY = chart1.ChartAreas[0].AxisY.Minimum;
                pg.MaximumAxisY = chart1.ChartAreas[0].AxisY.Maximum;

                pg.SizeMarketsSeries = chart1.Series[0].MarkerSize;
                if(chart1.Annotations.Count > 0)
                {
                    pg.ShowDetailedGrid = true;
                }
                else
                {
                    pg.ShowDetailedGrid = false;
                }
                if (chart1.Series[0].BorderDashStyle == ChartDashStyle.NotSet)
                    pg.LineStyleSeries = "Nenhuma";
                if (chart1.Series[0].BorderDashStyle == ChartDashStyle.Solid)
                    pg.LineStyleSeries = "Solida";
                if (chart1.Series[0].BorderDashStyle == ChartDashStyle.Dash)
                    pg.LineStyleSeries = "Tracejada";
                if (chart1.Series[0].BorderDashStyle == ChartDashStyle.Dot)
                    pg.LineStyleSeries = "Pontilhada";
                pg.LinesDepthSeries = chart1.Series[0].BorderWidth;

                propertyGrid1.SelectedObject = pg;

                if(chart1.Legends.Count > 0)
                {
                    pg.ShowLegend = true;
                }
                else
                {
                    pg.ShowLegend = false;
                }
            }

            if (Type == "sherpard" || Type == "pejrup" || Type == "folk" || Type == "folkThicks")
            {
                ThernaryDiagramPropertyGrid pg = new ThernaryDiagramPropertyGrid();
                pg.BackgroundColor = chart1.BackColor;
                if (chart1.BorderlineDashStyle == ChartDashStyle.NotSet)
                    pg.BorderStyle = "Nenhuma";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Solid)
                    pg.BorderStyle = "Solida";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Dash)
                    pg.BorderStyle = "Tracejada";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Dot)
                    pg.BorderStyle = "Pontilhada";
                pg.BorderDepth = chart1.BorderlineWidth;
                pg.BorderColor = chart1.BorderlineColor;

                if(chart1.Series[0].Points[0].LabelForeColor != Color.Transparent)
                {
                    pg.ShowLabels = true;
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        TempLabels.Add(chart1.Series[0].Points[i].Label);
                    }
                }
                else
                {
                    pg.ShowLabels = false;
                }

                pg.MarkersSize = chart1.Series[0].Points[0].MarkerSize;
                pg.MarkerColor = chart1.Series[0].Points[0].MarkerColor;


                if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Circle)
                {
                    pg.MarkerStyle = "Círculo";
                }
                else if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Cross)
                {
                    pg.MarkerStyle = "Cruz";
                }
                else if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Diamond)
                {
                    pg.MarkerStyle = "Diamante";
                }
                else if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Triangle)
                {
                    pg.MarkerStyle = "Triângulo";
                }
                else if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Star10)
                {
                    pg.MarkerStyle = "Estrela";
                }
                else
                {
                    pg.MarkerStyle = "Quadrado";
                }

                pg.LabelColor = chart1.Series[0].Points[0].LabelForeColor;

                propertyGrid1.SelectedObject = pg;
            }

            if (Type == "bivariate")
            {
                BivariatePropertyGrid pg = new BivariatePropertyGrid();
                pg.Title = chart1.Titles[0].Text;
                pg.TitleFont = chart1.Titles[0].Font;
                pg.BackgroundColor = chart1.BackColor;
                if (chart1.BorderlineDashStyle == ChartDashStyle.NotSet)
                    pg.BorderStyle = "Nenhuma";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Solid)
                    pg.BorderStyle = "Solida";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Dash)
                    pg.BorderStyle = "Tracejada";
                if (chart1.BorderlineDashStyle == ChartDashStyle.Dot)
                    pg.BorderStyle = "Pontilhada";
                pg.BorderDepth = chart1.BorderlineWidth;
                pg.BorderColor = chart1.BorderlineColor;

                pg.TitleAxisX = chart1.ChartAreas[0].AxisX.Title;
                pg.DepthAxisX = chart1.ChartAreas[0].AxisX.LineWidth;
                pg.IntervalAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.Interval;
                pg.SubdivisionsAxisX = chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled;
                pg.ColorAxisX = chart1.ChartAreas[0].AxisX.LineColor;
                pg.GridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.Enabled;
                pg.DepthGridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth;
                pg.ColorGridAxisX = chart1.ChartAreas[0].AxisX.MajorGrid.LineColor;
                pg.MinimumAxisX = chart1.ChartAreas[0].AxisX.Minimum;
                pg.MaximumAxisX = chart1.ChartAreas[0].AxisX.Maximum;

                pg.TitleAxisY = chart1.ChartAreas[0].AxisY.Title;
                pg.DepthAxisY = chart1.ChartAreas[0].AxisY.LineWidth;
                pg.IntervalAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.Interval;
                pg.SubdivisionsAxisY = chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled;
                pg.ColorAxisY = chart1.ChartAreas[0].AxisY.LineColor;
                pg.GridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.Enabled;
                pg.DepthGridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth;
                pg.ColorGridAxisY = chart1.ChartAreas[0].AxisY.MajorGrid.LineColor;
                pg.MinimumAxisY = chart1.ChartAreas[0].AxisY.Minimum;
                pg.MaximumAxisY = chart1.ChartAreas[0].AxisY.Maximum;

                if (chart1.Series[0].Points[0].LabelForeColor != Color.Transparent)
                {
                    pg.ShowLabels = true;
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        TempLabels.Add(chart1.Series[0].Points[i].Label);
                    }
                }
                else
                {
                    pg.ShowLabels = false;
                }

                pg.MarkersSize = chart1.Series[0].Points[0].MarkerSize;
                pg.MarkerColor = chart1.Series[0].Points[0].MarkerColor;


                if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Circle)
                {
                    pg.MarkerStyle = "Círculo";
                }
                else if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Cross)
                {
                    pg.MarkerStyle = "Cruz";
                }
                else if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Diamond)
                {
                    pg.MarkerStyle = "Diamante";
                }
                else if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Triangle)
                {
                    pg.MarkerStyle = "Triângulo";
                }
                else if (chart1.Series[0].Points[0].MarkerStyle == MarkerStyle.Star10)
                {
                    pg.MarkerStyle = "Estrela";
                }
                else
                {
                    pg.MarkerStyle = "Quadrado";
                }

                pg.LabelColor = chart1.Series[0].Points[0].LabelForeColor;

                propertyGrid1.SelectedObject = pg;
            }

        }

        private void PropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if(Type == "histogram")
            {
                HistogramPropertyGrid pg = (HistogramPropertyGrid)propertyGrid1.SelectedObject;
                chart1.Titles[0].Text = pg.Title;
                chart1.Titles[0].Font = pg.TitleFont;
                chart1.BackColor = pg.BackgroundColor;
                if (pg.BorderStyle == "Nenhuma")
                    chart1.BorderlineDashStyle = ChartDashStyle.NotSet;
                if (pg.BorderStyle == "Solida")
                    chart1.BorderlineDashStyle = ChartDashStyle.Solid;
                if (pg.BorderStyle == "Tracejada")
                    chart1.BorderlineDashStyle = ChartDashStyle.Dash;
                if (pg.BorderStyle == "Pontilhada")
                    chart1.BorderlineDashStyle = ChartDashStyle.Dot;
                chart1.BorderlineWidth = pg.BorderDepth;
                chart1.BorderlineColor = pg.BorderColor;

                chart1.ChartAreas[0].AxisX.Title = pg.TitleAxisX;
                chart1.ChartAreas[0].AxisX.LineWidth = pg.DepthAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = pg.IntervalAxisX;
                chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = pg.SubdivisionsAxisX;
                chart1.ChartAreas[0].AxisX.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MajorTickMark.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MinorTickMark.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = pg.GridAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = pg.DepthGridAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = pg.ColorGridAxisX;
                chart1.ChartAreas[0].AxisX.Minimum = pg.MinimumAxisX;
                chart1.ChartAreas[0].AxisX.Maximum = pg.MaximumAxisX;

                chart1.ChartAreas[0].AxisY.Title = pg.TitleAxisY;
                chart1.ChartAreas[0].AxisY.LineWidth = pg.DepthAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = pg.IntervalAxisY;
                chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = pg.SubdivisionsAxisY;
                chart1.ChartAreas[0].AxisY.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MajorTickMark.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MinorTickMark.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = pg.GridAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = pg.DepthGridAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = pg.ColorGridAxisY;
                chart1.ChartAreas[0].AxisY.Minimum = pg.MinimumAxisY;
                chart1.ChartAreas[0].AxisY.Maximum = pg.MaximumAxisY;

                int serie = 1;
                chart1.Series[serie].Color = pg.ColorSerie;
                chart1.Series[serie].BorderColor = pg.ColorBorderSerie;
                if (pg.BorderStyleSerie == "Nenhuma")
                    chart1.Series[serie].BorderDashStyle = ChartDashStyle.NotSet;
                if (pg.BorderStyleSerie == "Solida")
                    chart1.Series[serie].BorderDashStyle = ChartDashStyle.Solid;
                if (pg.BorderStyleSerie == "Tracejada")
                    chart1.Series[serie].BorderDashStyle = ChartDashStyle.Dash;
                if (pg.BorderStyleSerie == "Pontilhada")
                    chart1.Series[serie].BorderDashStyle = ChartDashStyle.Dot;
                chart1.Series[1].BorderWidth = pg.BorderDepthSerie;

                //obtem a cor do ponto de maior valor
                double maximumValue = 0;
                int idMaximumValue = 0;
                int c = 0;
                foreach (DataPoint dp in chart1.Series[1].Points)
                {
                    if (dp.YValues[0] > maximumValue)
                    {
                        maximumValue = dp.YValues[0];
                        idMaximumValue = c;
                    }
                    c++;
                }
                chart1.Series[1].Points[idMaximumValue].Color = pg.ColorMaximumColumn;
            }

            if (Type == "frequencyAcc")
            {
                FrequencyAccPropertyGrid pg = (FrequencyAccPropertyGrid)propertyGrid1.SelectedObject;
                chart1.Titles[0].Text = pg.Title;
                chart1.Titles[0].Font = pg.TitleFont;
                chart1.BackColor = pg.BackgroundColor;
                if (pg.BorderStyle == "Nenhuma")
                    chart1.BorderlineDashStyle = ChartDashStyle.NotSet;
                if (pg.BorderStyle == "Solida")
                    chart1.BorderlineDashStyle = ChartDashStyle.Solid;
                if (pg.BorderStyle == "Tracejada")
                    chart1.BorderlineDashStyle = ChartDashStyle.Dash;
                if (pg.BorderStyle == "Pontilhada")
                    chart1.BorderlineDashStyle = ChartDashStyle.Dot;
                chart1.BorderlineWidth = pg.BorderDepth;
                chart1.BorderlineColor = pg.BorderColor;

                chart1.ChartAreas[0].AxisX.Title = pg.TitleAxisX;
                chart1.ChartAreas[0].AxisX.LineWidth = pg.DepthAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = pg.IntervalAxisX;
                chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = pg.SubdivisionsAxisX;
                chart1.ChartAreas[0].AxisX.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MajorTickMark.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MinorTickMark.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = pg.GridAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = pg.DepthGridAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = pg.ColorGridAxisX;
                chart1.ChartAreas[0].AxisX.Minimum = pg.MinimumAxisX;
                chart1.ChartAreas[0].AxisX.Maximum = pg.MaximumAxisX;

                chart1.ChartAreas[0].AxisY.Title = pg.TitleAxisY;
                chart1.ChartAreas[0].AxisY.LineWidth = pg.DepthAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = pg.IntervalAxisY;
                chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = pg.SubdivisionsAxisY;
                chart1.ChartAreas[0].AxisY.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MajorTickMark.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MinorTickMark.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = pg.GridAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = pg.DepthGridAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = pg.ColorGridAxisY;
                chart1.ChartAreas[0].AxisY.Minimum = pg.MinimumAxisY;
                chart1.ChartAreas[0].AxisY.Maximum = pg.MaximumAxisY;



                for (int ss = 0; ss < chart1.Series.Count; ss++)
                {
                    chart1.Series[ss].MarkerSize = pg.SizeMarketsSeries;
                    if(pg.ShowDetailedGrid == true)
                    {
                        CreateDetailedGrid();
                    }
                    else
                    {
                        for (int m = 0; m < 4; m++)
                        {
                            for (int ann = 0; ann < chart1.Annotations.Count; ann++)
                            {
                                chart1.Annotations.RemoveAt(ann);
                            }
                        }
                        
                        chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                        chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                        chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

                    }

                    if (pg.LineStyleSeries == "Nenhuma")
                        chart1.Series[ss].BorderDashStyle = ChartDashStyle.NotSet;
                    if (pg.LineStyleSeries == "Solida")
                        chart1.Series[ss].BorderDashStyle = ChartDashStyle.Solid;
                    if (pg.LineStyleSeries == "Tracejada")
                        chart1.Series[ss].BorderDashStyle = ChartDashStyle.Dash;
                    if (pg.LineStyleSeries == "Pontilhada")
                        chart1.Series[ss].BorderDashStyle = ChartDashStyle.Dot;
                    chart1.Series[ss].BorderWidth = pg.LinesDepthSeries;

                }

                if (pg.ShowLegend == true)
                {
                    chart1.Legends.FindByName("Legend1").Enabled = true;
                }
                else
                {
                    chart1.Legends.FindByName("Legend1").Enabled = false;
                }
            }

            if (Type == "sherpard" || Type == "pejrup" || Type == "folk" || Type == "folkThicks")
            {
                ThernaryDiagramPropertyGrid pg = (ThernaryDiagramPropertyGrid) propertyGrid1.SelectedObject;
                chart1.BackColor = pg.BackgroundColor;
                if (pg.BorderStyle == "Nenhuma")
                    chart1.BorderlineDashStyle = ChartDashStyle.NotSet;
                if (pg.BorderStyle == "Solida")
                    chart1.BorderlineDashStyle = ChartDashStyle.Solid;
                if (pg.BorderStyle == "Tracejada")
                    chart1.BorderlineDashStyle = ChartDashStyle.Dash;
                if (pg.BorderStyle == "Pontilhada")
                    chart1.BorderlineDashStyle = ChartDashStyle.Dot;
                chart1.BorderlineWidth = pg.BorderDepth;
                chart1.BorderlineColor = pg.BorderColor;

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    chart1.Series[0].Points[i].MarkerSize = pg.MarkersSize;

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    chart1.Series[0].Points[i].MarkerColor = pg.MarkerColor;


                if (pg.MarkerStyle == "Círculo")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Circle;
                }
                if (pg.MarkerStyle == "Cruz")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Cross;
                }
                if (pg.MarkerStyle == "Diamante")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Diamond;
                }
                if (pg.MarkerStyle == "Triângulo")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Triangle;
                }
                if (pg.MarkerStyle == "Estrela")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Star10;
                }
                if (pg.MarkerStyle == "Quadrado")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Square;
                }

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    chart1.Series[0].Points[i].LabelForeColor = pg.LabelColor;

                if (pg.ShowLabels == true)
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        chart1.Series[0].Points[i].Label = TempLabels[i];
                        chart1.Series[0].Points[i].LabelForeColor = pg.LabelColor;
                    }
                    TempLabels = new List<string>();
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        TempLabels.Add(chart1.Series[0].Points[i].Label);
                    }
                }
                else
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        chart1.Series[0].Points[i].LabelForeColor = Color.Transparent;
                        chart1.Series[0].Points[i].Label = "";
                    }
                }
            }

            if (Type == "bivariate")
            {
                BivariatePropertyGrid pg = (BivariatePropertyGrid)propertyGrid1.SelectedObject;
                chart1.Titles[0].Text = pg.Title;
                chart1.Titles[0].Font = pg.TitleFont;
                chart1.BackColor = pg.BackgroundColor;
                if (pg.BorderStyle == "Nenhuma")
                    chart1.BorderlineDashStyle = ChartDashStyle.NotSet;
                if (pg.BorderStyle == "Solida")
                    chart1.BorderlineDashStyle = ChartDashStyle.Solid;
                if (pg.BorderStyle == "Tracejada")
                    chart1.BorderlineDashStyle = ChartDashStyle.Dash;
                if (pg.BorderStyle == "Pontilhada")
                    chart1.BorderlineDashStyle = ChartDashStyle.Dot;
                chart1.BorderlineWidth = pg.BorderDepth;
                chart1.BorderlineColor = pg.BorderColor;

                chart1.ChartAreas[0].AxisX.Title = pg.TitleAxisX;
                chart1.ChartAreas[0].AxisX.LineWidth = pg.DepthAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = pg.IntervalAxisX;
                chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = pg.SubdivisionsAxisX;
                chart1.ChartAreas[0].AxisX.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MajorTickMark.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MinorTickMark.LineColor = pg.ColorAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = pg.GridAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = pg.DepthGridAxisX;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = pg.ColorGridAxisX;
                chart1.ChartAreas[0].AxisX.Minimum = pg.MinimumAxisX;
                chart1.ChartAreas[0].AxisX.Maximum = pg.MaximumAxisX;

                chart1.ChartAreas[0].AxisY.Title = pg.TitleAxisY;
                chart1.ChartAreas[0].AxisY.LineWidth = pg.DepthAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.Interval = pg.IntervalAxisY;
                chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = pg.SubdivisionsAxisY;
                chart1.ChartAreas[0].AxisY.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MajorTickMark.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MinorTickMark.LineColor = pg.ColorAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = pg.GridAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = pg.DepthGridAxisY;
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = pg.ColorGridAxisY;
                chart1.ChartAreas[0].AxisY.Minimum = pg.MinimumAxisY;
                chart1.ChartAreas[0].AxisY.Maximum = pg.MaximumAxisY;

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    chart1.Series[0].Points[i].MarkerSize = pg.MarkersSize;

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    chart1.Series[0].Points[i].MarkerColor = pg.MarkerColor;


                if (pg.MarkerStyle == "Círculo")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Circle;
                }
                if (pg.MarkerStyle == "Cruz")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Cross;
                }
                if (pg.MarkerStyle == "Diamante")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Diamond;
                }
                if (pg.MarkerStyle == "Triângulo")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Triangle;
                }
                if (pg.MarkerStyle == "Estrela")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Star10;
                }
                if (pg.MarkerStyle == "Quadrado")
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                        chart1.Series[0].Points[i].MarkerStyle = MarkerStyle.Square;
                }

                for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    chart1.Series[0].Points[i].LabelForeColor = pg.LabelColor;

                if (pg.ShowLabels == true)
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        chart1.Series[0].Points[i].Label = TempLabels[i];
                        chart1.Series[0].Points[i].LabelForeColor = pg.LabelColor;
                    }
                    TempLabels = new List<string>();
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        TempLabels.Add(chart1.Series[0].Points[i].Label);
                    }
                }
                else
                {
                    for (int i = 0; i < chart1.Series[0].Points.Count; i++)
                    {
                        chart1.Series[0].Points[i].LabelForeColor = Color.Transparent;
                        chart1.Series[0].Points[i].Label = "";
                    }
                }
            }
        }

        private void CopiarCélulasSelecionadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyDataGridViewToClipboard(dataGridView1, false);
        }

        private void CopiarTodasAsCélulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyDataGridViewToClipboard(dataGridView1, true, true);
        }

        private void CopyDataGridViewToClipboard(DataGridView dgv, bool includeHeaders = true, bool allRows = false)
        {
            try
            {
                string s = "";
                DataGridViewColumn oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
                if (includeHeaders)
                {
                    do
                    {
                        s = s + oCurrentCol.HeaderText + "\t";
                        oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, DataGridViewElementStates.Visible, DataGridViewElementStates.None);
                    }
                    while (oCurrentCol != null);
                    s = s.Substring(0, s.Length - 1);
                    s = s + Environment.NewLine;    //Get rows
                }
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    oCurrentCol = dgv.Columns.GetFirstColumn(DataGridViewElementStates.Visible);

                    if (row.Selected || allRows)
                    {
                        do
                        {
                            if (row.Cells[oCurrentCol.Index].Value != null) s = s + row.Cells[oCurrentCol.Index].Value.ToString();
                            s = s + "\t";
                            oCurrentCol = dgv.Columns.GetNextColumn(oCurrentCol, DataGridViewElementStates.Visible, DataGridViewElementStates.None);
                        }
                        while (oCurrentCol != null);
                        s = s.Substring(0, s.Length - 1);
                        s = s + Environment.NewLine;
                    }
                }
                Clipboard.SetText(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void SalvarTabelaDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.exportDatagridToFile(dataGridView1, true);
        }

        private void EditarLegendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.ApplyPaletteColors();
            EditLegend form = new EditLegend();
            form.parentForm = this;
            form.type = Type;
            int i = 0;
            if (Type == "frequencyAcc")
            {
                foreach (var serie in chart1.Series)
                {
                    if (i < chart1.Series.Count - 1)
                    {
                        form.dataGridView1.Rows.Add(i.ToString(), serie.LegendText, serie.BorderWidth, serie.Color.ToString());
                        form.dataGridView1.Rows[i].Cells[3].Style.BackColor = serie.Color;
                    }
                    i++;
                }
            }
            else
            {
                
                foreach (var point in chart1.Series[0].Points)
                {
                    form.dataGridView1.Rows.Add(i.ToString(), point.Label, point.MarkerSize, point.MarkerColor.ToString());
                    form.dataGridView1.Rows[i].Cells[3].Style.BackColor = point.MarkerColor;
                    i++;
                }
            }
                
            form.ShowDialog();
        }
    }
}
