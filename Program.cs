using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SummOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string inputpath = "D:\\SolutionsForSpaceApp\\2002\\input.txt";
                string outputpath = "D:\\SolutionsForSpaceApp\\2002\\output.txt";


            //запись в массив
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr;
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //запись в файл из массива
             
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            File.WriteAllText(inputpath, string.Join(" ",arr));

            //чтение файлов в другой массив
            StreamReader fstake = new StreamReader(inputpath, Encoding.Unicode);
            int[] arr2 = File.ReadAllText(inputpath).Split(' ').Select(m => int.Parse(m)).ToArray();

            //сложение элементов массива и запись в output.txt
            int sum = 0;
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();
            for (int i=0; i<arr2.Length;i++)
            {
                sum+=Convert.ToInt32(arr2[i]);
            }
            File.WriteAllText(outputpath,sum.ToString());


        }
    }
}
    

