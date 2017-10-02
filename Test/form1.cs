using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AI.FunctionGraphs;
using AI.MathMod.Signals;
using AI.MathMod.AdditionalFunctions;
using AI.MathMod;


namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Vector vectX = MathFunc.GenerateTheSequence(0,0.4, 2);
        double fi = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fi += 0.18;
            Vector vectY = Signal.Sin(vectX, 3, 1, fi);// + Statistic.randNorm(vectX.N);
            functionGraphic1.ShowGraph(vectX, vectY);
        }

        private void functionGraphic1_Load(object sender, EventArgs e)
        {

        }
    }
}
