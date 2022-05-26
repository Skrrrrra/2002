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

            //для создания файла
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();

            //чтение файлов из массива
            int[] arr2 = File.ReadAllText(inputpath).Split(' ').Select(m => int.Parse(m)).ToArray();

            
            int sum = 0;
            //для создания файла
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();
            //сложение элементов массива и запись в output.txt
            for (int i=0; i<arr2.Length;i++)
            {
                sum+=Convert.ToInt32(arr2[i]);
            }
            File.WriteAllText(outputpath,sum.ToString());


        }
    }
}
    

