using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class _11399
    {
        public void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //첫째 줄 N 입력
            string[] P = Console.ReadLine().Split();
            //둘째 줄 입력란
            int[] pi = new int[N];
            //N만큼 배열 선언
            int mintime = 0;
            //최솟값 출력 변

            for (int i = 0; i < N; i++)
            //N만큼 반복해서 배열i번째에 P변환 및 넣기
            {
                pi[i] = int.Parse(P[i]);
            }
            Array.Sort(pi);
            //최솟값을 위해 정렬

            //ex) N이 5이면 
            //    0번째 배열은 5번 더하고
            //		1번째 배열4
            //		2번째 배열3
            //		3번째 배열2
            //		4번째 배열1 해야하므로
            //이중 포문으로 j가 i보다 크거나 같을 때 값을 더 해줬다
            for (int i = 0; i < pi.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    mintime += pi[j];
                }
            }
            Console.WriteLine(mintime);
            //최솟값 출력
        }
    }
}
