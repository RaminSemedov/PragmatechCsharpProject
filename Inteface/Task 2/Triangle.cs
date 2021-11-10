using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Triangle:IFigure
    {
        public Triangle(double sideA, double sideB, double sideC, double height)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = height;
        }

        public double SideA
        {
            set
            {
                if (value > 0)
                {
                    SideA = value;
                }
            }
            get
            {
                return SideA;
            }
        }
        public double SideB
        {
            set
            {
                if (value > 0)
                {
                    SideB = value;
                }
            }
            get
            {
                return SideB;
            }
        }

        public double SideC
        {
            set
            {
                if (value > 0)
                {
                    SideC = value;
                }
            }
            get
            {
                return SideC;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    Height = value;
                }
            }
            get
            {
                return Height;
            }
        }


        public double CalculateArea()
        {
            return SideA * Height / 2;
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }
    }
}
