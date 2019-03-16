using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    public class Point
    {
        public double X; //Х
        public double Y; //У
          
        public Point(string x, string y) //конструктор
        {
            if (x.Length != 0)
                X = double.Parse(x.Replace('.', ','));
            if (y.Length != 0)
                Y = double.Parse(y.Replace('.', ','));
        }
    }
}
