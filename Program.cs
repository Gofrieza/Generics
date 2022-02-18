// See https://aka.ms/new-console-template for more information
using GenericDemo;
using static GenericDemo.GenericMethod;

    //Console.WriteLine("Hello World!");
int[] intArray = { 2, 4, 5, 6, 8 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
double[] doubleArray = { 1.1, 3.3, 5.5, 8.7 };
GenericMethod.Display<int>(intArray);
GenericMethod.Display<char>(charArray);
GenericMethod.Display<double>(doubleArray);
Console.ReadKey();