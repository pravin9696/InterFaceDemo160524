using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceDemo160524
{
    interface Imyinterface
    {
        //int x;//invalid 
         int myVar { get; set; }//property declaration
        void show();//abstract
        int sum(int x, int y);
        void display();
        int mul(int x, float y, double z);
        
        
    }

    class c123 : Imyinterface
    {
        public int myVar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void display()
        {
            Console.WriteLine("sdfasdfsadf");
        }

        public int mul(int x, float y, double z)
        {
            throw new NotImplementedException();
        }

        public void show()
        {
            throw new NotImplementedException();
        }

        public int sum(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    class childOfInterface:Imyinterface
    {
        public int myVar { get; set; }

        public int sum(int P, int Q1T)
        {
            return 1;
        }
        public int mul(int a,float b,double c)
        {
            return 6;
        }
        public void display()
        {

        }
       
        public void show()
        {

        }
    }
    internal class interDemo
    {
    }
}
