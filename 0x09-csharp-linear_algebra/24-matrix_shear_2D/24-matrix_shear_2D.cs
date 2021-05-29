﻿using System;
using System.Collections.Generic;

///<summary>General class for matrix calculations</summary>
class MatrixMath
{
    ///<summary>Shear a matrix.</summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] bad = new double[,] {{-1}};
        double[,] translate = new double[2, 2] {{1, 0}, {0, 1}};
        double[,] matrix3 = new double[2, 2];
        double temp;

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return (bad);
        }
        if (direction == 'x')
            translate[1, 0] = factor;
        else if (direction == 'y')
            translate[0, 1] = factor;
        else
            return (bad);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                temp = 0;
                for (int k = 0; k < 2; k++)
                {
                    temp += matrix[i, k] * translate[k, j];
                }
                matrix3[i, j] = Math.Round(temp, 2);
            }
        }
        /*
        matrix3[0, 0] = Math.Round(rotate[0, 0] * matrix[0, 0] + rotate[1, 0] * matrix[0, 1], 2);
        matrix3[1, 0] = Math.Round(rotate[0, 0] * matrix[1, 0] + rotate[1, 0] * matrix[1, 1], 2);
        matrix3[0, 1] = Math.Round(rotate[0, 1] * matrix[0, 0] + rotate[1, 1] * matrix[0, 1], 2);
        matrix3[1, 1] = Math.Round(rotate[0, 1] * matrix[1, 0] + rotate[1, 1] * matrix[1, 1], 2);
         */
        return (matrix3);
    }
}