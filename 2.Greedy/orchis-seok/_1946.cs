/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//그리드 정렬
//신입사원
//https://www.acmicpc.net/problem/1946
class _1946
{
    static void Main()
    {
        //시간 초과, 잘못된 풀이, 문제의 잘못된 해석
        *//*int caseCount = int.Parse(Console.ReadLine());
        int num1 = int.Parse(Console.ReadLine());
        //num1개의 줄 caseCount개의 열 입력
        int[,] input1 = new int[num1,caseCount];
        for(int i = 0; i < num1; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            if(input.Length == caseCount)
            {
                for(int j = 0; j < caseCount; j++)
                {
                    input1[i, j] = int.Parse(input[j]);
                }
            }
        }
        int num2 = int.Parse(Console.ReadLine());
        //num2개의 줄 caseCount개의 열 입력
        int[,] input2 = new int[num2, caseCount];
        for (int i = 0; i < num2; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length == caseCount)
            {
                for (int j = 0; j < caseCount; j++)
                {
                    input2[i, j] = int.Parse(input[j]);
                }
            }
        }

        int count1 = 0;
        for(int i = 0; i < num1; i++)
        {
            for (int k = 0; k < num1; k++)
            {
                int j = 0;
                while (true)
                {
                    if (input1[i, j] > input1[k, j])
                    {
                        //Console.WriteLine(input1[i, j] + " > " + input1[k, j]);
                        j++;
                    }
                    else
                    {
                        break;
                    }

                    if (j >= caseCount) //모든 행이 다른 열보다 크다면 제외시키기
                    {
                        break;
                    }
                }
                if(j >= caseCount)
                {
                    //Console.WriteLine("열 " + i);
                    count1++;
                    break;
                }
            }
        }

        int count2 = 0;
        for (int i = 0; i < num2; i++)
        {
            for (int k = 0; k < num2; k++)
            {
                int j = 0;
                while (true)
                {
                    if (input2[i, j] > input2[k, j])
                    {
                        //Console.WriteLine(input1[i, j] + " > " + input1[k, j]);
                        j++;
                    }
                    else
                    {
                        break;
                    }

                    if (j >= caseCount) //모든 행이 다른 열보다 크다면 제외시키기
                    {
                        break;
                    }
                }
                if (j >= caseCount)
                {
                    //Console.WriteLine("열 " + i);
                    count2++;
                    break;
                }
            }
        }

        Console.WriteLine(num1 - count1);
        Console.WriteLine(num2 - count2);*//*

        //통과
        //int caseC = int.Parse(Console.ReadLine());
        //int[] num = new int[caseC];
        //int[] result = new int[caseC];

        //for (int i = 0; i < caseC; i++)
        //{
        //    num[i] = int.Parse(Console.ReadLine());
        //    //Console.WriteLine("인원 수 : " + num[i]);
        //    //int count = num[i];
        //    List<(int x, int y)> list = new List<(int x, int y)>();
        //    for (int j = 0; j < num[i]; j++)    //값 입력
        //    {
        //        string line = Console.ReadLine();
        //        list.Add((int.Parse(line.Split(' ')[0]), int.Parse(line.Split(' ')[1])));
        //    }
        //    list.Sort((a, b) => a.x.CompareTo(b.x));
        //    //첫 번째 요소로 정렬하기 위해서는 둘 다 x의 값으로 정렬.
        //    //두 값을 x(첫 번째 요소)를 기준으로 비교하여 정렬
        //    //foreach(var l in list)
        //    //{
        //    //    Console.WriteLine(l.x + " " + l.y);
        //    //}
        //    int sucess = 1;
        //    int count = list[0].y;
        //    for(int j = 1; j < num[i]; j++) //list.Remove를 하려면 num[i]까지 갈 수 없음
        //    {
        //        if(count > list[j].y)
        //        {
        //            count = list[j].y;
        //            sucess++;
        //            //j--
        //        }
        //        //else  //j의 범위가 작아지므로 문제 발생.런타임에러
        //        //{
        //        //    list.Remove(list[j]);
        //        //}
        //    }

        //    result[i] = sucess;
        //    //Console.WriteLine(i + " 바퀴");
        //}

        //for(int i = 0; i < caseC; i++)
        //{
        //    Console.WriteLine(result[i]);
        //}

        //다른 풀이
        int caseC = int.Parse(Console.ReadLine());
        int[] num = new int[caseC];
        int[] result = new int[caseC];

        for (int i = 0; i < caseC; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
            int[,] nums = new int[num[i], 2];
            for (int j = 0; j < num[i]; j++)    //각각의 값을 배열에 입력하기.
            {
                string input = Console.ReadLine();
                nums[j, 0] = int.Parse(input.Split(' ')[0]);
                nums[j, 1] = int.Parse(input.Split(' ')[1]);
            }
            var sortedByLinq = Enumerable.Range(0, nums.GetLength(0))
                .Select(n => new
                {
                    First = nums[n, 0],
                    Second = nums[n, 1]
                })
                .OrderBy(m => m.First).ToArray();
            foreach (var item in sortedByLinq)
            {
                Console.WriteLine(item.First + " " + item.Second);
            }
            int count = sortedByLinq[0].Second;
            int sucess = 1;
            for (int j = 1; j < num[i]; j++) //list.Remove를 하면 num[i]까지 갈 수 없음
            {
                if (count > sortedByLinq[j].Second)
                {
                    count = sortedByLinq[j].Second;
                    sucess++;
                    Console.WriteLine($"{sortedByLinq[j].First}, {sortedByLinq[j].Second}");
                }
            }
            result[i] = sucess;
        }     
        for (int i = 0; i < caseC; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}

//list.OrderBy(a => a.x + a.y).ThenBy((a,b) => a.x.CompareTo(b.x)),ToList(a => (a.x,a.y));  //풀이에 도움이 되지 않음
//1 4 - 5
//4 2 - 6
//2 5 - 7
//6 1 - 7
//3 6 - 9
//7 3 - 10
//5 7 - 12

//7 3 - 10/
///6 1 - 7
//5 7 - 12/
///4 2 - 6
///3 6 - 9
///2 5 - 7
///1 4 - 5

///7 3 - 10
//6 1 - 7
///5 7 - 12
//4 2 - 6
///3 6 - 9
///2 5 - 7
//1 4 - 5
//case 중 하나를 기준으로 내림차순

//case = 2인 경우
//첫 번째 열을 내림차순으로 한 후,
//두 번째 열이 뒤의 열 중 작은 수가 없으면 count++;

// 1 2 3 4 5 6 7
// 7 6 5 4 3 2 1

//서류심사와 면접심사만 있으며, case의 갯수에 따라 몇 번의 test를 하는지 정해짐. 예제의 경우 case = 2이기 때문에 결과도 2개 나옴.
//서류심사 결과를 기준으로 오름차순을 한 다음, 면접심사의 값이 뒤의 값 중 큰 값이 있다면 큰 값에 해당하는 것을 list에서 제외.
//마지막에 남은 list의 갯수를 result로 출력

*/