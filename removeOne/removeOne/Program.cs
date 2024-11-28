using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeOne
{
    internal class Program
    {
        static int indexDel(int[] arr, int nums)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(nums == arr[i])
                {
                    return i;
                }
            }

            return -1;
        }
        static void remove(int[] arr, int pos)
        {
            for (int i = pos; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = 0;
        }
        static void Main(string[] args)
        {
            int size;
            int[] array;

            //nhap kich thuoc mang
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                    Console.WriteLine("Size should not exceed 20");
            } while (size > 20);

            //nhap gia tri
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            //in mang ban dau
            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + ((j == array.Length - 1) ? " " : ", "));
            }

            //nhap gia tri can xoa
            Console.WriteLine();
            bool isValid = false;
            int num;
            do
            {
                Console.WriteLine("Enter element to remove: ");
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out num);
                if ((!isValid))
                {
                    Console.WriteLine("Invalid!");
                }
            } while ((!isValid));

            int index = indexDel(array, num);
            if (index == -1)
            {
                Console.WriteLine("{0} is not in array", num);
            }
            else
            {
                remove(array, index);
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write(array[j]+ " ");
                }
            }
            Console.ReadLine() ;
        }
    }
}
