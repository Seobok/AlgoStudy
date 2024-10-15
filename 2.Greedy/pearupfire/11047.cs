using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class _11047
    {
        public void Main(string[] args)
        {
            int inputCoin = 1000 - int.Parse(Console.ReadLine());
            //입력
            int[] changeCoins = { 500, 100, 50, 10, 5, 1 };
            //잔돈 거스름돈 배열 선언
            int coinCount = 0;
            //잔돈 개수 변수
            for (int i = 0; i < changeCoins.Length; i++)
            //잔돈 배열 반복
            {
                if (inputCoin > 0)
                //값이 0보다 작지 않으면
                {
                    coinCount += inputCoin / changeCoins[i];
                    //나눈 값을 카운트 해준다
                    inputCoin = inputCoin % changeCoins[i];
                    //남은 돈을 계산해주고 반복 
                }
            }
            Console.WriteLine(coinCount);
        }
    }
}
