using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceDemo160524
{
    interface IArrayOperations
    {
        void performOperation(int[]x);
    }
    class SortClass:IArrayOperations
    {
        public void performOperation(int[]x)
        {
            Console.WriteLine("Array before sort:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("\t" + x[i]);
            }
            // logic to sort array x
            int temp;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i+1; j < x.Length; j++)
                {
                    if (x[i] > x[j]) //ASC order sorting
                    {
                        temp = x[i];
                        x[i]= x[j];
                        x[j]= temp;
                    }
                }
            }
            Console.WriteLine("\nArray After sort:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write("\t" + x[i]);
            }
        }
    }
    public  class Insertion:IArrayOperations
    {
        public void performOperation(int[]x)
        {

        }
    }
    internal class ArrayOperationInterfaceDemo
    {
    }
}
