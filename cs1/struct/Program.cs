using System;

namespace _struct
{
    struct struct1 
    {
        public int a;
        public int b;

        void set()
        {
            a = 10;
            b = 10;
        }
    }


    class Program
{

        static void proc(struct1 str)
        {
            str.a -= 3;
        }

        static void Main(string[] args)
    {
            struct1 str1 = new struct1();

            str1.a = 12;
            str1.b = 12;

            proc(str1);
        }

}
}
