/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정렬
//세 수 정렬
//https://www.acmicpc.net/problem/2752

class _2752
{
    static void Main()
    {
        //배열을 이용한 풀이(틀림)
        *//*int[] num = new int[3];
        for(int i = 0; i < 3;  i++)
        {
            if(int.TryParse(Console.ReadLine(), out int result))
            {
                num[i] = result;
            }
        }
        num = num.OrderBy(x => x).ToArray();
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(num[i]);
        }*//*

        //List를 이용한 풀이(런타임 에러)
        *//*List<int> list = new List<int>();
        list.Add(int.Parse(Console.ReadLine()));
        list.Add(int.Parse(Console.ReadLine()));
        list.Add(int.Parse(Console.ReadLine()));

        list.Sort();

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }*//*

        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        //List를 이용한 풀이(런타임 에러)
        List<int> list2 = new List<int>();
        list2.Add(int.Parse(input.ReadLine()));
        list2.Add(int.Parse(input.ReadLine()));
        list2.Add(int.Parse(input.ReadLine()));

        list2.Sort();

        foreach (int i in list2)
        {
            result.WriteLine(i);
        }

        input.Close();
        result.Close();

        //StreamReader, StreamWriter를 이용하지 않는 배열 풀이
        string[] str = Console.ReadLine().Split(' ');
        int[] num = { int.Parse(str[0]), int.Parse(str[1]), int.Parse(str[2]) };
        Array.Sort(num);

        Console.WriteLine("{0}", string.Join(" ", num));

        //StreamReader, StreamWriter를 이용하지 않는 배열 풀이
        string line = Console.ReadLine();
        string[] num1 = line.Split(' ');
        int[] num2 = { int.Parse(num1[0]), int.Parse(num1[1]),  int.Parse(num1[2]) };
        Array.Sort(num2);

        Console.WriteLine("{0}", string.Join(" ", num2));
    }
}

//문제가 한 줄로 입력되는 숫자들의 집합을 정렬하는 문제인데, 한 숫자당 한 줄로 입력된다고 인지하여 틀림.

*/