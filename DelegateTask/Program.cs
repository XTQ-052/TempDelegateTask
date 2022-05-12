using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    #region 1
    public delegate void Func(string str);
    #endregion

    #region 2
    class MyClass
    {
        public void Space(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                Console.Write($"{str[i]}_");
            }
            Console.WriteLine(str[str.Length - 1]);
        }

        public void Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
    }
    #endregion

    #region 3
    class Run
    {
        public void RunFunc(Func func,string str)
        {
            func(str);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string : ");
            var str = Console.ReadLine();

            MyClass cls = new MyClass();
            Func funcDell = null;
            funcDell += cls.Space;
            funcDell += cls.Reverse;
            
            Run run = new Run();
            run.RunFunc(funcDell, str);

            Console.ReadKey();
        }
    }
}
