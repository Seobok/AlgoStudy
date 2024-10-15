namespace algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string N = Console.ReadLine();
            //입력
            N = N.ToString();
            //입력받은 N을 쪼갠다
            int Nsum = 0;
            //자릿수 합 변수 
            bool zerocheck = false;
            //0이 있는지 확인
            int[] num = new int[N.Length];
            //담을 배열 선언

            //N의 길이만큼 반복
            for (int i = 0; i < N.Length; i++)
            {
                //각 자리의 수를 인트로 변환 후 합을 구하기
                Nsum += int.Parse(N[i].ToString());
                //각 자리의 수를 배열로 넣기
                num[i] = int.Parse(N[i].ToString());
                //각 자리의 수를 확인 후 0이 있다면 true
                if (int.Parse(N[i].ToString()) == 0)
                {
                    zerocheck = true;
                }
            }

            //30의 배수인지 확인
            if (Nsum % 3 == 0 && zerocheck == true)
            {
                //배열을 정렬
                Array.Sort(num);
                //30의 배수의 큰 값을 구하므로 내림차순
                Array.Reverse(num);
                //배열 출력
                foreach (int n in num)
                {
                    Console.Write(n);
                }
            }
            //30의 배수가 아니면 =1
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
