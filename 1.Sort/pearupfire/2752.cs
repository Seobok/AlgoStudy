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
            string[] input = Console.ReadLine().Split();
            //입력
            int[] ThreaNum = { int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]) };
            //입력한 수 > 인트로 변환해 인트배열에 넣기
            Array.Sort(ThreaNum);
            //정렬
            foreach (int num in ThreaNum)
            {
                Console.Write(num + " ");
            }
            //배열을 출력
        }
    }
}
