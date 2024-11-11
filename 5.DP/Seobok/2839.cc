#include <iostream>
#include <vector>
using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(3);

	int N;
	int cnt_3 = 0;
	int cnt_5;
	cin >> N;

	while (N >= 0)
	{
		if (N % 5 != 0)
		{
			N -= 3;
			cnt_3++;
		}
		else
		{
			cnt_5 = N / 5;
			break;
		}
	}

	if (N < 0)
		cout << -1;
	else
		cout << cnt_3 + cnt_5;

	return 0;
}