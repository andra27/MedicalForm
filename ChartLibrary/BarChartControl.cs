using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLibrary
{
    public partial class BarChartControl : UserControl
    {
        private BarChartValue[] _data;
        public BarChartValue[] Data
        {
            get { return _data; }
            set { _data = value;
                Invalidate();
            }
        }
        public BarChartControl()
        {
            InitializeComponent();
            ResizeRedraw = true;
            Data = new[]
            {
                new BarChartValue("2015",30),
                new BarChartValue("2016",80),
                new BarChartValue("2017",40),
                new BarChartValue("2018",50)
            };
        }

        private void BarChartControl_Load(object sender, EventArgs e)
        {

        }

        private void BarChartControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle clipRectangle = e.ClipRectangle;
            var barWidth = clipRectangle.Width / Data.Length;

            var maxBarHeight = clipRectangle.Height * 0.9;
            var scalingFactor = maxBarHeight / Data.Max(x => x.Value);
            Brush redBrush = new SolidBrush(Color.Coral);
            for (int i = 0; i < Data.Length; i++)
            {
                var barHeight = Data[i].Value * scalingFactor;
                graphics.FillRectangle(redBrush,
                    i * barWidth,
                    (float)(clipRectangle.Height - barHeight),
                    (float)(0.8 * barWidth),
                    (float)barHeight);
            }
            
        }
    }
}
