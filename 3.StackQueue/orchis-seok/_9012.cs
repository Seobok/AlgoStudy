/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//괄호
//https://www.acmicpc.net/problem/9012
class _9012
{
    static void Main()
    {
        //배열을 이용한 풀이
        //괄호가 열리면 +1 닫히면 -1이라고 설정하여 음수가 되거나 결과값이 0이 아니면 No 출력
        int n = int.Parse(Console.ReadLine());  //몇 개의 값을 입력받고 출력하는지
        string[] strs = new string[n];
        string[] result = new string[n];

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            strs[i] = Console.ReadLine().ToString();
            for (int j = 0; j < strs[i].Length; j++)
            {
                if (strs[i][j] == '(')
                {
                    count++;
                }
                else if (strs[i][j] == ')')
                {
                    count--;
                }

                if (count < 0)
                {
                    break;
                }
            }

            if (count == 0)
            {
                result[i] = "YES";
            }
            else
            {
                result[i] = "NO";
            }
        }

        foreach (string r in result)
        {
            Console.WriteLine(r);
        }
    }
}*/