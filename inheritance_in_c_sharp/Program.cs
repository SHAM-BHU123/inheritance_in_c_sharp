using System;

namespace inheritance_in_c_sharp
{
    //this is a base class
    class shape {

        public int lenght;
        public int breath;

        public void setLength(int l)
        {
            lenght = l;
        }
        public void setBreath(int b)
        {
            breath = b;
        }

    }
    //this is a derived class

    
    class rectangle:shape{
         
         public int area()
        {
            return lenght * breath;
        }
        }

    class Program
    {
        static void Main(string[] args)
        {
            rectangle rec = new rectangle();

            rec.setLength(12);
            rec.setBreath(12);
            int area = rec.area();
            Console.WriteLine("the total area is:{0}", area);

        }
    }
}
