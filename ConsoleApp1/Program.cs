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
        float posNums = 0;
        float negNums = 0;
        float zeroNum = 0;

        foreach (int num in arr)
        {
            if(num > 0) { posNums++; }
            if(num < 0) { negNums++; }
            if(num == 0) { zeroNum++; }
        }

        float posNumDiv = posNums / n;
        double num2 = Math.Round(posNumDiv, 4);
        Console.WriteLine(num2);
       
        Console.Write(posNumDiv.ToString("F5") );
        
        
        

    }
}