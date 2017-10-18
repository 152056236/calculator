using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testclass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true, b = true;
            string flag = "y";
            while (flag == ("y") || flag == ("Y"))
            { 
            Console.WriteLine("welcome!");
                double result, op;
                string c, d;
                string z;
                Console.WriteLine("输入第一个操作数:");
                    c =Console.ReadLine();
                    Cal1.A = c;
                Console.WriteLine("输入第二个操作数:");
                d = Console.ReadLine();
                Cal1.B = d;
                Console.WriteLine("输入要进行的运算（1--加法，2--减法，3--乘法，4--除法）:");                
                op = Convert.ToDouble(Console.ReadLine());
                string s;
                if (op == null)
                {
                    result = 0;
                    s = "非法运算!";
                    Console.WriteLine(s);
                }
                else if(op==1){
                        if (Cal1.m == false && Cal1.n==false)
                                {
                                    z = Cal1.Line();
                                    Console.WriteLine(z);
                                    b = false;
                                }
                        else
                        {
                            result = Cal1.Add(c,d);
                            Console.WriteLine("{0}+{1}={2}", c, d, result);
                        }

                              }
                else if (op == 2)
                {
                    if (Cal1.m == false && Cal1.n == false)
                    {
                        z = Cal1.Delete();
                        Console.WriteLine(z);
                        b = false;
                    }
                    else
                    {
                        result = Cal1.Sub(c, d);
                        Console.WriteLine("{0}-{1}={2}", c, d, result);
                    }
                }
                else if (op == 3)
                {
                    result = Cal1.Mul(c, d);
                    Console.WriteLine("{0}*{1}={2}", c, d, result);
                }
                else if (op == 4)
                {
                    if (Convert.ToInt32(d) == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    else
                    {
                        result = Cal1.Div(c, d);
                        Console.WriteLine("{0}/{1}={2}", c, d, result);
                    }
                }
                else
                {
                    s = "非法运算!";
                    Console.WriteLine(s);
                }
                Console.WriteLine("继续使用计算器吗？（y或Y继续，其他键退出）");
                flag = Console.ReadLine();
            }
        }
    }
    public class Cal1 {

        public static int num1;
        public static int num2;
        public static string _a;
        public static string _b;
        public static bool m = true;
        public static bool n = true;
        public static string A
        {
            set
            {
                try
                {
                    num1 = Convert.ToInt32(value);
                }
                catch(FormatException e)
                {
                    m = false;
                    _a = value;
                }
                }
            }
        public static string B
        {
            set
            {
                try
                {
                    num2 = Convert.ToInt32(value);
                }catch(FormatException e)
                {
                    n = false;
                    _b = value;
                }
                }
            }        
        public static string Line()
        {
            return (_a + _b);
        }
        public static string Delete()
        {
            return (_a.Replace(_b, ""));
        }

        public static float Add(string a, string b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }
        public static float Sub(string a, string b)
        {
            return Convert.ToInt32(a) - Convert.ToInt32(b);
        }

        public static float Mul(string a, string b)
        {
            return Convert.ToInt32(a) * Convert.ToInt32(b);
        }
        public static float Div(string a, string b)
        {
            return Convert.ToInt32(a) / Convert.ToInt32(b);
        }
    }
}
