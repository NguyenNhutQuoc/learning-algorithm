namespace DynamicProgramming;

public class ClimbStairs
{
    public static int Resolved(int n)
    {
        var dp = new int[n + 1];
        return Resolved(n, dp);
    }

    private static int Resolved(int n, int[] dp)
    {
        if (n == 0)
        {
            dp[n] = 0;
            return dp[n];
        }

        if (n == 1)
        {
            dp[n] = 1;
            return dp[n];
        }

        if (n == 2)
        {
            dp[n] = 2;
            return dp[n];
        }

        if (dp[n] != 0) return dp[n];

        dp[n] = Resolved(n - 1, dp) + Resolved(n - 2, dp);
        return dp[n];
    }
}