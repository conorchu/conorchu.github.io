using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWorks01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用 Console.ReadLine() 讀取一個整數 max
            //(至少大於 90)，在螢幕上用 WriteLine 分行顯示
            //1~max，其中可被 3 整除者替換為 Build，可被
            //5 整除者替換為 School，可以被 3 和 5 同時整
            //除者替換為 Dann。
            Console.WriteLine("輸入一個整數");

            string input = Console.ReadLine();

            int X;
            if (int.TryParse(input, out X) && X > 90)
            {
                for (int i = 1; i <= X; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Dann");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Build");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("School");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadLine();
            //輸入一個有意義的英文敘述字串，計算其個別單字數
            //量(不區分大小寫)，例如 “To be or not to be”，
            


            //中華民國的稅率級距表如下


        }
    }
}
