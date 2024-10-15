/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//정렬
//매우 빠른 정렬
//https://www.acmicpc.net/problem/10989
class _10989
{
    static void Main()
    {
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int n = int.Parse(input.ReadLine());    //수의 개수

        //배열을 이용한 풀이(통과)
        int[] arr = new int[10001]; //10000보다 작거나 같은 자연수를 넣을 배열 0~10000
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(input.ReadLine());
            arr[num]++;
        }

        for (int i = 1; i <= 10000; i++)
        {
            while (arr[i] > 0)
            {
                result.WriteLine(i);
                arr[i]--;
            }
        }

        //배열을 sort(메모리 초과)
        int[] arr2 = new int[10000000];
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(input.ReadLine());
            arr2[i] = num;
        }
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (arr2[i] > arr2[j])
                {
                    int temp = arr2[i];
                    arr2[i] = arr2[j];
                    arr2[j] = temp;
                }
            }
        }

        //리스트를 이용한 풀이(메모리 초과)   //숫자가 천만개까지 들어가야하기 때문에, 순서배열을 하는 것에 있어서 메모리 초과가 되는 듯하다.
        List<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(input.ReadLine());
            list.Add(num);
        }
        list.Sort();
        foreach (int i in list)
        {
            result.WriteLine(i);
        }

        //딕셔너리를 이용한 풀이(통과)
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(input.ReadLine());
            if (!dict.ContainsKey(num))
            {
                dict.Add(num, 1);
            }
            else
            {
                dict[num]++;
            }
        }
        dict = dict.Keys.OrderBy(key => key).ToDictionary(key => key, key => dict[key]);
        foreach (int i in dict.Keys)
        {
            while (dict[i] > 0)
            {
                result.WriteLine(i);
                dict[i]--;
            }
        }

        input.Close();
        result.Close();
    }
}
*/
//10,000,000개의 칸을 만드는 순간 메모리 초과. 칸의 수를 줄이기 위해 0~10000을 채울 수 있는 10,001칸을 가지는 변수를 사용