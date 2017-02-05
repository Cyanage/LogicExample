using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throwaway4
{
    public class Program
    {
        public static A a = new A();
        public static void Main(string[] args)
        {
            H(a, a);
        }

        public static void H(I i2, J j2)
        {
            Console.WriteLine(i2.GetType());
            Console.WriteLine(j2.GetType());
            Console.ReadLine();
        }
    }

    public class A : I, J
    {
        public int i
        {
            get { return 1; }
            set { i = value; }
        }

        public int j
        {
            get { return 2; }
            set { j = value; }
        }
    }

    public interface I
    {
        int i { get; set; }
    }

    public interface J
    {
        int j { get; set; }
    }
}
