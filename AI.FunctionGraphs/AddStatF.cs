using AI.MathMod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.FunctionGraphs
{
    public static class AddStatF
    {
        public static double ScaleCoef(double max, int window)
        {
            return window / max;
        }


        public static Vector NewVector(Vector vect, int window)
        {
            double max = Statistic.MaximalValue(vect), min = Statistic.MinimalValue(vect);
            Vector outp = vect / (max-min);
            return outp*window;
        }
    }
}
