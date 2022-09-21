using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Array_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product[] products =
            //    {
            //     new Product { id = 1, name = "HPLaptop", price = 35000 },
            //     new Product { id = 2, name = "HPLaptop", price = 35000 },
            //     new Product { id = 3, name = "HPLaptop", price = 35000 },
            //     new Product { id = 4, name = "HPLaptop", price = 35000 },
            //     new Product { id = 5, name = "HPLaptop", price = 35000 },
            //};
            //foreach(Product p in products)
            //{
            //    Console.WriteLine(p);
            //}

            //course[] courses =
            //{
            //    new course{id=1,name="java",fees=45000},
            //    new course{id=2,name="java",fees=45000},
            //    new course{id=3,name="java",fees=45000},
            //    new course{id=4,name="java",fees=45000},
            //    new course{id=4,name="java",fees=45000},

            //};
            //foreach(course c in courses)
            //{
            //    Console.WriteLine(c);
            //}


            //Department[] departments =
            //{
            //    new Department{id=1,name="production",location="Ranjangaon"},
            //    new Department{id=2,name="Assembly",location="Ranjangaon"},
            //    new Department{id=3,name="Quality",location="Kesnand"},
            //    new Department{id=4,name="Finance",location="Shivajinagar"},
            //    new Department{id=5,name="Design",location="Chaakan"},
            //};
            //foreach(Department d in departments)
            //{
            //    Console.WriteLine(d);
            //}

            // Create an Array of 10 integer and find max num from it.

            //int[] number = new[] { 2, 3, 5, 6, 4, 9, 7, 1, 10, 8 };
            //int max = number[0];
            //for (int i = 0; i < number.Length; i++) 
            //{
            //    if (number[i]>max)
            //    {
            //        max = number[i];
            //    }

            //}
            //Console.WriteLine($"max num is {max}");


            ////create an array of 10 integer and find minimum number from it

            //int[] num = new[] { 20, 30, 40, 50, 10, 90, 70, 100, 60 };
            //int min = num[0];

            //for(int i=0;i<num.Length;i++)
            //{
            //    if (num[i]<min)
            //    {
            //        min = num[i];
            //    }
            //}
            //Console.WriteLine($"min num is {min}");


            //// Create an Array and find duplicate num from it


            //int[] arr = new[] { 1, 2, 3, 2, 4, 3, 5 };
            //for(int i=0;i<arr.Length;i++)
            //{
            //    for(int j=i+1;j<arr.Length;j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            Console.WriteLine(arr[j]);
            //        }
            //    }
            //}

            // WAp to find Contigoues sub array whose sum is equalto given input



            //int[] arr = new[] { 12, 5, 31, 9, 21, 8, 40, 5 };
            //int a = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for(int i=0;i<arr.Length;i++)
            //{
            //    sum = arr[i];
            //    for(int j=i+1;j<arr.Length;j++)
            //    {
            //        sum = sum + arr[j];
            //        if(sum==a)
            //        {
            //            for(int k=i;k<=j;k++)
            //            {
            //                Console.WriteLine(arr[k]);
            //            }
            //            Console.WriteLine();
            //        }
            //        else if (sum>a)
            //        {
            //            break;
            //        }


            //    }

            //}



            //wap to divide array into two parts and reverse the two part

            //int[] arr = new[] { 1, 2, 3, 4, 5,6 };
            //int mid = (arr.Length + 1) / 2;
            //int[] firsthalf = new int[mid];
            //int[] secondhalf = new int[arr.Length - mid];
            //Array.Copy(arr, 0,firsthalf,0, mid);
            //Array.Copy(arr,mid, secondhalf,0, secondhalf.Length);
            //foreach(int i in firsthalf)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("------------");
            //foreach(int j in secondhalf)
            //{
            //    Console.WriteLine(j);
            //}
            //Console.WriteLine("------------");
            //Array.Reverse(firsthalf);
            //foreach(int i in firsthalf)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------");
            //Array.Reverse(secondhalf);
            //foreach(int j in secondhalf)
            //{
            //    Console.WriteLine(j);
            //}

           

           
        }

    }
}
