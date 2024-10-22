/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//제로
//https://www.acmicpc.net/problem/10773
class _10773
{
    static void Main()
    {
        //Stack을 이용한 풀이(통과)
        StreamReader input = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter result = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        int k = int.Parse(input.ReadLine());
        Stack<int> stack = new Stack<int>();

        for(int i = 0; i < k; i++)
        {
            int num = int.Parse(input.ReadLine());
            if(num == 0)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(num);
            }
        }

        int n = 0;
        while(stack.Count > 0)
        {
            n += stack.Pop();
        }

        result.WriteLine(n);

        input.Close();
        result.Close();
    }
}

*/