using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceDemo160524
{
    class temp
    {
       public  temp()
        {
            Console.WriteLine("parent constructor called@@@@@");
        }
    }
    class temp2 : temp
    {
        public temp2()
        {
            Console.WriteLine("child constructor called  *****");
        }
    }
    abstract class AbClass
    {
        int x;
        int result;

        public AbClass() //default constructor
        {

            Console.WriteLine("hello");
        }
        public AbClass(int x1,int r1) //para constructor of abstract class
        {
            x = x1;
            result = r1;
        }
        public void show()
        {
            Console.WriteLine("show from Abclass");
        }
        abstract public void display();
    }

    class childOfAbstract:AbClass
    {
        public childOfAbstract():base(11,230)
        {
            Console.WriteLine("child constructor called");
        }
        override public void display()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //AbClass ABObj=new AbClass(); //invalid

            //temp2 t2 = new temp2();//child

            //childOfAbstract chObj = new childOfAbstract();// child

            //Imyinterface m1 = new Imyinterface();//invalid

            SortClass sObj = new SortClass();
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 int numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            sObj.performOperation(arr);
            Console.ReadKey();
        }
    }
}

//what is use of constructor?  why we requied constructor???