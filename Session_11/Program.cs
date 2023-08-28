using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region Multi-Dim 

            int[] num = new int[4]; //1-D Array

            //int[,] wcs = new int[4, 2];//2-D Array

            //wcs[0, 0] = 10;
            //wcs[0, 1] = 50;
            //wcs[1, 0] = 100;
            //wcs[1, 1] = 50;
            //wcs[2, 0] = 100;
            //wcs[2, 1] = 200;
            //wcs[3, 0] = 10;
            //wcs[3, 1] = 200;


            int[] xValues = { 10, 100, 100, 10 };
            int[] yValues = { 50, 50, 200, 200 };

            int[,] points = new int[xValues.Length, 2];

            for (int row = 0; row < xValues.Length; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    if (col == 0)
                    {
                        points[row, col] = xValues[row];
                    }
                    else
                    {
                        points[row, col] = yValues[row];
                    }

                }
            }


           // #endregion


        }
    }
}
