using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //int Input = int.Parse(input);
            //if(inputInt %2!=0)
            //{
            //    Console.WriteLine("weird");
            //}
            //else if(Input>=2&&inputInt<=5)
            //{
            //    Console.WriteLine("Not wierd");
            //}
            //else if(inputInt>=6 &&Inputint<=20)
            //{
            //    Console.WriteLine("wierd");
            //}
            //else
            //{
            //    Console.WriteLine("Not wierd");
            //}
            //Console.ReadLine();
            //int sum = 0;
            //for (int i = 0; i<=10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);



            //string input = Console.ReadLine();
            //int Input = int.Parse(input);
            //for (int i=input;i>=1;i++)
            //{
            //    for(int j = 1; j <= input; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}
            int[] studentNo = { 1, 2, 3, 4, 5 };
            string[] studentname = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] computerscore = { 80, 65, 100, 98, 83 };
            int[] progarmscore = { 75, 67, 93, 25, 82 };
            int[] designscore = { 60, 62, 91, 50, 87 };

            while(true)
            {
                Console.WriteLine("輸入座號(1-5)");
                var input = Console.ReadLine();
                int inputstudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo, inputstudentNo);
                if(arrayIndex>-1)
                {
                    Console.WriteLine("姓名:" + studentname[arrayIndex);
                    Console.WriteLine("電腦概論" + computerscore[arrayIndex]);
                }
            }


           



        }
    }
}
