#define _CRT_SECURE_NO_WARNINGS	
#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <vector>
#include <queue>
#include <stack>
#include <math.h>
#include <algorithm>
#include <map>

using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	/*cout << fixed;
	cout.precision(0);*/

	int T;
	cin >> T;

	for (int test = 0; test < T; test++)
	{
		int N, M, K;
		cin >> M >> N >> K;
		int** arr = new int* [N + 2];
		for (int i = 0; i < N + 2; i++)
		{
			arr[i] = new int[M + 2];
		}

		for (int i = 0; i < N + 2; i++)
		{
			for (int j = 0; j < M + 2; j++)
			{
				arr[i][j] = 0;
			}
		}

		for (int i = 0; i < K; i++)
		{
			int a, b;
			cin >> a >> b;
			arr[b + 1][a + 1] = 1;
		}

		queue<pair<int, int>> q;
		int cnt = 0;
		int x[4] = { -1, 1, 0, 0 };
		int y[4] = { 0, 0, -1, 1 };	//K=0=>left, K=1=>right, K=2=>down, K=3=>up

		for (int i = 1; i < N + 1; i++)
		{
			for (int j = 1; j < M + 1; j++)
			{
				if (arr[i][j] == 1)
				{
					cnt++;
					q.push({ i,j });
					while (1)
					{
						arr[q.front().first][q.front().second] = 0;
						for (int i = 0; i < 4; i++)
						{
							if (arr[q.front().first + y[i]][q.front().second + x[i]] == 1)
							{
								q.push({ q.front().first + y[i],q.front().second + x[i] });
								arr[q.front().first + y[i]][q.front().second + x[i]] = 0;
							}
						}
						q.pop();
						if (q.empty())
						{
							break;
						}
					}
				}
			}
		}
		printf("%d\n", cnt);
	}
}