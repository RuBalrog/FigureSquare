using System;

namespace WindowsFormsApplication1
{
    class FigureSquare
    {
        public enum FigureType
        {
            Triangle,
            Circle
        }

        private double[] sideFigures;
        private int typeOfFigure;

        public FigureSquare()
        {
            typeOfFigure = -1;
            sideFigures = new double[4];
            SetSideOfFigure(0,0,0,0);
        }

        public FigureSquare(FigureType figure, double side1 = 0, double side2 = 0, double side3 = 0, double side4 = 0)
        {
            typeOfFigure = (int)figure;
            sideFigures = new double[4];
            SetSideOfFigure(side1, side2, side3, side4);
        }

        public void SetTypeOfFigure(FigureType figure)
        {
            typeOfFigure = (int)figure;
        }

        public void SetSideOfFigure(double side1 = 0, double side2 = 0, double side3 = 0, double side4 = 0)
        {
            sideFigures[0] = side1;
            sideFigures[1] = side2;
            sideFigures[2] = side3;
            sideFigures[3] = side4;
        }

        public double SquareOfCircleOnRadius()
        {
            if (typeOfFigure != (int)FigureType.Circle || sideFigures[0]<=0) return 0;

            return Math.PI * Math.Pow(sideFigures[0], 2);
        }

        public double SquareOfTriangle()
        {
            if (typeOfFigure != (int)FigureType.Triangle || sideFigures[0] <= 0 || sideFigures[1] <= 0 || sideFigures[2]<=0) return 0;

            double p = (sideFigures[0] + sideFigures[1] + sideFigures[2]) / 2;

            return Math.Sqrt(p * (p - sideFigures[0]) * (p - sideFigures[1]) * (p - sideFigures[2]));
        }

        public bool IsTriangleRight()
        {
            if (Math.Pow(sideFigures[0], 2) == Math.Pow(sideFigures[1], 2) + Math.Pow(sideFigures[2], 2) ||
                Math.Pow(sideFigures[1], 2) == Math.Pow(sideFigures[0], 2) + Math.Pow(sideFigures[2], 2) ||
                Math.Pow(sideFigures[2], 2) == Math.Pow(sideFigures[0], 2) + Math.Pow(sideFigures[1], 2))
                return true;
            else return false;
        }
    }

}