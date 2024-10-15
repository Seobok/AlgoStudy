using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class _5585
    {
        public void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            //입력
            int N = int.Parse(input[0]);
            //입력란 인트로 변환
            int K = int.Parse(input[1]);
            int count = 0;
            //출력할 동전 개수
            int[] changCoins = new int[N];
            //N개만큼 담을 잔돈 배열

            //N만큼 입력할 잔돈 배열
            for (int i = 0; i < N; i++)
            {
                changCoins[i] = int.Parse(Console.ReadLine());
            }
            //배열 역순
            Array.Reverse(changCoins);

            //잔돈 배열만큼 반복
            for (int i = 0; i < changCoins.Length; i++)
            {
                //0보다 작지 않을 경우
                if (K > 0)
                {
                    //제일 큰값부터 코인을 잔돈을 나눈 값을 코인개수 증가
                    count += K / changCoins[i];
                    //남은 돈 K값에 넣어 주고 반복
                    K = K % changCoins[i];
                }
            }
            //잔돈 개수 출력
            Console.WriteLine(count);
        }
    }
}
