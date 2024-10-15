/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//그리드 정렬
//30
//https://www.acmicpc.net/problem/10610
class _10610
{
    static void Main()
    {
        //배열과 Linq를 이용한 풀이(오답)
        string str = Console.ReadLine();
        char[] s = str.ToArray();
        int[] num = new int[s.Length];
        for(int i = 0; i < s.Length; i++)
        {
            num[i] = (int)s[i] - 48;
        }
        num = num.OrderByDescending(x => x).ToArray();
        int sum = 0;
        foreach(int i in num)
        {
            sum += i;
        }
        string result ="";
        if (num[num.Length - 1] == 0 && sum % 3 == 0)
        {
            for(int i = 0;i < num.Length;i++)
            {
                result += num[i].ToString();
            }
            //result = string.Join(' ', num);
        }
        else
        {
            result = "-1";
        }

        Console.WriteLine(result);

        Console.WriteLine(sum);
        Console.WriteLine(s);
        Console.WriteLine(num[0]);
    }
}

//또 다른 풀이

*/