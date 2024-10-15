using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class _2750
    {
        public void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //입력
            int[] ArrayN = new int[N];
            //N만큼 배열 생성 
            for (int i = 0; i < N; i++)
            {
                ArrayN[i] = int.Parse(Console.ReadLine());
            }
            //N만큼 인력 가능하게 
            Array.Sort(ArrayN);
            //배열 정렬
            foreach (int i in ArrayN)
            {
                Console.WriteLine(i);
            }
            //배열만큼 출력
        }
    }
}
