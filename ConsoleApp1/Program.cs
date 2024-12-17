// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;




internal class Solutuon
{
    public static void Main()
    {



        int[] arr = { 1, 1, 0 ,- 1, -1 };
        Result.plusMinus(arr);
        

    }


}



internal class Result
{
    public static void plusMinus(int[] arr)
    {
        int n = arr.Length;
        double posNums = 0;
        float negNums = 0;
        float zeroNum = 0;

        foreach (int num in arr)
        {
            if(num > 0) { posNums++; }
            if(num < 0) { negNums++; }
            if(num == 0) { zeroNum++; }
        }

        Func<float, int, double> posNumsRatio = (posNums, n) => { var result = posNums / n; return Math.Round(result, 5); };
        Console.WriteLine(posNumsRatio);
        
        float negNumsRatio = Convert.ToInt32(negNums) / Convert.ToInt32(n);
        float zeroNumRatio = Convert.ToInt32(zeroNum) / Convert.ToInt32(n);

    }
}