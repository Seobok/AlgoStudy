using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//탑 (어려움)
//https://www.acmicpc.net/problem/2493
class _2493
{
    static void Main()
    {
        //2중 for문 사용 불가 1.5초 이내 풀이
        //배열을 사용하여 문제에 제시된대로 풀이(시간 초과)
        //int n = int.Parse(Console.ReadLine());

        //string[] strs = Console.ReadLine().Split(' ');
        //int[] nums = new int[n];
        //int[] result = new int[n];

        //for(int i = 0; i < n; i++)
        //{
        //    nums[i] = int.Parse(strs[i]);
        //}

        //for(int i = 0; i < n; i++)
        //{
        //    if(i == 0)
        //    {
        //        result[i] = 0;
        //    }
        //    else
        //    {
        //        for(int j = i - 1; j >= 0; j--)
        //        {
        //            if (nums[j] >= nums[i])
        //            {
        //                result[i] = j + 1;
        //                break;
        //            }
        //            if(j == 0)
        //            {
        //                result[i] = 0;
        //            }
        //        }
        //    }
        //}

        //for(int i = 0;i < n; i++)
        //{
        //    Console.Write(result[i] + " ");
        //}

        //priorityQueue를 사용한 풀이 //X
        //int n = int.Parse(Console.ReadLine());
        //string[] strs = Console.ReadLine().Split(' ');
        //PriorityQueue<int, int> queue = new PriorityQueue<int, int>();
        //int[] result = new int[n];

        //for(int i = 0; i < n; i++)
        //{
        //    queue.Enqueue(int.Parse(strs[i]), i + 1);
        //}

        //for(int i = 0;i < n; i++)
        //{
        //    if(i == 0)
        //    {
        //        result[i] = 0;
        //    }
        //    else
        //    {
        //        for(int j = i -1; j >= 0; j--)
        //        {
        //            if (queue[j].element > queue[i].element)
        //            {
        //                result[i] = queue[j].priority;
        //            }
        //        }
        //    }
        //}

        //입력시 입력한 수보다 큰 수가 있다면 그 수까지의 count를 element로 넣는다. 없으면 0    //그리고 모든 element를 순서대로 출력한다. priorityQueue X Queue O
        //빠른 입출력    //시간초과
        //StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        //StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        //int n = int.Parse(input.ReadLine());
        //string[] strs = input.ReadLine().Split(' ');
        //int[] nums = new int[n];
        //Queue<int> queue = new Queue<int>();
        //for(int i = 0; i < n; i++)
        //{
        //    nums[i] = int.Parse(strs[i]);
        //    if(i == 0)
        //    {
        //        queue.Enqueue(0);
        //    }
        //    else
        //    {
        //        for(int j = i-1; j >= 0; j--)
        //        {
        //            if (nums[i] <= nums[j])
        //            {
        //                queue.Enqueue(j + 1);
        //                break;
        //            }
        //            if(j == 0)
        //            {
        //                queue.Enqueue(0);
        //            }
        //        }
        //    }
        //}
        //foreach(int q in queue)
        //{
        //    result.Write($"{q} ");
        //}

        //input.Close();
        //result.Close();

        //Stack과 빠른 입출력을 이용한 풀이 //시간 초과
        //StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        //StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        //int n = int.Parse(input.ReadLine());
        //string[] strs = input.ReadLine().Split(' ');
        //int[] nums = new int[n];
        //Stack<int> stack = new Stack<int>();

        //for(int i = n - 1; i >= 0; i--)
        //{
        //    if (i == 0)
        //    {
        //        stack.Push(0);
        //        result.WriteLine("Push");
        //        continue;
        //    }
        //    else
        //    {
        //        for (int j = i -1; j >= 0; j--)
        //        {
        //            if (int.Parse(strs[i]) <= int.Parse(strs[j]))
        //            {
        //                stack.Push(j + 1);
        //                break;  //i != 0일 경우 무조건 0추가
        //            }
        //            if (j == 0)
        //            {
        //                stack.Push(0);
        //            }
        //        }
        //    }
        //}

        //while (stack.Count > 0)
        //{
        //    result.Write(stack.Pop() + " ");
        //}

        //input.Close();
        //result.Close();

        //Stack, 빠른 입출력, for문 하나    //시간 초과
        //StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        //StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        //int n = int.Parse(input.ReadLine());
        //string[] strs = input.ReadLine().Split(' ');
        //int[] nums = new int[n];
        ////int[] nums = int.Parse(input.ReadLine().Split(' '));
        //Stack<int> stack = new Stack<int>();
        //for(int i  = 0; i < n; i++)
        //{
        //    stack.Push(int.Parse(strs[i]));
        //}

        ////입력 완료
        //for (int i = 0; i < n; i++)
        //{
        //    int num = stack.Pop();
        //    for (int j = stack.Count() - 1; j >= 0; j--)
        //    {
        //        if (int.Parse(strs[n - 1 - j]) >= num)
        //        {
        //            nums[n - 1 - i] = j + 1;

        //            break;
        //        }

        //    }
        //}


        //result.WriteLine(string.Join(' ', nums));


        //input.Close();
        //result.Close();


        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(input.ReadLine());
        string[] strs = input.ReadLine().Split(' ');
        Stack<KeyValuePair<int, int>> stack = new Stack<KeyValuePair<int, int>>();

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                if (stack.Count == 0)
                {
                    result.Write(stack.Count() + " C ");
                    stack.Push(new KeyValuePair<int, int>(i + 1, int.Parse(strs[i])));
                    Console.WriteLine(stack.Peek().Key + " " + stack.Peek().Value + " Push " + stack.Count());
                    break;
                }

                if (stack.Peek().Value < int.Parse(strs[i]))
                {
                    Console.WriteLine(stack.Peek().Value + " < " + int.Parse(strs[i]));
                    Console.WriteLine(stack.Peek().Key + " " + stack.Peek().Value + " Pop " + stack.Count());
                    stack.Pop();
                }
                else
                {
                    result.Write(stack.Peek().Key + " T ");
                    stack.Push(new KeyValuePair<int, int>(i + 1, int.Parse(strs[i])));
                    Console.WriteLine(stack.Peek().Key + " " + stack.Peek().Value + " Push " + stack.Count());
                    break;
                }
            }
            Console.Write(string.Join(' ', stack));

        }

        input.Close();
        result.Close();
    }
}

