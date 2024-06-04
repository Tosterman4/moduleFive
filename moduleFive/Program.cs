using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace moduleFive
{
    internal class Program
    {
        static string ShowColor(string username,int age)
        {
            Console.WriteLine($"{username},{age} лет.\nНапишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }
        static int[] GetArrayFromConsole(int sum=5)
        {
            var result = new int[sum];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
                return result;
        }

        static int[] SortResult(int[] result)
        {
            int item=0;

            for (int j = 0; j < result.Length; j++)
            {
                for (int k = j+1; k < result.Length; k++)
                {
                    if (result[j] > result[k])
                    {
                        item = result[k];
                        result[k] = result[j];
                        result[j] = item;
                    }
                }
            }

            return result;
        }
        static int[] SortArrayAsc(int[] result)
        {
            int item = 0;

            for (int j = 0; j < result.Length; j++)
            {
                for (int k = j + 1; k < result.Length; k++)
                {
                    if (result[j] > result[k])
                    {
                        item = result[k];
                        result[k] = result[j];
                        result[j] = item;
                    }
                }
            }

            return result;
        }
        static int[] SortArrayDesc(int[] result)
        {
            int item = 0;

            for (int j = 0; j < result.Length; j++)
            {
                for (int k = j + 1; k < result.Length; k++)
                {
                    if (result[j] < result[k])
                    {
                        item = result[k];
                        result[k] = result[j];
                        result[j] = item;
                    }
                }
            }

            return result;
        }
        static void SortArray(in int[] array,out int[] sortedDesc,out int[] sortedAsc)
        {
            int[] arrayClone = (int[])array.Clone();
            sortedDesc = SortArrayDesc(array);
            sortedAsc = SortArrayAsc(arrayClone);
            foreach (int item in sortedDesc)
            {
                Console.WriteLine(item);
            }
            foreach (int item in sortedAsc)
            {
                Console.WriteLine(item);
            }
        }
        static int[] ShowArray(int[] array, bool isSort = false)
        {
            var temp = array;
            if(isSort==true)
            {
                temp = SortResult(array);
            }
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }
        static void SortComplexArray(int[,] arr)
        {
            int temp;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            temp = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = temp;
                        }
                    }
                }
            }
        }
        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static void Main(string[] args)
        {
            //Метод вывода цвета в консоль

            /*var (name, age) = ("Евгения", 27);

            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            string[] favcolor = new string[3];

            for (int i = 0; i < favcolor.Length; i++)
            {
                favcolor[i]=ShowColor(name,age);
            }
            for (int i = 0; i < favcolor.Length; i++)
            {
                Console.Write(favcolor[i]+" ");
            }*/

            //int[,] arr = {{ - 5,6,9,1, 2,3 }, { - 8, 8, 1, 1,2,-3}};
            //SortComplexArray(arr);


            //Задание на сортировку при использовнии необязательного параметра
            int[] arr1 = new Int32[10];
            int[] arr2 = new Int32[10];
            var array = GetArrayFromConsole(10);
            SortArray(in array, out arr1, out arr2);

            /*string someName = "Ринат";
            Console.WriteLine(someName);

            GetName(ref someName);
            Console.WriteLine(someName);*/


            Console.ReadKey();
        }
    }
}
