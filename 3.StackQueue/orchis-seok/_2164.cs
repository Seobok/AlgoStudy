/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//카드 2
//https://www.acmicpc.net/problem/2164
class _2164
{
    static void Main()
    {
        //Queue를 사용한 풀이(통과)
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n =int.Parse(input.ReadLine());
        Queue<int> queue = new Queue<int>();

        for(int i = 1; i <= n; i++)
        {
            queue.Enqueue(i);
        }

        while (queue.Count > 1)
        {
            queue.Dequeue();
            queue.Enqueue(queue.Dequeue());
        }

        //result.WriteLine(queue.Count.ToString());
        result.WriteLine(queue.Dequeue());

        input.Close();
        result.Close();
    }
}
*/
//a_n = {1, 2, 3, ..., n}
//C_1(a_n) = {3, ... , n , 2}
//C_m(a_n) = {(2m+1), (2m+2), ..., n, 2(1), 2(2), ..., 2(m)} (2m <= n)
//1 2 3 4 5 > 3 4 5 2 > 5 2 4 > 4 2 > 2


//if C_m(a_n).Count == 1,

//n = 1, r = 1
//n = 2, r = 2
//n = 3, r = 2
//n = 4, r = 4
//n = 5, r = 2
//n = 6, r = 4
//n = 7, r = 6

//공식 만들어보기