// Copyright 2023 Jeff Page

using MathNet.Numerics;
using System.Collections.Generic;

namespace DataNotebookUI.ApplicationService
{
    public struct CurveParameters
    {
        public CurveParameters(double intercept, double slope)
        {
            Intercept = intercept;
            Slope = slope;
        }

        public double Slope { get; }
        public double Intercept { get; }
    }

    public static class CurveFitProvider
    {
        public static CurveParameters FitCurve(List<double> data)
        {
            double[] yValues = data.ToArray();
            double[] xValues = new double[yValues.Length];
            InitializeXValues(xValues);

            var fit = Fit.Line(xValues, yValues); 
            var curveParameters = new CurveParameters(fit.A, fit.B);
            return curveParameters;
        }

        private static void InitializeXValues(double[] xValues)
        {
            for (int i = 0; i < xValues.Length; i++)
            {
                xValues[i] = i;
            }
        }

        public static List<double> GenerateCurve(List<double> data, CurveParameters curveParameters)
        {
            var curveData = new List<double>();

            // TODO

            return curveData;
        }

    }
}
