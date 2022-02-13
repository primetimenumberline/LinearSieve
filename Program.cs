int n = 101;
bool[] b = new bool[n + 1];
int[] primes = new int[n];
int index = -1;
for (int i = 2; i <= n; i++)
{
    if (!b[i])
    {
        index++;
        primes[index] = i;
    }
    for (int j = 0; j <= index; j++)
    {
        int k = i * primes[j];
        if (k > n) break;
        b[k] = true;
        if (i % primes[j] == 0) break;
    }

}
for (int i = 0; i <= index; i++)
    Console.WriteLine(primes[i]);