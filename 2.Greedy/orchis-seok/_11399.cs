/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//그리드 정렬
//ATM
//https://www.acmicpc.net/problem/11399
class _11399
{
    static void Main()
    {
        //배열과 Linq를 이용한 풀이
        int n = int.Parse(Console.ReadLine());
        string[] times = Console.ReadLine().Split(' ');
        int[] time = new int[n];
        for(int i = 0; i < n; i++)
        {
            if (times[i] != null)
            {
                time[i] = int.Parse(times[i]);
            }
        }
        time = time.OrderByDescending(x => x).ToArray();
        int result = 0;
        for(int i = 0; i < n; i++)
        {
            result += time[i] * (i + 1);
        }
        Console.WriteLine(result);
    }
}

//다양한 풀이를 해보기

*/