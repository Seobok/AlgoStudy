using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class _2751
    {
        public void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //입력
            int[] ArrayN = new int[N];
            //입력만큼 배열 생성
            for (int i = 0; i < N; i++)
            {
                ArrayN[i] = int.Parse(Console.ReadLine());
            }
            //배열의 수만큼 입력하게
            Array.Sort(ArrayN);
            //정렬
            Console.WriteLine(string.Join("\n", ArrayN));
            //시간제한으로 인해 스트링빌드로 출력
        }

    }
}
