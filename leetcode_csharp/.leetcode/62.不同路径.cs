/*
 * @lc app=leetcode.cn id=62 lang=csharp
 *
 * [62] 不同路径
 */

// @lc code=start
public class Solution {
    public int UniquePaths(int m, int n) {
        //动态规划 + 优化空间
        int[] dp = new int[n];
        Array.Fill(dp, 1);
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dp[j] += dp[j - 1];
            }
        }
        return dp[n - 1];
    }
        // public int UniquePaths(int m, int n) {
    //     //动态规划
    //     int[,] dp = new int[m,n];
    //     for (int i = 0; i < m; i++)
    //     {
    //         dp[i, 0] = 1;
    //     }
    //     for (int i = 0; i < n; i++)
    //     {
    //         dp[0, i] = 1;
    //     }
    //     for (int i = 1; i < m; i++)
    //     {
    //         for (int j = 1; j < n; j++)
    //         {
    //             dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
    //         }
    //     }
    //     return dp[m - 1, n - 1];
    // }
}
// @lc code=end

