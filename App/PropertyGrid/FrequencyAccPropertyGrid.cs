using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisgrain.PropertyGrid
{
    class FrequencyAccPropertyGrid : DefaultPropertyGrid
    {
        int _SizeMarketsSeries = 5;
        [Category("Frequência Acumulada")]
        [Description("Define o tamanho dos marcadores.")]
        [DisplayName("Tamanho dos marcadores")]
        public int SizeMarketsSeries
        {
            get { return _SizeMarketsSeries; }
            set { _SizeMarketsSeries = value; }
        }

        bool _ShowDetailedGrid;
        [Category("Frequência Acumulada")]
        [Description("Caso seja Sim, exibirá a grade detalhada.")]
        [DisplayName("Exibir grade?")]
        public bool ShowDetailedGrid
        {
            get { return _ShowDetailedGrid; }
            set { _ShowDetailedGrid = value; }
        }

        private String _LineStyleSeries = null;
        [Category("Frequência Acumulada")]
        [DisplayName("Estilo das linhas")]
        [Description("Define o estilo das linhas.")]
        [TypeConverter(typeof(BorderStyleConverter))]
        public String LineStyleSeries
        {
            get { return _LineStyleSeries; }
            set { _LineStyleSeries = value; }
        }

        int _LinesDepthSeries = 1;
        [Category("Frequência Acumulada")]
        [Description("Define a espessura das linhas.")]
        [DisplayName("Espessura das linhas")]
        public int LinesDepthSeries
        {
            get { return _LinesDepthSeries; }
            set { _LinesDepthSeries = value; }
        }

        bool _ShowLegend;
        [Category("Legenda")]
        [Description("Caso seja Sim, exibirá a legenda.")]
        [DisplayName("Exibir legenda?")]
        public bool ShowLegend
        {
            get { return _ShowLegend; }
            set { _ShowLegend = value; }
        }
    }
}
