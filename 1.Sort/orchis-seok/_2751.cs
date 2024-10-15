/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정렬
//수 정렬하기2(100만 개 정렬)
//https://www.acmicpc.net/problem/2751
class _2751
{
    static void Main()
    {
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(input.ReadLine());
        //배열을 sort
        int[] arr2 = new int[n];
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(input.ReadLine());
            arr2[i] = num;
        }
        arr2 = arr2.OrderBy(x => x).Distinct().ToArray();
        foreach (int i in arr2)
        {
            result.WriteLine(i);
        }

        input.Close();
        result.Close();
    }
}
//Linq 사용하지 않고 해보기.
//List를 사용하여 해보기.
*/