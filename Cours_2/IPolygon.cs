using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Cours_2
{

    interface IPolygon
    {
        string Name
        {
            get;
            set;
        }
        int NumOfSides
        {
            get;
            set;
        }
        void calculateArea(params int[] sides);
    }

    interface IColor
    {
        void getColor();

    }

    class Rectangle : IPolygon, IColor
    {

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private int _numOfSides;
        public int NumOfSides
        {
            get => _numOfSides;
            set => _numOfSides= value;
        }

        public void calculateArea(int[] sides)
        {
            int area = sides[0] * sides[1];
            Console.WriteLine("Area of Rectangle:" + area);
        }

        public void getColor()
        {
            Console.WriteLine("Red Rectangle");
        }

        public Rectangle() => _numOfSides = 4;
                
    }

    class Triangle: IPolygon, IColor
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private int _numOfSides;
        public int NumOfSides
        {
            get => _numOfSides;
            set => _numOfSides = value;
        }

        public void calculateArea(int[] sides)
        {
            var s = (sides[0] * sides[1] * sides[2])/2;
            double area = Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]));
            Console.WriteLine("Area of Triangle:" + _name+"is"+ area);
        }
        
        public void getColor()
        {
            Console.WriteLine("Green Rectangle");
        }

        public Triangle() => _numOfSides = 3;
    }


}




