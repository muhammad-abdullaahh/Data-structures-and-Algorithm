using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nMake a choice :\n1.Display the matrices \n2.Addition of Matrices \n3.Subtraction of matrcies " +
                    "\n4.Determinant of a matrciex \n5.Inverse of a matrix\n6.Exit");
                int userChoie = Convert.ToInt32(Console.ReadLine());
                if(userChoie == 6)
                {
                    break;
                }
                int row1 = 2, row2 = 2, col1 = 2, col2 = 2;
                int[,] mat1 = new int[row1, col1];
                int[,] mat2 = new int[row2, col2];
                int[,] addedMatrix = new int[row1, col1];
                int[,] multipliedMatrix = new int[row2, col2];
                double[,] inverseMatrix = new double[row2, col2];

                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        Console.Write("Enter the value at {0},{1} of matrix 1 :", i + 1, j + 1);
                        mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        Console.Write("Enter the value at {0},{1} of matrix 2 :", i + 1, j + 1);
                        mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                switch (userChoie)
                {
                    case 1:
                        Console.WriteLine("Matrix 1 :");
                        for (int i = 0; i < row1; i++)
                        {
                            for (int j = 0; j < col1; j++)
                            {
                                Console.Write(mat1[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Matrix 2 :");
                        for (int i = 0; i < row2; i++)
                        {
                            for (int j = 0; j < col2; j++)
                            {
                                Console.Write(mat2[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        for (int i = 0; i < row1; i++)
                        {
                            for (int j = 0; j < col1; j++)
                            {
                                addedMatrix[i, j] = mat1[i, j] + mat2[i, j];
                            }
                        }
                        Console.WriteLine("Added matrix :");
                        for (int i = 0; i < row2; i++)
                        {
                            for (int j = 0; j < col2; j++)
                            {
                                Console.Write(addedMatrix[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Subtracted matrix :");
                        for (int i = 0; i < row1; i++)
                        {
                            for (int j = 0; j < col1; j++)
                            {
                                Console.Write((mat1[i, j] - mat2[i, j]) + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 4:
                        Console.Write("Select any one matrix from 1 and 2 to take the determinant :");
                        int det = Convert.ToInt32(Console.ReadLine());
                        int determinant;
                        if (det == 1)
                        {
                            determinant = (mat1[0, 0] * mat1[1, 1]) - (mat1[0, 1] * mat1[1, 0]);
                            Console.WriteLine("The determinant of matrix 1 is " + determinant);
                        }
                        else if (det == 2)
                        {
                            determinant = (mat2[0, 0] * mat2[1, 1]) - (mat2[0, 1] * mat2[1, 0]);
                            Console.WriteLine("The determinant of matrix 2 is " + determinant);
                        }
                        break;

                    case 5:
                        Console.Write("Select any one matrix from 1 and 2 to take the inverse :");
                        int inv = Convert.ToInt32(Console.ReadLine());
                        double determinantInverse;
                        if (inv == 1)
                        {
                            determinantInverse = (mat1[0, 0] * mat1[1, 1]) - (mat1[0, 1] * mat1[1, 0]);
                            if (determinantInverse == 0)
                            {
                                Console.WriteLine("Inverse does not exist");
                                break;
                            }
                            inverseMatrix[0, 0] = (double)mat1[1, 1] / determinantInverse;
                            inverseMatrix[0, 1] = -(double)mat1[0, 1] / determinantInverse;
                            inverseMatrix[1, 0] = -(double)mat1[1, 0] / determinantInverse;
                            inverseMatrix[1, 1] = (double)mat1[0, 0] / determinantInverse;
                        }
                        else if (inv == 2)
                        {
                            determinantInverse = (mat2[0, 0] * mat2[1, 1]) - (mat2[0, 1] * mat2[1, 0]);
                            if (determinantInverse == 0)
                            {
                                Console.WriteLine("Inverse does not exist");
                                break;
                            }
                            inverseMatrix[0, 0] = (double)mat2[1, 1] / determinantInverse;
                            inverseMatrix[0, 1] = -(double)mat2[0, 1] / determinantInverse;
                            inverseMatrix[1, 0] = -(double)mat2[1, 0] / determinantInverse;
                            inverseMatrix[1, 1] = (double)mat2[0, 0] / determinantInverse;
                        }
                        for (int i = 0; i < row2; i++)
                        {
                            for (int j = 0; j < col2; j++)
                            {
                                Console.Write(Math.Round(inverseMatrix[i, j], 2) + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 6:
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
