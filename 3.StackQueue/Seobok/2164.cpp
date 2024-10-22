#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <vector>
#include <queue>
#include <math.h>
#include <algorithm>

using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(0);

	int N;

	cin >> N;

	int i = 0;

	if (N == 1)
		cout << 1;
	else
	{
		while (true)
		{
			if (N == pow(2, i) + 1)
			{
				cout << 2;
				break;
			}
			else if (N > pow(2, i) + 1)
			{
				i++;
			}
			else
			{
				i--;
				int temp = N - (pow(2, i) + 1);
				cout << 2 * (temp + 1);
				break;
			}
		}
	}

	return 0;
}