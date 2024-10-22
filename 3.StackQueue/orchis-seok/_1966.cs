/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//프린터큐 (어려움)
//https://www.acmicpc.net/problem/1966
class _1966
{
    static void Main()
    {
        //배열을 이용한 풀이    //같은 중요도를 가질 수 있으므로 X
        //int n = int.Parse(Console.ReadLine());
        //int[] result = new int[n];
        //string[] strs;

        //for (int i = 0; i < n; i++)
        //{
        //    strs = Console.ReadLine().Split(' ');
        //    int[] nums = new int[int.Parse(strs[0])];
        //    int num = int.Parse(strs[1]);

        //    strs = Console.ReadLine().Split(' ');
        //    for(int j = 0; j < nums.Length; i++)
        //    {
        //        nums[j] = int.Parse(strs[j]);
        //    }

        //    int count = nums[num];

        //    nums = nums.OrderByDescending(x => x).ToArray();
        //}

        //Queue를 이용한 풀이 //중요도는 1이상 9이하의 정수이므로, 중요도를 10-n의 형식으로 넣기.  //오답
        //int n = int.Parse(Console.ReadLine());
        //int[] result = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    string[] input1 = Console.ReadLine().Split(' ');    //2개의 값. 입력받을 개수와 찾을 요소의 순서
        //    Queue<int> queue = new Queue<int>();
        //    string[] input2 = Console.ReadLine().Split(' ');
        //    float num = 0f;
        //    for (int j = 0; j < int.Parse(input1[0]); j++)
        //    {
        //        if (j == int.Parse(input1[1]))
        //        {
        //            num = int.Parse(input2[j]);
        //            queue.Enqueue(int.Parse(input2[j]));
        //        }
        //        else
        //        {
        //            queue.Enqueue(int.Parse(input2[j]));            //결과값을 도출할 입력은 완료
        //        }
        //        //Console.WriteLine(int.Parse(input2[j]));
        //    }

        //    int count = int.Parse(input1[1]);   //초기 값
        //    int m = 0;
        //    while (true)
        //    {
        //        int max = queue.Max();
        //        if (max == queue.Peek())
        //        {
        //            if (queue.Peek() == num)
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                queue.Dequeue();
        //                --count;
        //                ++m;
        //                if(count < 0)
        //                {
        //                    count += queue.Count;
        //                }
        //            }
        //            Console.WriteLine(string.Join(" ", queue));
        //            Console.WriteLine("Count " + m + count + 1);
        //        }
        //        else
        //        {
        //            queue.Enqueue(queue.Dequeue());
        //            --count;
        //            if (count < 0)
        //            {
        //                count += queue.Count;
        //            }
        //            Console.WriteLine(string.Join (" ", queue));
        //            Console.WriteLine("Count " + m + count + 1);
        //        }
        //    }
        //    Console.WriteLine("R-Count " + m + count + 1);
        //    result[i] = m + count + 1;
        //}

        //foreach (int i in result)
        //{
        //    Console.WriteLine(i);
        //}

        //확인하기  //오답
        //int n = int.Parse(Console.ReadLine());
        //int[] result = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    string[] input1 = Console.ReadLine().Split(' ');
        //    Queue<int> queue = new Queue<int>();
        //    string[] input2 = Console.ReadLine().Split(' ');
        //    int num = 0;
        //    for (int j = 0; j < int.Parse(input1[0]); j++)
        //    {
        //        if (j == int.Parse(input1[1]))
        //        {
        //            num = int.Parse(input2[j]);
        //        }
        //        queue.Enqueue(int.Parse(input2[j]));
        //    }
        //    //입력 완료

        //    int count = int.Parse(input1[1]) + 1;
        //    int m = 0;
        //    while (true)    //가장 작은 값이 num인 경우 제대로 작동하나, 그렇지 않으면 반례가 생김( 1 2 2 9 1 2)의 인덱스 2의 2를 뽑기 위해서는 아래 코드로는 틀림
        //    {
        //        //if (queue.Max() == queue.Peek())
        //        //{
        //        //    if (queue.Max() == num)
        //        //    {
        //        //        if(queue.Peek() == num)
        //        //        {
        //        //            queue.Dequeue();
        //        //            ++m;
        //        //            --count;
        //        //        }
        //        //        else
        //        //        {
        //        //            queue.Enqueue(queue.Dequeue());
        //        //            --count;
        //        //        }
        //        //        if (count == 0)
        //        //        {
        //        //            break;
        //        //        }
        //        //    }
        //        //    queue.Dequeue();
        //        //    --count;
        //        //    ++m;
        //        //    if (count <= 0)
        //        //    {
        //        //        count += queue.Count;
        //        //    }

        //        //}
        //        //else
        //        //{
        //        //    queue.Enqueue(queue.Dequeue());
        //        //    --count;
        //        //    if (count <= 0)
        //        //    {
        //        //        count += queue.Count;
        //        //    }
        //        //}
        //    }
        //    result[i] = m;
        //}

        //foreach (int i in result)
        //{
        //    Console.WriteLine(i);
        //}

        //queue를 이용한 풀이
        int n = int.Parse(Console.ReadLine());
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            Queue<int> queue = new Queue<int>();
            string[] input2 = Console.ReadLine().Split(' ');
            int num = 0;
            for (int j = 0; j < int.Parse(input1[0]); j++)
            {
                if (j == int.Parse(input1[1]))
                {
                    num = int.Parse(input2[j]);
                }
                queue.Enqueue(int.Parse(input2[j]));
            }
            //입력 완료

            int count = int.Parse(input1[1]) + 1;
            int m = 0;
            while (true)
            {
                if (queue.Max() != queue.Peek()) //최고 값이 아니면 맨 뒤로 이동
                {
                    queue.Enqueue(queue.Dequeue());
                    count--;
                    if (count == 0)
                    {
                        count += queue.Count;
                    }
                }
                else    //최고 값이라면
                {
                    queue.Dequeue();
                    count--;
                    m++;
                    if (count == 0)
                    {
                        break;
                    }
                }
                //Console.WriteLine(string.Join(" ", queue.ToArray()));
            }
            result[i] = m;
        }

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }

    }
}

*/