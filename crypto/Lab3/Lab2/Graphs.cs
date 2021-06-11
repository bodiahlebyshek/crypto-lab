using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Graphs : Form
    {
        public Graphs()
        {
            InitializeComponent();

            for (int i = 0; i < Form1.alphabet.Length; i++)
            {
                textChart.Series["Series1"].Points.AddXY(Form1.alphabet[i].ToString(), Form1.textP[i]);
                textChart.ChartAreas[0].AxisX.Interval = 1;
            }
            for (int i = 0; i < Form1.alphabet.Length; i++)
            {
                encryptedTextChart.Series["Series1"].Points.AddXY(Form1.alphabet[i].ToString(), Form1.encryptedTextP[i]);
                encryptedTextChart.ChartAreas[0].AxisX.Interval = 1;
            }
        }
    }
}
