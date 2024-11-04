#include <iostream>
#include <queue>
using namespace std;

int board[1000][1000];
int visited[1000][1000];

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	int n, m;
	cin >> n >> m;

	queue<pair<int, int>> q;

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			cin >> board[i][j];
			if (board[i][j] == 2)
			{
				q.push({ i,j });
				visited[i][j] = -1;
			}
			if (board[i][j] == 0)
			{
				visited[i][j] = -1;
			}
		}
	}

	int dx[4] = { 0, 1, 0, -1 };
	int dy[4] = { 1, 0, -1, 0 };

	while (!q.empty())
	{
		int curX = q.front().second;
		int curY = q.front().first;

		q.pop();

		for (int i = 0; i < 4; i++)
		{
			if (curX + dx[i] >= 0 && curX + dx[i] < m && curY + dy[i] >= 0 && curY + dy[i] < n)
			{
				if (visited[curY + dy[i]][curX + dx[i]] == 0)
				{
					q.push({ curY + dy[i], curX + dx[i] });
					if (visited[curY][curX] == -1)
					{
						visited[curY + dy[i]][curX + dx[i]] = 1;
					}
					else
					{
						visited[curY + dy[i]][curX + dx[i]] = visited[curY][curX] + 1;
					}
				}
			}
		}
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			if (!(board[i][j] == 2 || board[i][j] == 0) && visited[i][j] == 0)
			{
				cout << -1 << ' ';
			}
			else if (visited[i][j] == -1)
				cout << 0 << ' ';
			else
				cout << visited[i][j] << ' ';
		}
		cout << '\n';
	}

	return 0;
}