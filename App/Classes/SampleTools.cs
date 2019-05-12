using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisgrain.Classes
{
    class SampleTools
    {
        public List<decimal> getPhiKeys()
        {
            List<decimal> phiKey = new List<decimal>();

            phiKey.Add((decimal)-4.0);
            phiKey.Add((decimal)-3.5);
            phiKey.Add((decimal)-3.0);
            phiKey.Add((decimal)-2.5);
            phiKey.Add((decimal)-2.0);
            phiKey.Add((decimal)-1.5);
            phiKey.Add((decimal)-1.0);
            phiKey.Add((decimal)-0.5);
            phiKey.Add((decimal)0.0);
            phiKey.Add((decimal)0.5);
            phiKey.Add((decimal)1.0);
            phiKey.Add((decimal)1.5);
            phiKey.Add((decimal)2.0);
            phiKey.Add((decimal)2.5);
            phiKey.Add((decimal)3.0);
            phiKey.Add((decimal)3.5);
            phiKey.Add((decimal)4.0);
            phiKey.Add((decimal)4.5);
            phiKey.Add((decimal)5.0);
            phiKey.Add((decimal)6.0);
            phiKey.Add((decimal)7.0);
            phiKey.Add((decimal)8.0);
            phiKey.Add((decimal)9.0);
            phiKey.Add((decimal)10.0);
            phiKey.Add((decimal)11.0);
            phiKey.Add((decimal)12.0);

            return phiKey;
        }


        public List<decimal> getDmmKeys()
        {
            List<decimal> dmmKey = new List<decimal>();

            dmmKey.Add((decimal)16.0);
            dmmKey.Add((decimal)11.3137);
            dmmKey.Add((decimal)8.0);
            dmmKey.Add((decimal)5.6569);
            dmmKey.Add((decimal)4.0);
            dmmKey.Add((decimal)2.8284);
            dmmKey.Add((decimal)2.0);
            dmmKey.Add((decimal)1.4142);
            dmmKey.Add((decimal)1.0);
            dmmKey.Add((decimal)0.7071);
            dmmKey.Add((decimal)0.5);
            dmmKey.Add((decimal)0.3536);
            dmmKey.Add((decimal)0.25);
            dmmKey.Add((decimal)0.1768);
            dmmKey.Add((decimal)0.1250);
            dmmKey.Add((decimal)0.0884);
            dmmKey.Add((decimal)0.0625);
            dmmKey.Add((decimal)0.0442);
            dmmKey.Add((decimal)0.0313);
            dmmKey.Add((decimal)0.0156);
            dmmKey.Add((decimal)0.0078);
            dmmKey.Add((decimal)0.0039);
            dmmKey.Add((decimal)0.002);
            dmmKey.Add((decimal)0.001);
            dmmKey.Add((decimal)0.0005);
            dmmKey.Add((decimal)0.0002);

            return dmmKey;
        }

        public List<string> getPhiClassifications(String method)
        {
            List<string> phiClassification = new List<string>();
            if(method == "Wentworth(1922)")
            {
                phiClassification.Add("Seixo");
                phiClassification.Add("Seixo");
                phiClassification.Add("Seixo");
                phiClassification.Add("Seixo");
                phiClassification.Add("Seixo");
                phiClassification.Add("Granulo");
                phiClassification.Add("Granulo");
                phiClassification.Add("Areia muito grossa");
                phiClassification.Add("Areia muito grossa");
                phiClassification.Add("Areia grossa");
                phiClassification.Add("Areia grossa");
                phiClassification.Add("Areia média");
                phiClassification.Add("Areia média");
                phiClassification.Add("Areia fina");
                phiClassification.Add("Areia fina");
                phiClassification.Add("Areia muito fina");
                phiClassification.Add("Areia muito fina");
                phiClassification.Add("Silte grosso");
                phiClassification.Add("Silte grosso");
                phiClassification.Add("Silte médio");
                phiClassification.Add("Silte fino");
                phiClassification.Add("Silte muito fino");
                phiClassification.Add("Argila grossa");
                phiClassification.Add("Argila ultra-grossa");
                phiClassification.Add("Argila ultra-grossa");
                phiClassification.Add("Argila ultra-grossa");
                phiClassification.Add("Argila ultra-grossa");
            }

            if (method == "Friedman(1978)")
            {
                phiClassification.Add("Seixo grosso");
                phiClassification.Add("Seixo médio");
                phiClassification.Add("Seixo médio");
                phiClassification.Add("Seixo fino");
                phiClassification.Add("Seixo fino");
                phiClassification.Add("Seixo muito fino");
                phiClassification.Add("Seixo muito fino");
                phiClassification.Add("Areia muito grossa");
                phiClassification.Add("Areia muito grossa");
                phiClassification.Add("Areia grossa");
                phiClassification.Add("Areia grossa");
                phiClassification.Add("Areia média");
                phiClassification.Add("Areia média");
                phiClassification.Add("Areia fina");
                phiClassification.Add("Areia fina");
                phiClassification.Add("Areia muito fina");
                phiClassification.Add("Areia muito fina");
                phiClassification.Add("Silte grosso");
                phiClassification.Add("Silte grosso");
                phiClassification.Add("Silte grosso");
                phiClassification.Add("Silte médio");
                phiClassification.Add("Silte fino");
                phiClassification.Add("Silte muito fino");
                phiClassification.Add("Argila");
                phiClassification.Add("Argila");
                phiClassification.Add("Argila");
                phiClassification.Add("Argila");
            }

            if (method == "Blott(2001)")
            {
                phiClassification.Add("Granulo grosso");
                phiClassification.Add("Granulo médio");
                phiClassification.Add("Granulo médio");
                phiClassification.Add("Granulo fino");
                phiClassification.Add("Granulo fino");
                phiClassification.Add("Granulo muito fino");
                phiClassification.Add("Granulo muito fino");
                phiClassification.Add("Areia muito grossa");
                phiClassification.Add("Areia muito grossa");
                phiClassification.Add("Areia grossa");
                phiClassification.Add("Areia grossa");
                phiClassification.Add("Areia média");
                phiClassification.Add("Areia média");
                phiClassification.Add("Areia fina");
                phiClassification.Add("Areia fina");
                phiClassification.Add("Areia muito fina");
                phiClassification.Add("Areia muito fina");
                phiClassification.Add("Silte grosso");
                phiClassification.Add("Silte grosso");
                phiClassification.Add("Silte grosso");
                phiClassification.Add("Silte médio");
                phiClassification.Add("Silte fino");
                phiClassification.Add("Silte muito fino");
                phiClassification.Add("Argila");
                phiClassification.Add("Argila");
                phiClassification.Add("Argila");
                phiClassification.Add("Argila");
            }



            return phiClassification;
        }

        public string getPhiClassificationSimple(decimal phi)
        {
            string classification = "";
            if (phi <= -1m)
            {
                classification = "Seixo";
            }
            if (phi<=0 && phi > -1m)
            {
                classification = "Areia muito grossa";
            }
            if (phi <= 1 && phi > 0)
            {
                classification = "Areia grossa";
            }
            if (phi <= 2 && phi > 1)
            {
                classification = "Areia média";
            }
            if (phi <= 3 && phi > 2)
            {
                classification = "Areia fina";
            }
            if (phi <= 4 && phi > 3)
            {
                classification = "Areia muito fina";
            }
            if (phi <= 9 && phi > 4)
            {
                classification = "Silte";
            }
            if (phi > 9)
            {
                classification = "Argila";
            }

            return classification;
        }

        public string getClassificationBySelection(decimal selection)
        {
            string r = "";
            if(selection < 0.35m)
            {
                r = "Muito bem selecionado";
            }
            if (selection > 0.35m && selection <= 0.5m)
            {
                r = "Bem selecionado";
            }
            if (selection > 0.5m && selection <= 1m)
            {
                r = "Moderadamente selecionado";
            }
            if (selection > 1m && selection <= 2m)
            {
                r = "Pobremente selecionado";
            }
            if (selection > 2m && selection <= 4m)
            {
                r = "Muito pobremente selecionado";
            }
            if (selection > 4m)
            {
                r = "Extremamente mal selecionado";
            }

            return r;
        }

        public string getClassificationByAssimetry(decimal assimetry)
        {
            string r = "";
            if (assimetry < -1.3m)
            {
                r = "Muito negativa";
            }
            if (assimetry > -1.3m && assimetry <= -0.43m)
            {
                r = "Negativa";
            }
            if (assimetry > -0.43m && assimetry <= 0.43m)
            {
                r = "Aproximadamente simétrica";
            }
            if (assimetry > 0.43m && assimetry <= 1.3m)
            {
                r = "Positiva";
            }
            if (assimetry > 1.3m)
            {
                r = "Muito positiva";
            }

            return r;
        }

        public string getClassificationByCurtose(decimal curtose)
        {
            string r = "";
            if (curtose < 1.7m)
            {
                r = "Muito plasticústica";
            }
            if (curtose > 1.7m && curtose <= 2.55m)
            {
                r = "Plasticústica";
            }
            if (curtose > 2.55m && curtose <= 3.7m)
            {
                r = "Mesocústica";
            }
            if (curtose > 3.7m && curtose <= 7.4m)
            {
                r = "Leptocústica";
            }
            if (curtose > 7.4m && curtose <= 15m)
            {
                r = "Muito leptocústica";
            }
            if (curtose > 15m)
            {
                r = "Extremamente leptocústica";
            }

            return r;
        }

        public decimal getTotalWeight(Sample sample)
        {
            //peso total
            Decimal totalWeight = sample.Peso0 + sample.Peso1 + sample.Peso2 + sample.Peso3 + sample.Peso4 + sample.Peso5 + sample.Peso6 + sample.Peso7 + sample.Peso8 + sample.Peso9 + sample.Peso10 + sample.Peso11 + sample.Peso12 + sample.Peso13 + sample.Peso14 + sample.Peso15 + sample.Peso16 + sample.Peso17 + sample.Peso18 + sample.Peso19 + sample.Peso20 + sample.Peso21 + sample.Peso22 + sample.Peso23 + sample.Peso24 + sample.Peso25;
            return (totalWeight);
        }

        public List<decimal> getWeights(Sample sample)
        {
            Decimal totalWeight = getTotalWeight(sample);

            List<decimal> weights = new List<decimal>();

            for (int i = 0; i < 26; i++)
            {
                PropertyInfo pinfo = typeof(Sample).GetProperty("Peso" + i);
                decimal weight = (decimal)pinfo.GetValue(sample);
                weights.Add(weight);
            }

            return weights;
        }

        public List<decimal> getFrequencies(Sample sample)
        {
            Decimal totalWeight = getTotalWeight(sample);

            List<decimal> frequencies = new List<decimal>();

            for (int i = 0; i < 26; i++)
            {
                PropertyInfo pinfo = typeof(Sample).GetProperty("Peso" + i);
                decimal weight = (decimal)pinfo.GetValue(sample);
                decimal frequency = (weight / totalWeight) * 100;
                frequencies.Add(frequency);
            }

            return frequencies;
        }

        public decimal getTotalFrequencies(Sample sample)
        {
            List<decimal> frequencies = getFrequencies(sample);
            decimal total = frequencies.Sum(x => Convert.ToDecimal(x));
            return total;
        }

        public List<decimal> getFrequenciesAcc(Sample sample)
        {
            Decimal totalWeight = getTotalWeight(sample);

            List<decimal> frequenciesAcc = new List<decimal>();

            decimal oldFrequency = 0;

            for (int i = 0; i < 26; i++)
            {
                PropertyInfo pinfo = typeof(Sample).GetProperty("Peso" + i);
                decimal weight = (decimal)pinfo.GetValue(sample);
                decimal frequency = ((weight / totalWeight) * 100) + oldFrequency;
                frequenciesAcc.Add(frequency);
                oldFrequency = frequency;
            }

            return frequenciesAcc;
        }

        public List<decimal> getPh1MidPoints()
        {
            List<decimal> ph1MidPoints = new List<decimal>();
            List<decimal> phiKeys = getPhiKeys();
            decimal oldPoint = -12;

            for (int i = 0; i < 26; i++)
            {
                decimal midPoint = (phiKeys[i] + oldPoint)/2;
                ph1MidPoints.Add(midPoint);
                oldPoint = phiKeys[i];
            }

            return ph1MidPoints;
        }

        public List<decimal> getWeightsPerClass(Sample sample)
        {
            List<decimal> weightsPerClass = new List<decimal>();

            List<decimal> Frequencies = getFrequencies(sample);
            List<decimal> midPoints = getPh1MidPoints();

            for (int i = 0; i < 26; i++)
            {
                weightsPerClass.Add(Frequencies[i] * midPoints[i]);
            }

            return weightsPerClass;
        }

        public decimal getTotalWeightsPerClass(Sample sample)
        {
            List<decimal> WeightsPerClass = getWeightsPerClass(sample);
            decimal total = WeightsPerClass.Sum(x => Convert.ToDecimal(x));
            return total;
        }

        public decimal getMedia(Sample sample)
        {
            decimal media = getTotalWeightsPerClass(sample) / getTotalFrequencies(sample);
            return media;
        }

        public decimal getMediana(Sample sample)
        {
            decimal frequencyMediana = getTotalFrequencies(sample) / 2;

            List<decimal> FrequenciesAcc = getFrequenciesAcc(sample);
            List<decimal> phiKeys = getPhiKeys();
            List<decimal> frequencies = getFrequencies(sample);

            int classMediana = 0;

            for (int i = 0; i < 26; i++)
            {
                if (frequencyMediana <= FrequenciesAcc[i] && frequencyMediana > FrequenciesAcc[i - 1])
                {
                    classMediana = i;
                }
            }

            decimal mediana = 0;

            if (classMediana > 0)
            {
                decimal phiClass = phiKeys[classMediana];
                decimal frequencyClass = frequencies[classMediana];
                decimal phiClassPrev = phiKeys[classMediana - 1];
                decimal frequencyAccClassPrev = FrequenciesAcc[classMediana - 1];
                decimal totalFrequencies = getTotalFrequencies(sample);

                mediana = phiClassPrev + ((((totalFrequencies / 2) - frequencyAccClassPrev) * (phiClass - phiClassPrev)) / frequencyClass);
            }
            
            return mediana;
        }

        public List<decimal> getPercentis(Sample sample)
        {
            List<decimal> percentis = new List<decimal>();

            List<decimal> FrequenciesAcc = getFrequenciesAcc(sample);
            List<decimal> phiKeys = getPhiKeys();
            List<decimal> frequencies = getFrequencies(sample);

            percentis.Add(0);

            //Faz o loop nos quartis
            for (int k = 1; k < 100; k++)
            {
                //Obtem a frequencia do quartil
                decimal totalFrequencies = getTotalFrequencies(sample);
                decimal frequencyPercentil = (totalFrequencies / 100) * k;

                //Obtem a classe do quartil
                int classQuartil = 0;
                for (int i = 0; i < 26; i++)
                {
                    try
                    {
                        if (frequencyPercentil <= FrequenciesAcc[i] && frequencyPercentil > FrequenciesAcc[i - 1])
                        {
                            classQuartil = i;
                        }
                    }
                    catch
                    {

                    }
                }

                decimal quartil = 0;

                if (classQuartil > 0)
                {
                    decimal phiClass = phiKeys[classQuartil];
                    decimal frequencyClass = frequencies[classQuartil];
                    decimal phiClassPrev = phiKeys[classQuartil - 1];
                    decimal frequencyAccClassPrev = FrequenciesAcc[classQuartil - 1];

                    quartil = ((((k * (totalFrequencies / 100)) - frequencyAccClassPrev) * (phiClass - phiClassPrev)) / frequencyClass) + phiClassPrev;
                }

                percentis.Add(quartil);
            }

            return percentis;
        }

        public List<decimal> getStatisticsByMehtod(string method, Sample sample)
        {
            List<decimal> statistics = new List<decimal>();
            List<decimal> percentis = getPercentis(sample);
            decimal media = 0;
            decimal selection = 0;
            if (method == "Folk&Ward(1957)")
            {
                media = (percentis[16] + percentis[50] + percentis[84]) / 3;
                selection = ((percentis[84] - percentis[16]) / 4) + ((percentis[95] - percentis[5]) / 6.6m);
            }
            if (method == "McCammonA(1962)")
            {
                media = (percentis[10] + percentis[30] + percentis[50] + percentis[70] + percentis[90]) / 5;
                selection = (percentis[85] + percentis[95] - percentis[5] - percentis[15]) / 5.4m;
            }
            if (method == "McCammonB(1962)")
            {
                media = (percentis[5] + percentis[15] + percentis[25] + percentis[35] + percentis[45] + percentis[55] + percentis[65] + percentis[75] + percentis[85] + percentis[95]) / 10m;
                selection = (percentis[70] + percentis[80] + percentis[90] + percentis[97] - percentis[3] - percentis[10] - percentis[20] - percentis[30]) / 9.1m;
            }
            if (method == "Trask(1930)")
            {
                media = percentis[50];
                selection = (percentis[75] - percentis[25]) / 1.35m;
            }
            if (method == "Otto(1939)")
            {
                media = (percentis[16] + percentis[84]) / 2;
                selection = (percentis[84] - percentis[16]) / 2;
            }

            decimal assimetry = (
                                    (percentis[16] + percentis[84] - (2 * percentis[50])) /
                                    (2 * (percentis[84] - percentis[16]))
                                ) +
                                (
                                    (percentis[5] + percentis[95] - (2 * percentis[50])) /
                                    (2 * (percentis[95] - percentis[5]))
                                );

            decimal curtose = (percentis[95] - percentis[5]) / 
                              (2.44m * (percentis[75] - percentis[25]));

            statistics.Add(media);
            statistics.Add(percentis[50]);
            statistics.Add(selection);
            statistics.Add(assimetry);
            statistics.Add(curtose);

            return statistics;
        }

        public decimal getStatistics(Sample sample)
        {

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+"###"+getPercentis(sample)[i]);
            }
            Console.WriteLine("***"+ getMediana(sample));

            /*Decimal totalWeight = getTotalWeight(sample);

            List<decimal> frequenciesAcc = new List<decimal>();

            decimal oldFrequency = 0;

            for (int i = 0; i < 26; i++)
            {
                PropertyInfo pinfo = typeof(Sample).GetProperty("Peso" + i);
                decimal weight = (decimal)pinfo.GetValue(sample);
                decimal frequency = ((weight / totalWeight) * 100) + oldFrequency;
                frequenciesAcc.Add(frequency);
                oldFrequency = frequency;
            }

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(frequenciesAcc[i]);
            }*/


            return new Decimal();
        }

    }
}
