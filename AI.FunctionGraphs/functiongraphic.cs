using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AI.MathMod;

namespace AI.FunctionGraphs
{
    public partial class FunctionGraphic: UserControl
    {
        public FunctionGraphic()
        {
            InitializeComponent();
        }

        private void FunctionGraphic_Load(object sender, EventArgs e)
        {

        }








        public void ShowGraph(Vector vectorX, Vector vectorY)
        {
            Bitmap bmp = new Bitmap(800,600);

            Vector v1 = AddStatF.NewVector(vectorX, 800), v2 = AddStatF.NewVector(vectorY, 500);

            PointF[] points = new PointF[vectorX.N];


            Graphics gr = Graphics.FromImage(bmp);

            for (int i = 0; i < 600; i += 50)
            {
                gr.DrawLine(new Pen(Color.Black, 1), 0, i, 800, i);
            }

            for (int i = 0; i < 800; i += 50)
            {
                gr.DrawLine(new Pen(Color.Black, 1), i, 0, i, 600);
            }

            gr.DrawLine(new Pen(Color.Black, 6), 0, 550, 800, 550);
            gr.DrawLine(new Pen(Color.Black, 6), 50, 0, 50, 600);



            for (int i = 0; i < vectorX.N; i++)
            {
                points[i] = new PointF((float)v1.Vecktor[i], 300-(float)( v2.Vecktor[i]));
            }

            gr.DrawLines(new Pen(Color.Green, 3), points);
            gr.DrawCurve(new Pen(Color.Blue, 3), points, (float)0.6);


        
         //   bmp = new Bitmap(bmp.Width, bmp.Height, gr);

            pictureBox1.Image = bmp;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
