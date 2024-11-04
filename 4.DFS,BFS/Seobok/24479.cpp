#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

vector<vector<int>> graph;
int* visited;

int n = 1;

void dfs(int node)
{
	visited[node] = n;
	n++;

	for (int i = 0; i < graph[node].size(); i++)
	{
		if (visited[graph[node][i]] == 0)
		{
			dfs(graph[node][i]);
		}
	}
}

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	int N, M, R;
	cin >> N >> M >> R;

	visited = new int[N];

	for (int i = 0; i < N; i++)
	{
		vector<int> temp;
		graph.push_back(temp);
		visited[i] = 0;
	}

	for (int i = 0; i < M; i++)
	{
		int u, v;
		cin >> u >> v;

		graph[u - 1].push_back(v - 1);
		graph[v - 1].push_back(u - 1);
	}

	for (int i = 0; i < N; i++)
	{
		sort(graph[i].begin(), graph[i].end());
	}

	dfs(R - 1);

	for (int i = 0; i < N; i++)
	{
		cout << visited[i] << '\n';
	}

	return 0;
}