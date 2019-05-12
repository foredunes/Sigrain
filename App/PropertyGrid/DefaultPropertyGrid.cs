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
    class DefaultPropertyGrid
    {
        //OPÇÕES GERAIS DO GRÁFICO
        //Titulo
        string _Title = "Título do meu gráfico";
        [Category("Aparência")]
        [DisplayName("Título do gráfico")]
        [Description("Título principal do gráfico.")]
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        Font _TitleFont;
        [Category("Aparência")]
        [DisplayName("Fonte do titulo")]
        [Description("Fonte do título principal do gráfico.")]
        public Font TitleFont
        {
            get { return _TitleFont; }
            set { _TitleFont = value; }
        }


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

        //EIXO HORIZONTAL X
        string _TitleAxisX = "Texto do eixo X";
        [Category("Eixo Horizontal")]
        [DisplayName("Titulo do eixo X")]
        [Description("Define o titulo do eixo X do gráfico.")]
        public string TitleAxisX
        {
            get { return _TitleAxisX; }
            set { _TitleAxisX = value; }
        }

        int _DepthAxisX = 3;
        [Category("Eixo Horizontal")]
        [Description("Define a espessura do eixo X.")]
        [DisplayName("Espessura do eixo X")]
        public int DepthAxisX
        {
            get { return _DepthAxisX; }
            set { _DepthAxisX = value; }
        }

        double _IntervalAxisX = 5;
        [Category("Eixo Horizontal")]
        [Description("Define o intervalo dos valores do eixo X.")]
        [DisplayName("Intervalo do eixo X")]
        public double IntervalAxisX
        {
            get { return _IntervalAxisX; }
            set { _IntervalAxisX = value; }
        }

        bool _SubdivisionsAxisX;
        [Category("Eixo Horizontal")]
        [Description("Caso seja Sim, exibirá subdivisões do eixo X.")]
        [DisplayName("Exibir subdivisões no eixo X?")]
        public bool SubdivisionsAxisX
        {
            get { return _SubdivisionsAxisX; }
            set { _SubdivisionsAxisX = value; }
        }

        Color _ColorAxisX;
        [Category("Eixo Horizontal")]
        [DisplayName("Cor do eixo X")]
        [DescriptionAttribute("Cor da linha do eixo X.")]
        public Color ColorAxisX
        {
            get { return _ColorAxisX; }
            set { _ColorAxisX = value; }
        }

        bool _GridAxisX;
        [Category("Eixo Horizontal")]
        [Description("Caso seja Sim, exibirá as linhas de grade do eixo X.")]
        [DisplayName("Exibir linhas de grade no eixo X?")]
        public bool GridAxisX
        {
            get { return _GridAxisX; }
            set { _GridAxisX = value; }
        }

        Color _ColorGridAxisX;
        [Category("Eixo Horizontal")]
        [DisplayName("Cor da grade do eixo X")]
        [DescriptionAttribute("Cor da grade do eixo X.")]
        public Color ColorGridAxisX
        {
            get { return _ColorGridAxisX; }
            set { _ColorGridAxisX = value; }
        }

        int _DepthGridAxisX = 3;
        [Category("Eixo Horizontal")]
        [Description("Define a espessura da grade do eixo X.")]
        [DisplayName("Espessura da grade do eixo X")]
        public int DepthGridAxisX
        {
            get { return _DepthGridAxisX; }
            set { _DepthGridAxisX = value; }
        }

        //EIXO VERTICAL Y
        string _TitleAxisY = "Texto do eixo Y";
        [Category("Eixo Vertical")]
        [DisplayName("Titulo do eixo Y")]
        [Description("Define o titulo do eixo Y do gráfico.")]
        public string TitleAxisY
        {
            get { return _TitleAxisY; }
            set { _TitleAxisY = value; }
        }

        int _DepthAxisY = 3;
        [Category("Eixo Vertical")]
        [Description("Define a espessura do eixo Y.")]
        [DisplayName("Espessura do eixo Y")]
        public int DepthAxisY
        {
            get { return _DepthAxisY; }
            set { _DepthAxisY = value; }
        }

        double _IntervalAxisY = 5;
        [Category("Eixo Vertical")]
        [Description("Define o intervalo dos valores do eixo Y.")]
        [DisplayName("Intervalo do eixo Y")]
        public double IntervalAxisY
        {
            get { return _IntervalAxisY; }
            set { _IntervalAxisY = value; }
        }

        bool _SubdivisionsAxisY;
        [Category("Eixo Vertical")]
        [Description("Caso seja Sim, exibirá subdivisões do eixo Y.")]
        [DisplayName("Exibir subdivisões no eixo Y?")]
        public bool SubdivisionsAxisY
        {
            get { return _SubdivisionsAxisY; }
            set { _SubdivisionsAxisY = value; }
        }

        Color _ColorAxisY;
        [Category("Eixo Vertical")]
        [DisplayName("Cor do eixo Y")]
        [DescriptionAttribute("Cor da linha do eixo Y.")]
        public Color ColorAxisY
        {
            get { return _ColorAxisY; }
            set { _ColorAxisY = value; }
        }

        bool _GridAxisY;
        [Category("Eixo Vertical")]
        [Description("Caso seja Sim, exibirá as linhas de grade do eixo Y.")]
        [DisplayName("Exibir linhas de grade no eixo Y?")]
        public bool GridAxisY
        {
            get { return _GridAxisY; }
            set { _GridAxisY = value; }
        }

        Color _ColorGridAxisY;
        [Category("Eixo Vertical")]
        [DisplayName("Cor da grade do eixo Y")]
        [DescriptionAttribute("Cor da grade do eixo Y.")]
        public Color ColorGridAxisY
        {
            get { return _ColorGridAxisY; }
            set { _ColorGridAxisY = value; }
        }

        int _DepthGridAxisY = 3;
        [Category("Eixo Vertical")]
        [Description("Define a espessura da grade do eixo Y.")]
        [DisplayName("Espessura da grade do eixo Y")]
        public int DepthGridAxisY
        {
            get { return _DepthGridAxisY; }
            set { _DepthGridAxisY = value; }
        }

    }
}
