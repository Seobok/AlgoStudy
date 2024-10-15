/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//그리드 정렬
//동전 0
//https://www.acmicpc.net/problem/11047
class _11047
{
    static void Main()
    {
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] strs = input.ReadLine().Split(' ');
        int[] nums = { int.Parse(strs[0]), int.Parse(strs[1]) };
        int[] coins = new int[nums[0]];
        //Console.WriteLine(nums[0] + " " + nums[1]);
        int count = 0;

        for(int i = 0; i < nums[0];  i++)
        {
            coins[i] = int.Parse(input.ReadLine());
        }

        for(int i = nums[0] - 1;i >= 0; i--)
        {
            if(i == nums[0] - 1)
            {
                count += nums[1] / coins[i];
            }
            else
            {
                count += nums[1] % coins[i + 1] / coins[i];
            }
        }

        result.WriteLine(count);

        input.Close();
        result.Close();
    }
}
*/
//좀 더 간단한 풀이가 있는지 확인해보기