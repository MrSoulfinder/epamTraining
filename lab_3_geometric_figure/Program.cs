﻿using System;

namespace lab_3
{
    abstract class Figure
    {
        public abstract string Area();
        public abstract string Perimeter();
        public abstract string ShapeName();
    }

    class Rectangle : Figure
    {
        double sideA;
        double sideB;
        public Rectangle(double rectSideA, double rectSideB)
        {
            SideA = rectSideA;
            sideB = rectSideB;
        }
        public double SideA
        {
            get { return sideA; }
            set { sideA = value < 0 ? -value : value; }
        }
        public override string Area()
        {
            return (sideA * sideB).ToString(); // формула нахождения площади прямоугольника 
                                                                                        
        }

        public override string Perimeter()
        {
            return ((sideA + sideB)*2).ToString(); // формула нахождения периметра прямоугольника
        }
        public override string ShapeName()
        {
            return "Прямогугольник";
        }
    }
    class Program
    {
        static void Main()
        {
            Figure figure1 = new Rectangle(2,4);
            Console.WriteLine(
            $"Название фигуры: {figure1.ShapeName()}\n" +
            $"Площадь: {figure1.Area()}\n" +
            $"Периметр: {figure1.Perimeter()}"
            );
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
