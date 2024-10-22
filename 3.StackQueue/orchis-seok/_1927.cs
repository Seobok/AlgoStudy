/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//최소 힙
//https://www.acmicpc.net/problem/1927
class _1927
{
    static void Main()
    {
        //Sort를 이용한 풀이  //시간 초과
        //int n = int.Parse(Console.ReadLine());  //연산의 개수
        //List<int> list = new List<int>();
        //List<int> result = new List<int>();

        //for(int i = 0; i < n; i++)
        //{
        //    int input = int.Parse(Console.ReadLine());
        //    if(input == 0)
        //    {
        //        if(list.Count == 0)
        //        {
        //            result.Add(0);
        //        }
        //        else if(list.Count > 0)
        //        {
        //            result.Add(list[0]);
        //            list.Remove(list[0]);
        //        }
        //    }
        //    else
        //    {
        //        list.Add(input);
        //        list.Sort();
        //    }
        //}

        //foreach(int r in result)
        //{
        //    Console.WriteLine(r);
        //}

        //priority Queue 사용한 풀이 //시간 초과
        //int n = int.Parse(Console.ReadLine());
        //PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        //List<int> result = new List<int>();

        //for(int i = 0; i < n; i++)
        //{
        //    int input = int.Parse(Console.ReadLine());
        //    if (input == 0)
        //    {
        //        if (queue.Count == 0)
        //        {
        //            result.Add(0);
        //        }
        //        else if (queue.Count > 0)
        //        {
        //            result.Add(queue.Dequeue());
        //        }
        //    }
        //    else
        //    {
        //        queue.Enqueue(input, input);
        //    }
        //}

        //foreach (int r in result)
        //{
        //    Console.WriteLine(r);
        //}

        //priority Queue 사용한 풀이 //시간 초과 //해결 : 빠른 입출력(통과)
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(input.ReadLine());
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(input.ReadLine());
            if (num == 0)
            {
                if (queue.Count == 0)
                {
                    result.WriteLine(0);
                }
                else if (queue.Count > 0)
                {
                    result.WriteLine(queue.Dequeue());
                }
            }
            else
            {
                queue.Enqueue(num, num);
            }
        }

        input.Close();
        result.Close();
    }
}

//Console.WriteLine
*/