/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//그리드 정렬
//거스름돈
//https://www.acmicpc.net/problem/5585

class _5585
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        //int money = 1000 - num;
        int count = 0;
        //while (money > 0)
        //{
        //    if (money / 500 != 0)
        //    {
        //        count += money / 500;
        //        money = money % 500;
        //    }
        //    else if (money / 100 != 0)
        //    {
        //        count += money / 100;
        //        money = money % 100;
        //    }
        //    else if (money / 50 != 0)
        //    {
        //        count += money / 50;
        //        money = money % 50;
        //    }
        //    else if (money / 10 != 0)
        //    {
        //        count += money / 10;
        //        money = money % 10;
        //    }
        //    else if (money / 5 != 0)
        //    {
        //        count += money / 5;
        //        money = money % 5;
        //    }
        //    else if (money / 1 != 0)
        //    {
        //        count += money / 1;
        //        money = money % 1;
        //        break;
        //    }
        //}

        //count = ((1000 - num) / 500) + ((1000 - num) % 500 / 100) + ((1000 - num) % 100 / 50) + ((1000 - num) % 50 / 10) + ((1000 - num) % 10 / 5) + ((1000 - num) % 5);
        
        count = ((1000 - num) / 500) + ((1000 - num) / 100 % 5) + ((1000 - num) / 50 % 2) + ((1000 - num) / 10 % 5) + ((1000 - num) / 5 % 2) + ((1000 - num) % 5);

        Console.WriteLine(count);
    }
}
//다른 풀이로 풀 수 있는지 더 해보기

*/