/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//그리드 정렬
//로프
//https://www.acmicpc.net/problem/2217
class _2217
{
    static void Main()
    {
        //배열과 Linq를 이용한 풀이
        int n = int.Parse(Console.ReadLine());
        int[] weights = new int[n];
        for(int i = 0; i < n; i++)
        {
            weights[i] = int.Parse(Console.ReadLine());
        }
        weights = weights.OrderByDescending(x => x).ToArray();
        int result = 0;
        for(int i = 0; i < n; i++)
        {
            if (weights[i] * (i +1) > result)
            {
                result = weights[i] * (i + 1);
            }
        }
        Console.WriteLine(result);
    }
}
//또 다른 풀이

*/