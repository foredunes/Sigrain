using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisgrain.PropertyGrid
{
    class ThernaryDiagramPropertyGrid
    {
        //OPÇÕES GERAIS DO GRÁFICO

        //Background
        Color _BackgroundColor;
        [Category("Aparência")]
        [DisplayName("Cor do fundo")]
        [DescriptionAttribute("Cor do plano de fundo do gráfico.")]
        public Color BackgroundColor
        {
            get { return _BackgroundColor; }
            set { _BackgroundColor = value; }
        }

        //Borda
        private String _BorderStyle = null;
        [Category("Aparência")]
        [DisplayName("Estilo da borda")]
        [Description("Define o estilo da borda do gráfico.")]
        [TypeConverter(typeof(BorderStyleConverter))]
        public String BorderStyle
        {
            get { return _BorderStyle; }
            set { _BorderStyle = value; }
        }

        public class BorderStyleConverter : StringConverter
        {
            public override Boolean GetStandardValuesSupported(ITypeDescriptorContext context) { return true; }
            public override Boolean GetStandardValuesExclusive(ITypeDescriptorContext context) { return true; }
            public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
            {
                List<String> list = new List<String>();
                list.Add("Nenhuma");
                list.Add("Solida");
                list.Add("Tracejada");
                list.Add("Pontilhada");
                return new StandardValuesCollection(list);
            }
        }


        Color _BorderColor;
        [Category("Aparência")]
        [DisplayName("Cor da borda")]
        [DescriptionAttribute("Cor da borda do gráfico.")]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set { _BorderColor = value; }
        }

        int _BorderDepth = 1;
        [Category("Aparência")]
        [Description("Define a espessura da borda.")]
        [DisplayName("Espessura da borda")]
        public int BorderDepth
        {
            get { return _BorderDepth; }
            set { _BorderDepth = value; }
        }

        bool _ShowLabels;
        [Category("Diagrama")]
        [Description("Caso seja Sim, exibirá os rótulos das amostras.")]
        [DisplayName("Exibir rótulos?")]
        public bool ShowLabels
        {
            get { return _ShowLabels; }
            set { _ShowLabels = value; }
        }

        int _MarkersSize = 1;
        [Category("Diagrama")]
        [Description("Define o tamanho dos pontos.")]
        [DisplayName("Tamanho dos pontos")]
        public int MarkersSize
        {
            get { return _MarkersSize; }
            set { _MarkersSize = value; }
        }

        Color _MarkerColor;
        [Category("Diagrama")]
        [DisplayName("Cor dos pontos")]
        [DescriptionAttribute("Cor dos pontos.")]
        public Color MarkerColor
        {
            get { return _MarkerColor; }
            set { _MarkerColor = value; }
        }


        private String _MarkerStyle = null;
        [Category("Diagrama")]
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
        [Category("Diagrama")]
        [DisplayName("Cor dos rótulos")]
        [DescriptionAttribute("Cor dos rótulos.")]
        public Color LabelColor
        {
            get { return _LabelColor; }
            set { _LabelColor = value; }
        }
    }
}
