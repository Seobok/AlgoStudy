/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정렬
//수 정렬하기(단순 정렬)
//https://www.acmicpc.net/problem/2750
class _2750
{
    static void Main()
    {
        //배열을 이용한 풀이
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(input.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(input.ReadLine());
        }
        nums = nums.OrderBy(x => x).Distinct().ToArray();
        foreach(int num in nums)
        {
            result.WriteLine(num);
        }

        input.Close();
        result.Close();

        //리스트를 이용한 풀이

        //Linq를 이용하지 않는 풀이
    }
}

*/