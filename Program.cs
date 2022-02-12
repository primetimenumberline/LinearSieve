int n = 101;
bool[] b = new bool[n + 1];
List<int> S = new List<int>();
for (int i = 2; i <= n; i++)
{
    if (!b[i])
        S.Add(i);
    foreach (int j in S)
    {
        int k = i * j;
        if (k > n) break;
        b[k] = true;
        if (i % j == 0) break;
    }
}
foreach(int i in S)
    Console.WriteLine(i);