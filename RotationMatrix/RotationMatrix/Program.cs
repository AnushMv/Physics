using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotationMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            double angle = 60;
            double angle1;
            double angle2;
            double angle3;
            
            int width = 3;
            int height = 3;
            double [,] m = new double[width, height];

            m[1,1] = Math.Sin(0);
            m[1,2] = Math.Sin(90);
            m[1,3] = Math.Sin(90);
            m[2,1] = Math.Sin(90);
            m[2,2] = Math.Sin(angle);
            m[2,3] = Math.Sin(90 - angle);
            m[3,1] = Math.Sin(90);
            m[3,2] = Math.Sin(90 + angle);
            m[3,3] = Math.Sin(angle);


            for (int x = 0; x < width; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    Console.Write( m[x, y] + " ");

                }
                Console.WriteLine();
            }


            Console.ReadKey();


            











        }
    }
}
