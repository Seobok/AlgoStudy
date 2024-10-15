/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정렬
//단어 정렬(문자열 정렬)
//https://www.acmicpc.net/problem/1181
class _1181
{
    static void Main()
    {
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(input.ReadLine());

        string[] strs = new string[n];
        for (int i = 0; i < n; i++)
        {
            strs[i] = input.ReadLine();
        }
        strs = strs.OrderBy(x => x.Length).ThenBy(x => x).Distinct().ToArray();
        foreach (string str in strs)
        {
            result.WriteLine(str);
        }

        input.Close();
        result.Close();
    }
}
*/
//Linq 사용하지 않고 풀어보기
//배열을 이용하지 않고 풀어보기