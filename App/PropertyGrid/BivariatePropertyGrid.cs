using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigran.PropertyGrid
{
    class BivariatePropertyGrid : DefaultPropertyGrid
    {
        bool _ShowLabels;
        [Category("Gráfico de Correlação")]
        [Description("Caso seja Sim, exibirá os rótulos das amostras.")]
        [DisplayName("Exibir rótulos?")]
        public bool ShowLabels
        {
            get { return _ShowLabels; }
            set { _ShowLabels = value; }
        }

        int _MarkersSize = 1;
        [Category("Gráfico de Correlação")]
        [Description("Define o tamanho dos pontos.")]
        [DisplayName("Tamanho dos pontos")]
        public int MarkersSize
        {
            get { return _MarkersSize; }
            set { _MarkersSize = value; }
        }

        Color _MarkerColor;
        [Category("Gráfico de Correlação")]
        [DisplayName("Cor dos pontos")]
        [DescriptionAttribute("Cor dos pontos.")]
        public Color MarkerColor
        {
            get { return _MarkerColor; }
            set { _MarkerColor = value; }
        }


        private String _MarkerStyle = null;
        [Category("Gráfico de Correlação")]
        [DisplayName("Estilo do ponto")]
        [Description("Define o estilo dos pontos.")]
        [TypeConverter(typeof(MarkerStyleConverter))]
        public String MarkerStyle
        {
            get { return _MarkerStyle; }
            set { _MarkerStyle = value; }
        }
        public class MarkerStyleConverter : StringConverter
        {
            public override Boolean GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                List<String> list = new List<String>();
                list.Add("Círculo");
                list.Add("Cruz");
                list.Add("Diamante");
                list.Add("Quadrado");
                list.Add("Triângulo");
                list.Add("Estrela");
                return new StandardValuesCollection(list);
            }
        }

        Color _LabelColor;
        [Category("Gráfico de Correlação")]
        [DisplayName("Cor dos rótulos")]
        [DescriptionAttribute("Cor dos rótulos.")]
        public Color LabelColor
        {
            get { return _LabelColor; }
            set { _LabelColor = value; }
        }
    }
}
