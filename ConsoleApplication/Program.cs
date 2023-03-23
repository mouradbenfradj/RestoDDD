using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        public class BaseClass
        {
            int num;
            public BaseClass()
            {
                Console.WriteLine("in BaseClass()");
            }

            public BaseClass(int i)
            {
                num = i;
                Console.WriteLine("in BaseClass(int i)");
                Console.Read();
            }

            public int GetNum()
            {
                return num;
            }
        }


        public class DerivedClass : BaseClass
        {
            // This constructor will call BaseClass.BaseClass()
            public DerivedClass()
                : base()
            {
            }

            // This constructor will call BaseClass.BaseClass(int i)
            public DerivedClass(int i)
                : base(i)
            {
            }

            static void Main()
            {
                DerivedClass md = new DerivedClass();
                DerivedClass md1 = new DerivedClass(1);
            }
        }
    }
}
