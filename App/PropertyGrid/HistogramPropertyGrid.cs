using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Sisgrain.PropertyGrid
{
    class HistogramPropertyGrid : DefaultPropertyGrid
    {

        Color _ColorSerie;
        [Category("Histograma")]
        [DisplayName("Cor da Série")]
        [DescriptionAttribute("Define a cor de preenchimento da série de dados.")]
        public Color ColorSerie
        {
            get { return _ColorSerie; }
            set { _ColorSerie = value; }
        }

        Color _ColorBorderSerie;
        [Category("Histograma")]
        [DisplayName("Cor da borda Série")]
        [DescriptionAttribute("Define a cor das bordas da série de dados.")]
        public Color ColorBorderSerie
        {
            get { return _ColorBorderSerie; }
            set { _ColorBorderSerie = value; }
        }

        private String _BorderStyleSerie = null;
        [Category("Histograma")]
        [DisplayName("Estilo da borda da série")]
        [Description("Define o estilo da borda da série de dados.")]
        [TypeConverter(typeof(BorderStyleConverter))]
        public String BorderStyleSerie
        {
            get { return _BorderStyleSerie; }
            set { _BorderStyleSerie = value; }
        }

        int _BorderDepthSerie = 1;
        [Category("Histograma")]
        [Description("Define a espessura da borda da série.")]
        [DisplayName("Espessura da borda da série")]
        public int BorderDepthSerie
        {
            get { return _BorderDepthSerie; }
            set { _BorderDepthSerie = value; }
        }

    }
}
