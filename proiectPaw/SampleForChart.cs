using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartLibrary;

namespace proiectPaw
{
    public partial class SampleForChart : Form
    {
        public SampleForChart()
        {
            InitializeComponent();
        }

        private void SampleForChart_Load(object sender, EventArgs e)
        {
            var data = new BarChartValue[]
           {
                new BarChartValue("2010", 10),
                new BarChartValue("2011", 20),
                new BarChartValue("2012", 30),
                new BarChartValue("2013", 40)
           };


            barChartControl1.Data = data;
            
        }

       
    }
}
